using System;
using System.IO;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int count = 0; double sum = 0;
                for (int i = 10; i < 30; i++)
                {
                    int multiplication = 0;
                    try
                    {
                        int line1, line2;
                        using (StreamReader reader = new StreamReader($"{i}.txt"))
                        {
                            line1 = int.Parse(reader.ReadLine());
                            line2 = int.Parse(reader.ReadLine());
                        }
                        multiplication = checked(line1 * line2);
                    }
                    catch (FileNotFoundException)
                    {
                        using (StreamWriter writer = new StreamWriter("no_file.txt", true))
                        {
                            writer.WriteLine($"{i}.txt");
                        }
                        continue;
                    }
                    catch (FormatException)
                    {
                        using (StreamWriter writer2 = new StreamWriter("bad_data.txt", true))
                        {
                            writer2.WriteLine($"{i}.txt");
                        }
                        continue;
                    }
                    catch (ArgumentNullException)
                    {
                        using (StreamWriter writer2 = new StreamWriter("bad_data.txt", true))
                        {
                            writer2.WriteLine($"{i}.txt");
                        }
                        continue;
                    }
                    catch (OverflowException)
                    {
                        using (StreamWriter writer3 = new StreamWriter("overflow.txt", true))
                        {
                            writer3.WriteLine($"{i}.txt");
                        }
                        continue;
                    }
                    count++;
                    sum += multiplication;
                }
                Console.WriteLine(sum / (double)count);

                //int hello = 2147483648;
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Oops! Something went wrong..");
                Console.ReadLine();
            }
        }
    }
}
