using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_examples
{
    class Program
    {
        static double Sum(int num1,double num2)
        {
            return num1 + num2;
        }
        static double Multi(int num1,double num2)
        {
            return num1 * num2;
        }
        static double Div(int num1, double num2)
        {
            return num1 / num2;
        }

        static double Reduct(int num1, double num2)
        {
            return num2 - num1;
        }

        static double Reply()
        {
            Console.WriteLine(" = ");

            string l = Console.ReadLine();
            bool isDouble = double.TryParse(l,out double result);
            if (isDouble)
            {
                return result;
            }
            return 0;
        }
        static bool ControlResult(double result,double my_result)
        {
            if (my_result == result)
            {
                return true;
            }
            return false;
        }
        
        static void Control(double result, double my_result)
        {
            if (!ControlResult(result, my_result))
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;                
            }
           
        }

        

        static void Main(string[] args)
        {
            
            Console.Write("How many examples do you want: ");         
            
            string line = Console.ReadLine();
            int count = int.Parse(line);
            int counter = 0;
            int true_results = 0;
            while (counter < count)
            {
                Random random = new Random();

                int number1 = random.Next(1, 10);
                double number2 = random.Next(1, 10);
                int rand = random.Next(1, 4);
                
                if (rand == 1)
                {
                    var s = Sum(number1, number2);
                    Console.Write($"{number1} + {number2}");
                    var c = Reply();
                    Console.Clear();
                    Control(s, c);
                    Console.WriteLine($"{number1} + {number2} = {s}");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (ControlResult(s, c))
                    {
                        ++true_results;
                    }
                }
                else if (rand == 2)
                {
                    var m = Multi(number1, number2);
                    Console.Write($"{number1} * {number2}");
                    var c = Reply();
                    Console.Clear();
                    Control(m, c);
                    Console.WriteLine($"{number1} * {number2} = {m}");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (ControlResult(m, c))
                    {
                        ++true_results;
                    }
                }
                else if (rand == 3)
                {
                    var d = Div(number1, number2);
                    Console.Write($"{number1} / {number2}");
                    var c = Reply();
                    Console.Clear();
                    
                        if (d!=c)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{number1} / {number2} = {d}");
                            ++true_results;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{number1} / {number2} = {d}");
                        }                   
                    
                    Console.ForegroundColor = ConsoleColor.White;
                  
                }
                else if (rand == 4)
                {
                    var r = Reduct(number1, number2);
                    Console.Write($"{number1} - {number2}");
                    var c = Reply();
                    Console.Clear();
                    Control(r, c);
                    Console.WriteLine($"{number1} - {number2} = {r}");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (ControlResult(r, c))
                    {
                        ++true_results;
                    }
                }
            }
            Console.Clear();
            Console.WriteLine($"True results: {true_results}");

        }
    }
}
