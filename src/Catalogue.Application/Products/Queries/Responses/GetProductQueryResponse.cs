﻿using Catalogue.Application.Abstractions;

namespace Catalogue.Application.Products.Queries.Responses;

public sealed class GetProductQueryResponse : ProductBase
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
}
