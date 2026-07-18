using Microsoft.AspNetCore.Mvc;
using Loja.Api.Models;

namespace Loja.Api.Controllers;

[ApiController]
[Route("api/produtos")]
public class ProdutosController : ControllerBase
{
    [HttpGet]
    public IActionResult Get(decimal minPrice, decimal maxPrice)
    {
        if (minPrice > 0 || maxPrice > 0)
            return Ok($"MinPrice: {minPrice} \nMaxPrice: {maxPrice}");

        return Ok(Produto.Produtos);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok(id);
    }

    [HttpGet("search")]
    public IActionResult Search(string name, decimal minPrice)
    {
        return Ok($"Nome: {name} \nMinPrice: {minPrice}");
    }

    [HttpPost]
    public IActionResult Create(CreateProductRequest request)
    {
        var service = new ProductService();
        var produto = service.Create(request);
        var produtoResponse = new ProductResponse(produto.ID, produto.Name, produto.Price);

        return Ok(produtoResponse);
    }


}