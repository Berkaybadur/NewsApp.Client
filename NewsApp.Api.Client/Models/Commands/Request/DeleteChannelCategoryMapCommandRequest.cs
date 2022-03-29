using MediatR;


namespace NewsApp.Api.Client
{
    public class DeleteChannelCategoryMapCommandRequest : IRequest<EmptyResponse>
    {
        public string Id { get; set; }
    }
}
