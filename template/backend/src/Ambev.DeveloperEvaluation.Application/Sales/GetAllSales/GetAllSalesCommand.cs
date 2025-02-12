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
   

    /// <summary>
    /// Initializes a new instance of GetAllSalesCommand
    /// </summary>
    /// <param name="customer"></param>
    public GetAllSalesCommand()
    {
    }

}
