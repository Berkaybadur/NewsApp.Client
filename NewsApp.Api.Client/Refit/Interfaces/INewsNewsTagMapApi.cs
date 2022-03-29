using Microsoft.AspNetCore.Mvc;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsApp.Api.Client.Refit.Interfaces
{
    public interface INewsNewsTagMapApi
    {
        [Get("/NewsNewsTagMap")]
        Task<IEnumerable<ListNewsNewsTagMapQueryResponse>> List([FromQuery] ListNewsNewsTagMapQueryRequest requestModel);

        [Get("/NewsNewsTagMap/{id}")]
        Task<NewsNewsTagMapQueryResponse> Get([FromRoute] string id);

        [Post("/NewsNewsTagMap")]
        Task<CreateNewsNewsTagMapCommandResponse> Post([FromBody] CreateNewsNewsTagMapCommandRequest requestModel);

        [Put("/NewsNewsTagMap")]
        Task<EmptyResponse?> Put([FromBody] UpdateNewsNewsTagMapCommandRequest requestModel);

        [Delete("/NewsNewsTagMap/{id}")]
        Task<EmptyResponse?> Delete([FromRoute] string id);
    }
}
