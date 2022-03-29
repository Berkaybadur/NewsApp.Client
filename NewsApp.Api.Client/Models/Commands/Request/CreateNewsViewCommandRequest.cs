using MediatR;

using System.Text.Json.Serialization;

namespace NewsApp.Api.Client
{
    public class CreateNewsViewCommandRequest : IRequest<CreateNewsViewCommandResponse>
    {
        public string NewsId { get; set; }

        [JsonIgnore]
        public string UserId { get; set; }
    }
}
