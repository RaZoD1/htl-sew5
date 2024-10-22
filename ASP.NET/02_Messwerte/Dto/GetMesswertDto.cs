using _02_Messwerte.Model;

namespace _02_Messwerte.Dto;

public record GetMessStationMesswertDto(int Id, int Value, string Unit);

public static class MessWertMapper
{
    public static GetMessStationMesswertDto ToDto(this MessWert messwert) => 
        new GetMessStationMesswertDto(messwert.Id, messwert.Value, messwert.Unit);

    public static IEnumerable<GetMessStationMesswertDto> ToDtos(this IEnumerable<MessWert> m) =>
        m.Select(it => it.ToDto());
}