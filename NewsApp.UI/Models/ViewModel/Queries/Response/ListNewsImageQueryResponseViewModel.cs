using System;

namespace NewsApp.UI.Models.ViewModel
{
    public class ListNewsImageQueryResponseViewModel
    {
        public string Id { get; set; }
        public string NewsId { get; set; }
        public string ImagePath { get; set; }
        public DateTime CreatedDate { get; set; }
        public int DisplayOrder { get; set; }

    }
}
