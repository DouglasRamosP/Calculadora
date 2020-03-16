using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	public class Calculadora
	{
		private List<double> listNumero = new List<double>();

		public void addNumero(double num)
		{
			this.listNumero.Add(num);
		}

		public double Soma()
		{
			double soma = 0;
			foreach (double numero in this.listNumero)
			{
				soma += numero;
			}
			this.listNumero.Clear();
			return soma;
		}
		public double Subtrai()
		{
			double diferenca = this.listNumero[0];
			this.listNumero.RemoveAt(0);
			foreach (double numero in this.listNumero)
			{
				diferenca -= numero;
			}
			this.listNumero.Clear();
			return diferenca;
		}

		public double Multiplica()
		{
			double produto = this.listNumero[0];
			this.listNumero.RemoveAt(0);
			foreach (double numero in this.listNumero)
			{
				produto *=  numero;
			}
			this.listNumero.Clear();
			return produto;
		}
		public double Dividi()
		{
			double quociente = this.listNumero[0];
			this.listNumero.RemoveAt(0);
			foreach (double numero in this.listNumero)
			{
				quociente /= numero;
			}
			this.listNumero.Clear();
			return quociente;
		}


	}
}
