using System;

namespace Play.Catalog.Service.Dtos
{
    public record Item(Guid Id, string Name, string Description, decimal Price, DateTimeOffset CreatedDate);

    public record CreateItem(string Name, string Description, decimal Price);

    public record UpdateItem(string Name, string Description, decimal Price);
}