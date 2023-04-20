using System.Security.Cryptography;
using System.Threading.Channels;

namespace M009;

internal class Program
{
	static void Main(string[] args)
	{
		Mensch m = new Mensch(); //Variablentyp Mensch, kann alle Objekte vom Typ Mensch oder einer Unterklasse halten

		Lebewesen l = new Mensch(); //Variablentyp Lebwesen, kann alle Objekte vom Typ Lebewesen oder einer Unterklasse halten (hier Mensch)

		object o = new Mensch(); //Variablentyp object, kann alle Objekte halten
		o = 123; //int
		o = false; //bool
		o = "Hallo"; //string

		l = m; //kompatibel weil Lebewesen > Mensch
               //m = l; //nicht kompatibel weil Lebewesen nicht größer Mensch

        //GetType(): gibt den Typen des derzeitigen Objekts zurück (Inhalt einer Variable)
        Console.WriteLine(m.GetType()); //M009.Mensch
        Console.WriteLine(l.GetType()); //M009.Mensch
		Console.WriteLine(o.GetType()); //System.String

		Type tm = m.GetType(); //GetType() gibt ein Type Objekt
		Type typeofM = typeof(Mensch); //Über typeof(<Klassenname>) einen Typen über eine Klasse extrahieren

        Console.WriteLine(tm.Name); //Nur Typ: Mensch
        Console.WriteLine(tm.FullName); //Namespace + Typ: M009.Mensch

		#region Exakter Typvergleich
		if (m.GetType() == typeof(Mensch))
		{
			//ist m genau ein Mensch?
			//true
		}

		if (m.GetType() == typeof(Lebewesen))
		{
			//ist m genau ein Lebewesen?
			//false
		}
		#endregion

		#region Vererbungshierarchie Typvergleich
		if (m is Mensch)
		{
			//ist m genau ein Mensch oder eine Unterklasse von Mensch?
			//true
		}

		if (m is Lebewesen)
		{
			//ist m genau ein Lebewesen oder eine Unterklasse von Lebewesen?
			//true
		}

		if (m is object)
		{
			//ist m genau ein object oder eine Unterklasse von object?
			//immer true
		}

		if (m is Program)
		{
			//false
		}
		#endregion

		#region Virtual Override
		Mensch mensch = new Mensch();
		mensch.WasBinIch2(); //Ich bin ein Mensch und bin 123 Jahre alt

		Lebewesen l3 = mensch;
		l3.WasBinIch2(); //Ich bin ein Mensch und bin 123 Jahre alt
						 //Verbindung zwischen Lebewesen und Mensch hergestellt, deshalb wird die Mensch Methode verwendet
		#endregion

		#region New
		Mensch mensch2 = new Mensch();
		mensch2.WasBinIch(); //Ich bin ein Mensch

		Lebewesen l4 = mensch2;
		l4.WasBinIch(); //Ich bin ein Lebewesen
						//Hier wird die Methode von Lebewesen verwendet, da die Verbindung getrennt wurde
		#endregion

		Lebewesen[] array = new Lebewesen[3]; //Lebewesen Array kann alle Lebewesen halten (Mensch, Katze)
		array[0] = new Mensch();
		array[1] = new Katze();
		array[2] = new Mensch();

		foreach (Lebewesen lw in array)
		{
			if (lw.GetType() == typeof(Mensch)) //Schauen was das jetztige Lebewesen für einen Typen hat
			{
				Mensch cast = (Mensch) lw;
				cast.Sprechen(); //Spezifische Methode aufrufen
			}

			if (lw is Katze k) //Schneller Cast
			{
				//Katze cast = (Katze) lw; //kann gespart werden, da Variablendeklaration und Cast in der if
				k.Springen(); //Spezifische Methode aufrufen
			}

			lw.Bewegen(); //Generische Methode aufrufen
		}
	}
}

public abstract class Lebewesen //abstract: Strukturklasse, kann nicht instanziert werden
{
	public void WasBinIch()
	{
		Console.WriteLine("Ich bin ein Lebewesen");
	}

	public virtual void WasBinIch2()
	{
		Console.WriteLine("Ich bin ein Lebewesen");
	}

	public abstract void Bewegen(); //Abstrakte Methoden haben keinen Body
}

public class Mensch : Lebewesen
{
	public new void WasBinIch()
	{
		Console.WriteLine("Ich bin ein Mensch");
	}

	public override void WasBinIch2()
	{
		Console.WriteLine("Ich bin ein Mensch");
	}

	public override void Bewegen() //Implementation von Bewegen() wird erzwungen durch abstract
	{
        Console.WriteLine("Der Mensch bewegt sich");
    }

	public void Sprechen()
	{
        Console.WriteLine("Hallo");
    }
}

public class Katze : Lebewesen
{
	public override void Bewegen() //Implementation von Bewegen() wird erzwungen durch abstract
	{
        Console.WriteLine("Die Katze bewegt sich");
    }

	public void Springen()
	{
		Console.WriteLine("Hopp");
	}
}