using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale;

/// <summary>
/// API response model for GetSale operation
/// </summary>
public class GetSaleResponse
{
    // <summary>
    /// The unique identifier of the sale
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The date of the sale
    /// </summary>
    public DateTime Date { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// The customer who purchased
    /// </summary>
    public string Customer { get; set; } = string.Empty;

    /// <summary>
    /// The total purchase price
    /// </summary>
    public decimal TotalSaleAmount { get; set; }

    /// <summary>
    /// Where the sale was made
    /// </summary>
    public string Branch { get; set; } = string.Empty;

    /// <summary>
    /// The products of sale
    /// </summary>
    public List<SaleItem> Itens { get; set; } = new List<SaleItem>();

    /// <summary>
    /// Sale is canceled true or false
    /// </summary>
    public bool IsCanceled { get; set; }
}
