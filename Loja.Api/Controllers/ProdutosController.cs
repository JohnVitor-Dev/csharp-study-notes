using Microsoft.AspNetCore.Mvc;
using Loja.Api.Models;

namespace Loja.Api.Controllers;

[ApiController]
[Route("api/produtos")]
public class ProdutosController : ControllerBase
{
    private readonly IProductService _service;


    public ProdutosController(IProductService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var produtos = _service.GetAll();
        return Ok(produtos);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, UpdateProductRequest request)
    {
        var produto = _service.Update(id, request);

        if (produto is null)
            return NotFound();

        return Ok(produto);
    }

    [HttpPost]
    public IActionResult Create(CreateProductRequest request)
    {
        var produto = _service.Create(request);

        if (produto is null)
            return BadRequest();

        return CreatedAtAction(
            nameof(GetById),
            new { id = produto.Id },
            new ProductResponse(
                produto.Id,
                produto.Name,
                produto.Price
            ));
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var deleted = _service.Delete(id);

        if (!deleted)
            return NotFound();

        return NoContent();
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var produto = _service.GetById(id);

        if (produto is null)
            return NotFound();

        return Ok(produto);
    }

    [HttpGet("search")]
    public IActionResult Search(string name)
    {
        var produtos = _service.Search(name);

        if (!produtos.Any())
        {
            return NotFound();
        }

        return Ok(produtos);
    }


}