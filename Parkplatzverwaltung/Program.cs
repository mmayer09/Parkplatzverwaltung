namespace Parkplatzverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            Parkhaus parkhaus = new Parkhaus(2, 3, 4); // 2 Stockwerke, 3 Reihen, 4 Plätze pro Reihe
            Stehplatzinformationen parkplatz1 = parkhaus.SucheParkplatz(Stehplatzinformationen.Fahrzeugtyp.Motorrad);
            Stehplatzinformationen parkplatz2 = parkhaus.SucheParkplatz(Stehplatzinformationen.Fahrzeugtyp.PKW);

            AParkplatz Billa = new Lebensmitteldiskontern();
            Billa.ZeigeAuslastung();
            var billa1 = Billa.SucheParkplatz(Stehplatzinformationen.Fahrzeugtyp.Motorrad);
            Thread.Sleep(12000); 
            Billa.VerlasseParkplatz(billa1);
            
            
            return;
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



