using MediatR;

using System.Collections.Generic;

namespace NewsApp.Api.Client
{
    public class ListNewsQueryRequest : IRequest<IEnumerable<ListNewsQueryResponse>>
    {
        public ListNewsQueryRequest()
        {
            ChannelCategoryMapIds = new List<string>();
        }
        public string NewsId { get; set; }
        public string Title { get; set; }
        public string ProviderNewsId { get; set; }
        public List<string> ChannelCategoryMapIds { get; set; }
    }
}
