﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302204034
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo b = new SayaTubeVideo("'Tutorial Design By Contract – [Jahfal Mudrik Ramadhan]'");
            b.PrintVideoDetails();
            b.IncreasePlayCount(3);
            b.PrintVideoDetails();
        }

    }
}