using System;

namespace num1___num2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 11;
            switch (num1)
            {
                case 5:
                    num1 = 11;
                    break;

                
            }
            switch (num2)
            {
                case 11:
                    num2 = 5;
                    break;

                default:
                    break;
                    
            }
            Console.WriteLine(num1 + " " + num2);
        }
    }
}
