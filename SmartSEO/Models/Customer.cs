using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmartSEO.Models
{
    /// <summary>
    /// 顾客
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// 顾客编号
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 顾客姓名
        /// </summary>
        [StringLength(20)]
        public string UserName { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public bool Sex { get; set; }

        /// <summary>
        /// 住址
        /// </summary>
        [StringLength(200)]
        public string Address { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 职位角色
        /// </summary>
        [StringLength(20)]
        public string Role { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        public List<Phone> Phone { get; set; }

        /// <summary>
        /// 客户认识渠道
        /// </summary>
        [StringLength(20)]
        public string Channel { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 籍贯
        /// </summary>
        [StringLength(200)]
        public string Origin { get; set; }
    }
}