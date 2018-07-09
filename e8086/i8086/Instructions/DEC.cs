﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDS.e8086
{
    /// <summary>
    /// OpCodes 0x48 - 0x4f
    /// Increment the designated register.
    /// Parse the op code, the affected register is the last 3 bits.
    /// </summary>
    public class DEC : Instruction
    {
        public DEC(byte opCode, IExecutionUnit eu, IBus bus) : base(opCode, eu, bus) { }

        protected override void ExecuteInstruction()
        {
            ushort dest = GetRegField16(OpCodeMode.RM);
            ushort result = (ushort)(dest - 1);
            SaveRegField16(OpCodeMode.RM, result);

            // Flags: O S Z A P
            // Flags are set as if SUB instruction was used with operand2 = 1
            // Carry flag is not affected by decrement
            EU.CondReg.CalcOverflowSubtract(1, 0x01, dest);
            EU.CondReg.CalcSignFlag(1, result);
            EU.CondReg.CalcZeroFlag(1, result);
            EU.CondReg.CalcAuxCarryFlag(0x01, dest);
            EU.CondReg.CalcParityFlag(result);
        }
    }
}