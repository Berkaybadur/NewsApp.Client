using MediatR;


namespace NewsApp.Api.Client
{
    public class DeleteSearchHistoryCommandRequest : IRequest<EmptyResponse>
    {
        public string Id { get; set; }
    }
}
