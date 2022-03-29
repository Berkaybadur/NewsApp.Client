using CodeHollow.FeedReader;
using NewsApp.Api.Client.Refit.Dependency;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace NewsApp.Api.Client.RssReader.RssParser
{
    public abstract class Parser
    {
        public Feed ReadFeed(string url)
        {
            return FeedReader.Read(url);
        }

        public XDocument ParseItem(string originalDocument)
        {
            return XDocument.Parse(originalDocument);
        }

        public ListChannelQueryResponse GetChannelId(string channelName)
        {
            ListChannelQueryRequest listChannelQueryRequest = new ListChannelQueryRequest()
            {
                Name = channelName
            };
            return RefitApiServiceDependency.ChannelApi.List(listChannelQueryRequest).Result.First();
        }

        public List<ListChannelCategoryMapQueryResponse> GetChannelXmlPath(string id)
        {

            ListChannelCategoryMapQueryRequest listChannelCategoryMapQueryRequest = new ListChannelCategoryMapQueryRequest()
            {
                ChannelId = id,
                CategoryId = ""
            };
            return RefitApiServiceDependency.ChannelCategoryMapApi.List(listChannelCategoryMapQueryRequest).Result.ToList();
        }


    }
}
