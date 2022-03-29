using Microsoft.AspNetCore.Mvc;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsApp.Api.Client.Refit.Interfaces
{
    [Headers("Content-Type: application/json; charset=UTF-8")]
    public interface INewsImageApi
    {
        [Get("/NewsImage")]
        Task<IEnumerable<ListNewsImageQueryResponse>> List([FromQuery] ListNewsImageQueryRequest requestModel);

        [Get("/NewsImage/{id}")]
        Task<NewsImageQueryResponse> Get([FromRoute] string id);

        [Post("/NewsImage")]
        Task<CreateNewsImageCommandResponse> Post([FromBody] CreateNewsImageCommandRequest requestModel);

        [Put("/NewsImage")]
        Task<EmptyResponse?> Put([FromBody] UpdateNewsImageCommandRequest requestModel);

        [Delete("/NewsImage/{id}")]
        Task<EmptyResponse?> Delete([FromRoute] string id);
    }
}
