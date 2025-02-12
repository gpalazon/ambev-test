﻿using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

public class CreateSaleResponse
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string SaleNumber { get; set; }
    public DateTime SaleDate { get; set; }
    public string Customer { get; set; }
    public decimal TotalAmount { get; private set; }
    public string Branch { get; set; }
    public bool IsCancelled { get; private set; }
    public List<SaleItem> Items { get; set; } = new();
}
