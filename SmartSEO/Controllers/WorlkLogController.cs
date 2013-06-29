using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webdiyer.WebControls.Mvc;

namespace SmartSEO.Controllers
{
    /// <summary>
    /// 工作日志
    /// </summary>
    public class WorlkLogController : Controller
    {
        private Models.SmartSEODB db = new Models.SmartSEODB();

        public ActionResult Index(int page = 0)
        {
            var data = db.WorlkLogs.OrderByDescending(m => m.CreateTime);

            //截取分页数据
            PagedList<Models.WorlkLog> pageData = data.ToPagedList(page, 20);

            return View(pageData);
        }

        public ActionResult Add()
        {
            var model = new Models.WorlkLog();
            model.UseTime = 8;

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Models.WorlkLog model)
        {
            model.CreateTime = DateTime.Now;

            db.WorlkLogs.Add(model);

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Del(int id)
        {
            var model = db.WorlkLogs.Where(m => m.ID == id).FirstOrDefault();

            if (model != null)
            {
                db.Entry(model).State = System.Data.EntityState.Deleted;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
