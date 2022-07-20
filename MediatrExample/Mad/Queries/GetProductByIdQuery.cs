using MediatR;

namespace MediatrExample.Mad.Queries;

public class GetProductByIdQuery:  IRequest<GetProductViewModel>
{
    public Guid Id { get; set; }
}