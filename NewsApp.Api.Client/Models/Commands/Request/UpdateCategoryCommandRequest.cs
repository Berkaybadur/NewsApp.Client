using MediatR;

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NewsApp.Api.Client
{
    public class UpdateCategoryCommandRequest : IRequest<EmptyResponse>
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }
        [JsonIgnore]
        public string UserId { get; set; }
    }
}