using System;

namespace TaskArrayDivisibleBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            
           
                for (int i = 0; i < n; i++)
                {
                    if (n < 50)
                    {
                        if (i % 3 == 0)
                        {

                            Console.WriteLine(i);
                        }
                }
                else if (n > 50 && n < 100)
                {
                    if (i % 5 == 0)
                    {

                        Console.WriteLine(i);
                    }
                }
                else
                {
                    if (i % 8 == 0)
                    {

                        Console.WriteLine(i);
                    }
                }
               
            }
        }
    }
}
