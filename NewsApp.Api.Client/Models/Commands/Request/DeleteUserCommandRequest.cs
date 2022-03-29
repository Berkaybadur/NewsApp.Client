using MediatR;


namespace NewsApp.Api.Client
{
    public class DeleteUserCommandRequest : IRequest<EmptyResponse>
    {
        public string Id { get; set; }
    }
}
