using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webdiyer.WebControls.Mvc;

namespace SmartSEO.Controllers
{
    [ValidateInput(false)]
    public class SignatureController : Controller
    {
        private Models.SmartSEODB db = new Models.SmartSEODB();

        public ActionResult Index(int page = 0)
        {
            var data = db.Signatures.OrderByDescending(m => m.CreateTime);

            //截取分页数据
            PagedList<Models.Signature> pageData = data.ToPagedList(page, 20);

            return View(pageData);
        }

        public ActionResult Add()
        {
            var model = new Models.Signature();

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Models.Signature model)
        {
            model.CreateTime = DateTime.Now;
            model.Random = true;

            db.Signatures.Add(model);

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Del(int id)
        {
            var model = db.Signatures.Where(m => m.SignatureID == id).FirstOrDefault();

            db.Signatures.Remove(model);

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var model = db.Signatures.Where(m => m.SignatureID == id).FirstOrDefault();

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Models.Signature model)
        {
            model.CreateTime = DateTime.Now;
            model.Random = true;

            db.Entry(model).State = System.Data.EntityState.Modified;

            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
