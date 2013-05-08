using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmartSEO.Models
{
    /// <summary>
    /// 优化文章
    /// </summary>
    public class Article
    {
        /// <summary>
        /// 文章编号
        /// </summary>
        [Key]
        public int ArticleID { get; set; }

        /// <summary>
        /// 文章标题
        /// </summary>
        [StringLength(180)]
        public string Title { get; set; }

        /// <summary>
        /// 文章内容
        /// </summary>
        [StringLength(8000)]
        public string Content { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 文章备注
        /// </summary>
        [StringLength(50)]
        public string Remark { get; set; }
    }
}