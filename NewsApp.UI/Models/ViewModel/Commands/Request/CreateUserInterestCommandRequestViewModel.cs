

using System.Text.Json.Serialization;

namespace NewsApp.UI.Models.ViewModel
{
    public class CreateUserInterestCommandRequestViewModel
    {
        public string ChannelCategoryMapId { get; set; }
        [JsonIgnore]
        public string UserId { get; set; }
    }
}
