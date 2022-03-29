using Microsoft.AspNetCore.Mvc;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsApp.Api.Client.Refit.Interfaces
{
    [Headers("Content-Type: application/json; charset=UTF-8")]
    public interface IUserApi
    {
        [Get("/User")]
        Task<IEnumerable<ListUserQueryResponse>> List([FromQuery] ListUserQueryRequest requestModel);

        [Get("/User/{id}")]
        Task<UserQueryResponse> Get([FromRoute] string id);

        [Post("/User")]
        Task<CreateUserCommandResponse> Post([FromBody] CreateUserCommandRequest requestModel);

        [Put("/User")]
        Task<EmptyResponse?> Put([FromBody] UpdateUserCommandRequest requestModel);

        [Delete("/User/{id}")]
        Task<EmptyResponse?> Delete([FromRoute] string id);
    }
}
