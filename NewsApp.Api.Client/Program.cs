using AutoMapper;
using NewsApp.Api.Client.Refit.Dependency;
using NewsApp.Api.Client.RssReader.Helper;
using NewsApp.Api.Client.RssReader.RssParser;
using NewsApp.Api.Client.RssReader.RssService;
using System.Collections.Generic;

namespace NewsApp.Api.Client
{
    class Program
    {
        public static IMapper _mapper;
        public Program(IMapper mapper)
        {
            _mapper = mapper;
        }
        static void Main(string[] args)
        {
            var rr = RefitApiServiceDependency.NewsApi.Delete("62103a1d7f6c4105d137bf63");
            var aa = rr.Result;
            //ListNewsQueryRequest listNewsQueryRequest = new ListNewsQueryRequest()
            //{
            //    ChannelCategoryMapIds = channelCategoryMapIds
            //};
            //var newss = RefitApiServiceDependency.NewsApi.List(listNewsQueryRequest);
            //var ress = newss.Result;

            //foreach (var res in ress)
            //{
            //    RefitApiServiceDependency.NewsApi.Delete(res.Id);

            //}

            List<CreateNewsCommandRequest> createNewsCommandRequests = new List<CreateNewsCommandRequest>();

            MilliyetTask milliyetTask = new MilliyetTask();
            var channel = milliyetTask.GetChannelId("star");
            var channelCategoryMaps = milliyetTask.GetChannelXmlPath(channel.Id);
            foreach (var channelCategoryMap in channelCategoryMaps)
            {
                var feed = milliyetTask.ReadFeed(channelCategoryMap.XmlPath);
                var baseFeedItems = RssHelper.GenerateBaseFeedItem(feed, channelCategoryMap.XmlPath);
                createNewsCommandRequests.AddRange(baseFeedItems);
            }




            NewsHelper newsHelper = new NewsHelper();
            foreach (var createNewsCommandRequest in createNewsCommandRequests)
            {
                //var news = _mapper.Map<CreateNewsCommandRequest>(baseFeedItem);

                var response = newsHelper.CreateNewsGenerateModel(createNewsCommandRequest);
                var result = response.Result;
            }

        }
    }
}

