namespace MyBGList.DTO
{
    public record RestDTO<T>(List<LinkDTO> Links, T Data);
}
