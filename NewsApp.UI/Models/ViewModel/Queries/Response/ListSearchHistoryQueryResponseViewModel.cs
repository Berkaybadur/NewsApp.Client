using System;

namespace NewsApp.UI.Models.ViewModel
{
    public class ListSearchHistoryQueryResponseViewModel
    {
        public string Id { get; set; }
        public string SearchText { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
