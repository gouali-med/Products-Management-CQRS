
using Application.Features.Posts.Commands.CreatePost;
using Application.Features.Posts.Commands.DeletePost;
using Application.Features.Posts.Commands.UpdatePost;
using Application.Features.Posts.Queries.GetPostDetail;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PostLand.Application.Features.Posts.Queries.GetPostsList;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllProducts")]
        public async Task<ActionResult<List<GetProductsListViewModel>>> GetAllProducts()
        {
            var dtos = await _mediator.Send(new GetProductsListQuery());
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetProductById")]
        public async Task<ActionResult<GetProductDetailViewModel>> GetProductById(Guid id)
        {
            var getEventDetailQuery = new GetProductDetailQuery() { ProductId = id };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }

        [HttpPost(Name = "AddProduct")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateProductCommand createProductCommand)
        {
            Guid id = await _mediator.Send(createProductCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdateProduct")]
        public async Task<ActionResult> Update([FromBody] UpdateProductCommand updateProductCommand)
        {
            await _mediator.Send(updateProductCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteProduct")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteProductCommand = new DeleteProductCommand() { ProductId = id };
            await _mediator.Send(deleteProductCommand);
            return NoContent();
        }

    }
}
