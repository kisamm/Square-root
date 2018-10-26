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

            Console.WriteLine("Podaj wartosc A"); // give a value A
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartosc B"); //give a value B

            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartosc C"); // give a value C
            c = Double.Parse(Console.ReadLine());
            delta = Math.Pow(b, 2) - (4 * a * c);


            if (delta == 0)
            {
                Console.WriteLine("Delta rowna 0"); // delta equal 0

                x0 = -(b) / (2 * a);
                Console.WriteLine("X0 wynosi " + x0); // X0 is :

                Console.WriteLine("Ogólna postać rownania kwadratowego"); // general form of the quadratic equation
                Console.WriteLine("f{x}= " + a + "x^2 + " + b + "x + " + c);

            }

            if (delta > 0)
            {
                Console.WriteLine("Delta wieksza od 0"); // delta greather than 0 
                Console.WriteLine("Delta wynosi = " + delta); //delta is


                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("x1= " + Math.Round(x1, 3));
                Console.WriteLine("x2= " + Math.Round(x2, 3));

                p = (-b) / (2 * a);
                q = (-delta) / (4 * a);
                Console.WriteLine("p= " + p + " " + " q= " + q);


                Console.WriteLine("Ogolna postac rownania kwadratowego"); // general form of the quadratic equation
                Console.WriteLine("f{x}= (" + a + ")*x^2 + (" + b + ")*x + " + "(" + c + ")");

                Console.WriteLine("Iloczyniowa postac rownaia kwadratowego "); // the product of the form of the square equation
                Console.WriteLine("f{x}= (" + a + ")*(x + (" + Math.Round(x1, 3) + "))*(x + (" + Math.Round(x2, 3) + "))");

                Console.WriteLine("Kanoniczna postc rownania kwadratowego"); // the canonical form of the square equation 
                Console.WriteLine("f{x]= (" + a + ")*x + (" + Math.Round(p, 3) + ")^2" + " + (" + q + ")");


            }


            if (delta < 0)
            {
                Console.WriteLine("Delta mniejsza od 0"); // delta less than 0 



                Console.WriteLine("Delta wynosi = " + delta); // delta is


                Re = (-b / (2 * a));
                Im = (Math.Sqrt(-delta)) / (2 * a);


                Console.WriteLine("x1 = " + Math.Round(Re, 3) + " + j " + Math.Round(Im, 3));
                Console.WriteLine("x2 = " + Math.Round(Re, 3) + " - j " + Math.Round(Im, 3));


                p = (-b) / (2 * a);
                q = (-delta) / (4 * a);

                Console.WriteLine("p= " + Math.Round(p, 3) + " " + "q= " + Math.Round(q, 3));

                Console.WriteLine("Ogólna postac rownania kwadratowego"); // general form of the quadratic equation
                Console.WriteLine("f{x}= (" + a + ")*x^2 + (" + b + ")*x + " + "(" + c + ")");

                Console.WriteLine("Iloczynowa postac rownania kwadratowego "); // the product of the form of the square equation
                Console.WriteLine("f{x}= (" + a + ") (x + " + Math.Round(Re, 3) + ")*(x + " + Math.Round(Im, 3) + ")");

                Console.WriteLine("Kanoniczna postac rownania kwadratowego"); // the canonical form of the square equation 
                Console.WriteLine("f{x]= (" + a + ")*x + (" + p + ")^2" + " + (" + q + ")");



            }


            Console.ReadKey();


        }
    }
}