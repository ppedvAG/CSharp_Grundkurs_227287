namespace M004
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Schleifen
			int a = 0;
			int b = 10;
			while (a < b) //Schleife läuft solange die Bedingung true ist
			{
				Console.WriteLine($"while: {a}");
				if (a == 5)
					break; //break: Beendet die Schleife
				a++;
			} //Nach jedem Ende der Schleife wird die Bedingung nochmal geprüft

			int c = 0;
			int d = 10;
			do //Wird mindestens einmal ausgeführt, auch wenn die Bedingung von Anfang an false ist
			{
				c++;
				if (c == 5)
					continue; //continue: Springt zum Schleifenkopf zurück, Code darunter wird übersprungen
				Console.WriteLine($"do-while: {c}");
			}
			while (c < d);

			//while (true) { } //Endlosschleife

			c = 0;

			while (true) //do-while mit Endlosschleife
			{
				c++;
				if (c == 5)
					continue;
				Console.WriteLine($"while true: {c}");

				if (c >= d)
					break;
			}

			//for + Tab + Tab
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine($"for: {i}");
			}

			//forr + Tab + Tab
			for (int i = 9; i >= 0; i--)
			{
				Console.WriteLine($"forr: {i}");
			}

			int[] zahlen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
			for (int i = 0; i < zahlen.Length; i++) //Array durchgehen und ausgeben
			{
				Console.WriteLine(zahlen[i]); //for Schleife kann daneben greifen, daher suboptimal
			}

			//foreach + Tab + Tab
			foreach (int item in zahlen) //Elemente direkt angreifen, kann nicht daneben greifen
			{
				Console.WriteLine(item);
			}

			foreach (int item in zahlen) //Einzeilige Schleifen können auch ohne Klammern geschrieben werden
				Console.WriteLine(item);
			#endregion

			#region Enums
			Wochentag wt = Wochentag.Mo; //Nur einer der 7 fixen Zustände möglich
			if (wt == Wochentag.Di)
			{
				Console.WriteLine("Es ist Dienstag");
			}

			Test(Wochentag.Do); //Hier bei Funktion einen der 7 Wochentage erzwingen

			//Jeder Enumwert hat einen int dahinter (Mo: 1, Di: 2, Mi: 3, ...)
			int x = 2;
			Wochentag cast = (Wochentag) x; //2 -> Di
			int di = (int) cast; //Di -> 2

			//Alle Wochentage in ein Array füllen
			Wochentag[] tage = Enum.GetValues<Wochentag>();
			foreach (Wochentag t in tage)
			{
				Console.WriteLine($"Der Tag ist {t}");
			}

			string tag = "Di"; //Funktioniert auch mit Zahlen
			Wochentag readTag = Enum.Parse<Wochentag>(tag); //Konvertiert einen String zu einem Wochentag
			Console.WriteLine($"Der eingegebene Tag ist {readTag}");
			#endregion

			#region Switch
			Wochentag sw = Wochentag.Di;
			if (sw == Wochentag.Mo)
			{
				Console.WriteLine("Wochenanfang");
			}
			else if (sw == Wochentag.Di || sw == Wochentag.Mi || sw == Wochentag.Do || sw == Wochentag.Fr)
			{
				Console.WriteLine("Wochenmitte");
			}
			else if (sw == Wochentag.Sa || sw == Wochentag.So)
			{
				Console.WriteLine("Wochenende");
			}
			else
			{
				Console.WriteLine("Fehler");
			}

			switch (sw) //if-else Baum mit Switch
			{
				case Wochentag.Mo: //Sozusagen eine if
					Console.WriteLine("Wochenanfang");
					break; //break notwendig bei jedem Codeblock
				case Wochentag.Di:
				case Wochentag.Mi:
				case Wochentag.Do:
				case Wochentag.Fr:
					Console.WriteLine("Wochenmitte");
					break;
				case Wochentag.Sa:
				case Wochentag.So:
					Console.WriteLine("Wochenende");
					break;
				default: //Sozusagen eine else
					Console.WriteLine("Fehler");
					break; //default optional
			}

			switch (sw) //Switch mit boolscher Logik
			{
				//and/or statt &&/||
				case >= Wochentag.Mo and <= Wochentag.Fr:
					Console.WriteLine("Wochenmitte");
					break;
				case Wochentag.Sa or Wochentag.So:
					Console.WriteLine("Wochenende");
					break;
				default:
					Console.WriteLine("Fehler");
					break;
			}
			#endregion
		}

		static void Test(Wochentag tag)
		{

		}
	}

	enum Wochentag
	{
		Mo = 1, //Enumwerten eigene Werte zuweisen, Rest wird aufgeschoben
		Di,
		Mi,
		Do = 10, //hier neu anfangen zu Zählen
		Fr,
		Sa,
		So
	}
}