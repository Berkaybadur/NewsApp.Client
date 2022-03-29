
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace NewsApp.UI.Models.ViewModel
{
    public class CreateNewsNewsTagMapCommandRequestViewModel
    {
        public string NewsId { get; set; }
        public string TagId { get; set; }
        public List<SelectListItem> NewsIds { get; set; }
        public List<SelectListItem> NewsTagIds { get; set; }

    }
}
