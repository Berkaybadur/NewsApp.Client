using MediatR;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NewsApp.Api.Client
{
    public class CreateCategoryCommandRequest : IRequest<CreateCategoryCommandResponse>
    {
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        [JsonIgnore]
        public string UserId { get; set; }
    }
}