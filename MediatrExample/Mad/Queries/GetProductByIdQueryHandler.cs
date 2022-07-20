using MediatR;

namespace MediatrExample.Mad.Queries;

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
{
    public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        //database veri çekme
        var viewModel= new GetProductViewModel()
        {
            Id = Guid.NewGuid(),
            Name = "Book"
        };
        return Task.FromResult(viewModel);
    }
}