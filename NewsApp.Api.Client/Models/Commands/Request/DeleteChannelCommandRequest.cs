using MediatR;


namespace NewsApp.Api.Client
{

    public class DeleteChannelCommandRequest : IRequest<EmptyResponse>
    {
        public string Id { get; set; }
    }
}