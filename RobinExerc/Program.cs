using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoisPontosP1P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X1, Y1, X2, Y2, DISTANCIA;


            Console.Write("Coordenadas do primeiro ponto (x1 y1): ");
            X1 = int.Parse(Console.ReadLine());
            Y1 = int.Parse(Console.ReadLine());

            Console.Write("Coordenadas do segundo ponto (x2 y2): ");
            X2 = int.Parse(Console.ReadLine());
            Y2 = int.Parse(Console.ReadLine());

            DISTANCIA = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));

            Console.WriteLine($"A distância entre os pontos é: {DISTANCIA} ");

        }
    }
}
