﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDS.e8086
{
    /// <summary>
    /// Op Codes: SUB 28-2B, SBB 18-1B
    ///         : CMP 38-3B
    /// operand1 = operand1 - operand2
    /// Flags: O S Z A P C
    /// </summary>
    public class SUB : TwoByteInstruction
    {
        public SUB(byte opCode, IExecutionUnit eu, IBus bus) : base(opCode, eu, bus)
        {

        }

        protected override void ExecuteInstruction()
        {
            int source = GetSourceData(direction, wordSize, secondByte.MOD, secondByte.REG, secondByte.RM);
            SUB_Destination(source, secondByte.MOD, secondByte.REG, secondByte.RM);
        }

        protected void SUB_Destination(int source, byte mod, byte reg, byte rm)
        {
            AssertMOD(mod);
            int result = 0;
            int offset;
            int dest = 0;
            int carry = 0;
            bool with_carry = (OpCode & 0x10) == 0x10;
            bool comp_only = (OpCode & 0x30) == 0x30;

            // Include carry flag if necessary
            if (with_carry && EU.CondReg.CarryFlag)
            {
                carry = 1;
            }

            // if direction is 1 (R/M is source) action is the same regardless of mod
            if (direction == 1)
            {
                if (wordSize == 0)
                {
                    dest = GetRegField8(reg);
                    result = dest - (source + carry);
                    if (!comp_only) SaveRegField8(reg, (byte)result);
                }
                else
                {
                    dest = GetRegField16(reg);
                    result = dest - (source + carry);
                    if (!comp_only) SaveRegField16(reg, (ushort)result);
                }
            }
            else
            {
                switch (mod)
                {
                    case 0x00:
                        {
                            offset = GetRMTable1(rm);
                            dest = Bus.GetData(wordSize, offset);
                            result = dest - (source + carry);
                            if (!comp_only) Bus.SaveData(wordSize, offset, result);
                            break;
                        }
                    case 0x01:
                    case 0x02:  // difference is processed in the GetRMTable2 function
                        {
                            offset = GetRMTable2(mod, rm);
                            dest = Bus.GetData(wordSize, offset);
                            result = dest - (source + carry);
                            if (!comp_only) Bus.SaveData(wordSize, offset, result);
                            break;
                        }
                    case 0x03:
                        {
                            if (wordSize == 0)
                            {
                                dest = GetRegField8(rm);
                                result = dest - (source + carry);
                                if (!comp_only) SaveRegField8(rm, (byte)result);
                            }
                            else // if ((direction == 0) && (wordSize == 1))
                            {
                                dest = GetRegField16(rm);
                                result = dest - (source + carry);
                                if (!comp_only) SaveRegField16(rm, (ushort)result);
                            }
                            break;
                        }
                }
            }

            // Flags: O S Z A P C
            EU.CondReg.CalcOverflowSubtract(wordSize, source + carry, dest);
            EU.CondReg.CalcSignFlag(wordSize, result);
            EU.CondReg.CalcZeroFlag(wordSize, result);
            EU.CondReg.CalcAuxCarryFlag(source, dest);
            EU.CondReg.CalcParityFlag(result);
            EU.CondReg.CalcCarryFlag(wordSize, result);
        }

    }
}