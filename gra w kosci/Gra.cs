using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gra_w_kosci
{
	public class Gra
	{
		Random kostka = new Random();
		private Zawodnik Gracz = new Zawodnik();
		int[] rzutKostkami = new int[5];

		public Gra(string s ) // konstruktor
		{
			Gracz.Imie = s;
		}

		public string Imie{get{return Gracz.Imie;}} // właściwość tylko zwracająca wartość
		public int Suma {get { return rzutKostkami.Sum(); } } // wlasciwosc zwraca sume wyrzuconych oczek z kosci.

		public void rzut()// losowanie 5 liczb
		{
			
			System.Threading.Thread.Sleep(1);
			for (int i = 0; i < 5; i++)
			{
				
				rzutKostkami[i] = kostka.Next(1, 7);
			}	
		}

		public void wyswietl() // Wyświetlanie wyników zawodników
		{
			Console.Write("{0}. Zawodnik {1} wyrzucił: ",Gracz.numerPorządkowy ,Gracz.Imie);
			foreach (var item in rzutKostkami)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine("\nCo daje sume: {0}", rzutKostkami.Sum());
		}

	}
}