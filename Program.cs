using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework20T1
{
    class Program
    {
        delegate double MyDelegate(double a);
        static void Main(string[] args)
        {


            MyDelegate myDelegate = RLenght;
            myDelegate += RSqr;
            myDelegate += RV;


            myDelegate(10);
            Console.WriteLine();
            Console.ReadKey();
        }


        static double RLenght(double R)
        {
            Console.WriteLine("Метод для определения Длины окружности по формуле D=2*n*R");
            double D = 2 * Math.PI * R;
            Console.WriteLine("{0}", (D = Math.Round(2 * Math.PI * R, 2)));
            return D;
        }

        static double RSqr(double R)
        {
            Console.WriteLine("Метод для определения площади круга по формуле S= n*R2");
            double S = Math.PI * Math.Pow(R, 2);
            Console.WriteLine("{0}", (S = Math.Round(Math.PI * Math.Pow(R, 2), 2)));
            return S;
        }

        static double RV(double R)
        {
            Console.WriteLine("Метод для определения Длины окружности по формуле V=4/3*n*R3");
            double V = (4 / 3) * Math.PI * Math.Pow(R, 3);
            Console.WriteLine("{0}", (V = Math.Round((4 / 3) * Math.PI * Math.Pow(R, 3),2)));
            return V;
        }

    }









}
