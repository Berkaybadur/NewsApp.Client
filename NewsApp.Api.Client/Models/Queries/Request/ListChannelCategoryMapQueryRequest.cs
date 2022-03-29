using MediatR;

using System.Collections.Generic;

namespace NewsApp.Api.Client
{
    public class ListChannelCategoryMapQueryRequest : IRequest<IEnumerable<ListChannelCategoryMapQueryResponse>>
    {
        public string ChannelId { get; set; }
        public string CategoryId { get; set; }
    }
}
