﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Assignment_C_.MyExceptions
{
    public class PaymentValidationException : Exception
    {
        public PaymentValidationException(string msg) : base(msg)
        {
        }
    }
}
