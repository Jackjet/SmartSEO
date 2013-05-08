using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;

namespace SmartSEO.Models
{
    public class Thumbnails
    {
        private List<Image> _images;

        public Size SingleImage { get; set; }

        public int ColumnCount { get; set; }

        public int Padding { get; set; }

        public Color BackGroundColor { get; set; }

        public Thumbnails(List<Image> images)
        {
            this._images = images;

            SingleImage = new Size(64, 64);
            ColumnCount = 3;
            Padding = 0;
            BackGroundColor = Color.Red;
        }

        public Image GetRectangleImage()
        {
            Bitmap bitMap = new Bitmap(
                ColumnCount * SingleImage.Width + ColumnCount * Padding,
                _images.Count % ColumnCount == 0 ?
                (_images.Count / ColumnCount * SingleImage.Height + ColumnCount * Padding) :
                (_images.Count / ColumnCount * SingleImage.Height + SingleImage.Height + ColumnCount * Padding));

            Graphics grp = Graphics.FromImage(bitMap);
            Pen pen = new Pen(BackGroundColor);
            pen.Width = bitMap.Height;
            grp.DrawRectangle(pen,
                new Rectangle(new Point(0, 0),
                new Size(bitMap.Width, bitMap.Height)));

            for (int i = 0; i < _images.Count; i++)
            {
                Image.GetThumbnailImageAbort call = new Image.GetThumbnailImageAbort(GetThumbnailImageAbort);

                var thumbnailImage = _images[i].GetThumbnailImage(SingleImage.Width,
                    SingleImage.Height,
                    call,
                    IntPtr.Zero);

                var point = new Point(
                    (i % ColumnCount * SingleImage.Width),
                    (i / ColumnCount * SingleImage.Height));

                point.Offset(new Point(i % ColumnCount * this.Padding, i / ColumnCount * this.Padding));

                grp.DrawImage(thumbnailImage, point);
            }

            grp.Dispose();

            return bitMap;
        }

        private bool GetThumbnailImageAbort()
        {
            return true;
        }
    }
}