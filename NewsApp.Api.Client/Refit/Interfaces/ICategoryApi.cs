using Microsoft.AspNetCore.Mvc;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsApp.Api.Client.Refit.Interfaces
{
    [Headers("Content-Type: application/json; charset=UTF-8")]
    public interface ICategoryApi
    {
        [Get("/Category")]
        Task<IEnumerable<ListCategoryQueryResponse>> List([FromBody] ListCategoryQueryRequest requestModel);

        [Get("/Category/{id}")]
        Task<CategoryQueryResponse> Get(/*[FromRoute]*/ string id);

        [Post("/Category")]
        Task<CreateCategoryCommandResponse> Post([FromBody] CreateCategoryCommandRequest requestModel);

        [Put("/Category")]
        Task<EmptyResponse?> Put([FromBody] UpdateCategoryCommandRequest requestModel);

        [Delete("/Category/{id}")]
        Task<EmptyResponse?> Delete([FromRoute] string id);
    }
}
