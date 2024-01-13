using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        public IActionResult Index()
        {
            var values = categoryManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category p)
        {
            CategoryValidator validationRules = new CategoryValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {
                categoryManager.TInsert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteCategory(int id)
        {
            var value = categoryManager.TGetByID(id);
            categoryManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var value = categoryManager.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category p)
        {
            categoryManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
