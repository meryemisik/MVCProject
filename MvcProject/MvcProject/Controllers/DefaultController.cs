using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class DefaultController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        ContentManager cm = new ContentManager(new EfContentDal());
        public PartialViewResult Index(int id=0)
        {
            var contentList = cm.GetListByHeadingID(id);
            return PartialView(contentList);
        }
        public ActionResult Headings()
        {
            var HeadingList = hm.GetList();
            return View(HeadingList);
        }
    }
}