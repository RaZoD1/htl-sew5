namespace _02_Messwerte.Model;

public class MessStation
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string BetriebsDauer { get; set; }
    
    public List<MessWert> MessWerte { get; set; }
}