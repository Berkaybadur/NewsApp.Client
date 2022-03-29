using MediatR;

namespace NewsApp.Api.Client
{
    public class DeleteNewsNewsTagMapCommandRequest : IRequest<EmptyResponse>
    {
        public string Id { get; set; }

        public string NewsId { get; set; }
    }
}
