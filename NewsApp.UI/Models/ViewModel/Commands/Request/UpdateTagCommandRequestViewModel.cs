

using System.ComponentModel.DataAnnotations;

namespace NewsApp.UI.Models.ViewModel
{
    public class UpdateTagCommandRequestViewModel
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }

    }
}
