using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webdiyer.WebControls.Mvc;

namespace SmartSEO.Controllers
{
    /// <summary>
    /// 客户拜访
    /// </summary>
    public class CustomerHistoryController : Controller
    {
        private Models.SmartSEODB db = new Models.SmartSEODB();

        public ActionResult Index(int page = 0)
        {
            var data = db.CustomerHistorys.OrderByDescending(m => m.Tick);

            //截取分页数据
            PagedList<Models.CustomerHistory> pageData = data.ToPagedList(page, 20);

            return View(pageData);
        }

        public ActionResult Add()
        {
            var model = new Models.CustomerHistory();


            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Models.CustomerHistory model)
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
