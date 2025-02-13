using Ambev.DeveloperEvaluation.Application.Users.GetUser;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale;

public class GetAllSalesCommand : IRequest<List<GetSaleResult>>
{

    public string? Customer { get; set; } = string.Empty;

    public DateTime? MinDate { get; set; } = DateTime.MinValue;

    public DateTime? MaxDate { get; set; } = DateTime.MaxValue;   

}
