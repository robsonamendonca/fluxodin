using fluxodin.Core.Models;
using fluxodin.Core.Requests.Categories;
using fluxodin.Core.Responses;

namespace fluxodin.Core.Handlers;

public interface ICategoryHandler
{
    Task<Response<Category?>> CreateAsync(CreateCategoryRequest request);
    Task<Response<Category?>> UpdateAsync(UpdateCategoryRequest request);
    Task<Response<Category?>> DeleteAsync(DeleteCategoryRequest request);
    Task<Response<Category?>> GetByIdAsync(GetCategoryByIdRequest request);
    
    Task<PagedResponse<List<Category>?>> GetAllAsync(GetAllCategoriesRequest request);

}
