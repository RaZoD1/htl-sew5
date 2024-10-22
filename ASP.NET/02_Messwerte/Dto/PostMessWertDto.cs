using _02_Messwerte.Model;

namespace _02_Messwerte.Dto;

public record PostMessWertDto(int Value, string Unit);

public static class PostMessWertDtoExtensions
{
    public static MessWert ToDomain(this PostMessWertDto dto, int stationId) => new MessWert()
    {
        Id = 0,
        Unit = dto.Unit,
        Value = dto.Value,
        StationId = stationId
    };
}