using System;
using System.Globalization;
namespace Uri_1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, a1, b1, c1, a2, b2,c2;
            a2 = 0;
            b2 = 0;
            c2 = 0;



            string[] vetor = Console.ReadLine().Split(' ');
            a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            c = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            if(a>b&&a>c)
            {
                a2 = a;

                if(b>c)
                {
                    b2 = b;
                    c2 = c;
                }
                else 
                { 
                    c2 = b; b2 = c; 
                }


            }
            else if(b>c)
            {
                a2 = b;
                if(a>c)
                {
                    b2 = a;
                    c2 = c;
                }
            }
            else
            {
                a2 = c;
                if(a>b)
                {
                    b2 = a;
                    c2 = b;
                }
                else
                {
                    b2 = b;
                    c2 = a;
                }
            }

            a = a2;
            b = b2;
            c = c2;

            if (a >= b + c)
            {
                Console.WriteLine("Não forma Triângulo");
            }
            else {
                if(a*a == b*b + c*c)
                {
                    Console.WriteLine("Triângulo Retangulo");
                    Console.WriteLine();
                }

               else if (a*a > b*b + c*c)
                {
                    Console.WriteLine("Triângulo Obtusangulo");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Triângulo Acutangulo");
                    Console.WriteLine();
                }
            }

            //

            if (a == b && a == c)
            {
                Console.WriteLine("Triângulo Equilatero");
                Console.WriteLine();
            }

            else if ((a == b) || (b == c) || (a == c))
            {
                Console.WriteLine("Triângulo Isosceles");
                Console.WriteLine();
            }




        }
    }
}
