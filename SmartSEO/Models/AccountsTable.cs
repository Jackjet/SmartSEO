using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmartSEO.Models
{
    /// <summary>
    /// 账务表
    /// </summary>
    public class AccountsTable
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        public float TransactionAmount { get; set; }

        /// <summary>
        /// 记录时间
        /// </summary>
        public DateTime RecordTime { get; set; }

        /// <summary>
        /// 消费凭据或内容
        /// </summary>
        [StringLength(200)]
        public string Receipt { get; set; }

        /// <summary>
        /// 报销申请人
        /// </summary>
        public BaseUser ApplyPeople { get; set; }
    }
}