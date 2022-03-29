using MediatR;


namespace NewsApp.Api.Client
{
    public class DeleteUserInterestCommandRequest : IRequest<EmptyResponse>
    {
        public string Id { get; set; }
    }
}
