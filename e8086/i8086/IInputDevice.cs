﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDS.e8086
{
    public interface IInputDevice
    {
        int PortNumber { get; }
        byte Read();
        UInt16 Read16();
    }
}
