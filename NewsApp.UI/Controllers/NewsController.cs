using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NewsApp.Api.Client;
using NewsApp.Api.Client.Refit.Dependency;
using NewsApp.UI.Models.ViewModel;
using System.Collections.Generic;

namespace NewsApp.UI.Controllers
{
    public class NewsController : Controller
    {
        private readonly IMapper _mapper;
        public NewsController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            List<string> channelCategoryMapIds = new List<string> { "62058959e660d4a0d70ad79f" };

            ListNewsQueryRequest listNewsQueryRequest = new ListNewsQueryRequest()
            {
                ChannelCategoryMapIds = channelCategoryMapIds
            };
            var response = RefitApiServiceDependency.NewsApi.List(listNewsQueryRequest);
            if (response.Exception == null)
            {
                var result = _mapper.Map<List<ListNewsQueryResponseViewModel>>(response.Result);
                return View(result);
            }
            else
            {
                return RedirectToAction("Error");
            }
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateNewsCommandRequestViewModel createNewsCommandRequestViewModel)
        {
            var resultRequest = _mapper.Map<CreateNewsCommandRequest>(createNewsCommandRequestViewModel);
            var response = RefitApiServiceDependency.NewsApi.Post(resultRequest);
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
            var response = RefitApiServiceDependency.NewsApi.Get(id);
            if (response.Exception == null)
            {
                var result = response.Result;
                return View(result);
            }
            else
            {
                return RedirectToAction("Error");
            }
        }
        [HttpPost]
        public IActionResult Edit(UpdateNewsCommandRequestViewModel updateNewsCommandRequestViewModel)
        {
            var resultRequest = _mapper.Map<UpdateNewsCommandRequest>(updateNewsCommandRequestViewModel);
            var response = RefitApiServiceDependency.NewsApi.Put(resultRequest);
            if (response.Exception == null)
            {
                TempData["Message"] = updateNewsCommandRequestViewModel.Id + "'li channel güncellendi .";
                var responseList = RefitApiServiceDependency.NewsApi.List(new ListNewsQueryRequest
                {
                });
                if (responseList.Exception == null)
                {
                    var result = _mapper.Map<List<ListNewsQueryResponseViewModel>>(responseList.Result);
                    return View("~/Views/News/Index.cshtml", result);
                }
                else
                {
                    return RedirectToAction("Error");
                }

            }
            else
            {
                return RedirectToAction("Error");
            }

        }
        public IActionResult Remove(string id)
        {
            var response = RefitApiServiceDependency.NewsApi.Delete(id);
            if (response.Exception == null)
            {
                TempData["Message"] = id + "li channel silindi .";
                var responseList = RefitApiServiceDependency.NewsApi.List(new ListNewsQueryRequest
                {
                });
                if (responseList.Exception == null)
                {
                    var result = _mapper.Map<List<ListNewsQueryResponseViewModel>>(responseList.Result);
                    return View("~/Views/Channel/Index.cshtml", result);
                }
                else
                {
                    return RedirectToAction("Error");
                }
            }
            else
            {
                return RedirectToAction("Error");
            }
        }
    }
}
