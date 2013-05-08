using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webdiyer.WebControls.Mvc;

namespace SmartSEO.Controllers
{
    public class AccountController : Controller
    {
        private Models.SmartSEODB db = new Models.SmartSEODB();

        public ActionResult Index(int page = 0)
        {
            var data = db.Accounts.OrderByDescending(m => m.CreateTime);

            //截取分页数据
            PagedList<Models.Account> pageData = data.ToPagedList(page, 20);

            return View(pageData);
        }

        public ActionResult Add()
        {
            var model = new Models.Account();

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Models.Account model)
        {
            model.CreateTime = DateTime.Now;

            db.Accounts.Add(model);

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Del(int id)
        {
            var model = db.Accounts.Where(m => m.AccountID == id).FirstOrDefault();

            db.Accounts.Remove(model);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var model = db.Accounts.Where(m => m.AccountID == id).FirstOrDefault();

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Models.Account model)
        {
            model.CreateTime = DateTime.Now;

            db.Entry(model).State = System.Data.EntityState.Modified;

            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
