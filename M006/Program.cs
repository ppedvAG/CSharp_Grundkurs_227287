using M006.Bauteile; //mit Using andere Namespaces importieren (Strg + . -> using <Namespace>)

namespace M006
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Fenster f = new Fenster(); //Fenster Objekt erstellen mit dem new Keyword
			f.SetLaenge(5);
			f.Breite = 5;
			//f.Status = FensterStatus.Geschlossen; //nicht möglich da private set

			Fenster f2 = new Fenster(5, 5); //Länge und Breite direkt übergeben

			Fenster f3 = new Fenster(5, 5, 2); //Beide Konstruktoren werden verwendet

			//Referenzen zwischen Objekten
			Raum r = new Raum();
			Tuere t = new Tuere();
			r.Tuer = t;
			r.Fenster[0] = f;
			r.Fenster[1] = f2;
			r.Fenster[2] = f3;

			//Console -> System
			//File, Directory, Path -> System.IO
			//HttpClient -> System.Net.Http
		}
	}
}