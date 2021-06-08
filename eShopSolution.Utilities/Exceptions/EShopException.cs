﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace eShopSolution.Utilities.Exceptions
{
    public class EShopException : Exception
    {
        public EShopException()
        {

        }
        public EShopException(string message)
        {
               
        }
        public EShopException(string message, Exception inner)
            :base(message, inner)
        {

        }
    }
}
