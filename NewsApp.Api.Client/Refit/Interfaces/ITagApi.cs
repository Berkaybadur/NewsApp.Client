using Microsoft.AspNetCore.Mvc;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsApp.Api.Client.Refit.Interfaces
{
    [Headers("Content-Type: application/json; charset=UTF-8")]
    public interface ITagApi
    {
        [Get("/Tag")]
        Task<IEnumerable<ListTagQueryResponse>> List([FromQuery] ListTagQueryRequest requestModel);

        [Get("/Tag/{id}")]
        Task<TagQueryResponse> Get([FromRoute] string id);

        [Post("/Tag")]
        Task<CreateTagCommandResponse> Post([FromBody] CreateTagCommandRequest requestModel);

        [Put("/Tag")]
        Task<EmptyResponse?> Put([FromBody] UpdateTagCommandRequest requestModel);

        [Delete("/Tag/{id}")]
        Task<EmptyResponse?> Delete([FromRoute] string id);
    }
}
