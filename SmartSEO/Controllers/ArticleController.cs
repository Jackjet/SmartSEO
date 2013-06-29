using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webdiyer.WebControls.Mvc;

namespace SmartSEO.Controllers
{
    [ValidateInput(false)]
    public class ArticleController : Controller
    {
        private Models.SmartSEODB db = new Models.SmartSEODB();

        public ActionResult Index(int page = 0)
        {
            var data = db.Articles.OrderByDescending(m => m.CreateTime);

            //截取分页数据
            PagedList<Models.Article> pageData = data.ToPagedList(page, 20);

            return View(pageData);
        }

        public ActionResult Add()
        {
            var model = new Models.Article();

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Models.Article model)
        {
            model.CreateTime = DateTime.Now;

            db.Articles.Add(model);

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var model = db.Articles.Where(m => m.ArticleID == id).FirstOrDefault();

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Models.Article model)
        {
            model.CreateTime = DateTime.Now;

            db.Entry(model).State = System.Data.EntityState.Modified;

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Del(int id)
        {
            var model = db.Articles.Where(m => m.ArticleID == id).FirstOrDefault();

            db.Entry(model).State = System.Data.EntityState.Deleted;

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Preview(string type, int id)
        {
            var model = db.Articles.Where(m => m.ArticleID == id).FirstOrDefault();

            var signatures = db.Signatures.ToList();
            if (signatures != null && signatures.Count > 0)
            {
                var random = new Random().Next(0, signatures.Count);
                ViewBag.Signature = signatures[random];
            }
            else
            {
                ViewBag.Signature = new Models.Signature()
                {
                    Content = ""
                };
            }

            ViewBag.ContentType = type;

            return View(model);
        }
    }
}
