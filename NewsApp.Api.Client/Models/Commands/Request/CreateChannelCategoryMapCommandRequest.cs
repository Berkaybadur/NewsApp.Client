using MediatR;


namespace NewsApp.Api.Client
{
    public class CreateChannelCategoryMapCommandRequest : IRequest<CreateChannelCategoryMapCommandResponse>
    {
        public string ChannelId { get; set; }
        public string CategoryId { get; set; }
        public string XmlPath { get; set; }
    }
}
