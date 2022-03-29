using MediatR;

using System.Collections.Generic;

namespace NewsApp.Api.Client
{
    public class ListTagQueryRequest : IRequest<IEnumerable<ListTagQueryResponse>>
    {
        public string NewsId { get; set; }
        public string Name { get; set; }
    }
}
