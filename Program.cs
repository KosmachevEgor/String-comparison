using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace YCP2Sravnenie_chisel
{
    class Program
    {
        static int _n1, _n2, _n3;
        static string _l1, _l2;

        static void Main(string[] args)
        {
            
               
                
                    START();
                
                
        }
        private static void GET_NUM_DATA()
        {
            Console.WriteLine("Введите первое число:");
            _n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            _n2 = Convert.ToInt32(Console.ReadLine());
        }
        private static void GET_STR_DATA()
        {
            Console.WriteLine("Введите первую строку: ");
            _l1 = Console.ReadLine();
                _n1 = _l1.Length;
            Console.WriteLine("Ввелите вторую строку: ");
                _l2 = Console.ReadLine();
                _n2 = _l2.Length;
        }
        private static void RESULT()
        {
            if (_n1>_n2 | _n1<_n2 & _n1!=_n2)
            { Console.WriteLine(_n1 > _n2); }
            else
            {
                Console.WriteLine("Введены неверные или равные значения");
            }
          
        }
        private static void START()
        {
            Console.WriteLine("Что желаете сравнить?");
            Console.WriteLine("1.Числа");
            Console.WriteLine("2.Строки");
            _n3 = Convert.ToInt32(Console.ReadLine());
            if (_n3 == 1 )
            {
                try
                {
                    GET_NUM_DATA();
                }
                catch
                {
                    Console.WriteLine("Возникло исключение!");
                    Console.WriteLine();
                }


                RESULT();
            }
            else if(_n3 == 2)
            {
                try
                {
                    GET_STR_DATA();
                }
                catch
                {
                    Console.WriteLine("Возникло исключение!");
                    Console.WriteLine();
                }
                RESULT();
            }    

        }






    }

}
