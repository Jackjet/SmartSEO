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
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Del()
        {
            return View();
        }
    }
}
