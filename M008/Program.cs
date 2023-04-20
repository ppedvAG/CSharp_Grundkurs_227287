using M008.Bauteile;

namespace M008;

internal class Program
{
	static void Main(string[] args)
	{
		Mensch m = new Mensch("", 123);
		m.Name = "Test";
		m.WasBinIch(); //Property und Methode wurden vererbt

		m.WasBinIch2();

        Console.WriteLine(m.ToString()); //ToString: gibt den Typen des Objekts aus (Standard), kann überschrieben werden
        Console.WriteLine(123.ToString()); //Hier 123 als String ("123")

        Console.WriteLine(m); //Wenn ein Objekt in eine Ausgabe kommt, wird die ToString() Methode verwendet

		Raum r = new Raum();
		Fenster f1 = new Fenster();
		Fenster f2 = new Fenster();
		Tuere t = new Tuere();
		r.Teile[0] = f1;
		r.Teile[1] = f2;
		r.Teile[2] = t;
    }
}

public class Lebewesen //Basisklasse
{
	public string Name { get; set; } //Wird nach unten vererbt

	public Lebewesen(string Name)
	{
		this.Name = Name;
	}

	public void WasBinIch() //Wird nach unten vererbt
	{
        Console.WriteLine("Ich bin ein Lebewesen");
    }

	public virtual void WasBinIch2() //virtual: kann überschrieben, muss aber nicht überschrieben werden
	{
        Console.WriteLine("Ich bin ein Lebewesen");
    }

	public override string ToString()
	{
		string typ = base.ToString(); //Methode von oben (hier Object) verwenden
		return $"Ich bin ein Lebewesen vom Typ {typ}";
	}
}

public sealed class Mensch : Lebewesen //Mensch ist ein Lebewesen (Vererbung herstellen)
{ //sealed: Vererbung verhindern
	public int Alter { get; set; }

	public Mensch(string Name, int Alter) : base(Name) //Konstruktoren zwischen vererbten Klassen müssen verketten sein mit base(Parameter)
	{
		//Extra Feld hinzufügen im Konstruktor (hier Alter)
		this.Alter = Alter;
	}

	public override sealed void WasBinIch2() //override: Überschreibe die Methode von oben, obere Methode muss virtual sein
	{ //sealed: Vererbung verhindern
		Console.WriteLine("Ich bin ein Mensch");
    }

	public override string ToString()
	{
		return base.ToString() + " und kann sprechen";
	}
}

//public class Katze : Lebewesen
//{
//	public int AnzBeine { get; set; }

//	public Katze(string Name, int AnzBeine) : base(Name)
//	{
//		this.AnzBeine = AnzBeine;
//	}
//}

//public class Kind : Mensch
//{
//	public Kind(string Name, int Alter) : base(Name, Alter)
//	{
//	}

//	public override void WasBinIch2()
//	{
//		base.WasBinIch2();
//	}
//}