using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmartSEO.Models
{
    /// <summary>
    /// 顾客拜访历史
    /// </summary>
    public class CustomerHistory
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 拜访人(业务员)
        /// </summary>
        public BaseUser VisitPeople { get; set; }

        /// <summary>
        /// 被访问人(客户)
        /// </summary>
        public Customer AccessPeople { get; set; }

        /// <summary>
        /// 访问时间
        /// </summary>
        public DateTime Tick { get; set; }

        /// <summary>
        /// 讨论内容
        /// </summary>
        [StringLength(1024)]
        public string DiscussContent { get; set; }
    }
}
