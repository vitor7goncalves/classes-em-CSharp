using System;
using System.Collections.Generic;
using System.Globalization;
namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
           Triangulo x, y;
           x = new Triangulo();
           y = new Triangulo();
            
             Console.WriteLine("Entre com os valores do triangulo X: ");
                x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Entre com os valores do triangulo Y: ");
                y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                 
                double areaX = x.Area();

                 
                double areaY = y.Area();

                Console.WriteLine("Area de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine("Area de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

                 if (areaY > areaX)
                {
                    Console.WriteLine("A maior area é do triangulo Y");
                }
                else if (areaX == areaY)
                {
                    Console.WriteLine("Ambas áreas são iguais");
                }
                else if (areaY < areaX)
                {
                    Console.WriteLine("A maior area é do triangulo X");
                }
        }
    }
}
