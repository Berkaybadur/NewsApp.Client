
namespace NewsApp.UI.Models.ViewModel
{
    public class CreateChannelCommandRequestViewModel
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string ImagePath { get; set; }
        public int DisplayOrder { get; set; }

    }
}