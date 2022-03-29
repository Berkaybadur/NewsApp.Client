using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace NewsApp.UI.Models.ViewModel
{
    public class NewsImageQueryResponseViewModel
    {
        public string Id { get; set; }
        public string NewsId { get; set; }
        public string ImagePath { get; set; }
        public DateTime CreatedDate { get; set; }
        public string DisplayOrder { get; set; }
        public List<SelectListItem> NewsIds { get; set; }

    }
}
