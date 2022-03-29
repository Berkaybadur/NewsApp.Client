using MediatR;


namespace NewsApp.Api.Client
{
    public class CreateTagCommandRequest : IRequest<CreateTagCommandResponse>
    {
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

    }
}
