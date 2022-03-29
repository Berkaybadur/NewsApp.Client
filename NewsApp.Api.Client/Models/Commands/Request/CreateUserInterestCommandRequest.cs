using MediatR;

using System.Text.Json.Serialization;

namespace NewsApp.Api.Client
{
    public class CreateUserInterestCommandRequest : IRequest<CreateUserInterestCommandResponse>
    {
        public string ChannelCategoryMapId { get; set; }
        [JsonIgnore]
        public string UserId { get; set; }
    }
}
