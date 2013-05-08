using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmartSEO.Models
{
    /// <summary>
    /// 账号资源
    /// </summary>
    public class Account
    {
        /// <summary>
        /// 账号资源编号
        /// </summary>
        [Key]
        public int AccountID { get; set; }

        /// <summary>
        /// 访问地址
        /// </summary>
        [StringLength(500)]
        public string Url { get; set; }

        /// <summary>
        /// 登录账号
        /// </summary>
        [StringLength(50)]
        public string UserName { get; set; }

        /// <summary>
        /// 账号密码
        /// </summary>
        [StringLength(50)]
        public string Password { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 账号备注
        /// </summary>
        [StringLength(50)]
        public string Remark { get; set; }
    }
}