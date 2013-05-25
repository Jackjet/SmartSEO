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

        public DbSet<AccountsTable> AccountsTables { get; set; }

        public DbSet<BaseUser> BaseUsers { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<CustomerALert> CustomerALerts { get; set; }

        public DbSet<CustomerHistory> CustomerHistorys { get; set; }

        public DbSet<Phone> Phones { get; set; }

        public DbSet<WorlkLog> WorlkLogs { get; set; }
    }
}