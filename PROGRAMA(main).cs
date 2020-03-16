using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	class PROGRAMA
	{
		static void Main(string[] args)
		{
            Calculadora c = new Calculadora();
            c.addNumero(10.1);
            c.addNumero(2.9);
            System.Console.WriteLine(c.soma());


            c.addNumero(10.1);
            c.addNumero(4.9);
            System.Console.WriteLine(c.soma());

            c.addNumero(10);
            c.addNumero(5);
            c.addNumero(2);
            System.Console.WriteLine(c.subtrai());

            c.addNumero(10);
            c.addNumero(2);
            c.addNumero(2);
            System.Console.WriteLine(c.multiplica());

            c.addNumero(11);
            c.addNumero(2);
            System.Console.WriteLine(c.dividi());

            System.Console.ReadKey();
        }
	}
}
