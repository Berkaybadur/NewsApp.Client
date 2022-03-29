using System;
using System.Collections.Generic;

namespace NewsApp.Api.Client.RssReader.RssModel
{
    public class BaseFeedItem
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public DateTime Published { get; set; }
        public string Creator { get; set; }
        public string Category { get; set; }
        public string Encoded { get; set; }
        public string Language { get; set; }
        public string XmlPath { get; set; }
        public string ChannelCategoryMapId { get; set; }
        public int DisplayOrder { get; set; }
        public List<string> ImageUrls { get; set; } = null;
    }
}
