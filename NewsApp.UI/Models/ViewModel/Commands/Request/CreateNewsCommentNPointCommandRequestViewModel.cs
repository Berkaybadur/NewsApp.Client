
using System.Text.Json.Serialization;

namespace NewsApp.UI.Models.ViewModel
{
    public class CreateNewsCommentNPointCommandRequestViewModel
    {
        public string NewsId { get; set; }

        [JsonIgnore]
        public string UserId { get; set; }
        public string CommandText { get; set; }
        public int Point { get; set; }
    }
}