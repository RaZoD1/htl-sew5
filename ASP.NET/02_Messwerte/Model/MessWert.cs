namespace _02_Messwerte.Model;

public class MessWert
{
    public int Id {get; set;}
    public int Value {get; set;}
    public string Unit {get; set;}
    
    public MessStation? Station {get; set;}
    public int StationId {get; set;}
}