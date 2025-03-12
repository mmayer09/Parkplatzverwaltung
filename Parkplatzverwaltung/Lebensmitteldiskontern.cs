namespace Parkplatzverwaltung;

public class Lebensmitteldiskontern : AParkplatz
{
    
    private Stehplatzinformationen[,] Parkplatzarray = new Stehplatzinformationen[3, 4];

    private Stehplatzinformationen[][] JaggedParkplatzarray;

    public Lebensmitteldiskontern()
    {
        JaggedParkplatzarray = new Stehplatzinformationen[3][];
        JaggedParkplatzarray[0] = new Stehplatzinformationen[2]; 
        JaggedParkplatzarray[1] = new Stehplatzinformationen[3]; 
        JaggedParkplatzarray[2] = new Stehplatzinformationen[4]; 
    }

    public override Stehplatzinformationen SucheParkplatz(Stehplatzinformationen.Fahrzeugtyp fahrzeug)
    {
        for (int i = 0; i < Parkplatzarray.GetLength(0); i++)
        {
            for (int j = 0; j < Parkplatzarray.GetLength(1); j++)
            {
                if (Parkplatzarray[i, j] == null)
                {
                    Parkplatzarray[i, j] = new Stehplatzinformationen(fahrzeug);
                    Console.WriteLine($"Das Fahrzeug {fahrzeug} parkt im 2D-Array auf Platz {i}, {j}");
                    ZeigeAuslastung();
                    return Parkplatzarray[i, j];
                }
            }
        }

        
        for (int i = 0; i < JaggedParkplatzarray.Length; i++)
        {
            for (int j = 0; j < JaggedParkplatzarray[i].Length; j++)
            {
                if (JaggedParkplatzarray[i][j] == null)
                {
                    JaggedParkplatzarray[i][j] = new Stehplatzinformationen(fahrzeug);
                    Console.WriteLine($"Das Fahrzeug {fahrzeug} parkt im Jagged-Array auf Platz {i}, {j}");
                    ZeigeAuslastung();
                    return JaggedParkplatzarray[i][j];
                }
            }
        }

        Console.WriteLine("Kein freier Parkplatz gefunden.");
        return null;
    }

    public override void ZeigeAuslastung()
    {
        Console.WriteLine("Parkplatzbelegung (2D-Array):");
        for (int i = 0; i < Parkplatzarray.GetLength(0); i++)
        {
            for (int j = 0; j < Parkplatzarray.GetLength(1); j++)
            {
                Console.Write(Parkplatzarray[i, j] == null ? "[ Frei ]" : "[Belegt]");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Parkplatzbelegung (Jagged Array):");
        for (int i = 0; i < JaggedParkplatzarray.Length; i++)
        {
            if (JaggedParkplatzarray[i]!=null)
            {
                for (int j = 0; j < JaggedParkplatzarray[i].Length; j++)
                {
                    Console.Write(JaggedParkplatzarray[i][j] == null ? "[ Frei ]" : "[Belegt]");
                }
                Console.WriteLine();
            }
            
        }
    }

    public override void VerlasseParkplatz(Stehplatzinformationen stehplatz)
    {
        for (int i = 0; i < Parkplatzarray.GetLength(0); i++)
        {
            for (int j = 0; j < Parkplatzarray.GetLength(1); j++)
            {
                if (Parkplatzarray[i, j] == stehplatz)
                {
                    Parkplatzarray[i, j] = null;
                    Console.WriteLine($"Platz {i}, {j} im 2D-Array ist jetzt frei.");
                    ZeigeAuslastung();
                    return;
                }
            }
        }

        for (int i = 0; i < JaggedParkplatzarray.Length; i++)
        {
            if (JaggedParkplatzarray[i] != null)
            {
                 for (int j = 0; j < JaggedParkplatzarray[i].Length; j++)
                 {
                     if (JaggedParkplatzarray[i][j] == stehplatz)
                     {
                         JaggedParkplatzarray[i][j] = null;
                         Console.WriteLine($"Platz {i}, {j} im Jagged-Array ist jetzt frei.");
                         ZeigeAuslastung();
                         return;
                     }
                 }
            }
           
        }
    }
}
