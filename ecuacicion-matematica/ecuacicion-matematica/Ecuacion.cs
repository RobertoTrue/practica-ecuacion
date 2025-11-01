using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ecuacicion_matematica
{
    public class Ecuacion
    {
        double a;
        double b;
        double c;
        public Ecuacion(double a ,double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void CalcularSoluciones()
        {
            double dis = this.b * this.b - 4 * this.a * this.c;

            if (dis > 0)
            {
                double raiz1 = (-b + Math.Sqrt(dis)) / (2 * this.a);
                double raiz2 = (-b - Math.Sqrt(dis)) / (2 * this.a);
                Console.WriteLine("Resultado > 0");
                Console.WriteLine("Primera Raiz: " + raiz1);
                Console.WriteLine("Segunda Raiz: " + raiz2);
            }
            else if (dis == 0)
            {
                double raiz = -this.b / (2 * this.a);
                Console.WriteLine("Resultado " + raiz);
            }
            else
            {
                Console.WriteLine("Las soluciones son muy complejas.");
            }
        }
    }
}
