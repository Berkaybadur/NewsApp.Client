using System;

namespace NewsApp.UI.Models.ViewModel
{
    public class ChannelQueryResponseViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string ImagePath { get; set; }
        public DateTime CreatedDate { get; set; }
        public int DisplayOrder { get; set; }

    }
}