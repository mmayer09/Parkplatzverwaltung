namespace Parkplatzverwaltung;

public class Parkhaus
{
    private Stehplatzinformationen[,,] Parkflaechen;

    public Parkhaus(int stockwerke, int zeilen, int spalten)
    {
        Parkflaechen = new Stehplatzinformationen[stockwerke, zeilen, spalten];
    }

    public Stehplatzinformationen SucheParkplatz(Stehplatzinformationen.Fahrzeugtyp fahrzeug)
    {
        for (int s = 0; s < Parkflaechen.GetLength(0); s++)
        {
            for (int z = 0; z < Parkflaechen.GetLength(1); z++)
            {
                for (int p = 0; p < Parkflaechen.GetLength(2); p++)
                {
                    if (Parkflaechen[s, z, p] == null)
                    {
                        Parkflaechen[s, z, p] = new Stehplatzinformationen(fahrzeug);
                        Console.WriteLine($"Fahrzeug parkt im Parkhaus: Ebene {s}, Reihe {z}, Platz {p}");
                        return Parkflaechen[s, z, p];
                    }
                }
            }
        }
        Console.WriteLine("Kein freier Parkplatz im Parkhaus gefunden.");
        return null;
    }
}

