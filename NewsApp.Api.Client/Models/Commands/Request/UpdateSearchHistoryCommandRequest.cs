using MediatR;


namespace NewsApp.Api.Client
{
    public class UpdateSearchHistoryCommandRequest : IRequest<EmptyResponse>
    {
        public string Id { get; set; }
        public string SearchText { get; set; }
    }
}
