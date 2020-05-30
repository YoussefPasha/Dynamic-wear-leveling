using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{




    class Program
    {
        static void Main(string[] args)
        {


            File file = new File();
            file.add("A", 5);
            file.print();
            file.add("B", 4);
            file.print();
            file.add("C", 6);
            file.print();
            file.erase("B");
            file.print();
            file.add("D", 3);
            file.print();
            file.erase("D");
            file.print();
            file.add("F", 3);
            file.print();
            file.erase("C");
            file.print();
            file.add("G", 2);
            file.print();

        }
    }
}
