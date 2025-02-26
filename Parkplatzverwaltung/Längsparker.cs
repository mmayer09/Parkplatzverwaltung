namespace Parkplatzverwaltung;

public class Längsparker:AParkplatz
{
    private Stehplatzinformationen[] Parkplätze;

    public Längsparker(int Anzahl)
    {
        Parkplätze = new Stehplatzinformationen[Anzahl];
    }
      

    public override Stehplatzinformationen SucheParkplatz(Stehplatzinformationen.Fahrzeugtyp fahrzeug)
    {
        for (int i = 0; i < Parkplätze.Length; i++)
        {
            if (Parkplätze[i] == null)
            {
                Parkplätze[i] = new Stehplatzinformationen(fahrzeug);
                Console.WriteLine($"Das Fahrzeug: {fahrzeug} parkt auf Platz {i}");
                return Parkplätze[i];
            }
        }
        Console.WriteLine("Kein freier Parkplatz wurde gefunden");
        return null;
    }

    public override void ZeigeAuslastung()
    {
        Console.WriteLine("Parkplatzbelegung:");
        for (int i = 0; i < Parkplätze.Length; i++)
        {
            Console.Write("-------");
        }
        Console.WriteLine();
        for (int i = 0; i < Parkplätze.Length; i++)
        {
            Console.Write(Parkplätze[i] == null ? "[ Frei ]" : "[Belegt]");
        }
        Console.WriteLine();
        for (int i = 0; i < Parkplätze.Length; i++)
        {
            Console.Write("-------");
        }
        Console.WriteLine();
    }
    
    public override void VerlasseParkplatz(Stehplatzinformationen stehplatz)
    {
        for (int i = 0; i < Parkplätze.Length; i++)
        {
            if (Parkplätze[i] == stehplatz)
            {
                stehplatz.VerlasseParkplatz();
                Parkplätze[i] = null;
                Console.WriteLine($"Platz {i} ist jetzt frei.");
                return;
            }
        }
    }
}