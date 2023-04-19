namespace M007
{
	internal class Program
	{
		static string Info = "Eine Info";

		static void Main(string[] args)
		{
			#region GC
			for (int i = 0;i < 5; i++)
			{
				Fenster f = new Fenster();
				Console.WriteLine(f.GetHashCode()); //Hashcode: Speicheradresse im RAM
			}

			GC.Collect(); //Hier GC erzwingen
			GC.WaitForPendingFinalizers(); //Warte auf alle Destruktoren
			#endregion

			#region Static
			//Globale Member
			//Normalerweise hat jedes Objekt einen eigenen Wert in einer Variable
			//Bei Static hat die entsprechende Variable einen globalen Wert

			//Statische Member müssen ohne Objekte arbeiten
			//Program.Main(args); //Statische Funktion aufrufen über Klassenname
			//new Program().Main(args);

			Console.WriteLine();
			Console.WriteLine(Program.Info);
			Console.WriteLine(DateTime.Now);

			//Fenster.FensterOeffnen();
			Fenster fenster = new Fenster();
			fenster.FensterOeffnen();
			#endregion

			#region Werte-/Referenztypen
			//Referenztyp
			//class
			//==, != werden die Speicheradressen verglichen
			//Zuweisungen sind Referenzen (anstatt Kopien)

			//Wertetyp
			//struct
			//==, != werden die Inhalte verglichen
			//Zuweisungen werden kopiert (statt referenziert)

			//Wertetyp
			int original = 5;
			int x = original; //original wird in x kopiert
			original = 10; //x bleibt unverändert

			//Referenztyp
			Fenster f1 = new Fenster();
			Fenster f2 = f1; //f2 macht eine Referenz auf f1
			f1.Breite = 8; //f1 und f2 werden angepasst
			#endregion

			#region Null
			Fenster f3; //Standardmäßig null (es hängt kein Wert daran)
			f3 = null; //Referenz zum Objekt löschen
			//f3.FensterOeffnen(); //Fenster das nicht existiert kann nicht geöffnet werden

			if (f3 != null) //Vorher schauen ob das Fenster null ist
			{
				f3.FensterOeffnen();
			}

			if (f3 == null)
			{
				f3 = new Fenster();
			}

			if (f3 is null || f3 is not null)
			{

			}
			#endregion
		}
	}
}