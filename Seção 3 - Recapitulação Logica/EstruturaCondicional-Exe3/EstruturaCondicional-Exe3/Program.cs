using System;

namespace EstruturaCondicional_Exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, este programa tem o objetivo de indetificar se dois números são multiplos entre si.");
            Console.WriteLine("Por favor, digite os dois números: ");
            string[] numbers = Console.ReadLine().Split(' ');
            int num1 = int.Parse(numbers[0]);
            int num2 = int.Parse(numbers[1]);

            if (num1 > num2)
            {
                if (num1 % num2 == 0)
                {
                    Console.WriteLine("Os números digitados são Multiplos!");
                }
                else
                {
                    Console.WriteLine("Os números digitados não são Multiplos!");
                }
            }
            else if (num2 % num1 == 0)
                 {
                Console.WriteLine("Os números digitados são Multiplos!");
                  }
            else
                 {
                Console.WriteLine("Os números digitados não são Multiplos!");
                  }
        
             }
        }
    }
