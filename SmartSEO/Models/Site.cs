using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmartSEO.Models
{
    /// <summary>
    /// 网站资源
    /// </summary>
    public class Site
    {
        /// <summary>
        /// 网站资源编号
        /// </summary>
        [Key]
        public int SiteID { get; set; }

        /// <summary>
        /// 网站域名
        /// </summary>
        [StringLength(500)]
        public string Domain { get; set; }

        /// <summary>
        /// 网站标题
        /// </summary>
        [StringLength(160)]
        public string Title { get; set; }

        /// <summary>
        /// GooglePR
        /// </summary>
        public int GooglePR { get; set; }

        /// <summary>
        /// BaiDuPR
        /// </summary>
        public int BaiDuPR { get; set; }

        /// <summary>
        /// 谷歌收录
        /// </summary>
        public float GoogleRecord { get; set; }

        /// <summary>
        /// 百度收录
        /// </summary>
        public float BaiDuRecord { get; set; }

        /// <summary>
        /// 权重
        /// </summary>
        public float Rank { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 资源备注
        /// </summary>
        [StringLength(50)]
        public string Remark { get; set; }
    }
}