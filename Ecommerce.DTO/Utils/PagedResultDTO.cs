namespace Ecommerce.DTO.Utils;

public record PagedResultDTO<T>(IReadOnlyList<T> items, int total, string search);
