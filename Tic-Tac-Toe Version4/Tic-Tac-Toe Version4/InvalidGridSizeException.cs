﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public class InvalidGridSizeException : Exception
    {
        public InvalidGridSizeException(string message) : base(message)
        {

        }
    }
}
