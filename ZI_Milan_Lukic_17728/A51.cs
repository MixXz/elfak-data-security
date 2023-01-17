using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZI_Milan_Lukic_17728
{
    internal class A51
    {
        private ShiftRegister R1;
        private ShiftRegister R2;
        private ShiftRegister R3;
        private byte[] key;

        public A51(byte[] key)
        {
            R1 = new ShiftRegister(19, new int[] { 13, 16, 17, 18 }, 8);
            R2 = new ShiftRegister(22, new int[] { 20, 21 }, 10);
            R3 = new ShiftRegister(23, new int[] { 7, 20, 21, 22 }, 10);

            this.key = key;
            FillRegisters();
        }
        private void FillRegisters()
        { 
            BitArray keyBits = new BitArray(key);

            for (int i = 0; i < 19; i++)
                R1.Register[i] = keyBits[i];
            for (int i = 0; i < 22; i++)
                R2.Register[i] = keyBits[i + 19];
            for (int i = 0; i < 23; i++)
                R3.Register[i] = keyBits[i + 22];
        }
        private void RegisterSteps(ShiftRegister reg)
        {
            bool newVal = false;

            foreach(int index in R1.OperationMembers)
                newVal ^= reg.Register[index];

            reg.Shift(newVal);
        }
        private bool MajorityVote()
        {
            int voteSum = 0;
            voteSum += R1.Register[R1.VoteMember] ? 1 : 0;
            voteSum += R2.Register[R2.VoteMember] ? 1 : 0;
            voteSum += R3.Register[R3.VoteMember] ? 1 : 0;

            return voteSum > 1 ? true : false;
        }

        public byte[] BitArrayToByteArray(BitArray bits)
        {
            byte[] ret = new byte[(bits.Length - 1) / 8 + 1];
            bits.CopyTo(ret, 0);

            return ret;
        }

        public byte[] Cypher(byte[] file)
        {
            BitArray source = new BitArray(file);
            BitArray encryptedSource = new BitArray(source.Length);

            for(int i = 0; i < source.Length; i++)
            {
                bool mVote = MajorityVote();

                if (R1.Register[R1.VoteMember] == mVote)
                    RegisterSteps(R1);

                if (R2.Register[R2.VoteMember] == mVote)
                    RegisterSteps(R2);

                if (R3.Register[R3.VoteMember] == mVote)
                    RegisterSteps(R3);

                bool encBit = false;
                encBit = ((encBit ^ R1.Output) ^ R2.Output) ^ R3.Output;

                encryptedSource[i] = source[i] ^ encBit;
            }

            return BitArrayToByteArray(encryptedSource);
        }

    }
}
