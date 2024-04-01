using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero de 1 a 4 ");
            Console.WriteLine("1. Converter de centímetros para metros");
            Console.WriteLine("2. Converter de metros para centímetros");
            Console.WriteLine("3. Converter de milímetros para metros "); 
            Console.WriteLine("4. Converter de metros para milímetros ");
            int num1 = int.Parse(Console.ReadLine());
            switch (num1)
            {
                case 1:
                    Console.WriteLine(" 1. Converter de centímetros para metros");
                    Console.WriteLine("Digite os Centímetros ");
                    double cm = double.Parse(Console.ReadLine());
                    double result = cm / 100;
                    Console.WriteLine(result + " Metros ");
                    break;

                case 2:
                    
                    Console.WriteLine(" 2. Converter de metros para centímetros");
                    Console.WriteLine("Digite os Metros  ");
                    double m = double.Parse(Console.ReadLine());
                    double resultado = m * 100;
                    Console.WriteLine(resultado + " Centímetros");
                    break;

                case 3:
                    Console.WriteLine(" 3. Converter de milímetros para metros ");
                    Console.WriteLine("Digite os Milímetros  ");
                    double mm = double.Parse(Console.ReadLine());
                    double result1 = mm / 1000;
                    Console.WriteLine(result1 + " Metros ");
                    break;

                case 4:
                    Console.WriteLine(" 4. Converter de metros para milímetros ");
                    Console.WriteLine("Digite os Metros  ");
                    double m1 = double.Parse(Console.ReadLine());
                    double result2 = m1 * 1000;
                    Console.WriteLine(result2 + " Milímetros ");
                    break;

                default:

                    Console.WriteLine(" OPÇÃO INVÁLIDO ");
                    break;


            }
            Console.ReadKey();
        }
    }
}
