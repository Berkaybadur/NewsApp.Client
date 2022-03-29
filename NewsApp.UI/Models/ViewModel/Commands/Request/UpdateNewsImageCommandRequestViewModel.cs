


namespace NewsApp.UI.Models.ViewModel
{
    public class UpdateNewsImageCommandRequestViewModel
    {
        public string Id { get; set; }
        public string NewsId { get; set; }
        public string ImagePath { get; set; }
        public int DisplayOrder { get; set; }

    }
}
