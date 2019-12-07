using System;

namespace ConsoleApp1
{
    class Program
    {
        static int NumParse()
        {
            int x = 0;
            bool validNumber = false;
            while (validNumber == false)
            {
                string input = Console.ReadLine();
                validNumber = int.TryParse(input, out x);
                if (validNumber == false)
                    Console.WriteLine("Invalid number");
            }
            return x;
        }


        static void Main(string[] args)
        {
            {
                bool opError = true;
                bool loopCalc = true;
                while (loopCalc == true)
                {
                    //if (Console.ReadLine() == "")
                    //break;
                    int num1 = NumParse();
                    int num2 = NumParse();

                    while (opError == true)
                    {
                        string operation = Console.ReadLine();
                        if (operation == "+")
                        {
                            Console.WriteLine(num1 + num2);
                            break;
                        }
                        else if (operation == "-")
                        {
                            Console.WriteLine(num1 - num2);
                            break;
                        }
                        else if (operation == "*")
                        {
                            Console.WriteLine(num1 * num2);
                            break;
                        }
                        else if (operation == "/")
                        {
                            Console.WriteLine(num1 / num2);
                            break;
                        }
                        else
                            Console.WriteLine("Invalid Operation");
                    }
                }
            }



        }

    }

}

                          

