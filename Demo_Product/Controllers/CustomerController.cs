﻿using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Demo_Product.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        JobManager jobManager = new JobManager(new EfJobDal());

        public IActionResult Index()
        {
            var values = customerManager.GetCustomersListWithJob();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            //Dropdownlist i kullanabilmek için dropdownlist e gelmesi gereken değerler atanıyor
            List<SelectListItem> values = (from x in jobManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.JobID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer p)
        {
            CustomerValidator validationRules = new CustomerValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {
                customerManager.TInsert(p);
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

        public IActionResult DeleteCustomer(int id)
        {
            var value = customerManager.TGetByID(id);
            customerManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            //Dropdownlist i kullanabilmek için dropdownlist e gelmesi gereken değerler atanıyor
            List<SelectListItem> values = (from x in jobManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.JobID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value = customerManager.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer p)
        {
            customerManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
