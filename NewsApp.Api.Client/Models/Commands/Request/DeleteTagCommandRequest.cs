using MediatR;


namespace NewsApp.Api.Client
{
    public class DeleteTagCommandRequest : IRequest<EmptyResponse>
    {
        public string Id { get; set; }
    }
}
