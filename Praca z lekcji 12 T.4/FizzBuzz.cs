using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praca_z_lekcji_12_T._4
{
    class FizzBuzz
    {
        public FizzBuzz(int data)
        {
            try
            {
                //Console.WriteLine("Podaj Liczbe a czasem otrzymasz niespodziewaną odpowiedz:");
                //var data = int.Parse(Console.ReadLine());
                if (data % 15 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (data % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (data % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine($"Wpisales liczbe {data}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Proszę podawać tylko liczby");
            }
            finally
            {

            }

        }
    }
}
