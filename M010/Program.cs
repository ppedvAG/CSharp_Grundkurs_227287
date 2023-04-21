using System.Text;

namespace M010;

internal class Program
{
	static void Main(string[] args)
	{
		Console.OutputEncoding = Encoding.UTF8;

		Mensch m = new Mensch();
		m.Gehalt = 5000;
		m.Job = "Softwareentwickler";
		//m.Lohnauszahlung(); //Lohnauszahlungsmethode durch Interface

		IArbeit a = m; //Variable vom Typ IArbeit genau wie bei Vererbung
		a.Lohnauszahlung();

		ITeilzeitArbeit ta = m;
		ta.Lohnauszahlung();

        Console.WriteLine($"Der Mitarbeiter verdient {m.Jahresgehalt()}€ pro Jahr.");
		Console.WriteLine($"Der Mitarbeiter verdient {m.LohnProStunde(m.Gehalt / 4)}€ pro Stunde.");

		//IEnumerable: Basisinterface von allen Listen in C#
		IEnumerable<int> e1 = new int[10];
		IEnumerable<int> e2 = new List<int>();
		IEnumerable<int> e3 = new Stack<int>();

		Test(e1); //Methode akzeptiert alle Listen
		Test(e2);
		Test(e3);

		if (m is IArbeit) //Überprüfen ob ein Interface an einem Objekt angehängt ist
		{

		}
    }

	static void Test<T>(IEnumerable<T> l)
	{

	}
}

public class Lebewesen { }

public class Mensch : Lebewesen, IArbeit, ITeilzeitArbeit
{
	public int Gehalt { get; set; }

	public string Job { get; set; }

	public int LohnProStunde(int lohn)
	{
		return lohn / IArbeit.Wochenstunden;
	}

	public int Jahresgehalt()
	{
		return Gehalt * 12;
	}

	void IArbeit.Lohnauszahlung()
	{
        Console.WriteLine($"Dieser Mitarbeiter hat ein Gehalt von {Gehalt}€ für den Job {Job} bekommen. " +
			$"Er arbeitet {IArbeit.Wochenstunden} Stunden pro Woche.");
    }

	void ITeilzeitArbeit.Lohnauszahlung()
	{
		Console.WriteLine($"Dieser Mitarbeiter hat ein Gehalt von {Gehalt / 2}€ für den Job {Job} bekommen. " +
			$"Er arbeitet {ITeilzeitArbeit.Wochenstunden} Stunden pro Woche.");
	}
}