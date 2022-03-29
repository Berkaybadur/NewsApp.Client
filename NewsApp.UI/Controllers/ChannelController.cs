using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NewsApp.Api.Client;
using NewsApp.Api.Client.Refit.Dependency;
using NewsApp.UI.Models.ViewModel;
using System.Collections.Generic;

namespace NewsApp.UI.Controllers
{
    public class ChannelController : Controller
    {
        private readonly IMapper _mapper;
        public ChannelController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var response = RefitApiServiceDependency.ChannelApi.List(new ListChannelQueryRequest
            {
            });
            if (response.Exception == null)
            {
                var result = _mapper.Map<List<ListChannelQueryResponseViewModel>>(response.Result);
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
        public IActionResult Create(CreateChannelCommandRequestViewModel createChannelCommandRequestViewModel)
        {
            var resultRequest = _mapper.Map<CreateChannelCommandRequest>(createChannelCommandRequestViewModel);
            var response = RefitApiServiceDependency.ChannelApi.Post(resultRequest);
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
            var response = RefitApiServiceDependency.ChannelApi.Get(id);
            if (response.Exception == null)
            {
                var result = _mapper.Map<ChannelQueryResponseViewModel>(response.Result);
                return View(result);
            }
            else
            {
                return RedirectToAction("Error");
            }
        }
        [HttpPost]
        public IActionResult Edit(UpdateChannelCommandRequestViewModel updateChannelCommandRequestViewModel)
        {
            var resultRequest = _mapper.Map<UpdateChannelCommandRequest>(updateChannelCommandRequestViewModel);
            var response = RefitApiServiceDependency.ChannelApi.Put(resultRequest);
            if (response.Exception == null)
            {
                TempData["Message"] = updateChannelCommandRequestViewModel.Id + "'li channel güncellendi .";
                var responseList = RefitApiServiceDependency.ChannelApi.List(new ListChannelQueryRequest
                {
                });
                if (responseList.Exception == null)
                {
                    var result = _mapper.Map<List<ListChannelQueryResponseViewModel>>(responseList.Result);
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
        public IActionResult Remove(string id)
        {
            var response = RefitApiServiceDependency.ChannelApi.Delete(id);
            if (response.Exception == null)
            {
                TempData["Message"] = id + "li channel silindi .";
                var responseList = RefitApiServiceDependency.ChannelApi.List(new ListChannelQueryRequest
                {
                });
                if (responseList.Exception == null)
                {
                    var result = _mapper.Map<List<ListChannelQueryResponseViewModel>>(responseList.Result);
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
