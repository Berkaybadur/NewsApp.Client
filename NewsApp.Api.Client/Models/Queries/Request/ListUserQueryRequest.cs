using MediatR;

using System.Collections.Generic;

namespace NewsApp.Api.Client
{
    public class ListUserQueryRequest : IRequest<IEnumerable<ListUserQueryResponse>>
    {
        public string Email { get; set; }
    }
}
