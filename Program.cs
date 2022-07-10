using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Ex
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Здравствуйте вас приветствует математическая программа");

            while (true)
            {
                
                Console.WriteLine("пожалуйста введите число. ");
                String UserNumber = Console.ReadLine();
                int.TryParse(UserNumber, out int number);
                
                try
                {
                    Console.WriteLine("Факториал равет " + GetFactorial(number));
                    Console.WriteLine("Сумма от 1 до N равна " + GetSum(number));
                    Console.WriteLine("максимальное четное число меньше N равно " + GetMaxEvenNum(number));

                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("Неизвестное значение. Попробуйте еще раз.");
                }

            }
            
        }
        public static int GetFactorial(int number)
        {
            int factorial = 1;
            if(number< 0)
            {
                factorial = -1;
            }
            if(number > 1)
            {
                for(int i = number; i >0 ; i--)
                {
                    factorial *= i;
                }
            }
            return factorial;
            
        }

        public static int GetSum( int number)
        {
            int sum = 0;
            for(int i = 0; i <= number; i++)
            {
                sum += i;
            }
            return sum;
            
        }

        public static int GetMaxEvenNum( int number)
        {
            int maxEvenNum = 0;
            for( int i = 0; i <= number; i++)
            {
                if(i%number == 0)
                    maxEvenNum = i;
            }
            return maxEvenNum;
            
        }
    }
}
    
