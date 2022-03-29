using MediatR;

using System.Collections.Generic;

namespace NewsApp.Api.Client
{
    public class ListNewsImageQueryRequest : IRequest<IEnumerable<ListNewsImageQueryResponse>>
    {
        public string NewsId { get; set; }
    }
}
