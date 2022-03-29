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
    public class NewsImageController : Controller
    {
        private readonly IMapper _mapper;
        public NewsImageController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var response = RefitApiServiceDependency.NewsImageApi.List(new ListNewsImageQueryRequest
            {
            });
            if (response.Exception == null)
            {
                var result = _mapper.Map<List<ListNewsImageQueryResponseViewModel>>(response.Result);
                return View(result);
            }
            else
            {
                return RedirectToAction("Error");
            }
        }
        public IActionResult Create()
        {
            var model = new CreateNewsImageCommandRequestViewModel()
            {
                NewsIds = PrepareBookerDestinationNews()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(CreateNewsImageCommandRequestViewModel createNewsImageCommandRequestViewModel)
        {
            var result = _mapper.Map<CreateNewsImageCommandRequest>(createNewsImageCommandRequestViewModel);
            var response = RefitApiServiceDependency.NewsImageApi.Post(result);
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
            var responseEdit = RefitApiServiceDependency.NewsImageApi.Get(id);

            if (responseEdit.Exception == null)
            {
                var result = _mapper.Map<NewsImageQueryResponseViewModel>(responseEdit.Result);
                result.NewsIds = PrepareBookerDestinationNews();
                return View(result);
            }
            else
            {
                return RedirectToAction("Error");
            }


        }
        [HttpPost]
        public IActionResult Edit(UpdateNewsImageCommandRequestViewModel updateNewsImageCommandRequestViewModel)
        {
            var result = _mapper.Map<UpdateNewsImageCommandRequest>(updateNewsImageCommandRequestViewModel);
            var responseUpdate = RefitApiServiceDependency.NewsImageApi.Put(result);

            TempData["Message"] = updateNewsImageCommandRequestViewModel.Id + "'li kategori güncellendi .";

            var responseList = RefitApiServiceDependency.NewsImageApi.List(new ListNewsImageQueryRequest
            {
            });

            if (responseList.Exception == null)
            {
                var listNewsImageQueryResponseViewModel = _mapper.Map<List<ListNewsImageQueryResponseViewModel>>(responseList.Result);
                return View("~/Views/NewsImage/Index.cshtml", listNewsImageQueryResponseViewModel);
            }
            else
            {
                return RedirectToAction("Error");
            }

        }
        public IActionResult Remove(string id)
        {
            var responseDelete = RefitApiServiceDependency.NewsImageApi.Delete(id);

            TempData["Message"] = id + "'li kategori silindi .";

            var responseList = RefitApiServiceDependency.NewsImageApi.List(new ListNewsImageQueryRequest
            {
            });

            if (responseList.Exception == null)
            {
                var listNewsImageQueryResponseViewModel = _mapper.Map<List<ListNewsImageQueryResponseViewModel>>(responseList.Result);
                return View("~/Views/NewsImage/Index.cshtml", listNewsImageQueryResponseViewModel);
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
    }
}
