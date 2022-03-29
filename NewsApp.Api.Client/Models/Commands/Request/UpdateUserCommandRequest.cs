using MediatR;

using System.ComponentModel.DataAnnotations;

namespace NewsApp.Api.Client
{
    public class UpdateUserCommandRequest : IRequest<EmptyResponse>
    {
        public string Id { get; set; }
        [Required]
        public string Email { get; set; }
        public string AppId { get; set; }
    }
}
