using System.Collections.Generic;

namespace NewsApp.UI.Models.ViewModel
{
    public class ListNewsQueryResponseViewModel
    {
        public string Id { get; set; }
        public string ProviderNewsId { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public string XmlPath { get; set; }
        public int DisplayOrder { get; set; }
        public string ChannelCategoryMapId { get; set; }
        public IEnumerable<ListNewsImageQueryResponseViewModel> Images { get; set; }
        public IEnumerable<ListNewsCommentNPointQueryResponseViewModel> NewsCommentsNPoints { get; set; }
        public IEnumerable<ListTagQueryResponseViewModel> Tags { get; set; }
        public IEnumerable<ListNewsViewQueryResponseViewModel> NewsViews { get; set; }


    }
}
