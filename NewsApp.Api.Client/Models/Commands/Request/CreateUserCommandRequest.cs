using MediatR;

using System.Text.Json.Serialization;

namespace NewsApp.Api.Client
{
    public class CreateUserCommandRequest : IRequest<CreateUserCommandResponse>
    {
        public string Email { get; set; }
        [JsonIgnore]
        public string AppId { get; set; }
    }
}
