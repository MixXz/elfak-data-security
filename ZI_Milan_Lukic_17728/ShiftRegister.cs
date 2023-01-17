using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_Milan_Lukic_17728
{
    internal class ShiftRegister
    {
        public BitArray Register { get; set; }
        public int VoteMember { get; set; } 
        public int[] OperationMembers { get; set; }

        public ShiftRegister(int arrLength, int[] operationMembers, int voteMember)
        {
            Register = new BitArray(arrLength, false);
            OperationMembers = operationMembers;
            VoteMember = voteMember;
        }

        public bool Shift(bool newEntry)
        {
            bool ret = Register[Register.Length - 1];

            for (int i = Register.Length - 1; i > 0; i--)
            {
                Register[i] = Register[i - 1];
            }

            Register[0] = newEntry;

            return ret;
        }

        public bool Output 
        { 
            get
            {
                return Register[Register.Length - 1];
            } 
        }
    }
}
