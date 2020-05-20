using System;
using System.ComponentModel;

namespace _1.uzduotis
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Skaiciuojam trikampio plota:");
            Console.Write("Iveskite krastine a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("iveskite krastine b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Iveskite kampa tarp krastiniu: ");
            double kampas = double.Parse(Console.ReadLine());
            kampas = (Math.PI / 180)*kampas;

            double sinC = Math.Sin(kampas);

            void Plotas()
            {
                double S = a * b * sinC/2;
                S = Math.Round(S, 2);
                Console.WriteLine($"Plotas yra: {S}");
            }

            Plotas();
        }
    }
}
/*S Parašyti programą su metodu, kuris apskaičiuotų trikampio plotą pagal
 * duotas dvi kraštines a ir b ir kampą C tarp jų. Trikampio ploto formulė S = 1/2 * a * b * sin(C). 
 * Vartotojas įveda kraštines ir kampą, o atsakymą konsolėje išvesti dviejų skaičių po kablelio tikslumu.
Pvz. kraštinės 4 ir 8, kampas tarp jų 60, S = 13,86.*/
