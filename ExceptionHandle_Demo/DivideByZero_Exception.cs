﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandle_Demo
{
    public class DivideByZero_Exception
    {
        // it will handle error generated form divided by zero
        public void Custom()
        {
            int x = 0;
            try
            {
                int a = 100 / x;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }

        }

    }
}
