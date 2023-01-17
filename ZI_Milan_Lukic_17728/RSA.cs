using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZI_Milan_Lukic_17728
{
    internal class RSA
    {
        private int n;
        private int e;
        private int d;
        public RSA(int p, int q, int exp) 
        {
            n = p * q;
            e = CheckExp(p, q, exp);
            d = CalcD(p, q);
        }

        public byte[] Crypt(byte[] input)
        {
            uint[] arr = new uint[input.Length];

            for (int i = 0; i < input.Length; i++)
                arr[i] = Calculate(input[i], true);

            byte[] result = new byte[arr.Length * sizeof(uint)];
            Buffer.BlockCopy(arr, 0, result, 0, result.Length);

            return result;
        }

        public byte[] Decrypt(byte[] input)
        {
            uint[] bytesAsInts = ConvertByteArrayToIntArray(input);
            byte[] result = new byte[bytesAsInts.Length];

            for (int i = 0; i < bytesAsInts.Length; i++)
                result[i] = (byte) Calculate(bytesAsInts[i], false);

            return result;
        }

        private uint[] ConvertByteArrayToIntArray(byte[] input)
        { 
            uint[] retVal = new uint[input.Length / 4];
            byte[] byteArr = new byte[4];

            int n = 0;
            for (int i = 0; i <= input.Length - 4; i += 4)
            {
                byteArr[0] = input[i];
                byteArr[1] = input[i + 1];
                byteArr[2] = input[i + 2];
                byteArr[3] = input[i + 3];

                retVal[n++] = BitConverter.ToUInt32(byteArr, 0);
            }

            return retVal;
        }

        private int FindGCD(int a, int b)
        {
            int tmp;
            while ((a % b) > 0)
            {
                tmp = a % b;
                a = b;
                b = tmp;
            }
            return b;
        }

        private uint Calculate(uint startVal, bool crypt)
        {
            uint retVal = startVal;
            int exp = crypt ? e : d;

            for(int i = 1; i < exp; i++)
            {
                retVal = (retVal * startVal) % (uint)n;
            }

            return retVal;
        }

        private int CheckExp(int p, int q, int exp)
        {
            int phi = (p - 1) * (q - 1);

            if (exp > 1 && exp < phi) return exp;

            exp = exp == 1 ? 3 : exp;

            while (FindGCD(phi, exp) > 1)
                exp++;

            return exp;
        }

        private int CalcD(int p, int q)
        {
            int D = 1;
            int phi = (p - 1) * (q - 1);
            while ((D * e) % phi != 1)
                D++;

            return D;
        }
    }
}
