using MediatR;

using System.Collections.Generic;

namespace NewsApp.Api.Client
{
    public class ListSearchHistoryQueryRequest : IRequest<IEnumerable<ListSearchHistoryQueryResponse>>
    {
        public string SearchText { get; set; }
    }
}
