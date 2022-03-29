using MediatR;

using System.ComponentModel.DataAnnotations;

namespace NewsApp.Api.Client
{
    public class UpdateTagCommandRequest : IRequest<EmptyResponse>
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }

    }
}
