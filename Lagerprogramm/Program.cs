using System;

public class Program
{
	public static void Main()
	{
		// String für Produktnamen
		String[] produkte_namen = new String[10];

		// Array für die Anzahl der Produkte
		int[] produkte_anzahl = new int[10];

		// Anzahl der Produkttypen - 0, weil ich habe noch keine Produkte
		int anzahl_liste = 0;

		/*
		Datenmodell für die Speicherung von Produkten
		produkte_namen[0] = "Milch";
		produkte_anzahl[0] = 20;
		*/

		// String für Eingabe mit Console.ReadLine
		String eingabe = "";
		int index = 0;
		int anzahl_eingabe = 0;

		// Endlosschleifen für Menüführung
		while (true)
		{
			// Ausgabe für Benutzer
			Console.WriteLine("(1) Produkt anlegen");
			Console.WriteLine("(2) Produkt anzeigen");
			Console.WriteLine("(3) Produkt verkaufen");
			Console.WriteLine("(4) Exit");

			// Eingabe des Benutzers
			eingabe = Console.ReadLine();

			// Exit
			if (eingabe.Equals("4"))
			{
				// Bildschirm löschen
				Console.Clear();
				break;
			}

			// Produkt anlegen 
			if (eingabe.Equals("1"))
			{
				// Bildschirm löschen
				Console.Clear();

				Console.WriteLine("Bitte Namen eingeben:");
				// Name eingeben
				eingabe = Console.ReadLine();

				// Eingabe (Name des Produkts) wird in Array an Position "anzahl_liste" (0) gespeichert
				produkte_namen[anzahl_liste] = eingabe;

				Console.WriteLine("Bitte Anzahl eingeben:");
				// Anzahl eingeben
				eingabe = Console.ReadLine();

				// String wird in Integer umgewandelt 
				produkte_anzahl[anzahl_liste] = Int32.Parse(eingabe);

				// Anzahl Produkte hochzählen
				anzahl_liste++;

				// Bildschirm löschen
				Console.Clear();
			}

			// Produkt anzeigen lassen 
			if (eingabe.Equals("2"))
			{
				Console.WriteLine("================================================");
				// Ausgabe der Produkte im Array durch eine for Schleife
				for (int i = 0; i < anzahl_liste; i++)
				{
					Console.WriteLine("ID:" + (i + 1) + " - " + produkte_namen[i] + ": " + produkte_anzahl[i]);
				}
				Console.WriteLine("================================================");
			}

			// Produkt verkaufen
			if (eingabe.Equals("3"))
			{
				Console.WriteLine("Bitte Produkt ID eingeben:");
				// Name eingeben
				eingabe = Console.ReadLine();
				index = Int32.Parse(eingabe);
				// ID ist immer Eingaben - 1 weil Index ist ID-1
				index = index - 1;

				// Anzahl der verkauften Produkte eingeben	 
				Console.WriteLine("Anzahl verkaufter Produkte:");
				eingabe = Console.ReadLine();
				anzahl_eingabe = Int32.Parse(eingabe);

				if ((produkte_anzahl[index] - anzahl_eingabe) < 0)
				{
					Console.WriteLine("So viele Produkte davon gibt es nicht!");
				}
				else
				{
					// Abziehen und neu speichern
					produkte_anzahl[index] -= anzahl_eingabe;
					Console.Clear();
				}

			}

		}
	}
}
