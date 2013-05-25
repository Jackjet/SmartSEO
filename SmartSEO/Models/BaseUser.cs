using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmartSEO.Models
{
    /// <summary>
    /// 用户信息表
    /// </summary>
    public class BaseUser
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [Key]
        public string UserName { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        [StringLength(20)]
        public string Role { get; set; }

        /// <summary>
        /// 入职时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}