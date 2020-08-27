using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter amount of money in your wallet");
            var x = Console.ReadLine();

            Console.WriteLine("Now Please Enter amount of money in your bank account");
            var y = Console.ReadLine();



            
        }

                
        static int Add( int x, int y)
        {
           return x + y;
        }
        static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        static string Add(int x, int y, bool a)
        {
            if (a == true)
            {
                var sum = x + y;
                if (sum != 1)
                {
                    return $"{sum} dollars";
                }
                else
                {
                    return $"{sum} dollar";
                }
            }
            else
            {
                return (x + y).ToString();
            }    
        }

               


    }
}

