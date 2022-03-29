

using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace NewsApp.UI.Models.ViewModel
{
    public class CreateChannelCategoryMapCommandRequestViewModel
    {
        public string ChannelId { get; set; }
        public string CategoryId { get; set; }
        public string XmlPath { get; set; }
        public List<SelectListItem> ChannelIds { get; set; }
        public List<SelectListItem> CategoryIds { get; set; }
    }
}
