using MediatR;

using System.Collections.Generic;

namespace NewsApp.Api.Client
{
    public class ListUserInterestQueryRequest : IRequest<IEnumerable<ListUserInterestQueryResponse>>
    {
        public string UserId { get; set; }
    }
}
