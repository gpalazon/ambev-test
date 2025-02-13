using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale;


/// <summary>
/// Handler for processing GetSaleHandler requests
/// </summary>
public class GetAllSalesHandler : IRequestHandler<GetAllSalesCommand, List<GetSaleResult>>
{
    private readonly ISaleRepository _saleRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of GetAllSalesHandler
    /// </summary>
    /// <param name="saleRepository"></param>
    /// <param name="mapper"></param>
    public GetAllSalesHandler(ISaleRepository saleRepository, IMapper mapper)
    {
        _saleRepository = saleRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the GetAllSalesCommand request
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<List<GetSaleResult>> Handle(GetAllSalesCommand request, CancellationToken cancellationToken)
    {
        var sales = await _saleRepository.GetAllAsync(request.Customer, request.MinDate, request.MaxDate, cancellationToken);
        return _mapper.Map<List<GetSaleResult>>(sales);
    }
}
