using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b, c, x1, x2, x0, delta, p, q, Re, Im;

            Console.WriteLine("Podaj wartosc A");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartosc B");

            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartosc C");
            c = Double.Parse(Console.ReadLine());
            delta = Math.Pow(b, 2) - (4 * a * c);


            if (delta == 0)
            {
                Console.WriteLine("Delta rowna 0");

                x0 = -(b) / (2 * a);
                Console.WriteLine("X0 wynosi " + x0);

                Console.WriteLine("Ogólna postać rownania kwadratowego");
                Console.WriteLine("f{x}= " + a + "x^2 + " + b + "x + " + c);

            }

            if (delta > 0)
            {
                Console.WriteLine("Delta wieksza od 0");
                Console.WriteLine("Delta wynosi = " + delta);


                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("x1= " + Math.Round(x1, 3));
                Console.WriteLine("x2= " + Math.Round(x2, 3));

                p = (-b) / (2 * a);
                q = (-delta) / (4 * a);
                Console.WriteLine("p= " + p + " " + " q= " + q);


                Console.WriteLine("Ogolna postac rownania kwadratowego");
                Console.WriteLine("f{x}= (" + a + ")*x^2 + (" + b + ")*x + " + "(" + c + ")");

                Console.WriteLine("Iloczyniowa postac rownaia kwadratowego ");
                Console.WriteLine("f{x}= (" + a + ")*(x + (" + Math.Round(x1, 3) + "))*(x + (" + Math.Round(x2, 3) + "))");

                Console.WriteLine("Kanoniczna postc rownania kwadratowego");
                Console.WriteLine("f{x]= (" + a + ")*x + (" + Math.Round(p, 3) + ")^2" + " + (" + q + ")");


            }


            if (delta < 0)
            {
                Console.WriteLine("Delta mniejsza od 0");



                Console.WriteLine("Delta wynosi = " + delta);


                Re = (-b / (2 * a));
                Im = (Math.Sqrt(-delta)) / (2 * a);


                Console.WriteLine("x1 = " + Math.Round(Re, 3) + " + j " + Math.Round(Im, 3));
                Console.WriteLine("x2 = " + Math.Round(Re, 3) + " - j " + Math.Round(Im, 3));


                p = (-b) / (2 * a);
                q = (-delta) / (4 * a);

                Console.WriteLine("p= " + Math.Round(p, 3) + " " + "q= " + Math.Round(q, 3));

                Console.WriteLine("Ogólna postac rownania kwadratowego");
                Console.WriteLine("f{x}= (" + a + ")*x^2 + (" + b + ")*x + " + "(" + c + ")");

                Console.WriteLine("Iloczynowa postac rownania kwadratowego ");
                Console.WriteLine("f{x}= (" + a + ") (x + " + Math.Round(Re, 3) + ")*(x + " + Math.Round(Im, 3) + ")");

                Console.WriteLine("Kanoniczna postac rownania kwadratowego");
                Console.WriteLine("f{x]= (" + a + ")*x + (" + p + ")^2" + " + (" + q + ")");



            }


            Console.ReadKey();


        }
    }
}