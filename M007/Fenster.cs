namespace M007
{
	internal class Fenster
	{
		#region Variable + Get/Set
		/// <summary>
		/// Die Länge des Fensters in Meter
		/// </summary>
		private double laenge; //Felder sollten nicht von außen angreifbar sein (private)

		/// <summary>
		/// Gibt die Länge des Fensters zurück.
		/// </summary>
		/// <returns>Die Länge des Fensters in Meter</returns>
		public double GetLaenge()
		{
			return laenge;
		}
		
		/// <summary>
		/// Setzt die Länge des Fensters auf einen neuen Wert.
		/// </summary>
		/// <param name="laenge">Die neue Länge des Fensters in Meter (0 bis 10)</param>
		public void SetLaenge(double laenge)
		{
			if (laenge > 0 && laenge < 10) //Überprüfung machen bevor die Länge gesetzt wird
			{
				this.laenge = laenge; //this: Aus der Methode herausgreifen (nach oben greifen)
			}
			else
			{
				Console.WriteLine("Länge ist zu klein/groß");
			}
		}
		#endregion

		#region Properties
		private double breite;

		public double Breite
		{
			get //Äquivalent zur Get-Methode
			{ 
				return breite; 
			}
			set //Äquivalent zur Set-Methode
			{ 
				if (value > 0 && value < 10)
					breite = value; //value: der neue Wert (wie oben in der Set Methode -> laenge Parameter)
				else
                    Console.WriteLine("Breite zu klein/groß");
            }
		}

		public double Breite2
		{
			get => breite;
			set
			{
				if (value > 0 && value < 10)
					breite = value;
				else
					Console.WriteLine("Breite zu klein/groß");
			} //value kommt von der Main Methode bei der Zuweisung (f.Breite = 5)
		}

		//Get-Only Property
		public double Area
		{
			get
			{
				return laenge * breite;
			}
			//hier Setter (Set-Accessor) weglassen
		}

		public double AreaKurz
		{
			get => laenge * breite;
		}

		public double AreaNochKuerzer => laenge * breite;

		public double CalcArea() => laenge * breite;


		private FensterStatus status = FensterStatus.Geschlossen; //Standardwert setzen, wird bei Erstellung des Objekts gesetzt (new)

		public FensterStatus Status
		{
			get => status;
			private set => status = value; //private set: nicht von außen setzbar (nur innerhalb der Klasse)
		}

		public void FensterOeffnen()
		{
			if (Status != FensterStatus.Offen)
				Status = FensterStatus.Offen; //hier private set sichtbar
			else
                Console.WriteLine("Fenster ist bereits geöffnet");
        }

		public int Scheibenanzahl { get; set; } = 2; //Standardwert setzen, wird bei Erstellung des Objekts gesetzt (new)
		#endregion

		#region Konstruktor
		public Fenster()
		{

        }

		public Fenster(double laenge, double breite) //Konstruktor: Initialcode, der bei Erstellung des Objekts ausgeführt wird
		{
			SetLaenge(laenge);
			Breite = breite;
		}

		public Fenster(double laenge, double breite, int scheiben) : this(laenge, breite) //Konstruktoren verketten (wenn dieser Konstruktor verwendet wird, wird der obere auch verwendet)
		{
			Scheibenanzahl = scheiben;
		}
		#endregion

		~Fenster()
		{
            Console.WriteLine($"Das Fenster wurde eingesammelt: {GetHashCode()}");
        }
	}

	public enum FensterStatus
	{
		Offen,
		Gekippt,
		Geschlossen
	}
}