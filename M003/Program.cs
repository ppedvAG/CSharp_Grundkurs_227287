namespace M003
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Arrays
			//Array: Variable die mehrere Werte halten kann
			int[] zahlen; //Arrayvariable mit [] nach Typ (Typ[])
			zahlen = new int[10]; //Array mit Länge 10 (Index 0-9)
			zahlen[3] = 10; //Stelle angreifen mit [Index]
			Console.WriteLine(zahlen[3]); //Wert auslesen

			int[] zahlenDirekt = new int[] { 1, 2, 3, 4, 5 }; //Direkte Initialisierung, Länge automatisch (5)
			int[] zahlenDirektKuerzer = new[] { 1, 2, 3, 4, 5 }; //Kurzschreibweise
			int[] zahlenDirektNochKuerzer = { 1, 2, 3, 4, 5 }; //Kürzeste Schreibweise

			Console.WriteLine(zahlen.Length); //Die Länge des Arrays (hier 10)

			zahlen.Contains(10); //Ist 10 im Array enthalten? true/false
            Console.WriteLine(zahlen.Contains(10));

			int[,] zweiDArray = new int[3, 3]; //Matrix (3x3), Deklaration mit Komma in der Klammer
			zweiDArray[1, 2] = 5; //Rechts Mitte
			Console.WriteLine(zweiDArray[1, 2]);

			zweiDArray = new[,] //Direkte Initialisierung
			{
				{ 1, 2, 3 },
				{ 4, 5, 6 },
				{ 7, 8, 9 }
			};

            Console.WriteLine(zweiDArray.Length); //Anzahl Gesamtelemente (3x3 = 9)
            Console.WriteLine(zweiDArray.Rank); //Anzahl Dimensionen (2)
            Console.WriteLine(zweiDArray.GetLength(0)); //Die Länge der nullten Dimension (3)
            Console.WriteLine(zweiDArray.GetLength(1)); //Die Länge der ersten Dimension (3)
			#endregion

			#region Bedingungen
			int z1 = 5;
			int z2 = 8;

			if (z1 == 5) { } //Wenn z1 = 5, führe den Code in der Klammer aus, ansonsten überspringe den Code

			if (z1 == 5 && z2 == 8) //Wenn z1 = 5 und z2 = 8
			{
				
			}

			if (z1 == 5 || z2 == 8) //Wenn z1 = 5 oder z2 = 8 oder beides
			{

			}

			if (z1 == 5) //Wenn z1 = 5
			{

			}
			else if (z2 == 8) //Wenn z1 nicht 5
			{

			}
			else //Wenn z2 nicht 8
			{

			}

			if (z1 == 5) //Bei einzeiligen ifs/elses/else-ifs können die Klammern weggelassen werden
                Console.WriteLine("z1 ist 5");

			//Ternary Operator (Fragezeichen-Operator): ifs kompakt machen (? ist if, : ist else)
			if (z1 == z2)
                Console.WriteLine("Zahl1 gleich Zahl2");
			else
                Console.WriteLine("Zahl1 ungleich Zahl2");

            Console.WriteLine(z1 == z2 ? "Zahl1 gleich Zahl2" : "Zahl1 ungleich Zahl2"); //Selbiges wie oben nur in einer Zeile statt in 4 Zeilen
            #endregion
        }
	}
}