using Application.Mediator;
using Application.Models.RequestModels;
using Application.Models.ResponseModels;

namespace Application.Handlers;

public class GetProductQueryHandler : IRequestHandler<GetProductQuery, GetProductResponse>
{
    public Task<GetProductResponse> HandleAsync(GetProductQuery request)
    {
        throw new NotImplementedException();
    }
}
