using MediatR;

using System.Collections.Generic;

namespace NewsApp.Api.Client
{
    public class ListNewsViewQueryRequest : IRequest<IEnumerable<ListNewsViewQueryResponse>>
    {
        public string NewsId { get; set; }
    }
}
