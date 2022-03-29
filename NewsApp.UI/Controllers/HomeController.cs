using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewsApp.Api.Client;
using NewsApp.Api.Client.Refit.Dependency;
using NewsApp.UI.Models;
using NewsApp.UI.Models.ViewModel;
using System.Diagnostics;
using System.Linq;

namespace NewsApp.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            var list = RefitApiServiceDependency.NewsApi.List(new ListNewsQueryRequest() { ChannelCategoryMapIds = null });
            var news = list.Result;
            // model maplenmesi gerek 
            // ChannelCategoryMapId yerine channel id ve category yazılsa daha sık olur

            var liste = RefitApiServiceDependency.ChannelCategoryMapApi.List(new ListChannelCategoryMapQueryRequest
            {
            });
            var ccmap = liste.Result;
            var ltagiste = RefitApiServiceDependency.TagApi.List(new ListTagQueryRequest
            {
            });
            var tag = ltagiste.Result;


            var commentr = RefitApiServiceDependency.NewsApi.GetAllNewsCommentNPoint(new ListNewsCommentNPointQueryRequest
            {
            });
            var commentNPoint = commentr.Result;

            var listec = RefitApiServiceDependency.ChannelApi.List(new ListChannelQueryRequest
            {
            });
            var channel = listec.Result;

            var listeca = RefitApiServiceDependency.CategoryApi.List(new ListCategoryQueryRequest
            {
            });
            var category = listeca.Result;

            var result = new HomeIndexViewModel
            {
                NewsCount = news.Count(),
                CategoryCount = category.Count(),
                ChannelCount = channel.Count(),
                CommentNPointCount = commentNPoint.Count(),
                TagCount = tag.Count()
            };
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
