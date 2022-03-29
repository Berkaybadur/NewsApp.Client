﻿


using System.Collections.Generic;

namespace NewsApp.UI.Models.ViewModel
{
    public class ListNewsQueryRequestViewModel
    {
        public ListNewsQueryRequestViewModel()
        {
            ChannelCategoryMapIds = new List<string>();
        }
        public string NewsId { get; set; }
        public string Title { get; set; }
        public string ProviderNewsId { get; set; }
        public List<string> ChannelCategoryMapIds { get; set; }
    }
}
