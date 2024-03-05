using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação (+ - * /)");
            string op = Console.ReadLine();

            if(op == "+")
            { double res = n1 + n2; 
              Console.WriteLine("Sue resultado será:" +  res);
            }
                
            else if(op == "-")
            { double res = n1 - n2;
                Console.WriteLine("Sue resultado será:" + res);
            }
            else if(op == "*") 
            { double res = n1 * n2;
                Console.WriteLine("Sue resultado será:" + res);
            }
            else if(op == "/")
            { 
                double res = n1 / n2;
                Console.WriteLine("Sue resultado será:" + res);
            }
            else 
            {
                Console.WriteLine("Operação inexistente tente novamente");
            }
            Console.ReadKey();
        }
    }
}
