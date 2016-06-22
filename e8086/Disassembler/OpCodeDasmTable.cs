﻿
namespace KDS.e8086
{
    public class OpCodeDasmTable
    {
        public static OpCodeDasmRecord[] opCodes = new OpCodeDasmRecord[]
        {
            new OpCodeDasmRecord(0x00,"MRR","DISP","ADD","RM-8","R-8"),
            new OpCodeDasmRecord(0x01,"MRR","DISP","ADD","RM-16","R-16"),
            new OpCodeDasmRecord(0x02,"MRR","DISP","ADD","R-8","RM-8"),
            new OpCodeDasmRecord(0x03,"MRR","DISP","ADD","R-16","RM-16"),
            new OpCodeDasmRecord(0x04,"D-8","","ADD","AL","I-8"),
            new OpCodeDasmRecord(0x05,"D-LO","D-HI","ADD","AX","I-16"),
            new OpCodeDasmRecord(0x06,"","","PUSH ES","",""),
            new OpCodeDasmRecord(0x07,"","","POP ES","",""),
            new OpCodeDasmRecord(0x08,"MRR","DISP","OR","RM-8","R-8"),
            new OpCodeDasmRecord(0x09,"MRR","DISP","OR","RM-16","R-16"),
            new OpCodeDasmRecord(0x0A,"MRR","DISP","OR","R-8","RM-8"),
            new OpCodeDasmRecord(0x0B,"MRR","DISP","OR","R-16","RM-16"),
            new OpCodeDasmRecord(0x0C,"D-8","","OR","AL","I-8"),
            new OpCodeDasmRecord(0x0D,"D-LO","D-HI","OR","AX","I-16"),
            new OpCodeDasmRecord(0x0E,"","","PUSH CS","",""),
            new OpCodeDasmRecord(0x0F,"","","POP CS","",""),
            new OpCodeDasmRecord(0x10,"MRR","DISP","ADC","RM-8","R-8"),
            new OpCodeDasmRecord(0x11,"MRR","DISP","ADC","RM-16","R-16"),
            new OpCodeDasmRecord(0x12,"MRR","DISP","ADC","R-8","RM-8"),
            new OpCodeDasmRecord(0x13,"MRR","DISP","ADC","R-16","RM-16"),
            new OpCodeDasmRecord(0x14,"D-8","","ADC","AL","I-8"),
            new OpCodeDasmRecord(0x15,"D-LO","D-HI","ADC","AX","I-16"),
            new OpCodeDasmRecord(0x16,"","","PUSH SS","",""),
            new OpCodeDasmRecord(0x17,"","","POP SS","",""),
            new OpCodeDasmRecord(0x18,"MRR","DISP","SBB","RM-8","R-8"),
            new OpCodeDasmRecord(0x19,"MRR","DISP","SBB","RM-16","R-16"),
            new OpCodeDasmRecord(0x1A,"MRR","DISP","SBB","R-8","RM-8"),
            new OpCodeDasmRecord(0x1B,"MRR","DISP","SBB","R-16","RM-16"),
            new OpCodeDasmRecord(0x1C,"D-8","","SBB","AL","I-8"),
            new OpCodeDasmRecord(0x1D,"D-LO","D-HI","SBB","AX","I-16"),
            new OpCodeDasmRecord(0x1E,"","","PUSH DS","",""),
            new OpCodeDasmRecord(0x1F,"","","POP DS","",""),
            new OpCodeDasmRecord(0x20,"MRR","DISP","AND","RM-8","R-8"),
            new OpCodeDasmRecord(0x21,"MRR","DISP","AND","RM-16","R-16"),
            new OpCodeDasmRecord(0x22,"MRR","DISP","AND","R-8","RM-8"),
            new OpCodeDasmRecord(0x23,"MRR","DISP","AND","R-16","RM-16"),
            new OpCodeDasmRecord(0x24,"D-8","","AND","AL","I-8"),
            new OpCodeDasmRecord(0x25,"D-LO","D-HI","AND","AX","I-16"),
            new OpCodeDasmRecord(0x26,"","","ES:","",""),
            new OpCodeDasmRecord(0x27,"","","DAA","",""),
            new OpCodeDasmRecord(0x28,"MRR","DISP","SUB","RM-8","R-8"),
            new OpCodeDasmRecord(0x29,"MRR","DISP","SUB","RM-16","R-16"),
            new OpCodeDasmRecord(0x2A,"MRR","DISP","SUB","R-8","RM-8"),
            new OpCodeDasmRecord(0x2B,"MRR","DISP","SUB","R-16","RM-16"),
            new OpCodeDasmRecord(0x2C,"D-8","","SUB","AL","I-8"),
            new OpCodeDasmRecord(0x2D,"D-LO","D-HI","SUB","AX","I-16"),
            new OpCodeDasmRecord(0x2E,"","","CS:","",""),
            new OpCodeDasmRecord(0x2F,"","","DAS","",""),
            new OpCodeDasmRecord(0x30,"MRR","DISP","XOR","RM-8","R-8"),
            new OpCodeDasmRecord(0x31,"MRR","DISP","XOR","RM-16","R-16"),
            new OpCodeDasmRecord(0x32,"MRR","DISP","XOR","R-8","RM-8"),
            new OpCodeDasmRecord(0x33,"MRR","DISP","XOR","R-16","RM-16"),
            new OpCodeDasmRecord(0x34,"D-8","","XOR","AL","I-8"),
            new OpCodeDasmRecord(0x35,"D-LO","D-HI","XOR","AX","I-16"),
            new OpCodeDasmRecord(0x36,"","","SS:","",""),
            new OpCodeDasmRecord(0x37,"","","AAA","",""),
            new OpCodeDasmRecord(0x38,"MRR","DISP","CMP","RM-8","R-8"),
            new OpCodeDasmRecord(0x39,"MRR","DISP","CMP","RM-16","R-16"),
            new OpCodeDasmRecord(0x3A,"MRR","DISP","CMP","R-8","RM-8"),
            new OpCodeDasmRecord(0x3B,"MRR","DISP","CMP","R-16","RM-16"),
            new OpCodeDasmRecord(0x3C,"D-8","","CMP","AL","I-8"),
            new OpCodeDasmRecord(0x3D,"D-LO","D-HI","CMP","AX","I-16"),
            new OpCodeDasmRecord(0x3E,"","","DS:","",""),
            new OpCodeDasmRecord(0x3F,"","","AAS","",""),
            new OpCodeDasmRecord(0x40,"","","INC AX","",""),
            new OpCodeDasmRecord(0x41,"","","INC CX","",""),
            new OpCodeDasmRecord(0x42,"","","INC DX","",""),
            new OpCodeDasmRecord(0x43,"","","INC BX","",""),
            new OpCodeDasmRecord(0x44,"","","INC SP","",""),
            new OpCodeDasmRecord(0x45,"","","INC BP","",""),
            new OpCodeDasmRecord(0x46,"","","INC SI","",""),
            new OpCodeDasmRecord(0x47,"","","INC DI","",""),
            new OpCodeDasmRecord(0x48,"","","DEC AX","",""),
            new OpCodeDasmRecord(0x49,"","","DEC CX","",""),
            new OpCodeDasmRecord(0x4A,"","","DEC DX","",""),
            new OpCodeDasmRecord(0x4B,"","","DEC BX","",""),
            new OpCodeDasmRecord(0x4C,"","","DEC SP","",""),
            new OpCodeDasmRecord(0x4D,"","","DEC BP","",""),
            new OpCodeDasmRecord(0x4E,"","","DEC SI","",""),
            new OpCodeDasmRecord(0x4F,"","","DEC DI","",""),
            new OpCodeDasmRecord(0x50,"","","PUSH AX","",""),
            new OpCodeDasmRecord(0x51,"","","PUSH CX","",""),
            new OpCodeDasmRecord(0x52,"","","PUSH DX","",""),
            new OpCodeDasmRecord(0x53,"","","PUSH BX","",""),
            new OpCodeDasmRecord(0x54,"","","PUSH SP","",""),
            new OpCodeDasmRecord(0x55,"","","PUSH BP","",""),
            new OpCodeDasmRecord(0x56,"","","PUSH SI","",""),
            new OpCodeDasmRecord(0x57,"","","PUSH DI","",""),
            new OpCodeDasmRecord(0x58,"","","POP AX","",""),
            new OpCodeDasmRecord(0x59,"","","POP CX","",""),
            new OpCodeDasmRecord(0x5A,"","","POP DX","",""),
            new OpCodeDasmRecord(0x5B,"","","POP BX","",""),
            new OpCodeDasmRecord(0x5C,"","","POP SP","",""),
            new OpCodeDasmRecord(0x5D,"","","POP BP","",""),
            new OpCodeDasmRecord(0x5E,"","","POP SI","",""),
            new OpCodeDasmRecord(0x5F,"","","POP DI","",""),
            new OpCodeDasmRecord(0x60,"","","","",""),
            new OpCodeDasmRecord(0x61,"","","","",""),
            new OpCodeDasmRecord(0x62,"","","","",""),
            new OpCodeDasmRecord(0x63,"","","","",""),
            new OpCodeDasmRecord(0x64,"","","","",""),
            new OpCodeDasmRecord(0x65,"","","","",""),
            new OpCodeDasmRecord(0x66,"","","","",""),
            new OpCodeDasmRecord(0x67,"","","","",""),
            new OpCodeDasmRecord(0x68,"","","","",""),
            new OpCodeDasmRecord(0x69,"","","","",""),
            new OpCodeDasmRecord(0x6A,"","","","",""),
            new OpCodeDasmRecord(0x6B,"","","","",""),
            new OpCodeDasmRecord(0x6C,"","","","",""),
            new OpCodeDasmRecord(0x6D,"","","","",""),
            new OpCodeDasmRecord(0x6E,"","","","",""),
            new OpCodeDasmRecord(0x6F,"","","","",""),
            new OpCodeDasmRecord(0x70,"IP-INC-8","","JO","SHORT",""),
            new OpCodeDasmRecord(0x71,"IP-INC-8","","JNO","SHORT",""),
            new OpCodeDasmRecord(0x72,"IP-INC-8","","JB","SHORT",""),
            new OpCodeDasmRecord(0x73,"IP-INC-8","","JNB","SHORT",""),
            new OpCodeDasmRecord(0x74,"IP-INC-8","","JZ","SHORT",""),
            new OpCodeDasmRecord(0x75,"IP-INC-8","","JNZ","SHORT",""),
            new OpCodeDasmRecord(0x76,"IP-INC-8","","JBE","SHORT",""),
            new OpCodeDasmRecord(0x77,"IP-INC-8","","JA","SHORT",""),
            new OpCodeDasmRecord(0x78,"IP-INC-8","","JS","SHORT",""),
            new OpCodeDasmRecord(0x79,"IP-INC-8","","JNS","SHORT",""),
            new OpCodeDasmRecord(0x7A,"IP-INC-8","","JPE","SHORT",""),
            new OpCodeDasmRecord(0x7B,"IP-INC-8","","JPO","SHORT",""),
            new OpCodeDasmRecord(0x7C,"IP-INC-8","","JL","SHORT",""),
            new OpCodeDasmRecord(0x7D,"IP-INC-8","","JGE","SHORT",""),
            new OpCodeDasmRecord(0x7E,"IP-INC-8","","JLE","SHORT",""),
            new OpCodeDasmRecord(0x7F,"IP-INC-8","","JGE","SHORT",""),
            new OpCodeDasmRecord(0x80,"MRR","DISP","GRP1","RM-8","I-8"),
            new OpCodeDasmRecord(0x81,"MRR","DISP","GRP1","RM-16","I-16"),
            new OpCodeDasmRecord(0x82,"MRR","DISP","GRP1","RM-8","I-8"),
            new OpCodeDasmRecord(0x83,"MRR","DISP-SX","GRP1","RM-16","I-8"),
            new OpCodeDasmRecord(0x84,"MRR","DISP","TEST","RM-8","R-8"),
            new OpCodeDasmRecord(0x85,"MRR","DISP","TEST","RM-16","R-16"),
            new OpCodeDasmRecord(0x86,"MRR","DISP","XCHG","R-8","RM-8"),
            new OpCodeDasmRecord(0x87,"MRR","DISP","XCHG","R-16","RM-16"),
            new OpCodeDasmRecord(0x88,"MRR","DISP","MOV","RM-8","R-8"),
            new OpCodeDasmRecord(0x89,"MRR","DISP","MOV","RM-16","R-16"),
            new OpCodeDasmRecord(0x8A,"MRR","DISP","MOV","R-8","RM-8"),
            new OpCodeDasmRecord(0x8B,"MRR","DISP","MOV","R-16","RM-16"),
            new OpCodeDasmRecord(0x8C,"MRR","DISP","MOV","RM-16","SEG"),
            new OpCodeDasmRecord(0x8D,"MRR","DISP","LEA","R-16","M-16"),
            new OpCodeDasmRecord(0x8E,"MRR","DISP","MOV","SEG","RM-16"),
            new OpCodeDasmRecord(0x8F,"MRR","DISP","POP","RM-16",""),
            new OpCodeDasmRecord(0x90,"","","NOP","",""),
            new OpCodeDasmRecord(0x91,"","","XCHG AX,CX","",""),
            new OpCodeDasmRecord(0x92,"","","XCHG AX,DX","",""),
            new OpCodeDasmRecord(0x93,"","","XCHG AX,BX","",""),
            new OpCodeDasmRecord(0x94,"","","XCHG AX,SP","",""),
            new OpCodeDasmRecord(0x95,"","","XCHG AX,BP","",""),
            new OpCodeDasmRecord(0x96,"","","XCHG AX,SI","",""),
            new OpCodeDasmRecord(0x97,"","","XCHG AX,DI","",""),
            new OpCodeDasmRecord(0x98,"","","CBW","",""),
            new OpCodeDasmRecord(0x99,"","","CWD","",""),
            new OpCodeDasmRecord(0x9A,"D-LO","D-HI,S-LO,S-HI","CALL","FAR",""),
            new OpCodeDasmRecord(0x9B,"","","WAIT","",""),
            new OpCodeDasmRecord(0x9C,"","","PUSHF","",""),
            new OpCodeDasmRecord(0x9D,"","","POPF","",""),
            new OpCodeDasmRecord(0x9E,"","","SAHF","",""),
            new OpCodeDasmRecord(0x9F,"","","LAHF","",""),
            new OpCodeDasmRecord(0xA0,"A-LO","A-HI","MOV","AL","M-8"),
            new OpCodeDasmRecord(0xA1,"A-LO","A-HI","MOV","AX","M-16"),
            new OpCodeDasmRecord(0xA2,"A-LO","A-HI","MOV","M-8","AL"),
            new OpCodeDasmRecord(0xA3,"A-LO","A-HI","MOV","M-16","AX"),
            new OpCodeDasmRecord(0xA4,"","","MOVSB","",""),
            new OpCodeDasmRecord(0xA5,"","","MOVSW","",""),
            new OpCodeDasmRecord(0xA6,"","","CMPSB","",""),
            new OpCodeDasmRecord(0xA7,"","","CMPSW","",""),
            new OpCodeDasmRecord(0xA8,"D-8","","TEST","AL","I-8"),
            new OpCodeDasmRecord(0xA9,"D-LO","D-HI","TEST","AX","I-16"),
            new OpCodeDasmRecord(0xAA,"","","STOSB","",""),
            new OpCodeDasmRecord(0xAB,"","","STOSW","",""),
            new OpCodeDasmRecord(0xAC,"","","LODSB","",""),
            new OpCodeDasmRecord(0xAD,"","","LODSW","",""),
            new OpCodeDasmRecord(0xAE,"","","SCASB","",""),
            new OpCodeDasmRecord(0xAF,"","","SCASW","",""),
            new OpCodeDasmRecord(0xB0,"D-8","","MOV","AL","I-8"),
            new OpCodeDasmRecord(0xB1,"D-8","","MOV","CL","I-8"),
            new OpCodeDasmRecord(0xB2,"D-8","","MOV","DL","I-8"),
            new OpCodeDasmRecord(0xB3,"D-8","","MOV","BL","I-8"),
            new OpCodeDasmRecord(0xB4,"D-8","","MOV","AH","I-8"),
            new OpCodeDasmRecord(0xB5,"D-8","","MOV","CH","I-8"),
            new OpCodeDasmRecord(0xB6,"D-8","","MOV","DH","I-8"),
            new OpCodeDasmRecord(0xB7,"D-8","","MOV","BH","I-8"),
            new OpCodeDasmRecord(0xB8,"D-LO","D-HI","MOV","AX","I-16"),
            new OpCodeDasmRecord(0xB9,"D-LO","D-HI","MOV","CX","I-16"),
            new OpCodeDasmRecord(0xBA,"D-LO","D-HI","MOV","DX","I-16"),
            new OpCodeDasmRecord(0xBB,"D-LO","D-HI","MOV","BX","I-16"),
            new OpCodeDasmRecord(0xBC,"D-LO","D-HI","MOV","SP","I-16"),
            new OpCodeDasmRecord(0xBD,"D-LO","D-HI","MOV","BP","I-16"),
            new OpCodeDasmRecord(0xBE,"D-LO","D-HI","MOV","SI","I-16"),
            new OpCodeDasmRecord(0xBF,"D-LO","D-HI","MOV","DI","I-16"),
            new OpCodeDasmRecord(0xC0,"","","","",""),
            new OpCodeDasmRecord(0xC1,"","","","",""),
            new OpCodeDasmRecord(0xC2,"D-LO","D-HI","RET","I-16",""),
            new OpCodeDasmRecord(0xC3,"","","RET","",""),
            new OpCodeDasmRecord(0xC4,"MRR","DISP","LES","R-16","M-16"),
            new OpCodeDasmRecord(0xC5,"MRR","DISP","LDS","R-16","M-16"),
            new OpCodeDasmRecord(0xC6,"MRR","DISP","MOV","M-8","I-8"),
            new OpCodeDasmRecord(0xC7,"MRR","DISP","MOV","M-16","I-16"),
            new OpCodeDasmRecord(0xC8,"","","","",""),
            new OpCodeDasmRecord(0xC9,"","","","",""),
            new OpCodeDasmRecord(0xCA,"D-LO","D-HI","RET","I-16",""),
            new OpCodeDasmRecord(0xCB,"","","RET","",""),
            new OpCodeDasmRecord(0xCC,"","","INT3","",""),
            new OpCodeDasmRecord(0xCD,"D-8","","INT","I-8",""),
            new OpCodeDasmRecord(0xCE,"","","INTO","",""),
            new OpCodeDasmRecord(0xCF,"","","IRET","",""),
            new OpCodeDasmRecord(0xD0,"MRR","DISP","GRP2","RM-8","1"),
            new OpCodeDasmRecord(0xD1,"MRR","DISP","GRP2","RM-16","1"),
            new OpCodeDasmRecord(0xD2,"MRR","DISP","GRP2","RM-8","CL"),
            new OpCodeDasmRecord(0xD3,"MRR","DISP","GRP2","RM-16","CL"),
            new OpCodeDasmRecord(0xD4,"D-8","","AAM","I-8",""),
            new OpCodeDasmRecord(0xD5,"D-8","","AAD","I-8",""),
            new OpCodeDasmRecord(0xD6,"","","","",""),
            new OpCodeDasmRecord(0xD7,"","","XLAT","",""),
            new OpCodeDasmRecord(0xD8,"MRR","DISP","ESC","OPCODE","SOURCE"),
            new OpCodeDasmRecord(0xD9,"","","","",""),
            new OpCodeDasmRecord(0xDA,"","","","",""),
            new OpCodeDasmRecord(0xDB,"","","","",""),
            new OpCodeDasmRecord(0xDC,"","","","",""),
            new OpCodeDasmRecord(0xDD,"","","","",""),
            new OpCodeDasmRecord(0xDE,"","","","",""),
            new OpCodeDasmRecord(0xDF,"MRR","","","",""),
            new OpCodeDasmRecord(0xE0,"IP-INC-8","","LOOPNZ","SHORT",""),
            new OpCodeDasmRecord(0xE1,"IP-INC-8","","LOOPZ","SHORT",""),
            new OpCodeDasmRecord(0xE2,"IP-INC-8","","LOOP","SHORT",""),
            new OpCodeDasmRecord(0xE3,"IP-INC-8","","JCXZ","SHORT",""),
            new OpCodeDasmRecord(0xE4,"D-8","","IN","AL","I-8"),
            new OpCodeDasmRecord(0xE5,"D-8","","IN","AX","I-8"),
            new OpCodeDasmRecord(0xE6,"D-8","","OUT","I-8","AL"),
            new OpCodeDasmRecord(0xE7,"D-8","","OUT","I-8","AX"),
            new OpCodeDasmRecord(0xE8,"IP-INC-LO","IP-INC-HI","CALL","NEAR",""),
            new OpCodeDasmRecord(0xE9,"IP-INC-LO","IP-INC-HI","JMP","NEAR",""),
            new OpCodeDasmRecord(0xEA,"IP-LO","IP-HI,CS-LO,CS-HI","JMP","FAR",""),
            new OpCodeDasmRecord(0xEB,"IP-INC-8","","JMP","SHORT",""),
            new OpCodeDasmRecord(0xEC,"","","IN AL,DX","",""),
            new OpCodeDasmRecord(0xED,"","","IN AX,DX","",""),
            new OpCodeDasmRecord(0xEE,"","","OUT AL,DX","",""),
            new OpCodeDasmRecord(0xEF,"","","OUT AX,DX","",""),
            new OpCodeDasmRecord(0xF0,"","","LOCK","",""),
            new OpCodeDasmRecord(0xF1,"","","","",""),
            new OpCodeDasmRecord(0xF2,"","","REPNZ","",""),
            new OpCodeDasmRecord(0xF3,"","","REP","",""),
            new OpCodeDasmRecord(0xF4,"","","HLT","",""),
            new OpCodeDasmRecord(0xF5,"","","CMC","",""),
            new OpCodeDasmRecord(0xF6,"MRR","DISP","GRP3","RM-8","I-8"),
            new OpCodeDasmRecord(0xF7,"MRR","DISP","GRP3","RM-16",""),
            new OpCodeDasmRecord(0xF8,"","","CLC","",""),
            new OpCodeDasmRecord(0xF9,"","","STC","",""),
            new OpCodeDasmRecord(0xFA,"","","CLI","",""),
            new OpCodeDasmRecord(0xFB,"","","STI","",""),
            new OpCodeDasmRecord(0xFC,"","","CLD","",""),
            new OpCodeDasmRecord(0xFD,"","","STD","",""),
            new OpCodeDasmRecord(0xFE,"MRR","DISP","GRP4","RM-8",""),
            new OpCodeDasmRecord(0xFF,"MRR","DISP","GRP5","RM-16","")

        };
    }
}