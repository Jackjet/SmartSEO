using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmartSEO.Models
{
    /// <summary>
    /// 签名
    /// </summary>
    public class Signature
    {
        /// <summary>
        /// 签名编号
        /// </summary>
        [Key]
        public int SignatureID { get; set; }

        /// <summary>
        /// 签名标题
        /// </summary>
        [StringLength(180)]
        public string Title { get; set; }

        /// <summary>
        /// 签名内容
        /// </summary>
        [StringLength(4000)]
        public string Content { get; set; }

        /// <summary>
        /// 随机出现
        /// </summary>
        public bool Random { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}