using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace v9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a Doc");

            using (var doc = new WebSupergoo.ABCpdf9.Doc())
            {
                // is it working ?
            }

            Console.WriteLine("OK");
        }
    }
}