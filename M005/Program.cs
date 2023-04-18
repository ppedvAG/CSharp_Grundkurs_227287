using System.Runtime.CompilerServices;

namespace M005;

internal class Program
{
	static void Main(string[] args)
	{
		PrintAddiere(3, 4); //Funktionsaufruf mit dem Namen der Funktion, Parameter müssen mit angegeben werden
		PrintAddiere(6, 3);
		PrintAddiere(7, 9);

		int summe = Addiere(4, 6); //Ergebnis der Addiere Funktion in die summe Variable schreiben
		Console.WriteLine(summe);

		Console.WriteLine(); //18 Overloads, verschiedene Methoden mit verschiendenen Parametern

		Addiere(5, 5); //Zwei Ints -> Int Auswahl
		Addiere(5.0, 5); //Ein oder Zwei Doubles -> Double Auswahl
		Addiere(1, 2, 3); //Drei Ints -> 3x Int Funktion

		Summiere(); //0 Zahlen sind auch beliebig viele Zahlen
		Summiere(2, 3, 4); //3 Parameter
		Summiere(1, 2, 3, 4, 5, 6, 7, 8, 9); //9 Parameter

		Subtrahiere(3, 4); //Standardwert von optionalem Parameter genommen
		Subtrahiere(3, 4, 5); //Optionaler Parameter überschrieben

		AddiereOderSubtrahiere(4, 6);
		AddiereOderSubtrahiere(4, 6);
		AddiereOderSubtrahiere(4, 6);
		AddiereOderSubtrahiere(4, 6);
		AddiereOderSubtrahiere(4, 6);
		AddiereOderSubtrahiere(4, 6, true); //Sonderfall über bool abdecken
		AddiereOderSubtrahiere(4, 6);
		AddiereOderSubtrahiere(4, 6);

		Test(z: 5, b: true); //x und y auslassen
		Test(x: 5, b: true); //y und z auslassen

		int add = 0;
		int sub = SubtrahiereUndAddiere(4, 6, out add);

		int result = 0;
		bool b = int.TryParse("123", out result);
		if (b) //Ergebnis des Parsens steht in result wenn das Parsen funktioniert hat
		{
			//Parsen hat funktioniert
		}
		else
		{
			//Parsen hat nicht funktioniert
		}
        Console.WriteLine(result);
    }

	static void PrintAddiere(int x, int y) //Funktion mit void (ohne Rückgabewert) und zwei Parametern (x und y)
	{
		Console.WriteLine($"{x} + {y} = {x + y}");
	}

	static int Addiere(int x, int y) //Funktion mit Rückgabewert (statt void)
	{
		return x + y; //Ergebnis der Funktion mit return zurückgeben
	}

	static double Addiere(double x, double y) //Funktionen überladen, Funktionen mit gleichem Namen definieren wie bereits vorhandene Funktion mit anderen Parametern
	{
		return x + y;
	}

	static int Addiere(int x, int y, int z)
	{
		return x + y + z;
	}

	static double Summiere(params double[] zahlen) //Mit Params können beliebig viele Parameter übergeben werden (der Parameter muss ein Array sein)
	{
		return zahlen.Sum();
	}

	static double Subtrahiere(int x, int y, int z = 0) //Optionaler Parameter: Kann bei Funktionsaufruf übergeben werden, muss aber nicht
	{
		return x - y - z;
	}

	static double AddiereOderSubtrahiere(int x, int y, bool sub = false)
	{
		//if (sub)
		//	return x - y;
		//else
		//	return x + y;
		return sub ? x - y : y + x;
	}

	static void Test(int x = 0, int y = 0, int z = 0, bool b = false)  //Hier optionale Parameter um nur bestimmte Parameter die benötigt werden angeben zu können
	{

	}

	static int SubtrahiereUndAddiere(int x, int y, out int summe) //out-Parameter: mehrere Rückgabewerte
	{
		summe = x + y; //Summe Parameter befüllen
		return x - y;
	}

	static void PrintZahl(int zahl)
	{
		return; //Aus Funktion herausspringen / Funktion beendet
        Console.WriteLine(zahl);
    }
}