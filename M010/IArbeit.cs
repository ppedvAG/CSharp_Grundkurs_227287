namespace M010;

public interface IArbeit //Interfaces fangen per Konvention mit I an
{
	static readonly int Wochenstunden = 40; //statisches Feld über IArbeit.Wochenstunden angreifen

	int Gehalt { get; set; } //Properties werden weitergegeben

	string Job { get; set; }

	void Lohnauszahlung(); //Methoden ohne Body

	int Jahresgehalt();

	int LohnProStunde(int lohn);

	public void Test()
	{
		//Bad Practice
	}
}

public interface ITeilzeitArbeit
{
	static readonly int Wochenstunden = 20;

	void Lohnauszahlung();
}