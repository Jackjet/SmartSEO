using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webdiyer.WebControls.Mvc;

namespace SmartSEO.Controllers
{
    /// <summary>
    /// 客户管理
    /// </summary>
    public class CustomerController : Controller
    {
        private Models.SmartSEODB db = new Models.SmartSEODB();

        public ActionResult Index(int page = 0)
        {
            var data = db.Customers.OrderByDescending(m => m.CreateTime);

            //截取分页数据
            PagedList<Models.Customer> pageData = data.ToPagedList(page, 20);

            return View(pageData);
        }

        public ActionResult Add()
        {
            Models.Customer m = new Models.Customer();
            m.CreateTime = DateTime.Now;
            m.Age = 30;

            return View(m);
        }

        [HttpPost]
        public ActionResult Add(Models.Customer model)
        {
            model.CreateTime = DateTime.Now;

            //model.Phone = new List<Models.Phone>();
            //var phoneModel = new Models.Phone();
            //phoneModel.Number = Request.Form["PhoneNumber"] != null ? Request.Form["PhoneNumber"] : "";
            //phoneModel.CreateTime = DateTime.Now;
            //phoneModel.PhoneType = "默认号码";
            //phoneModel.Remark = "正常";
            //model.Phone.Add(phoneModel);

            db.Customers.Add(model);

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id = 0)
        {
            var model = db.Customers.Where(m => m.ID == id).FirstOrDefault();

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Models.Customer model)
        {
            //var srcModel = db.Customers.Where(m => m.ID == model.ID).FirstOrDefault();
            //srcModel.Address = model.Address;
            //srcModel.Age = model.Age;
            //srcModel.Channel = model.Channel;
            //srcModel.Origin = model.Origin;
            //srcModel.Role = model.Role;
            //srcModel.Sex = model.Sex;
            //srcModel.UserName = model.UserName;
            //srcModel.BusinessArea = model.BusinessArea;
            //srcModel.CompanyAddress = model.CompanyAddress;
            //srcModel.CompanyName = model.CompanyName;
            //srcModel.Email = model.Email;
            //srcModel.Phone = model.Phone;
            //srcModel.QQ = model.QQ;
            //srcModel.Remark = model.Remark;
            //srcModel.Url = model.Url;
            //srcModel.ZipCode = model.ZipCode;

            model.CreateTime = DateTime.Now;

            db.Entry(model).State = System.Data.EntityState.Modified;

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Del(int id = 0)
        {
            var model = db.Customers.Where(m => m.ID == id).FirstOrDefault();

            db.Entry(model).State = System.Data.EntityState.Deleted;

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult View(int id = 0)
        {
            var model = db.Customers.Where(m => m.ID == id).FirstOrDefault();

            return View(model);
        }
        
        //public ActionResult AddPhone(int id = 0)
        //{
        //    Models.Phone model = new Models.Phone();
        //    model.CreateTime = DateTime.Now;

        //    ViewBag.Customer_ID = id;

        //    return View(model);
        //}

        //[HttpPost]
        //public ActionResult AddPhone(Models.Phone model)
        //{
        //    int id = int.Parse(Request.Form["Customer_ID"]);
        //    var customers = db.Customers.Where(m => m.ID == id).FirstOrDefault();

        //    model.CreateTime = DateTime.Now;
        //    model.Customer = customers;
        //    //customers.Phone.Add(model);
        //    //db.Phones.Add(model);

        //    db.SaveChanges();

        //    return RedirectToAction("Index");
        //}

    }
}
