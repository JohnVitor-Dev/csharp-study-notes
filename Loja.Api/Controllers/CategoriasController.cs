using Microsoft.AspNetCore.Mvc;
using Loja.Api.Models;

namespace Loja.Api.Controllers;

[ApiController]
[Route("api/categorias")]
public class CategoriasController : ControllerBase
{
    private readonly ICategoryService _service;


    public CategoriasController(ICategoryService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var categorias = _service.GetAll();
        return Ok(categorias);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, UpdateNameCategoryRequest request)
    {
        var categoria = _service.UpdateName(id, request);

        if (categoria is null)
            return NotFound();

        return Ok(categoria);
    }

    [HttpPost]
    public IActionResult Create(CreateCategoryRequest request)
    {
        var categoria = _service.Create(request);

        if (categoria is null)
            return BadRequest();

        return CreatedAtAction(
            nameof(GetById),
            new { id = categoria.Id },
            new CategoryResponse(
                categoria.Id,
                categoria.Name
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
        var categoria = _service.GetById(id);

        if (categoria is null)
            return NotFound();

        return Ok(categoria);
    }

    [HttpGet("search")]
    public IActionResult Search(string name)
    {
        var categoria = _service.Search(name);

        if (!categoria.Any())
        {
            return NotFound();
        }

        return Ok(categoria);
    }


}