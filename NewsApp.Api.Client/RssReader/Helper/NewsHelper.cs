using NewsApp.Api.Client.Refit.Dependency;
using System.Threading.Tasks;

namespace NewsApp.Api.Client.RssReader.Helper
{
    public class NewsHelper
    {
        public async Task<CreateNewsCommandResponse> CreateNewsGenerateModel(CreateNewsCommandRequest request)
        {
            request.ChannelCategoryMapId = "62058959e660d4a0d70ad79f";
            request.Language = "tr";

            return await RefitApiServiceDependency.NewsApi.Post(request);
        }

        public async Task<EmptyResponse> UpdateNewsGenerateModel(UpdateNewsCommandRequest request)
        {
            return await RefitApiServiceDependency.NewsApi.Put(request);
        }

    }
}
