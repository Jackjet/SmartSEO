using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmartSEO.Models
{
    /// <summary>
    /// 工作日志
    /// </summary>
    public class WorlkLog
    {
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 用户账号
        /// </summary>
        //public BaseUser UserName { get; set; }
        [StringLength(20)]
        public string UserName { get; set; }

        /// <summary>
        /// 使用时间/小时
        /// </summary>
        public int UseTime { get; set; }

        /// <summary>
        /// 工作内容
        /// </summary>
        [StringLength(1024)]
        public String WorlkContent { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
