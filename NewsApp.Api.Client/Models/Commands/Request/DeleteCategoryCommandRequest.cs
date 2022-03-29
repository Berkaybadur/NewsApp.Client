using MediatR;


namespace NewsApp.Api.Client
{
    public class DeleteCategoryCommandRequest : IRequest<EmptyResponse>
    {
        public string Id { get; set; }
    }
}