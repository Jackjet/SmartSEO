using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webdiyer.WebControls.Mvc;

namespace SmartSEO.Controllers
{
    public class SitesController : Controller
    {
        private Models.SmartSEODB db = new Models.SmartSEODB();

        public ActionResult Index(int page = 0)
        {
            var data = db.Sites.OrderByDescending(m => m.CreateTime);

            //截取分页数据
            PagedList<Models.Site> pageData = data.ToPagedList(page, 20);

            return View(pageData);
        }

        public ActionResult Add()
        {
            var model = new Models.Site();

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Models.Site model)
        {
            model.CreateTime = DateTime.Now;
            model.Rank = 0;

            //判断Url是否已经存在
            var m = db.Sites.Where(p => p.Domain == model.Domain).FirstOrDefault();
            if (m == null)
            {
                //自动补全http://协议标识
                if (model.Domain.Length >= 7 && model.Domain.ToLower().Substring(0, 7) != "http://")
                {
                    model.Domain = "http://" + model.Domain;
                }

                db.Sites.Add(model);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var model = db.Sites.Where(m => m.SiteID == id).FirstOrDefault();

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Models.Site model)
        {
            model.CreateTime = DateTime.Now;

            db.Entry(model).State = System.Data.EntityState.Modified;

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Del(int id)
        {
            var model = db.Sites.Where(m => m.SiteID == id).FirstOrDefault();

            db.Entry(model).State = System.Data.EntityState.Deleted;

            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
