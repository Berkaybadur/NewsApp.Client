using MediatR;


namespace NewsApp.Api.Client
{
    public class CreateNewsNewsTagMapCommandRequest : IRequest<CreateNewsNewsTagMapCommandResponse>
    {
        public string NewsId { get; set; }
        public string TagId { get; set; }
    }
}
