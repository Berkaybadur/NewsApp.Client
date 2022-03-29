using System;
using System.Collections.Generic;

namespace NewsApp.Api.Client.RssReader.RssModel
{
    public class BaseFeed
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Url { get; set; }
        public string WebsiteUrl { get; set; }
        public string ImageUrl { get; set; } = null;
        public DateTime LastUpdate { get; set; }
        public List<BaseFeedItem> BaseFeedItems { get; set; }
    }
}
