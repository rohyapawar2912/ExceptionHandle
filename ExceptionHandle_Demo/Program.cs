using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandle_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DivideByZero_Exception divideByZero_Exception = new DivideByZero_Exception();
            divideByZero_Exception.Custom();
            Console.WriteLine("-------------------------------------------------------------");
        }
    }
}
