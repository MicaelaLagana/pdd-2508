using System;

namespace ejercicio_uno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adivina el numero del 1 al 9");
            int correctNumber = 7;
            Console.WriteLine("ingresa un numero: ");
            var input = Console.ReadLine();
            int inputNumber = int.Parse(input);

            while (correctNumber != inputNumber) {
                Console.WriteLine("intenta de nuevo: ");
                inputNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("correcto");
        }
    }
}
