using Microsoft.AspNetCore.Mvc;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsApp.Api.Client.Refit.Interfaces
{
    [Headers("Content-Type: application/json; charset=UTF-8")]

    public interface IChannelApi
    {
        [Get("/Channel")]
        Task<IEnumerable<ListChannelQueryResponse>> List([FromQuery] ListChannelQueryRequest requestModel);

        [Get("/Channel/{id}")]
        Task<ChannelQueryResponse> Get([FromRoute] string id);

        [Post("/Channel")]
        Task<CreateChannelCommandResponse> Post([FromBody] CreateChannelCommandRequest requestModel);

        [Put("/Channel")]
        Task<EmptyResponse?> Put([FromBody] UpdateChannelCommandRequest requestModel);
        [Delete("/Channel/{id}")]
        Task<EmptyResponse?> Delete([FromRoute] string id);
    }
}
