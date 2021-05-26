using System;

namespace mathdemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. Plus");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.Write("Enter your choose: ");
            int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        {
                            Console.WriteLine(a + " + " + b + " = " + (a + b));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(a + " - " + b + " = " + (a - b));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(a + " * " + b + " = " + (a * b));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine(a + " / " + b + " = " + ((double)a / (double)b));
                            break;
                        }
                }
        }
    }
}
