using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZI_Milan_Lukic_17728
{
    enum Algorithms
    {
        A51,
        PLayFair,
        RSA
    }
    enum Action
    {
        Encrypt,
        Decrypt
    }
    public partial class Form1 : Form
    {
        private string fileName;
        private string filePath;
        private string saveFilePath;
        private string bmpFilePath;
        private string bmpFileName;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbSaveToSame.Checked = true;
            lblThreadsCount.Visible = false;
            numThreadsCount.Visible = false;
            rbEncrypt.Checked = true;
            rbRSA.Checked = true;
            lblBmpFileName.Text = string.Empty;
            lblEncBmpFileName.Text = string.Empty;
            lblSha2Result.Text = string.Empty;

            filePath = string.Empty;
            bmpFilePath = string.Empty;
            bmpFileName = string.Empty;

            pbRawBmp.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEncryptedBmp.SizeMode = PictureBoxSizeMode.StretchImage;

            numP.Value = 17;
            numQ.Value = 23;
            numE.Value = 3;
        }
        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() != DialogResult.OK)
                return;

            fileName = fileDialog.SafeFileName;
            filePath = Path.GetDirectoryName(fileDialog.FileName) + "\\";
            saveFilePath = cbSaveToSame.Checked ? filePath : string.Empty;

            rtbPreview.Text = File.ReadAllText(fileDialog.FileName);
            tbSaveFilePath.Text = saveFilePath;
            tbFilePath.Text = fileDialog.FileName;

            tbDecryptedHash.Text = tbUnencryptedHash.Text = lblSha2Result.Text = string.Empty;
        }

        private void btnSaveTo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browseDialog = new FolderBrowserDialog();

            if (browseDialog.ShowDialog() == DialogResult.OK)
            {
                saveFilePath = browseDialog.SelectedPath + "\\";
                tbSaveFilePath.Text = saveFilePath;
            }
        }

        private void cbSaveToSame_CheckedChanged(object sender, EventArgs e)
        {
            saveFilePath = filePath;
            btnSaveTo.Enabled = cbSaveToSame.Checked ? false : true;
            tbSaveFilePath.Text = cbSaveToSame.Checked ? filePath : string.Empty;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if(filePath == string.Empty)
            {
                MessageBox.Show("No file selected!");
                return;
            }

            Action action = rbEncrypt.Checked ? Action.Encrypt : Action.Decrypt;

            switch ((Algorithms)tcAlgorithms.SelectedIndex)
            {
                case Algorithms.A51:
                    A51Handler(action);
                    break;
                case Algorithms.PLayFair:
                    PlayfairHandler(action);
                    break;
                case Algorithms.RSA:
                    RSAHandler(action);
                    break;
                default:
                    break;
            }
        }

        private void A51Handler(Action action)
        {
            string key = tbA51Key.Text;

            if (key.Length != 8)
            {
                MessageBox.Show("Key must be 8 bytes!");
                return;
            }

            A51 a51 = new A51(Encoding.ASCII.GetBytes(key));

            byte[] readBytes = ReadBytesFromFile(filePath + fileName);
            if (readBytes == null) return;

            if (!cbCFBMode.Checked)
            {
                SaveBytesToFile(action, "A51", a51.Cypher(readBytes));
                return;
            }

            CFBMode cfb = new CFBMode();
            FileInfo fileInfo = new FileInfo(filePath + fileName);

            if (action == Action.Decrypt && !File.Exists(filePath + "CFB_InitVector.txt"))
            {
                MessageBox.Show("No file with Initialization vector bytes found.");
                return;
            }

            SaveBytesToFile(action, "A51_CFB", action == Action.Encrypt ? cfb.Encrypt(fileInfo, a51, readBytes) : cfb.Decrypt(fileInfo, a51, readBytes));
        }

        private void PlayfairHandler(Action action)
        {
            string key = tbPlayfairKey.Text;
            if (key.Distinct().Count() != key.Length)
            {
                MessageBox.Show("The key should be up to 8 characters long and must not contain double letters");
                return;
            }

            PlayfairCipher pfc = new PlayfairCipher(key);
            string readText = File.ReadAllText(filePath + fileName);

            if (action == Action.Encrypt && cbParallel.Checked)
            {
                int tCount = numThreadsCount.Value == 0 ? 1 : (int)numThreadsCount.Value;
                SaveTextToFile(action, "PFC_Parallel", pfc.EncryptParallel(readText, tCount));
                return;
            }

            SaveTextToFile(action, "PFC", action == Action.Encrypt ? pfc.Encrypt(readText) : pfc.Decrypt(readText));
        }

        private void RSAHandler(Action action) 
        {
            RSA rsa = new RSA((int)numP.Value, (int)numQ.Value, (int)numE.Value);

            byte[] readBytes = ReadBytesFromFile(filePath + fileName);
            if (readBytes == null) return;

            SaveBytesToFile(action, "RSA", action == Action.Encrypt ? rsa.Crypt(readBytes) : rsa.Decrypt(readBytes));
        }

        private void CypherBitmap(Action action, byte[] readBytes)
        {
            progressBar.PerformStep();

            int pos = readBytes[10] + 256 * (readBytes[11] + 256 * (readBytes[12] + 256 * readBytes[13]));

            byte[] headerBytes = readBytes.Take(pos).ToArray();
            byte[] toEncryptBytes = readBytes.Skip(pos).ToArray();
            byte[] encryptedBytes;

            progressBar.PerformStep();

            if (rbA51.Checked)
            {
                A51 a51 = new A51(Encoding.ASCII.GetBytes("OvoJeKey"));
                encryptedBytes = a51.Cypher(toEncryptBytes);
            }
            else
            {
                RSA rsa = new RSA(17, 23, 3);
                encryptedBytes = action == Action.Encrypt ? rsa.Crypt(toEncryptBytes) : rsa.Decrypt(toEncryptBytes);
            }

            progressBar.PerformStep();

            byte[] ret = new byte[headerBytes.Length + encryptedBytes.Length];
            Buffer.BlockCopy(headerBytes, 0, ret, 0, headerBytes.Length);
            Buffer.BlockCopy(encryptedBytes, 0, ret, headerBytes.Length, encryptedBytes.Length);

            progressBar.PerformStep();

            SaveBitmap(action, rbA51.Checked ? "A51" : "RSA", ret);
        }

        private byte[] ReadBytesFromFile(string filePath)
        {
            if (filePath == string.Empty)
            {
                MessageBox.Show("No file selected!");
                return null;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File doesn't exist!");
                return null;
            }

            return File.ReadAllBytes(filePath);
        }

        private void SaveBytesToFile(Action action, string algName, byte[] bytes)
        {
            string newFileName = string.Empty;

            if (action == Action.Encrypt)
                newFileName = algName + "_Encrypted_" + fileName;
            else if (action == Action.Decrypt)
                newFileName = fileName.Replace("Encrypted", "Decrypted");

            File.WriteAllBytes(saveFilePath + newFileName, bytes);
            rtbPreview.Text = Encoding.UTF8.GetString(bytes);

            if(action == Action.Decrypt)
            {
                SHA2 sha2 = new SHA2();

                string hash = sha2.Hash(File.ReadAllText(filePath + fileName.Replace(algName + "_Encrypted_", "")));
                string decHash = sha2.Hash(Encoding.UTF8.GetString(bytes));

                tbUnencryptedHash.Text = hash;
                tbDecryptedHash.Text = decHash;

                bool isMatch = hash == decHash;

                lblSha2Result.Text = isMatch ? "Files match" : "Files do not match";
                lblSha2Result.ForeColor = isMatch ? Color.Green : Color.Red;
            }

            MessageBox.Show("File successfully " + (action == Action.Encrypt ? "encrypted" : "decrypted") + ".");
        }

        private void SaveTextToFile(Action action, string algName, string text)
        {
            string newFileName = string.Empty;

            if (action == Action.Encrypt)
                newFileName = algName + "_Encrypted_" + fileName;
            else if (action == Action.Decrypt)
                newFileName = fileName.Replace("Encrypted", "Decrypted");

            File.WriteAllText(saveFilePath + newFileName, text);
            rtbPreview.Text = text;

            MessageBox.Show("File successfully " + (action == Action.Encrypt ? "encrypted" : "decrypted") + ".");
        }

        private void SaveBitmap(Action action, string algName, byte[] bytes)
        {
            string newFileName = string.Empty;

            if (action == Action.Encrypt)
                newFileName = algName + "_Encrypted_" + bmpFileName;
            else if (action == Action.Decrypt)
                newFileName = bmpFileName.Replace("Encrypted", "Decrypted");

            File.WriteAllBytes(bmpFilePath + newFileName, bytes);

            lblEncBmpFileName.Text = newFileName;
            pbEncryptedBmp.Image = new Bitmap(bmpFilePath + newFileName);

            MessageBox.Show("Bitmap successfully " + (action == Action.Encrypt ? "encrypted" : "decrypted") + " and saved to same directory.");
        }

        private void cbParallel_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = cbParallel.Checked;

            lblThreadsCount.Visible = isChecked;
            numThreadsCount.Visible = isChecked;
        }

        private void rbDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            cbParallel.Checked = false;
            cbParallel.Enabled = !rbDecrypt.Checked;
        }

        private void btnChooseBitmap_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() != DialogResult.OK)
                return;

            pbRawBmp.Image = new Bitmap(fileDialog.FileName);
            lblBmpFileName.Text = fileDialog.SafeFileName;

            bmpFileName = fileDialog.SafeFileName;
            bmpFilePath = Path.GetDirectoryName(fileDialog.FileName) + "\\";
        }

        private void btnEncryptBmp_Click(object sender, EventArgs e)
        {
            if(bmpFilePath == string.Empty)
            {
                MessageBox.Show("No bitmap selected!");
                return;
            }

            Cursor.Current = Cursors.WaitCursor;
            CypherBitmap(Action.Encrypt, File.ReadAllBytes(bmpFilePath + bmpFileName));
            Cursor.Current = Cursors.Default;
            progressBar.Value = 0;
        }

        private void btnDecryptBmp_Click(object sender, EventArgs e)
        {
            if (bmpFilePath == string.Empty)
            {
                MessageBox.Show("No bitmap selected!");
                return;
            }

            Cursor.Current = Cursors.WaitCursor;
            CypherBitmap(Action.Decrypt, File.ReadAllBytes(bmpFilePath + bmpFileName));
            Cursor.Current = Cursors.Default;
            progressBar.Value = 0;
        }
    }
}
