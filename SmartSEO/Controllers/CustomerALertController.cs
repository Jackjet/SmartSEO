using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webdiyer.WebControls.Mvc;

namespace SmartSEO.Controllers
{
    /// <summary>
    /// 客户提醒管理
    /// </summary>
    public class CustomerALertController : Controller
    {
        private Models.SmartSEODB db = new Models.SmartSEODB();

        public ActionResult Index(int page = 0, bool isRead = false)
        {
            var data = db.CustomerALerts.Include("Customer")
                .Where(m => m.IsRead == isRead)
                .OrderBy(m => m.AlertTime);

            //截取分页数据
            PagedList<Models.CustomerALert> pageData = data.ToPagedList(page, 20);

            return View(pageData);
        }

        public ActionResult Add(int CustomerID = 0)
        {
            Models.CustomerALert model = new Models.CustomerALert();
            model.AlertTime = DateTime.Now;

            model.Customer = db.Customers.Where(m => m.ID == CustomerID).FirstOrDefault();

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Models.CustomerALert model)
        {
            int id = int.Parse(Request.Form["CustomerID"]);

            model.Customer = db.Customers.Where(m => m.ID == id).FirstOrDefault();
            model.IsRead = false;
            //model.AlertPeople

            db.CustomerALerts.Add(model);

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Del(int id = 0)
        {
            var model = db.CustomerALerts.Where(m => m.ID == id).FirstOrDefault();

            db.Entry(model).State = System.Data.EntityState.Deleted;

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Read(int id = 0)
        {
            var model = db.CustomerALerts.Where(m => m.ID == id).FirstOrDefault();

            model.IsRead = true;

            db.Entry(model).State = System.Data.EntityState.Modified;

            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
