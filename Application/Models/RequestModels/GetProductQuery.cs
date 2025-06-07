using Application.Mediator;
using Application.Models.ResponseModels;
using System.Text.Json.Serialization;

namespace Application.Models.RequestModels;

public class GetProductQuery : IRequest<GetProductResponse>
{
    public int Id { get; set; }
}
