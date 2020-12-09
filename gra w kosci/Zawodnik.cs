using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gra_w_kosci
{
	public class Zawodnik
	{
		private string _zawodnik; // imie
		static private int _numer=0; // liczy ilosc utworzeń classy zawodnik
		private int _numerPorzadkowy;
		public Zawodnik()
		{
			_numer++; // przy inicjalizacji nowego zawodnika zostaje dodane do numeru zawodnika 1. Czyli numerujemy zawodników.
			_numerPorzadkowy = _numer;
		}
		public int numerPorządkowy {get { return _numerPorzadkowy; } }
		public string Imie
		{
			get
			{
				return _zawodnik;
			}
			set
			{
				_zawodnik = value;
			}
		}
	}
}