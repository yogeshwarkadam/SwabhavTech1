﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Model
{
    class Kid:Man
    {
        public override void jump()
        {
            Console.WriteLine("kid is jumping");
        }
    }
}
