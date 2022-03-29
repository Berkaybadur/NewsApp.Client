using Microsoft.AspNetCore.Mvc;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsApp.Api.Client.Refit.Interfaces
{
    [Headers("Content-Type: application/json; charset=UTF-8")]
    public interface IChannelCategoryMapApi
    {
        [Get("/ChannelCategoryMap")]
        Task<IEnumerable<ListChannelCategoryMapQueryResponse>> List([FromQuery] ListChannelCategoryMapQueryRequest requestModel);

        [Get("/ChannelCategoryMap/{id}")]
        Task<ChannelCategoryMapQueryResponse> Get([FromRoute] string id);

        [Post("/ChannelCategoryMap")]
        Task<CreateChannelCategoryMapCommandResponse> Post([FromBody] CreateChannelCategoryMapCommandRequest requestModel);

        [Put("/ChannelCategoryMap")]
        Task<EmptyResponse?> Put([FromBody] UpdateChannelCategoryMapCommandRequest requestModel);

        [Delete("/ChannelCategoryMap/{id}")]
        Task<EmptyResponse?> Delete([FromRoute] string id);
    }
}
