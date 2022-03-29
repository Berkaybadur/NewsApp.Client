

using System.Text.Json.Serialization;

namespace NewsApp.UI.Models.ViewModel
{
    public class UpdateUserInterestCommandRequestViewModel
    {
        public int Id { get; set; }
        public string ChannelCategoryMapId { get; set; }
        [JsonIgnore]
        public string UserId { get; set; }
    }
}
