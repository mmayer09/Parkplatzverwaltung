namespace Parkplatzverwaltung;

public class Stehplatzinformationen
{
   public enum Fahrzeugtyp
   {
      Nix,
      Motorrad,
      PKW
   }
    
   public DateTime Ankunftzeit { get; set; }
   public Fahrzeugtyp Fahrzeug { get; set; }

   public Stehplatzinformationen(Fahrzeugtyp fahrzeug)
   {
      Fahrzeug = fahrzeug;
      Ankunftzeit = DateTime.Now;
   }

   public void VerlasseParkplatz()
   {
      TimeSpan Parkdauer = DateTime.Now - Ankunftzeit;
      int Minuten = (int)Parkdauer.TotalMinutes;
      int Kosten = (Fahrzeug == Fahrzeugtyp.Motorrad) ? Minuten * 1 : Minuten * 3;
      Console.WriteLine($"Fahrzeugtyp: {Fahrzeug} " +
                        $"\n Minuten: {Minuten} " +
                        $"\n Kosten: {Kosten} ");
   }
   
}