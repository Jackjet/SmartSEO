using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SmartSEO.Models
{
    /// <summary>
    /// 初始化数据
    /// </summary>
    public class InitData : DropCreateDatabaseIfModelChanges<SmartSEODB>
    {
        protected override void Seed(SmartSEODB context)
        {
            //new List<Account>
            //{
            //    new Account(){
            //         CreateTime= DateTime.Now,
            //         ApplyPeople = "jcjmyz",
            //         Password="wangdan1494",
            //         Url="http://www.qq.com",
            //         Remark="成功"
            //    }
            //}.ForEach(m => context.Accounts.Add(m));
        }
    }
}