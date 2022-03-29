

using System.ComponentModel.DataAnnotations;

namespace NewsApp.UI.Models.ViewModel
{
    public class UpdateUserCommandRequestViewModel
    {
        public string Id { get; set; }
        [Required]
        public string Email { get; set; }
        public string AppId { get; set; }
    }
}
