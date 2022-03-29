

using System.ComponentModel.DataAnnotations;

namespace NewsApp.UI.Models.ViewModel
{
    public class UpdateChannelCommandRequestViewModel
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Url { get; set; }
        public string ImagePath { get; set; }
        public int DisplayOrder { get; set; }
    }
}