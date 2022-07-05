using System;
using System.Globalization;

namespace Problema_terreno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double area, comp, altura, perimetro, diagonal, soma, media;

            Console.Write("Digite o valor da base do retângulo: ");
            comp = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da altura do retângulo: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("RELATÓRIO FINAL:");
            area = comp * altura;
            Console.WriteLine("Área do terreno: " + area.ToString("F4",CI) + "m2");
            perimetro = 2 *(comp + altura);
            Console.WriteLine("Perímetro do terreno: " + perimetro.ToString("F4", CI) + "m2");
            diagonal = Math.Sqrt(Math.Pow(comp,2.0) + Math.Pow(altura, 2.0));
            Console.WriteLine("Valor da diagonal do terreno: " + diagonal.ToString("F4", CI) + "m2");

        }
    }
}
