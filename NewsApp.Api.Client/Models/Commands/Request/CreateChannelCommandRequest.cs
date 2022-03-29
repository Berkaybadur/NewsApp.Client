using MediatR;


namespace NewsApp.Api.Client
{
    public class CreateChannelCommandRequest : IRequest<CreateChannelCommandResponse>
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string ImagePath { get; set; }
        public int DisplayOrder { get; set; }

    }
}