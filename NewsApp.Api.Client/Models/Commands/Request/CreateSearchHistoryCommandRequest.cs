using MediatR;


namespace NewsApp.Api.Client
{
    public class CreateSearchHistoryCommandRequest : IRequest<CreateSearchHistoryCommandResponse>
    {
        public string SearchText { get; set; }
    }
}
