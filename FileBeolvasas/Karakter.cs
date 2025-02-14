using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileBeolvasas
{
	internal class Karakter
	{
		private string name;
		private int ero;
		private int eletero;
		private int szint;

		public Karakter(string name, int ero, int eletero, int szint)
		{
			this.name = name;
			this.ero = ero;
			this.eletero = eletero;
			this.szint = szint;
		}

		public string Name { get => name; set => name = value; }
		public int Ero { get => ero; set => ero = value; }
		public int Eletero { get => eletero; set => eletero = value; }
		public int Szint { get => szint; set => szint = value; }


		











		public override string? ToString()
		{
			return $"Name: {name}, Ero: {ero}, Eletero: {eletero}, Szint: {szint}";
		}
	}
}
