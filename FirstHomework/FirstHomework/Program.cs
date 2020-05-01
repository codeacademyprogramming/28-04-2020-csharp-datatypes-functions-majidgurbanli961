using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomework
{
    class Program
    {
        static void Main(string[] args)

        {
#pragma region Region_1



            /*
            Console.WriteLine("Give a number please");
            int.TryParse(Console.ReadLine(), out int number);
            countDigits(number);
            */



#pragma endregion Region_1
            /*  Console.WriteLine("Give a number for second Exercise please");
              int.TryParse(Console.ReadLine(), out int number);
              isSimple(number);
              */
            Console.WriteLine("Give a number for third Exercise please");
            int.TryParse(Console.ReadLine(), out int number);
            calculateWhichMonth(number);










        }
        static int countDigits(int number)
        {
            int remain = number % 10;
            number = (number - remain) / 10;

            int counter = 1;
            while (number > 0)
            {
                remain = number % 10;
                number = (number - remain) / 10;
                counter++;
            }
            Console.WriteLine($" Final result is { counter}");


            return number;
        }
        static bool isSimple(int number)
        {
           
          
            int counter=1;
            for(var i=2;i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }

            }
            if (counter > 1)
            {
                Console.WriteLine("Simple deil");
                return false;
            }


            Console.WriteLine("Simpledi");


            return true;
        }
        static void calculateWhichMonth(int number)
        {
            if(number==12 || number==1 || number == 2)
            {
                Console.WriteLine("Qishdir");
            }
            else if (number == 3 || number == 4 || number == 5)
            {
                Console.WriteLine("Yazdir");
            }
            else if (number == 6 || number == 7 || number == 8)
            {
                Console.WriteLine("Yaydir");
            }
            else if (number == 9 || number == 10 || number == 11)
            {
                Console.WriteLine("Payizdir");
            }
            else
            {
                Console.WriteLine("Melumat yanlishdir");
            }

        }
    }
}
