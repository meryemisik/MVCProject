using BusinnesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using BusinnesLayer.ValidationRules;
using FluentValidation.Results;

namespace MvcProject.Controllers
{
   
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterDal());
        WriterValidator writerValidatior = new WriterValidator();
        public ActionResult Index()
        {
            var writerValues = wm.GetList();
            return View(writerValues);
        }
        [HttpGet]
        public ActionResult AddWritter()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddWritter(Writer p)
        {
            
            ValidationResult results =writerValidatior.Validate(p);
            if (results.IsValid)
            {
                wm.WriterAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditWriter(int id)
        {
            var writerValues = wm.GetById(id);
            return View(writerValues);
        }

        [HttpPost]
        public ActionResult EditWriter(Writer p)
        {

            ValidationResult results = writerValidatior.Validate(p);
            if (results.IsValid)
            {
                 wm.WriterUpdate(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}