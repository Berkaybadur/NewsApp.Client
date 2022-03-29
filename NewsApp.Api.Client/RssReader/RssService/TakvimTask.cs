using NewsApp.Api.Client.Refit.Dependency;
using NewsApp.Api.Client.RssReader.Helper;
using System;
using System.Threading.Tasks;
using System.Xml;

namespace NewsApp.Api.Client.RssReader.RssService
{
    public class TakvimTask
    {
        public NewsHelper _newsHelper;

        public TakvimTask(NewsHelper newsHelper)
        {
            _newsHelper = newsHelper;
        }

        public async Task TakvimRssFeedTask(string id)
        {

            var doc = await XmlDownload(id);

        }

        private Task XmlParser(XmlDocument xml)
        {
            throw new NotImplementedException();
        }

        private async Task<XmlDocument> XmlDownload(string id)
        {
            var response = await RefitApiServiceDependency.ChannelCategoryMapApi.List(new ListChannelCategoryMapQueryRequest
            {
                ChannelId = id
            });

            foreach (var item in response)
            {
                var xmlPath = item.XmlPath;

                var channelcategromapid = item.Id;// channelcategromapid
                var ProviderNewsId = "ProviderNewsId";// channelcategromapid
                var haber = RefitApiServiceDependency.NewsApi.Get(ProviderNewsId);
                if (haber == null)
                {
                    CreateNewsCommandRequest request = new CreateNewsCommandRequest
                    {
                        ChannelCategoryMapId = channelcategromapid
                    };

                    await _newsHelper.CreateNewsGenerateModel(request);
                }
                else
                {
                    var request = new UpdateNewsCommandRequest();
                    await _newsHelper.UpdateNewsGenerateModel(request);
                }
            }

            return new XmlDocument();
        }
    }
}
