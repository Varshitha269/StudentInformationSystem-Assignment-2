﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Assignment_C_.MyExceptions
{
    public class StudentNotFoundException : Exception
    {
        public StudentNotFoundException(string msg) : base(msg)
        {
        }


    }
}
