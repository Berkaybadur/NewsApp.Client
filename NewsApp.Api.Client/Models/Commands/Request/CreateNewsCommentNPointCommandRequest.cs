using MediatR;

using System.Text.Json.Serialization;

namespace NewsApp.Api.Client
{
    public class CreateNewsCommentNPointCommandRequest : IRequest<CreateNewsCommentNPointCommandResponse>
    {
        public string NewsId { get; set; }

        [JsonIgnore]
        public string UserId { get; set; }
        public string CommandText { get; set; }
        public int Point { get; set; }
    }
}