using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string line1, line2;
                for(int i=10; i < 30; i++)
                {
                    using (StreamReader reader = new StreamReader($"{i}.txt"))
                    {
                        line1 = reader.ReadLine();
                        line2 = reader.ReadLine();
                    }
                    Console.WriteLine(line1);
                    //Console.WriteLine(line2);
                    Console.ReadLine();
                }
                
            }//
            catch (Exception)
            {

            }
        }
    }
}
