using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZI_Milan_Lukic_17728
{
    internal class PlayfairCipher
    {
        private char[,] keyTable;
        public PlayfairCipher(string key) 
        {
            keyTable = new char[5, 5];
            FillKeySquare(key);
        }

        private void FillKeySquare(string key)
        {
            char[] alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ".ToCharArray();
            key = string.IsNullOrEmpty(key) ? "ABCDEFGHIKLMNOPQRSTUVWXYZ" : key.ToUpper();
            key = key.Replace("J", "");

            for (int i = 0; i < alphabet.Length; i++)
                if (!key.Contains(alphabet[i]))
                    key += alphabet[i];

            for (int i = 0; i < 25; i++)
                keyTable[i / 5, i % 5] = key[i];
        }

        public string Cypher(string source, Action action)
        {
            string input = ParseInput(source);
            string output = string.Empty;
            int k = action == Action.Encrypt ? 1 : -1;

            for (int i = 0; i < input.Length; i += 2)
            {
                char a = input[i];
                char b = input[i + 1];

                b = a == b ? 'X' : b;

                int[] pos = FindPositions(a, b);

                if (pos[0] == pos[2])
                {
                    output += keyTable[pos[0], Mod5(pos[1] + k)];
                    output += keyTable[pos[0], Mod5(pos[3] + k)];
                }
                else if (pos[1] == pos[3])
                {
                    output += keyTable[Mod5(pos[0] + k), pos[1]];
                    output += keyTable[Mod5(pos[2] + k), pos[1]];
                }
                else
                {
                    output += keyTable[pos[0], pos[3]];
                    output += keyTable[pos[2], pos[1]];
                }
            }

            return action == Action.Encrypt ? output : ParseOutput(output);
        }

        public string Encrypt(string source)
        {
            return Cypher(source, Action.Encrypt);
        }

        public string Decrypt(string source)
        {
            return Cypher(source, Action.Decrypt);
        }

        private int[] FindPositions(char a, char b)
        {
            int[] positions = new int[4];

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    if (keyTable[i, j] == a)
                    {
                        positions[0] = i;
                        positions[1] = j;
                    }
                    else if (keyTable[i, j] == b) 
                    {
                        positions[2] = i;
                        positions[3] = j;
                    }

            return positions;
        }
        private string ParseInput(string input)
        {
            Regex rgx = new Regex("[^a-zA-Z]");

            string retVal = rgx.Replace(input, "");

            if (retVal.Length % 2 != 0)
                retVal += 'X';

            return retVal.ToUpper();
        }

        private string ParseOutput(string output)
        {
            char[] arr = output.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == 'X' && i != 0 && i != arr.Length - 1)
                    arr[i] = arr[i - 1];

            return new string(arr);
        }

        private int Mod5(int a) 
        {
            a += a < 0 ? 5 : 0;
            return (a % 5); 
        }

        public string EncryptParallel(string input, int threadsNum)
        {
            string[] chunks = SplitIntoChunks(input, threadsNum);

            object lockObject = new object();
            var encryptedChunks = new List<string>();

            Parallel.ForEach(chunks, chunk =>
            {
                string ciphertext = Encrypt(chunk);

                lock (lockObject)
                {
                    encryptedChunks.Add(string.Join("", ciphertext));
                }
            });

            return string.Join("", encryptedChunks);
        }

        private string[] SplitIntoChunks(string input, int count)
        {
            int chunkSize = input.Length / count;

            string[] chunks = new string[count];
            for (int i = 0; i < count; i++)
            {
                int startIndex = i * chunkSize;
                int endIndex = startIndex + chunkSize;
                if (i == count - 1)
                {
                    endIndex = input.Length;
                }
                chunks[i] = input.Substring(startIndex, endIndex - startIndex);
            }

            return chunks;
        }
    }
}

