namespace M008;

class AccessModifier //Klassen und Member ohne Modifier sind internal
{
	public string Name { get; set; } //Kann überall gesehen werden, auch außerhalb vom Projekt

	private int Alter { get; set; } //Nur innerhalb dieser Klasse sichtbar

	internal string Wohnort { get; set; } //Überall sichtbar, aber nur innerhalb vom Projekt


	protected string Lieblingsfarbe { get; set; } //Nur innerhalb der Klasse (~ private), und in Unterklassen (auch außerhalb vom Projekt)

	protected internal string Lieblingsnahrung { get; set; } //Kann überall im Projekt (internal) gesehen werden, und in Unterklassen außerhalb vom Projekt

	protected private DateTime Geburtsdatum { get; set; } //Kann nur in dieser Klasse (private) und in Unterklassen nur im Projekt gesehen werden
}
