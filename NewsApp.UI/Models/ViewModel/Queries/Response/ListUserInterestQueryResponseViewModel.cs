using System;

namespace NewsApp.UI.Models.ViewModel
{
    public class ListUserInterestQueryResponseViewModel
    {
        public string Id { get; set; }
        public string ChannelCategoryMapId { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
