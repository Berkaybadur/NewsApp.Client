using MediatR;

using System.ComponentModel.DataAnnotations;

namespace NewsApp.Api.Client
{
    public class UpdateChannelCommandRequest : IRequest<EmptyResponse>
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Url { get; set; }
        public string ImagePath { get; set; }
        public int DisplayOrder { get; set; }
    }
}