using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmartSEO.Models
{
    /// <summary>
    /// 电话号码
    /// </summary>
    public class Phone
    {
        /// <summary>
        /// ID主键
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [StringLength(20)]
        public string Number { get; set; }

        /// <summary>
        /// 电话类型
        /// </summary>
        [StringLength(20)]
        public string PhoneType { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 号码备注
        /// </summary>
        [StringLength(200)]
        public string Remark { get; set; }


        public Customer Customer { get; set; }
    }
}