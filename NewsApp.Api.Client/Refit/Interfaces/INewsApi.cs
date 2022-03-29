using Microsoft.AspNetCore.Mvc;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsApp.Api.Client.Refit.Interfaces
{
    [Headers("Content-Type: application/json; charset=UTF-8")]
    public interface INewsApi
    {
        [Get("/News")]
        Task<IEnumerable<ListNewsQueryResponse>> List([FromQuery] ListNewsQueryRequest request);

        [Get("/News/AllNewsView")]
        Task<IEnumerable<ListNewsViewQueryResponse>> GetAllNewsView([FromQuery] ListNewsViewQueryRequest requestModel);

        [Post("/News/NewsCategoryAll")]
        Task<IEnumerable<ListNewsQueryResponse>> ListRelation([FromBody] ListNewsQueryRequest request);

        [Get("/News/{id}")]
        Task<NewsQueryResponse> Get([FromRoute] string id);

        [Post("/News/NewNews")]
        Task<CreateNewsCommandResponse> Post([FromBody] CreateNewsCommandRequest request);

        [Post("/News/newsView")]
        Task<CreateNewsViewCommandResponse> CreateNewsView([FromBody] CreateNewsViewCommandRequest request);

        [Put("/News")]
        Task<EmptyResponse?> Put([FromBody] UpdateNewsCommandRequest request);

        [Delete("/News/{id}")]
        Task<EmptyResponse?> Delete([FromRoute] string id);

        [Get("/News/AllNewsCommentNPoint")]
        Task<IEnumerable<ListNewsCommentNPointQueryResponse>> GetAllNewsCommentNPoint([FromQuery] ListNewsCommentNPointQueryRequest request);
    }
}
