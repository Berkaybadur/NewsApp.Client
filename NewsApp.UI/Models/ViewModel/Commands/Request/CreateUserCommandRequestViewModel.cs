
using System.Text.Json.Serialization;

namespace NewsApp.UI.Models.ViewModel
{
    public class CreateUserCommandRequestViewModel
    {
        public string Email { get; set; }
        [JsonIgnore]
        public string AppId { get; set; }
    }
}
