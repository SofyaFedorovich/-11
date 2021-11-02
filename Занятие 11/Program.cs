using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_11
{
    //решение линейного уравнения

    struct Reshenie
    {
        private double firstNumber;
        private double secondNumber;
        private double x;

        public void Dano(double b, double k)
        {
            firstNumber = b;
            secondNumber = k;
            Root();
        }
        public void Root()
        {
            if (secondNumber != 0)
            {
                x = -firstNumber / secondNumber;
                Console.WriteLine("Решение уравнения х: {0,2:f2}", x);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Деление на ноль! Введите другое значение K");
                Console.ReadKey();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение линейного уравнения типа  0=kx+b");
            Reshenie reshenie = new Reshenie();
            Console.WriteLine("Введите значение b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение k: ");
            double k = Convert.ToDouble(Console.ReadLine());
            reshenie.Dano(b, k);
        }
    }



}
    

