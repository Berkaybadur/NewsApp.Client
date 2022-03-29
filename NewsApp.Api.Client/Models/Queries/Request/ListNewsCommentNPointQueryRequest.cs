using MediatR;

using System.Collections.Generic;

namespace NewsApp.Api.Client
{
    public class ListNewsCommentNPointQueryRequest : IRequest<IEnumerable<ListNewsCommentNPointQueryResponse>>
    {
        public string NewsId { get; set; }
    }
}
