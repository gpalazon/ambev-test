using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Sale : BaseEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string SaleNumber { get; set; }
    public DateTime SaleDate { get; set; }
    public string Customer { get; set; }
    public decimal TotalAmount { get; private set; }
    public string Branch { get; set; }
    public bool IsCancelled { get; private set; }
    public List<SaleItem> Items { get; set; } = new();

    public void AddItem(SaleItem item)
    {
        if (item.Quantity > 20)
            throw new InvalidOperationException("Cannot sell more than 20 identical items.");

        item.ApplyDiscount();
        Items.Add(item);
        RecalculateTotal();
    }

    public void CancelSale()
    {
        IsCancelled = true;
    }

    private void RecalculateTotal()
    {
        TotalAmount = 0;
        foreach (var item in Items)
        {
            TotalAmount += item.TotalItemAmount;
        }
    }
}

