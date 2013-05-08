using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SmartSEO.Models
{
    public class SmartSEODB : DbContext
    {
        /// <summary>
        /// 优化文章
        /// </summary>
        public DbSet<Article> Articles { get; set; }

        /// <summary>
        /// 网站资源
        /// </summary>
        public DbSet<Site> Sites { get; set; }

        /// <summary>
        /// 账号资源
        /// </summary>
        public DbSet<Account> Accounts { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        public DbSet<Signature> Signatures { get; set; }
    }
}