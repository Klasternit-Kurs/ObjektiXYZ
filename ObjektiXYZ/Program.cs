using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektiXYZ
{
	class Program
	{
		static void Main(string[] args)
		{
			int broj = 5;
			string tekst = "Neki tekst";

			List<string> nekaLista = new List<string>();
			nekaLista.Add("Neki tekst");

			List<Osoba> Imenik = new List<Osoba>();

			Osoba NekaOsoba = new Osoba("Pera", "Peric", "Nemam ideje BB", "1234", "ppera@nesto.net");

			Imenik.Add(NekaOsoba);

			NekaOsoba = new Osoba("Neko", "Nekic");
			new Osoba();


		}
	}

	class Osoba
	{
		public Osoba() {}

		public Osoba(string i, string p)
		{
			Ime = i;
			Prezime = p;
		}

		public Osoba(string i, string p, string t, string a, string m)
		{
			Ime = i;
			Prezime = p;
			Telefon = t;
			Adresa = a;
			Mejl = m;
		}

		public int broj; 
		public bool test; 
		public string Ime;
		public string Prezime;
		public string Telefon;
		public string Adresa = "Nepoznata";
		public string Mejl;
	}
}
