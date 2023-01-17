namespace ZI_Milan_Lukic_17728
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnSaveTo = new System.Windows.Forms.Button();
            this.cbSaveToSame = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSaveFilePath = new System.Windows.Forms.TextBox();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDecrypt = new System.Windows.Forms.RadioButton();
            this.rbEncrypt = new System.Windows.Forms.RadioButton();
            this.tcAlgorithms = new System.Windows.Forms.TabControl();
            this.tpA51 = new System.Windows.Forms.TabPage();
            this.cbCFBMode = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbA51Key = new System.Windows.Forms.TextBox();
            this.tpPlayfair = new System.Windows.Forms.TabPage();
            this.lblThreadsCount = new System.Windows.Forms.Label();
            this.numThreadsCount = new System.Windows.Forms.NumericUpDown();
            this.cbParallel = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPlayfairKey = new System.Windows.Forms.TextBox();
            this.tpRSA = new System.Windows.Forms.TabPage();
            this.numE = new System.Windows.Forms.NumericUpDown();
            this.lblP = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.numQ = new System.Windows.Forms.NumericUpDown();
            this.lblE = new System.Windows.Forms.Label();
            this.numP = new System.Windows.Forms.NumericUpDown();
            this.btnRun = new System.Windows.Forms.Button();
            this.rtbPreview = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSha2Result = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDecryptedHash = new System.Windows.Forms.TextBox();
            this.tbUnencryptedHash = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.rbRSA = new System.Windows.Forms.RadioButton();
            this.rbA51 = new System.Windows.Forms.RadioButton();
            this.lblEncBmpFileName = new System.Windows.Forms.Label();
            this.btnEncryptBmp = new System.Windows.Forms.Button();
            this.pbEncryptedBmp = new System.Windows.Forms.PictureBox();
            this.btnDecryptBmp = new System.Windows.Forms.Button();
            this.pbRawBmp = new System.Windows.Forms.PictureBox();
            this.btnChooseBitmap = new System.Windows.Forms.Button();
            this.lblBmpFileName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tcAlgorithms.SuspendLayout();
            this.tpA51.SuspendLayout();
            this.tpPlayfair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThreadsCount)).BeginInit();
            this.tpRSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numP)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEncryptedBmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRawBmp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(8, 23);
            this.btnChooseFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(102, 28);
            this.btnChooseFile.TabIndex = 1;
            this.btnChooseFile.Text = "Choose file";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // btnSaveTo
            // 
            this.btnSaveTo.Location = new System.Drawing.Point(8, 59);
            this.btnSaveTo.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveTo.Name = "btnSaveTo";
            this.btnSaveTo.Size = new System.Drawing.Size(102, 28);
            this.btnSaveTo.TabIndex = 3;
            this.btnSaveTo.Text = "Save to";
            this.btnSaveTo.UseVisualStyleBackColor = true;
            this.btnSaveTo.Click += new System.EventHandler(this.btnSaveTo_Click);
            // 
            // cbSaveToSame
            // 
            this.cbSaveToSame.AutoSize = true;
            this.cbSaveToSame.Location = new System.Drawing.Point(9, 96);
            this.cbSaveToSame.Margin = new System.Windows.Forms.Padding(4);
            this.cbSaveToSame.Name = "cbSaveToSame";
            this.cbSaveToSame.Size = new System.Drawing.Size(187, 20);
            this.cbSaveToSame.TabIndex = 7;
            this.cbSaveToSame.Text = "Save file to same directory";
            this.cbSaveToSame.UseVisualStyleBackColor = true;
            this.cbSaveToSame.CheckedChanged += new System.EventHandler(this.cbSaveToSame_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSaveFilePath);
            this.groupBox1.Controls.Add(this.tbFilePath);
            this.groupBox1.Controls.Add(this.btnChooseFile);
            this.groupBox1.Controls.Add(this.cbSaveToSame);
            this.groupBox1.Controls.Add(this.btnSaveTo);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(596, 129);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Browse File";
            // 
            // tbSaveFilePath
            // 
            this.tbSaveFilePath.Location = new System.Drawing.Point(118, 59);
            this.tbSaveFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.tbSaveFilePath.Name = "tbSaveFilePath";
            this.tbSaveFilePath.ReadOnly = true;
            this.tbSaveFilePath.Size = new System.Drawing.Size(466, 22);
            this.tbSaveFilePath.TabIndex = 9;
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(118, 25);
            this.tbFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.ReadOnly = true;
            this.tbFilePath.Size = new System.Drawing.Size(466, 22);
            this.tbFilePath.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDecrypt);
            this.groupBox2.Controls.Add(this.rbEncrypt);
            this.groupBox2.Controls.Add(this.tcAlgorithms);
            this.groupBox2.Controls.Add(this.btnRun);
            this.groupBox2.Location = new System.Drawing.Point(636, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(339, 233);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuration";
            // 
            // rbDecrypt
            // 
            this.rbDecrypt.AutoSize = true;
            this.rbDecrypt.Location = new System.Drawing.Point(251, 166);
            this.rbDecrypt.Name = "rbDecrypt";
            this.rbDecrypt.Size = new System.Drawing.Size(75, 20);
            this.rbDecrypt.TabIndex = 15;
            this.rbDecrypt.TabStop = true;
            this.rbDecrypt.Text = "Decrypt";
            this.rbDecrypt.UseVisualStyleBackColor = true;
            this.rbDecrypt.CheckedChanged += new System.EventHandler(this.rbDecrypt_CheckedChanged);
            // 
            // rbEncrypt
            // 
            this.rbEncrypt.AutoSize = true;
            this.rbEncrypt.Location = new System.Drawing.Point(172, 166);
            this.rbEncrypt.Name = "rbEncrypt";
            this.rbEncrypt.Size = new System.Drawing.Size(73, 20);
            this.rbEncrypt.TabIndex = 14;
            this.rbEncrypt.TabStop = true;
            this.rbEncrypt.Text = "Encrypt";
            this.rbEncrypt.UseVisualStyleBackColor = true;
            // 
            // tcAlgorithms
            // 
            this.tcAlgorithms.Controls.Add(this.tpA51);
            this.tcAlgorithms.Controls.Add(this.tpPlayfair);
            this.tcAlgorithms.Controls.Add(this.tpRSA);
            this.tcAlgorithms.Location = new System.Drawing.Point(7, 25);
            this.tcAlgorithms.Name = "tcAlgorithms";
            this.tcAlgorithms.SelectedIndex = 0;
            this.tcAlgorithms.Size = new System.Drawing.Size(323, 135);
            this.tcAlgorithms.TabIndex = 13;
            // 
            // tpA51
            // 
            this.tpA51.Controls.Add(this.cbCFBMode);
            this.tpA51.Controls.Add(this.label4);
            this.tpA51.Controls.Add(this.tbA51Key);
            this.tpA51.Location = new System.Drawing.Point(4, 25);
            this.tpA51.Name = "tpA51";
            this.tpA51.Padding = new System.Windows.Forms.Padding(3);
            this.tpA51.Size = new System.Drawing.Size(315, 106);
            this.tpA51.TabIndex = 0;
            this.tpA51.Text = "A5/1";
            this.tpA51.UseVisualStyleBackColor = true;
            // 
            // cbCFBMode
            // 
            this.cbCFBMode.AutoSize = true;
            this.cbCFBMode.Location = new System.Drawing.Point(20, 48);
            this.cbCFBMode.Margin = new System.Windows.Forms.Padding(4);
            this.cbCFBMode.Name = "cbCFBMode";
            this.cbCFBMode.Size = new System.Drawing.Size(93, 20);
            this.cbCFBMode.TabIndex = 26;
            this.cbCFBMode.Text = "CFB Mode";
            this.cbCFBMode.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Enter key:";
            // 
            // tbA51Key
            // 
            this.tbA51Key.Location = new System.Drawing.Point(90, 18);
            this.tbA51Key.Margin = new System.Windows.Forms.Padding(4);
            this.tbA51Key.Name = "tbA51Key";
            this.tbA51Key.Size = new System.Drawing.Size(135, 22);
            this.tbA51Key.TabIndex = 26;
            this.tbA51Key.Text = "OvoJeKey";
            // 
            // tpPlayfair
            // 
            this.tpPlayfair.Controls.Add(this.lblThreadsCount);
            this.tpPlayfair.Controls.Add(this.numThreadsCount);
            this.tpPlayfair.Controls.Add(this.cbParallel);
            this.tpPlayfair.Controls.Add(this.label5);
            this.tpPlayfair.Controls.Add(this.tbPlayfairKey);
            this.tpPlayfair.Location = new System.Drawing.Point(4, 25);
            this.tpPlayfair.Name = "tpPlayfair";
            this.tpPlayfair.Size = new System.Drawing.Size(315, 106);
            this.tpPlayfair.TabIndex = 2;
            this.tpPlayfair.Text = "Playfair";
            this.tpPlayfair.UseVisualStyleBackColor = true;
            // 
            // lblThreadsCount
            // 
            this.lblThreadsCount.AutoSize = true;
            this.lblThreadsCount.Location = new System.Drawing.Point(16, 73);
            this.lblThreadsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThreadsCount.Name = "lblThreadsCount";
            this.lblThreadsCount.Size = new System.Drawing.Size(117, 16);
            this.lblThreadsCount.TabIndex = 31;
            this.lblThreadsCount.Text = "Number of threads";
            // 
            // numThreadsCount
            // 
            this.numThreadsCount.Location = new System.Drawing.Point(141, 71);
            this.numThreadsCount.Margin = new System.Windows.Forms.Padding(4);
            this.numThreadsCount.Name = "numThreadsCount";
            this.numThreadsCount.Size = new System.Drawing.Size(53, 22);
            this.numThreadsCount.TabIndex = 32;
            // 
            // cbParallel
            // 
            this.cbParallel.AutoSize = true;
            this.cbParallel.Location = new System.Drawing.Point(19, 49);
            this.cbParallel.Margin = new System.Windows.Forms.Padding(4);
            this.cbParallel.Name = "cbParallel";
            this.cbParallel.Size = new System.Drawing.Size(75, 20);
            this.cbParallel.TabIndex = 28;
            this.cbParallel.Text = "Parallel";
            this.cbParallel.UseVisualStyleBackColor = true;
            this.cbParallel.CheckedChanged += new System.EventHandler(this.cbParallel_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Enter key:";
            // 
            // tbPlayfairKey
            // 
            this.tbPlayfairKey.Location = new System.Drawing.Point(90, 18);
            this.tbPlayfairKey.Margin = new System.Windows.Forms.Padding(4);
            this.tbPlayfairKey.Name = "tbPlayfairKey";
            this.tbPlayfairKey.Size = new System.Drawing.Size(135, 22);
            this.tbPlayfairKey.TabIndex = 29;
            this.tbPlayfairKey.Text = "Monarchy";
            // 
            // tpRSA
            // 
            this.tpRSA.Controls.Add(this.numE);
            this.tpRSA.Controls.Add(this.lblP);
            this.tpRSA.Controls.Add(this.lblQ);
            this.tpRSA.Controls.Add(this.numQ);
            this.tpRSA.Controls.Add(this.lblE);
            this.tpRSA.Controls.Add(this.numP);
            this.tpRSA.Location = new System.Drawing.Point(4, 25);
            this.tpRSA.Name = "tpRSA";
            this.tpRSA.Padding = new System.Windows.Forms.Padding(3);
            this.tpRSA.Size = new System.Drawing.Size(315, 106);
            this.tpRSA.TabIndex = 1;
            this.tpRSA.Text = "RSA";
            this.tpRSA.UseVisualStyleBackColor = true;
            // 
            // numE
            // 
            this.numE.Location = new System.Drawing.Point(41, 70);
            this.numE.Margin = new System.Windows.Forms.Padding(4);
            this.numE.Name = "numE";
            this.numE.Size = new System.Drawing.Size(53, 22);
            this.numE.TabIndex = 23;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(17, 13);
            this.lblP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(16, 16);
            this.lblP.TabIndex = 15;
            this.lblP.Text = "P";
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(17, 42);
            this.lblQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(17, 16);
            this.lblQ.TabIndex = 17;
            this.lblQ.Text = "Q";
            // 
            // numQ
            // 
            this.numQ.Location = new System.Drawing.Point(41, 40);
            this.numQ.Margin = new System.Windows.Forms.Padding(4);
            this.numQ.Name = "numQ";
            this.numQ.Size = new System.Drawing.Size(53, 22);
            this.numQ.TabIndex = 22;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(19, 72);
            this.lblE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(15, 16);
            this.lblE.TabIndex = 19;
            this.lblE.Text = "e";
            // 
            // numP
            // 
            this.numP.Location = new System.Drawing.Point(41, 10);
            this.numP.Margin = new System.Windows.Forms.Padding(4);
            this.numP.Name = "numP";
            this.numP.Size = new System.Drawing.Size(53, 22);
            this.numP.TabIndex = 21;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(196, 197);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(135, 28);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // rtbPreview
            // 
            this.rtbPreview.Location = new System.Drawing.Point(16, 152);
            this.rtbPreview.Margin = new System.Windows.Forms.Padding(4);
            this.rtbPreview.Name = "rtbPreview";
            this.rtbPreview.ReadOnly = true;
            this.rtbPreview.Size = new System.Drawing.Size(596, 476);
            this.rtbPreview.TabIndex = 11;
            this.rtbPreview.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSha2Result);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbDecryptedHash);
            this.groupBox3.Controls.Add(this.tbUnencryptedHash);
            this.groupBox3.Location = new System.Drawing.Point(16, 635);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(596, 160);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SHA2";
            // 
            // lblSha2Result
            // 
            this.lblSha2Result.AutoSize = true;
            this.lblSha2Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSha2Result.Location = new System.Drawing.Point(7, 126);
            this.lblSha2Result.Name = "lblSha2Result";
            this.lblSha2Result.Size = new System.Drawing.Size(0, 25);
            this.lblSha2Result.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Decrypted file hash";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unencrypted file hash";
            // 
            // tbDecryptedHash
            // 
            this.tbDecryptedHash.Location = new System.Drawing.Point(6, 97);
            this.tbDecryptedHash.Name = "tbDecryptedHash";
            this.tbDecryptedHash.ReadOnly = true;
            this.tbDecryptedHash.Size = new System.Drawing.Size(578, 22);
            this.tbDecryptedHash.TabIndex = 1;
            // 
            // tbUnencryptedHash
            // 
            this.tbUnencryptedHash.Location = new System.Drawing.Point(6, 42);
            this.tbUnencryptedHash.Name = "tbUnencryptedHash";
            this.tbUnencryptedHash.ReadOnly = true;
            this.tbUnencryptedHash.Size = new System.Drawing.Size(578, 22);
            this.tbUnencryptedHash.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.progressBar);
            this.groupBox4.Controls.Add(this.rbRSA);
            this.groupBox4.Controls.Add(this.rbA51);
            this.groupBox4.Controls.Add(this.lblEncBmpFileName);
            this.groupBox4.Controls.Add(this.btnEncryptBmp);
            this.groupBox4.Controls.Add(this.pbEncryptedBmp);
            this.groupBox4.Controls.Add(this.btnDecryptBmp);
            this.groupBox4.Controls.Add(this.pbRawBmp);
            this.groupBox4.Controls.Add(this.btnChooseBitmap);
            this.groupBox4.Controls.Add(this.lblBmpFileName);
            this.groupBox4.Location = new System.Drawing.Point(636, 269);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(339, 526);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "24-bit BMP";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(11, 274);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(315, 18);
            this.progressBar.Step = 25;
            this.progressBar.TabIndex = 20;
            // 
            // rbRSA
            // 
            this.rbRSA.AutoSize = true;
            this.rbRSA.Location = new System.Drawing.Point(14, 243);
            this.rbRSA.Name = "rbRSA";
            this.rbRSA.Size = new System.Drawing.Size(56, 20);
            this.rbRSA.TabIndex = 19;
            this.rbRSA.TabStop = true;
            this.rbRSA.Text = "RSA";
            this.rbRSA.UseVisualStyleBackColor = true;
            // 
            // rbA51
            // 
            this.rbA51.AutoSize = true;
            this.rbA51.Location = new System.Drawing.Point(76, 243);
            this.rbA51.Name = "rbA51";
            this.rbA51.Size = new System.Drawing.Size(55, 20);
            this.rbA51.TabIndex = 18;
            this.rbA51.TabStop = true;
            this.rbA51.Text = "A5/1";
            this.rbA51.UseVisualStyleBackColor = true;
            // 
            // lblEncBmpFileName
            // 
            this.lblEncBmpFileName.AutoSize = true;
            this.lblEncBmpFileName.Location = new System.Drawing.Point(11, 299);
            this.lblEncBmpFileName.Name = "lblEncBmpFileName";
            this.lblEncBmpFileName.Size = new System.Drawing.Size(95, 16);
            this.lblEncBmpFileName.TabIndex = 17;
            this.lblEncBmpFileName.Text = "Enc_Bmp.bmp";
            // 
            // btnEncryptBmp
            // 
            this.btnEncryptBmp.Location = new System.Drawing.Point(158, 239);
            this.btnEncryptBmp.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncryptBmp.Name = "btnEncryptBmp";
            this.btnEncryptBmp.Size = new System.Drawing.Size(80, 28);
            this.btnEncryptBmp.TabIndex = 16;
            this.btnEncryptBmp.Text = "Encrypt";
            this.btnEncryptBmp.UseVisualStyleBackColor = true;
            this.btnEncryptBmp.Click += new System.EventHandler(this.btnEncryptBmp_Click);
            // 
            // pbEncryptedBmp
            // 
            this.pbEncryptedBmp.BackColor = System.Drawing.Color.White;
            this.pbEncryptedBmp.Location = new System.Drawing.Point(11, 321);
            this.pbEncryptedBmp.Name = "pbEncryptedBmp";
            this.pbEncryptedBmp.Size = new System.Drawing.Size(315, 175);
            this.pbEncryptedBmp.TabIndex = 15;
            this.pbEncryptedBmp.TabStop = false;
            // 
            // btnDecryptBmp
            // 
            this.btnDecryptBmp.Location = new System.Drawing.Point(246, 239);
            this.btnDecryptBmp.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecryptBmp.Name = "btnDecryptBmp";
            this.btnDecryptBmp.Size = new System.Drawing.Size(80, 28);
            this.btnDecryptBmp.TabIndex = 14;
            this.btnDecryptBmp.Text = "Decrypt";
            this.btnDecryptBmp.UseVisualStyleBackColor = true;
            this.btnDecryptBmp.Click += new System.EventHandler(this.btnDecryptBmp_Click);
            // 
            // pbRawBmp
            // 
            this.pbRawBmp.BackColor = System.Drawing.Color.White;
            this.pbRawBmp.Location = new System.Drawing.Point(11, 57);
            this.pbRawBmp.Name = "pbRawBmp";
            this.pbRawBmp.Size = new System.Drawing.Size(315, 175);
            this.pbRawBmp.TabIndex = 12;
            this.pbRawBmp.TabStop = false;
            // 
            // btnChooseBitmap
            // 
            this.btnChooseBitmap.Location = new System.Drawing.Point(11, 22);
            this.btnChooseBitmap.Margin = new System.Windows.Forms.Padding(4);
            this.btnChooseBitmap.Name = "btnChooseBitmap";
            this.btnChooseBitmap.Size = new System.Drawing.Size(133, 28);
            this.btnChooseBitmap.TabIndex = 10;
            this.btnChooseBitmap.Text = "Choose bitmap";
            this.btnChooseBitmap.UseVisualStyleBackColor = true;
            this.btnChooseBitmap.Click += new System.EventHandler(this.btnChooseBitmap_Click);
            // 
            // lblBmpFileName
            // 
            this.lblBmpFileName.AutoSize = true;
            this.lblBmpFileName.Location = new System.Drawing.Point(151, 28);
            this.lblBmpFileName.Name = "lblBmpFileName";
            this.lblBmpFileName.Size = new System.Drawing.Size(65, 16);
            this.lblBmpFileName.TabIndex = 11;
            this.lblBmpFileName.Text = "Bmp.bmp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 807);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.rtbPreview);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1008, 854);
            this.MinimumSize = new System.Drawing.Size(1008, 854);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Protection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tcAlgorithms.ResumeLayout(false);
            this.tpA51.ResumeLayout(false);
            this.tpA51.PerformLayout();
            this.tpPlayfair.ResumeLayout(false);
            this.tpPlayfair.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThreadsCount)).EndInit();
            this.tpRSA.ResumeLayout(false);
            this.tpRSA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numP)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEncryptedBmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRawBmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnSaveTo;
        private System.Windows.Forms.CheckBox cbSaveToSame;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.RichTextBox rtbPreview;
        private System.Windows.Forms.TextBox tbSaveFilePath;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.NumericUpDown numE;
        private System.Windows.Forms.NumericUpDown numQ;
        private System.Windows.Forms.NumericUpDown numP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDecryptedHash;
        private System.Windows.Forms.TextBox tbUnencryptedHash;
        private System.Windows.Forms.TabControl tcAlgorithms;
        private System.Windows.Forms.TabPage tpA51;
        private System.Windows.Forms.CheckBox cbCFBMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbA51Key;
        private System.Windows.Forms.TabPage tpPlayfair;
        private System.Windows.Forms.CheckBox cbParallel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPlayfairKey;
        private System.Windows.Forms.TabPage tpRSA;
        private System.Windows.Forms.Label lblThreadsCount;
        private System.Windows.Forms.NumericUpDown numThreadsCount;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pbRawBmp;
        private System.Windows.Forms.Label lblBmpFileName;
        private System.Windows.Forms.Button btnChooseBitmap;
        private System.Windows.Forms.Label lblEncBmpFileName;
        private System.Windows.Forms.Button btnEncryptBmp;
        private System.Windows.Forms.PictureBox pbEncryptedBmp;
        private System.Windows.Forms.Button btnDecryptBmp;
        private System.Windows.Forms.RadioButton rbDecrypt;
        private System.Windows.Forms.RadioButton rbEncrypt;
        private System.Windows.Forms.RadioButton rbRSA;
        private System.Windows.Forms.RadioButton rbA51;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblSha2Result;
    }
}

