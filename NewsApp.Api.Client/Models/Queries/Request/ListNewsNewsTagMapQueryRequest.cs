using MediatR;

using System.Collections.Generic;

namespace NewsApp.Api.Client
{
    public class ListNewsNewsTagMapQueryRequest : IRequest<IEnumerable<ListNewsNewsTagMapQueryResponse>>
    {
        public string NewsId { get; set; }
    }
}
