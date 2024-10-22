using System.Collections;
using _02_Messwerte.Model;

namespace _02_Messwerte.Dto;

public record GetMessStationDto(int Id, string Name, string BetriebsDauer, IEnumerable<GetMessStationMesswertDto> Messwerte)
{
    
}

public static class MessStationMapper
{
    public static GetMessStationDto ToDto(this MessStation m) =>
        new GetMessStationDto(m.Id, m.Name, m.BetriebsDauer, m.MessWerte.ToDtos());

    public static IQueryable<GetMessStationDto> ToDtos(this IQueryable<MessStation> m) => 
        m.Select(it => it.ToDto());
}