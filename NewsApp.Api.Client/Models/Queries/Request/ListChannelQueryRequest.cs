using MediatR;

using System.Collections.Generic;

namespace NewsApp.Api.Client
{
    public class ListChannelQueryRequest : IRequest<IEnumerable<ListChannelQueryResponse>>
    {
        public string Name { get; set; }
    }
}