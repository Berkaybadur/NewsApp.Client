using MediatR;

using System.Collections.Generic;

namespace NewsApp.Api.Client
{
    public class ListCategoryQueryRequest : IRequest<IEnumerable<ListCategoryQueryResponse>>
    {
        public string Name { get; set; }
    }
}