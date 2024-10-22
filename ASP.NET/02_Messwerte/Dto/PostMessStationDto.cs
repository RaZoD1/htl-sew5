using _02_Messwerte.Model;

namespace _02_Messwerte.Dto;

public record PostMessStationDto(string Name, string Betriebsdauer);

public static class PostMessStationDtoExtensions
{
    public static MessStation ToDomain(this PostMessStationDto dto) => new MessStation()
    {
        Id = 0,
        Name = dto.Name,
        BetriebsDauer = dto.Betriebsdauer,
        MessWerte = []
    };
}