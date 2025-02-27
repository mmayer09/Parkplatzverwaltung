namespace Parkplatzverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            Längsparker parkplatz = new Längsparker(5);
            parkplatz.ZeigeAuslastung();
        
            var stehplatz = parkplatz.SucheParkplatz(Stehplatzinformationen.Fahrzeugtyp.Motorrad);
            parkplatz.ZeigeAuslastung();
        
            Thread.Sleep(120000); 
            parkplatz.VerlasseParkplatz(stehplatz);
            parkplatz.ZeigeAuslastung();
        }
    }
}



