using MediatR;


namespace NewsApp.Api.Client
{
    public class GetCategoryQueryRequest : IRequest<CategoryQueryResponse>
    {
        public string Id { get; set; }
    }
}