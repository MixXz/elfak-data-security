using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZI_Milan_Lukic_17728
{
    internal class CFBMode
    {
        private const int blockSize = 16;

        public CFBMode() 
        {
        }

        public byte[] Encrypt(FileInfo fileInfo, A51 a51, byte[] inputBytes)
        {
            byte[] initVector = InitializeIV(fileInfo, Action.Encrypt);

            byte[] input = PadByteArray(inputBytes, blockSize);
            byte[] result = new byte[input.Length];
            int n = 0;

            for (int i = 0; i < input.Length; i += blockSize)
            {
                byte[] plaintextBlock = new byte[blockSize];
                Buffer.BlockCopy(input, i, plaintextBlock, 0, blockSize);

                byte[] encryptedIV = a51.Cypher(initVector);

                for (int j = 0; j < blockSize; j++)
                {
                    plaintextBlock[j] ^= encryptedIV[j];
                    result[n + j] = plaintextBlock[j];
                }

                initVector = encryptedIV;
                n += blockSize;
            }

            return result;
        }

        public byte[] Decrypt(FileInfo fileInfo, A51 a51, byte[] inputBytes)
        {
            byte[] initVector = InitializeIV(fileInfo, Action.Decrypt);

            byte[] result = new byte[inputBytes.Length];
            int n = 0;

            for (int i = 0; i < inputBytes.Length; i += blockSize)
            {
                byte[] plaintextBlock = new byte[blockSize];
                Buffer.BlockCopy(inputBytes, i, plaintextBlock, 0, blockSize);

                byte[] encryptedIV = a51.Cypher(initVector);

                for (int j = 0; j < blockSize; j++)
                {
                    plaintextBlock[j] ^= encryptedIV[j];
                    result[n + j] = plaintextBlock[j];
                }

                initVector = encryptedIV;
                n += blockSize;
            }

            return UnpadByteArray(result);
        }

        private byte[] InitializeIV(FileInfo fileInfo, Action action)
        {
            if(action == Action.Decrypt)
                return File.ReadAllBytes(fileInfo.DirectoryName + "\\CFB_InitVector.txt");

            byte[] result = new byte[blockSize];

            using (var rng = RandomNumberGenerator.Create())
                rng.GetBytes(result);

            File.WriteAllBytes(fileInfo.DirectoryName + "\\CFB_InitVector.txt", result);

            return result;
        }

        private byte[] PadByteArray(byte[] arr, int bSize)
        {
            int paddingBytes = bSize - arr.Length % bSize;
            byte[] result = new byte[arr.Length + paddingBytes];

            Array.Copy(arr, result, arr.Length);

            for (int i = 0; i < paddingBytes; i++)
                result[arr.Length + i] = (byte)paddingBytes;

            return result;
        }

        private byte[] UnpadByteArray(byte[] arr)
        {
            int paddingBytes = arr[arr.Length - 1];
            byte[] result = new byte[arr.Length - paddingBytes];

            Array.Copy(arr, result, result.Length);

            return result;
        }
    }
}
