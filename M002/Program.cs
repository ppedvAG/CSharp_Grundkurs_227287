namespace M002
{
	/// <summary>
	/// Die Program Klasse
	/// </summary>
	internal class Program
	{
		/// <summary>
		/// Die Main Methode
		/// </summary>
		/// <param name="args">Die Programmargumente</param>
		static void Main(string[] args)
		{
			#region Variablen
			//Variable: Ein Feld das einen Wert halten kann
			int zahl; //Deklaration
			zahl = 3; //Zuweisung
					  //int: Ganze Zahl
			Console.WriteLine(zahl); //cw + Tab

			int zahlMitZuweisung = 3;

			int zahlMalZwei = zahl * 2; //obere Zahl mal 2 = 6

			/*
				Mehrzeiliger
				Kommentar
			 */

			string wort = "Hallo";
			Console.WriteLine(wort);

			char zeichen = 'A';
			Console.WriteLine(zeichen);

			double d = 49.29;
			float f = 49.29f;
			decimal m = 49.29m; //32 Kommastellen -> Geldwerte weil niedrige Gleitkommaungenauigkeit

			bool b = true;
			b = false;
			#endregion

			#region Strings
			string kombi = "Das Wort ist: " + wort;
			Console.WriteLine(kombi);

			string kombiInt = "Die Zahl ist: " + zahl;
			Console.WriteLine(kombiInt);

			string abstand = "Das Wort ist: " + wort + ", die Zahl ist: " + zahl + ", " + b; //Anstrengend
			Console.WriteLine(abstand);

			//Interpolated Strings ($-String): Code in Strings einbauen
			Console.WriteLine($"Das Wort ist: {wort}, die Zahl ist: {zahl}, {b}"); //Einfacher als oben mit Interpolation

			//https://docs.microsoft.com/en-us/cpp/c-language/escape-sequences?view=msvc-170
			Console.WriteLine("Umbruch \n Umbruch");
			Console.WriteLine("Tab \t Tab");
			Console.WriteLine("C:\\Users");

			//Verbatim-String (@-String): Nimmt den String 1:1 wie er geschrieben wurde (keine Escape-Sequenzen)
			string pfad = @"C:\Users\lk3\source\repos\CSharp_Grundkurs_2023_04_17\M002";

			Console.WriteLine(@"Umbruch
Umbruch");
			#endregion

			#region Eingabe
			//string eingabe = Console.ReadLine();
			//Console.WriteLine(eingabe);

			//ConsoleKeyInfo rk = Console.ReadKey();
			//Console.WriteLine(rk.Key);
			//Console.WriteLine(rk.KeyChar);

			//int eingabeI = int.Parse(eingabe); //String zu int konvertieren
			//double eingabeD = double.Parse(eingabe); //Parse gibt es für verschiedene Typen (int, double, long, ...)
			#endregion

			#region Konvertierungen
			int i = 50;
			double komma = i; //Implizit, weil alle ints in alle doubles passen

			//Explizite Konvertierung (Cast, Typecast, Casting)
			double x = 49.29;
			int y = (int) x; //Hier Konvertierung erzwingen
            Console.WriteLine(y); //Kommastellen werden abgeschnitten

			float z = (float) x; //Hier auch notwendig, da double > float

			string s = i.ToString(); //Beliebiges Objekt zu einem String umwandeln
			#endregion

			#region Arithmetik
			int z1 = 5;
			int z2 = 8;
            Console.WriteLine(z1 + z2); //Originale Werte bleiben unverändert

			z1 += z2; //Hier wird z1 verändert

			double z3 = 3925.239587290;
			//Rundungsfunktionen verändern nicht den originalen Wert
			Math.Ceiling(z3);
			Math.Floor(z3);
			Math.Round(z3);
			Math.Round(3.5); //4
			Math.Round(4.5); //4

			double round = Math.Round(z3, 2); //Auf 2 Kommastellen runden
            Console.WriteLine(round);

			Console.WriteLine(8 / 5); //Int Division, da zwei Ints als Argumente (1 statt 1.6)
            Console.WriteLine(8d / 5);
            Console.WriteLine(8.0 / 5);
			Console.WriteLine((double) z1 / z2); //Eine der beiden Variablen zu double konvertieren per Cast
            #endregion
        }
	}
}