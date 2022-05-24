using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    class Program
    {
        static void Main(string[] args)
        {
            float celsius, far;
            Console.WriteLine("Informe o Grau Celsius: ");
            celsius = float.Parse(Console.ReadLine());
            far = 9 * (celsius / 5) + 32;
            Console.WriteLine("A quantidade de " + celsius + "°C equivale em Farhrenheit: " + far );
            Console.Read();
        }
    }
}
