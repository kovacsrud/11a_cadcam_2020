﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetelek
{
    public class SajatHiba:Exception
    {
        public SajatHiba(string uzenet):base(uzenet)
        {

        }
    }
}
