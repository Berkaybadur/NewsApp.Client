using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NewsApp.Api.Client;
using NewsApp.Api.Client.Refit.Dependency;
using NewsApp.UI.Models.ViewModel;
using System.Collections.Generic;

namespace NewsApp.UI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IMapper _mapper;
        public CategoryController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var response = RefitApiServiceDependency.CategoryApi.List(new ListCategoryQueryRequest
            {
            });
            if (response.Exception == null)
            {
                var result = _mapper.Map<List<ListCategoryQueryResponseViewModel>>(response.Result);
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
        public IActionResult Create(CreateCategoryCommandRequestViewModel createCategoryCommandRequestViewModel)
        {
            var result = _mapper.Map<CreateCategoryCommandRequest>(createCategoryCommandRequestViewModel);
            var response = RefitApiServiceDependency.CategoryApi.Post(result);
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
            var responseEdit = RefitApiServiceDependency.CategoryApi.Get(id);

            if (responseEdit.Exception == null)
            {
                var result = _mapper.Map<CategoryQueryResponseViewModel>(responseEdit.Result);
                return View(result);
            }
            else
            {
                return RedirectToAction("Error");
            }


        }
        [HttpPost]
        public IActionResult Edit(UpdateCategoryCommandRequestViewModel updateCategoryCommandRequestViewModel)
        {
            var result = _mapper.Map<UpdateCategoryCommandRequest>(updateCategoryCommandRequestViewModel);
            var responseUpdate = RefitApiServiceDependency.CategoryApi.Put(result);

            TempData["Message"] = updateCategoryCommandRequestViewModel.Id + "'li kategori güncellendi .";

            var responseList = RefitApiServiceDependency.CategoryApi.List(new ListCategoryQueryRequest
            {
            });

            if (responseList.Exception == null)
            {
                var listCategoryQueryResponseViewModel = _mapper.Map<List<ListCategoryQueryResponseViewModel>>(responseList.Result);
                return View("~/Views/Category/Index.cshtml", listCategoryQueryResponseViewModel);
            }
            else
            {
                return RedirectToAction("Error");
            }

        }
        public IActionResult Remove(string id)
        {
            var responseDelete = RefitApiServiceDependency.CategoryApi.Delete(id);

            TempData["Message"] = id + "'li kategori silindi .";

            var responseList = RefitApiServiceDependency.CategoryApi.List(new ListCategoryQueryRequest
            {
            });

            if (responseList.Exception == null)
            {
                var listCategoryQueryResponseViewModel = _mapper.Map<List<ListCategoryQueryResponseViewModel>>(responseList.Result);
                return View("~/Views/Category/Index.cshtml", listCategoryQueryResponseViewModel);
            }
            else
            {
                return RedirectToAction("Error");
            }
        }
    }
}
