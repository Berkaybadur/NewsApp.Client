
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace NewsApp.UI.Models.ViewModel
{
    public class CreateNewsImageCommandRequestViewModel
    {
        public string NewsId { get; set; }
        public string ImagePath { get; set; }
        public int DisplayOrder { get; set; }
        public List<SelectListItem> NewsIds { get; set; }

    }
}
