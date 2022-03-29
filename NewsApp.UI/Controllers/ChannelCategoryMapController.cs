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
    public class ChannelCategoryMapController : Controller
    {
        private readonly IMapper _mapper;
        public ChannelCategoryMapController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var response = RefitApiServiceDependency.ChannelCategoryMapApi.List(new ListChannelCategoryMapQueryRequest
            {
            });

            if (response.Exception == null)
            {
                var result = _mapper.Map<List<ListChannelCategoryMapQueryResponseViewModel>>(response.Result);
                return View(result);
            }
            else
            {
                return RedirectToAction("Error");
            }

        }
        public IActionResult Create()
        {
            var cate = getlist();
            var model = new CreateChannelCategoryMapCommandRequestViewModel()
            {
                CategoryIds = PrepareBookerDestination(cate),
                ChannelIds = PrepareBookerDestination2()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CreateChannelCategoryMapCommandRequestViewModel createChannelCategoryMapCommandRequestViewModel)
        {
            var result = _mapper.Map<CreateChannelCategoryMapCommandRequest>(createChannelCategoryMapCommandRequestViewModel);
            var response = RefitApiServiceDependency.ChannelCategoryMapApi.Post(result);
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
            var response = RefitApiServiceDependency.ChannelCategoryMapApi.Get(id);
            var cat = getlist();
            if (response.Exception == null)
            {
                var result = _mapper.Map<ChannelCategoryMapQueryResponseViewModel>(response.Result);
                result.CategoryIds = PrepareBookerDestination(cat);
                result.ChannelIds = PrepareBookerDestination2();
                return View(result);
            }
            else
            {
                return RedirectToAction("Error");
            }

        }
        [HttpPost]
        public IActionResult Edit(UpdateChannelCategoryMapCommandRequestViewModel updateChannelCategoryMapCommandRequestViewModel)
        {
            var resultRequest = _mapper.Map<UpdateChannelCategoryMapCommandRequest>(updateChannelCategoryMapCommandRequestViewModel);
            var response = RefitApiServiceDependency.ChannelCategoryMapApi.Put(resultRequest);
            if (response.Exception == null)
            {
                TempData["Message"] = updateChannelCategoryMapCommandRequestViewModel.Id + "'li map güncellendi .";
                var responseList = RefitApiServiceDependency.ChannelCategoryMapApi.List(new ListChannelCategoryMapQueryRequest
                {
                });
                if (responseList.Exception == null)
                {
                    var result = _mapper.Map<List<ListChannelCategoryMapQueryResponseViewModel>>(responseList.Result);
                    return View("~/Views/ChannelCategoryMap/Index.cshtml", result);
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
            var response = RefitApiServiceDependency.ChannelCategoryMapApi.Delete(id);
            if (response.Exception == null)
            {
                TempData["Message"] = id + "li map silindi .";
                var responseList = RefitApiServiceDependency.ChannelCategoryMapApi.List(new ListChannelCategoryMapQueryRequest
                {
                });
                if (responseList.Exception == null)
                {
                    var result = _mapper.Map<List<ListChannelCategoryMapQueryResponseViewModel>>(responseList.Result);
                    return View("~/Views/ChannelCategoryMap/Index.cshtml", result);
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

        private List<SelectListItem> PrepareBookerDestination(List<ListCategoryQueryResponse> bookerDestination)
        {

            var typeSelectListItems = bookerDestination.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
            return typeSelectListItems;
        }
        private List<SelectListItem> PrepareBookerDestination2()
        {
            var bookerDestination = RefitApiServiceDependency.ChannelApi.List(new ListChannelQueryRequest
            {
            });
            var typeSelectListItems = bookerDestination.Result.ToList().Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
            return typeSelectListItems;
        }
        private List<ListCategoryQueryResponse> getlist()
        {
            var bookerDestination = RefitApiServiceDependency.CategoryApi.List(new ListCategoryQueryRequest
            {

            });
            return bookerDestination.Result.ToList();
        }

        private CategoryQueryResponse getid(string id)
        {
            var bookerDestination = RefitApiServiceDependency.CategoryApi.Get(id);
            return bookerDestination.Result;
        }
    }
}
