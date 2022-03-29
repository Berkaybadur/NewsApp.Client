using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NewsApp.Api.Client;
using NewsApp.Api.Client.Refit.Dependency;
using NewsApp.UI.Models.ViewModel;
using System.Collections.Generic;

namespace NewsApp.UI.Controllers
{
    public class TagController : Controller
    {
        private readonly IMapper _mapper;
        public TagController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var response = RefitApiServiceDependency.TagApi.List(new ListTagQueryRequest
            {
            });
            if (response.Exception == null)
            {
                var result = _mapper.Map<List<ListTagQueryResponseViewModel>>(response.Result);
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
        public IActionResult Create(CreateTagCommandRequestViewModel createTagCommandRequestViewModel)
        {
            var result = _mapper.Map<CreateTagCommandRequest>(createTagCommandRequestViewModel);
            var response = RefitApiServiceDependency.TagApi.Post(result);
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
            var responseEdit = RefitApiServiceDependency.TagApi.Get(id);

            if (responseEdit.Exception == null)
            {
                var result = _mapper.Map<TagQueryResponseViewModel>(responseEdit.Result);
                return View(result);
            }
            else
            {
                return RedirectToAction("Error");
            }


        }
        [HttpPost]
        public IActionResult Edit(UpdateTagCommandRequestViewModel updateTagCommandRequestViewModel)
        {
            var result = _mapper.Map<UpdateTagCommandRequest>(updateTagCommandRequestViewModel);
            var responseUpdate = RefitApiServiceDependency.TagApi.Put(result);

            TempData["Message"] = updateTagCommandRequestViewModel.Id + "'li kategori güncellendi .";

            var responseList = RefitApiServiceDependency.TagApi.List(new ListTagQueryRequest
            {
            });

            if (responseList.Exception == null)
            {
                var listTagQueryResponseViewModel = _mapper.Map<List<ListTagQueryResponseViewModel>>(responseList.Result);
                return View("~/Views/Tag/Index.cshtml", listTagQueryResponseViewModel);
            }
            else
            {
                return RedirectToAction("Error");
            }

        }
        public IActionResult Remove(string id)
        {
            var responseDelete = RefitApiServiceDependency.TagApi.Delete(id);

            TempData["Message"] = id + "'li kategori silindi .";

            var responseList = RefitApiServiceDependency.TagApi.List(new ListTagQueryRequest
            {
            });

            if (responseList.Exception == null)
            {
                var listTagQueryResponseViewModel = _mapper.Map<List<ListTagQueryResponseViewModel>>(responseList.Result);
                return View("~/Views/Tag/Index.cshtml", listTagQueryResponseViewModel);
            }
            else
            {
                return RedirectToAction("Error");
            }
        }
    }
}
