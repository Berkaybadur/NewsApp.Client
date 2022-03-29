using System;

namespace NewsApp.UI.Models.ViewModel
{
    public class ListCategoryQueryResponseViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int DisplayOrder { get; set; }

    }
}