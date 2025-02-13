namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale;

/// <summary>
/// Request model for getting a Sale
/// </summary>
public class GetAllSalesRequest
{
    public string? Customer { get; set; }

    public DateTime? MinDate { get; set; }

    public DateTime? MaxDate { get; set; }
}