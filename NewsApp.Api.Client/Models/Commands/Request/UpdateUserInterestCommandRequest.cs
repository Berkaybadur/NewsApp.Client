using MediatR;

using System.Text.Json.Serialization;

namespace NewsApp.Api.Client
{
    public class UpdateUserInterestCommandRequest : IRequest<EmptyResponse>
    {
        public int Id { get; set; }
        public string ChannelCategoryMapId { get; set; }
        [JsonIgnore]
        public string UserId { get; set; }
    }
}
