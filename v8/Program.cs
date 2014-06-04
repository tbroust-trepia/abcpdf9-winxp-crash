using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace v8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a Doc");

            using (var doc = new WebSupergoo.ABCpdf8.Doc())
            {
                // is it working ?
            }

            Console.WriteLine("OK");
        }
    }
}