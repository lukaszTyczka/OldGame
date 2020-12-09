using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gra_w_kosci
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Gra> Gry = new List<Gra>();
			ConsoleKeyInfo a; // do warunky wychodzenia z pętli.
			// Pętla dodawania graczy
			do
			{
				Console.Write("Podaj imie gracza: ");
				string imie;
				imie = Console.ReadLine();
				Gry.Add(new Gra(imie));
				Console.WriteLine("Naciśnij 'z' jeżeli chcesz przestać dodawać graczy,\nlub dowolny inny klawisz by dalej dodawać!");
				a = Console.ReadKey(true); // dodałem true, ponieważ nie chce, aby klawisz który naciscisne był wyświetlany w consoli.
			} while (a.KeyChar.ToString().ToUpper() != "Z");
			// Petla gry!
			do
			{
				
				foreach (var item in Gry)
				{
					item.rzut();
					item.wyswietl();
				}
				int maxSum = Gry.Max(t => t.Suma); // porsta instrukcja linq by wyszukał maksymalną wartosci w zbiorze, dla sumy.
				Console.Write("Wygrywa/wają: ");
				foreach (var item in Gry)
				{
					if(item.Suma == maxSum)
					{
						Console.ForegroundColor = ConsoleColor.Green; // xmiana koloru na zielony dla wygranych imion
						Console.Write(item.Imie + " ");
					}
				}
				Console.ForegroundColor = ConsoleColor.White; // powrot do białego koloru
				Console.WriteLine("\nNaciśnij T, by zagrać jeszcze jedną ture,\n naciśnij dowolny inny klawisz by przerwać!");
				a = Console.ReadKey(true);
			} while (a.KeyChar.ToString().ToUpper()== "T");
			
		}
	}
} 
