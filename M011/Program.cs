using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace M011;

internal class Program
{
	static void Main(string[] args)
	{
		List<int> list = new List<int>(); //Erstellung einer Liste mit einem Generic (generischem Typargument)
		list.Add(1); //T wird ersetzt durch int
		list.Add(2); //T wird ersetzt durch int
		list.Add(3); //T wird ersetzt durch int

		List<string> strList = new List<string>();
		strList.Add("123"); //T wird ersetzt durch string

		Console.WriteLine(list[1]); //Funktioniert genau wie beim Array
		list[2] = 5; //Zuweisung genau wie beim Array

        Console.WriteLine(list.Count); //Count statt Length, nicht Count() benutzen

		list.Sort(); //Liste sortieren

		foreach (int i in list) //Liste itereieren wie bei Array
		{
            Console.WriteLine(i);
        }

		if (list.Contains(2))
		{

		}

		list.Clear(); //Entleert die Liste



		Stack<int> stack = new Stack<int>();
		stack.Push(1); //Elemente auflegen
		stack.Push(2);
		stack.Push(3);
		stack.Push(4);

        Console.WriteLine(stack.Peek()); //Oberstes Element anschauen (4)

        Console.WriteLine(stack.Pop()); //Oberstes Element anschauen und entfernen (4)

		Queue<int> queue = new Queue<int>();
		queue.Enqueue(1);
		queue.Enqueue(2);
		queue.Enqueue(3);
		queue.Enqueue(4);

        Console.WriteLine(queue.Peek()); //Erstes Element anschauen (1)

        Console.WriteLine(queue.Dequeue()); //Erstes Element anschauen und entfernen (1)



		//Liste von Key-Value Paaren, Keys müssen eindeutig sein
		Dictionary<string, int> einwohnerzahlen = new(); //new(): Typ wird von Links ergänzt
		einwohnerzahlen.Add("Wien", 2_000_000); //Zwei Parameter: Key = string, Value = int
		einwohnerzahlen.Add("Berlin", 3_650_000);
		einwohnerzahlen.Add("Paris", 2_160_000);
        //einwohnerzahlen.Add("Paris", 2_160_000); //ArgumentException

        Console.WriteLine(einwohnerzahlen["Wien"]); //Elemente angreifen wie bei Array/List

		einwohnerzahlen["Wien"] = 2_000_001;

		if (einwohnerzahlen.ContainsKey("Salzburg")) //Schauen ob der Schlüssel schon existiert
		{
			Console.WriteLine(einwohnerzahlen["Salzburg"]);
		}

		//var: Typ automatisch ergänzen lassen
		//Strg + . -> tatsächlichen Typen generieren lassen
		foreach (KeyValuePair<string, int> kv in einwohnerzahlen) //Dictionary iterieren mit KeyValuePair<TKey, TValue>
		{
            Console.WriteLine($"Die Stadt {kv.Key} hat {kv.Value} Einwohner.");
        }

		einwohnerzahlen.Keys.ToList(); //Nur Keys holen
		einwohnerzahlen.Values.ToList(); //Nur Values holen

		ObservableCollection<string> str = new(); //Benachrichtigt wenn in der Liste was passiert
		str.CollectionChanged += Str_CollectionChanged; //Immer wenn in der Liste sich etwas ändert, wird die angehängte Methode ausgeführt
		str.Add("X");
		str.Add("Y");
		str.Add("Z");
		str.Remove("X");
	}

	private static void Str_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
	{
		switch (e.Action)
		{
			case NotifyCollectionChangedAction.Add:
                Console.WriteLine($"Ein Element wurde hinzugefügt: {e.NewItems[0]}");
                break;
			case NotifyCollectionChangedAction.Remove:
                Console.WriteLine($"Ein Element wurde entfernt: {e.OldItems[0]}");
                break;
		}
	}
}