﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Interfacce
{
    interface IDInterfacce
    {
        int id { get; set; }
        bool status { get; }
        void connetti(string s);
        void disconnetti(string s);
    }
}
