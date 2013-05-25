using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmartSEO.Models
{
    public class CustomerALert
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 客户
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// 提醒时间
        /// </summary>
        public DateTime AlertTime { get; set; }

        /// <summary>
        /// 提醒内容
        /// </summary>
        [StringLength(200)]
        public string AlertMsg { get; set; }

        /// <summary>
        /// 消息是否已读
        /// true已读,false未读
        /// </summary>
        public bool IsRead { get; set; }

        /// <summary>
        /// 提醒人(消息受众者)
        /// </summary>
        public BaseUser AlertPeople { get; set; }
    }
}
