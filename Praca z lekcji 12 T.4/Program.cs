using System;

namespace Praca_z_lekcji_12_T._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {

                    Console.WriteLine("Podaj Liczbe a czasem otrzymasz niespodziewaną odpowiedz:");
                    var fizzGame = new FizzBuzz();

                    var number = int.Parse(Console.ReadLine());

                    var player = fizzGame.Fizz(number);
                    Console.WriteLine(player);

                    Console.WriteLine("Jesli chcesz grac dalej wpisz 1");
                    var answer = int.Parse(Console.ReadLine());
                    if (answer != 1)
                    {
                        break;
                    }
                    Console.Clear();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Proszę podawać tylko liczby");
            }
            finally
            {
                Console.WriteLine("Dziekuję za udział w grze");
            }
        }
    }
}
