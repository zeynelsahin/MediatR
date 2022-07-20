using MediatR;
using MediatrExample.Mad.Command;
using MediatrExample.Mad.Queries;
using Microsoft.AspNetCore.Mvc;

namespace MediatrExample.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : Controller
{
    private IMediator _mediator;

    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var query = new GetProductByIdQuery() { Id = id };
        return Ok(await _mediator.Send(query));
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetAll()
    {
        var query = new GetAllProductQuery();
        return Ok(await _mediator.Send(query));
    } 
    [HttpPost()]
    public async Task<IActionResult> GetAll(CreateProductCommand command)
    {
        return Ok(await _mediator.Send(command));
    }
}