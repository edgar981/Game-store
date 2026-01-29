using System.ComponentModel.DataAnnotations;

namespace GameStore.Api.Dtos
{
    //Record was added in C# 9 and later, so Class was used instead. 
    //See more info: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record
    public record UpdateGameDto(
        [Required][StringLength(50)] string Name,
        [Required][StringLength(20)] string Genre,
        [Range(1, 100)] decimal Price,
        DateOnly ReleaseDate
    );
}
