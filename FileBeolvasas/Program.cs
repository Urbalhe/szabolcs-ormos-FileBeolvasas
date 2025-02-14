using System.Diagnostics.Tracing;

namespace FileBeolvasas
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Karakter> karakterek = [];
			Beolvasas("karakterek.txt", karakterek);
			MaximumElet(karakterek);
			AtlagSzint(karakterek);
			RendezoEro(karakterek);
			NagyobbE50Nel(karakterek);
			KarakterStats(karakterek);
			//CSVBeir(karakterek);
			LegjobbHarom(karakterek);
			KarakterRangsor(karakterek);
			CsataVerseny(karakterek);


		}

		static void Beolvasas(string filenev, List<Karakter> karakterek)
		{
			StreamReader sr = new(filenev);
			string[] sorok = File.ReadAllLines(filenev);


			sr.ReadLine();

			while (!sr.EndOfStream)
			{
				string sor = sr.ReadLine();
				string[] szavak = sor.Split(';');


				Karakter karakter = new(szavak[0], Convert.ToInt16(szavak[1]), Convert.ToInt16(szavak[2]), Convert.ToInt16(szavak[3]));
				karakterek.Add(karakter);
			}

		}



		static void MaximumElet(List<Karakter> karakterek)
		{
			int max = karakterek[0].Eletero;
			string name = karakterek[0].Name;
			foreach (var item in karakterek)
			{
				if (item.Eletero > max)
				{
					max = item.Eletero;
				}
			}

			Console.WriteLine("");
			Console.WriteLine("2. Feladat");
			Console.WriteLine($"{name}-nek, {max} életereje van.");
		}

		static void AtlagSzint(List<Karakter> karakterek)
		{
			int osszeg = 0;
			foreach (var item in karakterek)
			{
				osszeg += item.Szint;
			}
			double atlag = osszeg / karakterek.Count;
			Console.WriteLine("");
			Console.WriteLine("3. Feladat");
			Console.WriteLine($"A karakterek átlag szintje: {atlag}");
		}

		static void RendezoEro(List<Karakter> karakterek)
		{
			karakterek.Sort((x, y) => x.Ero.CompareTo(y.Ero));
			Console.WriteLine("");
			Console.WriteLine("4. Feladat");
			Console.WriteLine("A karakterek erő szerinti rendezése:");
			Console.WriteLine("");
			foreach (var item in karakterek)
			{
				Console.WriteLine(item);
			}
		}

		static void NagyobbE50Nel(List<Karakter> karakterek)
		{
			Console.WriteLine("");
			Console.WriteLine("5. Feladat");
			Console.WriteLine("Azok a karakterek, akiknek az ereje nagyobb, mint 50:");
			foreach (var item in karakterek)
			{
				if (item.Ero > 50)
				{
					Console.WriteLine(item);
				}
			}
		}



		static void KarakterStats(List<Karakter> karakterek)
		{
			Console.WriteLine("");
			Console.WriteLine("6. Feladat");
			Console.WriteLine("Karakterek statisztikája:");
			Console.WriteLine("Név\tEro\tÉleterő\tSzint");
			foreach (var item in karakterek)
			{
				Console.WriteLine($"{item.Name}\t{item.Ero}\t{item.Eletero}\t{item.Szint}");
			}
		}

		//static void CSVBeir(List<Karakter> karakterek)
		//{
		//          Console.WriteLine("");
		//          Console.WriteLine("7. Feladat");
		//          StreamWriter sw = new("karakterek_rendezett.csv");
		//	sw.WriteLine("Név;Ero;Életerő;Szint");
		//	foreach (var item in karakterek)
		//	{
		//		sw.WriteLine($"{item.Name};{item.Ero};{item.Eletero};{item.Szint}");
		//	}
		//	sw.Close();
		//}


		static void LegjobbHarom(List<Karakter> karakterek)
		{
			Console.WriteLine("");
			Console.WriteLine("8. Feladat");
			Console.WriteLine("A legjobb 3 karakter:");
			karakterek.Sort((x, y) => y.Ero.CompareTo(x.Ero));
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine(karakterek[i]);
			}

		}


		static void KarakterRangsor(List<Karakter> karakterek)
		{
			Console.WriteLine("");
			Console.WriteLine("9. Feladat");
			Console.WriteLine("Karakterek rangsora:");
			Console.WriteLine("Név\tEro\tÉleterő\tSzint");
			int helyezes = 1;
			foreach (var item in karakterek)
			{
				Console.WriteLine($"{helyezes}. {item.Name}\t{item.Ero}\t{item.Eletero}\t{item.Szint}");
				helyezes++;
			}
		}




		static void CsataVerseny(List<Karakter> karakterek)
		{
			Console.WriteLine("");
			Console.WriteLine("10. Feladat");
			Console.WriteLine("Csata verseny:");
			Random rnd = new();
			int karakter1 = rnd.Next(0, karakterek.Count);
			int karakter2 = rnd.Next(0, karakterek.Count);
			Console.WriteLine($"{karakterek[karakter1].Name} vs {karakterek[karakter2].Name}");
			if (karakterek[karakter1].Ero > karakterek[karakter2].Ero)
			{
				Console.WriteLine($"{karakterek[karakter1].Name} nyert!");
			}
			else if (karakterek[karakter1].Ero < karakterek[karakter2].Ero)
			{
				Console.WriteLine($"{karakterek[karakter2].Name} nyert!");
			}
			else
			{
				Console.WriteLine("Döntetlen!");
			}




		}
	}
}


