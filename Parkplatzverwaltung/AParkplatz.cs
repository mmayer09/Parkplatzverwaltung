namespace Parkplatzverwaltung;

public abstract class AParkplatz
{
    public abstract Stehplatzinformationen SucheParkplatz(Stehplatzinformationen.Fahrzeugtyp fahrzeug);
    public abstract void ZeigeAuslastung();
    public abstract void VerlasseParkplatz(Stehplatzinformationen stehplatz);
}