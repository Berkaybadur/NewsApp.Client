using MediatR;


namespace NewsApp.Api.Client
{
    public class UpdateNewsNewsTagMapCommandRequest : IRequest<EmptyResponse>
    {
        public string Id { get; set; }
        public string NewsId { get; set; }
        public string TagId { get; set; }
    }
}
