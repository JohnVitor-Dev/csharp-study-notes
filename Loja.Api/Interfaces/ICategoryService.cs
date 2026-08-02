using Loja.Api.Models;

public interface ICategoryService
{
    Categoria? Create(CreateCategoryRequest request);

    List<CategoryResponse> GetAll();

    CategoryResponse? GetById(int id);

    CategoryResponse? UpdateName(int id, UpdateNameCategoryRequest request);

    bool Delete(int id);

    List<CategoryResponse> Search(string name);

}