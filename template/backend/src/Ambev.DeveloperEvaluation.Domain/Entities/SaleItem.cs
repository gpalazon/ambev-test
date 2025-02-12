using Ambev.DeveloperEvaluation.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Entities;


public class SaleItem : BaseEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Product { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; private set; }
    public decimal TotalItemAmount { get; private set; }

    public void ApplyDiscount()
    {
        if (Quantity >= 10 && Quantity <= 20)
            Discount = 0.20m;
        else if (Quantity >= 4)
            Discount = 0.10m;
        else
            Discount = 0.00m;

        TotalItemAmount = Quantity * UnitPrice * (1 - Discount);
    }
}
