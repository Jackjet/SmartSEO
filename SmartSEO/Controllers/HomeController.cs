using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartSEO.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<System.Drawing.Image> image = new List<System.Drawing.Image>();

            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_142856.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_143054.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_144241.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_144317.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_144421.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_144527.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_144718.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_142856.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_143054.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_144241.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_144317.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_144421.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_144527.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_144718.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_142856.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_143054.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_144241.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_144317.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_144421.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_144527.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_144718.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_142856.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_143054.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_144241.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_144317.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_144421.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_144527.jpg"));
            image.Add(System.Drawing.Image.FromFile(@"G:\相册备份\2013年01月\IMG_20130111_144718.jpg"));


            Models.Thumbnails thumbs = new Models.Thumbnails(image);
            thumbs.ColumnCount = 5;
            thumbs.Padding = 2;
            thumbs.SingleImage = new System.Drawing.Size(200, 150);

            var img = thumbs.GetRectangleImage();

            img.Save(@"c:\001.png", System.Drawing.Imaging.ImageFormat.Png);

            return View();
        }
    }
}
