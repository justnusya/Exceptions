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
            for (int i = 10; i < 30; i++)
            {
                try
                {
                    int line1, line2;
                    using (StreamReader reader = new StreamReader($"{i}.txt"))
                    {
                        line1 = int.Parse(reader.ReadLine());
                        line2 = int.Parse(reader.ReadLine());
                    }
                    Console.WriteLine(line1);
                    Console.WriteLine(line2);
                }
                catch (FileNotFoundException)
                {
                    using (StreamWriter writer = new StreamWriter("no_file.txt", true))
                    {
                        writer.WriteLine($"{i}.txt");
                    }
                }
                catch (FormatException)
                {
                    using (StreamWriter writer2 = new StreamWriter("bad_data.txt", true))
                    {
                        writer2.WriteLine($"{i}.txt");
                    }
                }
                catch (ArgumentNullException)
                {
                    using (StreamWriter writer2 = new StreamWriter("bad_data.txt", true))
                    {
                        writer2.WriteLine($"{i}.txt");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
