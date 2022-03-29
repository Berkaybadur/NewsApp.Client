using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NewsApp.Api.Client;
using NewsApp.Api.Client.Refit.Dependency;
using NewsApp.UI.Models.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace NewsApp.UI.Controllers
{
    public class NewsNewsTagMapController : Controller
    {
        private readonly IMapper _mapper;
        public NewsNewsTagMapController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var response = RefitApiServiceDependency.NewsNewsTagMapApi.List(new ListNewsNewsTagMapQueryRequest
            {
            });
            if (response.Exception == null)
            {
                var result = _mapper.Map<List<ListNewsNewsTagMapQueryResponseViewModel>>(response.Result);
                return View(result);
            }
            else
            {
                return RedirectToAction("Error");
            }
        }
        public IActionResult Create()
        {
            var model = new CreateNewsNewsTagMapCommandRequestViewModel()
            {
                NewsIds = PrepareBookerDestinationNews(),
                NewsTagIds = PrepareBookerDestinationNewsTag()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(CreateNewsNewsTagMapCommandRequestViewModel createNewsNewsTagMapCommandRequestViewModel)
        {
            var result = _mapper.Map<CreateNewsNewsTagMapCommandRequest>(createNewsNewsTagMapCommandRequestViewModel);
            var response = RefitApiServiceDependency.NewsNewsTagMapApi.Post(result);
            if (response.Exception == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Error");
            }
        }
        public IActionResult Edit(string id)
        {
            var responseEdit = RefitApiServiceDependency.NewsNewsTagMapApi.Get(id);

            if (responseEdit.Exception == null)
            {
                var result = _mapper.Map<NewsNewsTagMapQueryResponseViewModel>(responseEdit.Result);
                result.NewsIds = PrepareBookerDestinationNews();
                result.NewsTagIds = PrepareBookerDestinationNewsTag();
                return View(result);
            }
            else
            {
                return RedirectToAction("Error");
            }


        }
        [HttpPost]
        public IActionResult Edit(UpdateNewsNewsTagMapCommandRequestViewModel updateNewsNewsTagMapCommandRequestViewModel)
        {
            var result = _mapper.Map<UpdateNewsNewsTagMapCommandRequest>(updateNewsNewsTagMapCommandRequestViewModel);
            var responseUpdate = RefitApiServiceDependency.NewsNewsTagMapApi.Put(result);

            TempData["Message"] = updateNewsNewsTagMapCommandRequestViewModel.Id + "'li kategori güncellendi .";

            var responseList = RefitApiServiceDependency.NewsNewsTagMapApi.List(new ListNewsNewsTagMapQueryRequest
            {
            });

            if (responseList.Exception == null)
            {
                var listNewsNewsTagMapQueryResponseViewModel = _mapper.Map<List<ListNewsNewsTagMapQueryResponseViewModel>>(responseList.Result);
                return View("~/Views/NewsNewsTagMap/Index.cshtml", listNewsNewsTagMapQueryResponseViewModel);
            }
            else
            {
                return RedirectToAction("Error");
            }

        }
        public IActionResult Remove(string id)
        {
            var responseDelete = RefitApiServiceDependency.NewsNewsTagMapApi.Delete(id);

            TempData["Message"] = id + "'li kategori silindi .";

            var responseList = RefitApiServiceDependency.NewsNewsTagMapApi.List(new ListNewsNewsTagMapQueryRequest
            {
            });

            if (responseList.Exception == null)
            {
                var listNewsNewsTagMapQueryResponseViewModel = _mapper.Map<List<ListNewsNewsTagMapQueryResponseViewModel>>(responseList.Result);
                return View("~/Views/NewsNewsTagMap/Index.cshtml", listNewsNewsTagMapQueryResponseViewModel);
            }
            else
            {
                return RedirectToAction("Error");
            }
        }
        private List<SelectListItem> PrepareBookerDestinationNews()
        {
            List<string> channelCategoryMapIds = new List<string> { "62058959e660d4a0d70ad79f" };

            ListNewsQueryRequest listNewsQueryRequest = new ListNewsQueryRequest()
            {
                ChannelCategoryMapIds = channelCategoryMapIds
            };
            var bookerDestination = RefitApiServiceDependency.NewsApi.List(listNewsQueryRequest);
            var typeSelectListItems = bookerDestination.Result.ToList().Select(x => new SelectListItem { Text = x.Title, Value = x.Id.ToString() }).ToList();
            return typeSelectListItems;
        }
        private List<SelectListItem> PrepareBookerDestinationNewsTag()
        {
            var bookerDestination = RefitApiServiceDependency.TagApi.List(new ListTagQueryRequest
            {
            });
            var typeSelectListItems = bookerDestination.Result.ToList().Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
            return typeSelectListItems;
        }
    }
}
