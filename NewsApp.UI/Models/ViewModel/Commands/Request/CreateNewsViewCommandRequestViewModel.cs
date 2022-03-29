
using System.Text.Json.Serialization;

namespace NewsApp.UI.Models.ViewModel
{
    public class CreateNewsViewCommandRequestViewModel
    {
        public string NewsId { get; set; }

        [JsonIgnore]
        public string UserId { get; set; }
    }
}
