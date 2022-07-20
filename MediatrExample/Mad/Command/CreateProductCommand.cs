using MediatR;

namespace MediatrExample.Mad.Command;

public class CreateProductCommand: IRequest<Guid>
{
    public int Name { get; set; }
    public int Quantity { get; set; }
    public decimal Value { get; set; }
    
    public class CreateProductCommandHandler: IRequestHandler<CreateProductCommand,Guid>
    {
        public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            //Database veri gönderme
            return Task.FromResult(Guid.NewGuid());
        }
    }
}