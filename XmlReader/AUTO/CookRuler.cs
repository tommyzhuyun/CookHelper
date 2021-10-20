using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CookHelper
{
    public partial class CookRuler : Form
    {
        private int value1, value2, value3;
        private int LineImage = Color.Black.ToArgb();

        public CookRuler(int v1,int v2,int v3)
        {
            InitializeComponent();
            value1 = v1;
            value2 = v2;
            value3 = v3;
            //Console.WriteLine(SystemColors.Control.R + " " + SystemColors.Control.G + " " + SystemColors.Control.B);
        }
        public void Update(int v1, int v2, int v3)
        {
            value1 = v1;
            value2 = v2;
            value3 = v3;
            RulerImage();
        }
        private void CookRuler_Load(object sender, EventArgs e)
        {
            RulerImage();
        }
        private bool mouseIsDown = false;
        private Point firstPoint;
        private void CookRuler_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            if (e.Button == MouseButtons.Left)
                mouseIsDown = true;
        }

        private void CookRuler_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void CookRuler_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }

        private void CookRuler_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                LineImage = InvertedColor(LineImage);
                RulerImage();
                ChangeBackImage();
                GC.Collect();
            }
        }

        private void RulerImage()
        {
            int Width = RulerPanel.Width;
            int Height = RulerPanel.Height;
            int[] data = new int[Width * Height];
            int ControlColor = SystemColors.Control.ToArgb();
            int Yellow = Color.Yellow.ToArgb();
            int Cyan = Color.Cyan.ToArgb();
            int HotPink = Color.HotPink.ToArgb();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = ControlColor;
            }
            
            int sum = value3 + value2 + value1;
            int point1 = (value1) * (Width) / sum;
            int point2 = (value1 + value2) * (Width) / sum;
            int point3 = (value1 + value2 + value3) * (Width) / sum;
            //Console.WriteLine(point1 + " " + point2 + " " + point3);
            for (int x = 0; x < Width; x++)//228
            {
                for(int y = 0; y < Height; y++)
                {
                    if ( x == point1 || x == point2)
                    {
                        if (data[x + y * Width] != LineImage)
                            data[x + y * Width] = LineImage;
                    }
                    else if (y < 8 && x <= point1)
                        data[x + y * Width] = Yellow;
                    else if (y < 8 && x > point1 && x <= point2)
                        data[x + y * Width] = Cyan;
                    else if (y < 8 && x > point2 && x<= point3)
                        data[x + y * Width] = HotPink;
                }
            }
            Bitmap bitmap = new Bitmap(Width, Height, PixelFormat.Format32bppArgb);
            CopyFromArray(data, bitmap);
            RulerPanel.BackgroundImage?.Dispose();
            RulerPanel.BackgroundImage = bitmap;
            
        }

        private void ChangeBackImage()
        {
            int ControlColor = SystemColors.Control.ToArgb();
            Bitmap BackImage = new Bitmap(BackgroundImage);
            int[] data = CopyToArray(BackImage);

            for (int x = 0; x < Width; x++)//228
            {
                for (int y = 0; y < Height; y++)
                {
                    if (data[x + y * Width] != ControlColor)
                    {
                            data[x + y * Width] = InvertedColor(data[x + y * Width]);
                    }
                }
            }

            CopyFromArray(data, BackImage);
            BackgroundImage?.Dispose();
            BackgroundImage = BackImage;
            this.Refresh();
        }


        private void CookRuler_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            //Console.WriteLine(key);
            if(key == (char)Keys.Escape)
            {
                this.Close();
            }else if(key == 'w')
            {
                this.Location = new Point(this.Location.X, this.Location.Y - 1);
            }
            else if (key == 's')
            {
                this.Location = new Point(this.Location.X, this.Location.Y + 1);
            }
            else if (key == 'a')
            {
                this.Location = new Point(this.Location.X - 1, this.Location.Y);
            }
            else if (key == 'd')
            {
                this.Location = new Point(this.Location.X + 1, this.Location.Y);
            }

        }

        /// <summary>
        /// Copies the contents of the given array of colors into this FastBitmap.
        /// Throws an ArgumentException if the count of colors on the array mismatches the pixel count from this FastBitmap
        /// </summary>
        /// <param name="colors">The array of colors to copy</param>
        /// <param name="bitmap">The Result Bitmap</param>
        public static int[] CopyToArray(Bitmap bitmap)
        {
            if (Image.GetPixelFormatSize(bitmap.PixelFormat) != 32)
            {
                throw new ArgumentException(@"The provided bitmap must have a 32bpp depth", nameof(bitmap));
            }
            int[] data = new int[bitmap.Width * bitmap.Height];

            var bmpData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, bitmap.PixelFormat);

            System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, data, 0, data.Length);

            bitmap.UnlockBits(bmpData);
            return data;
        }

        /// <summary>
        /// Copies the contents of the given array of colors into this FastBitmap.
        /// Throws an ArgumentException if the count of colors on the array mismatches the pixel count from this FastBitmap
        /// </summary>
        /// <param name="data">The array of colors to copy</param>
        /// <param name="bitmap">The Result Bitmap</param>
        public static void CopyFromArray(int[] data, Bitmap bitmap)
        {
            if (Image.GetPixelFormatSize(bitmap.PixelFormat) != 32)
            {
                throw new ArgumentException(@"The provided bitmap must have a 32bpp depth", nameof(bitmap));
            }
            var bmpData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),ImageLockMode.WriteOnly, bitmap.PixelFormat);

            System.Runtime.InteropServices.Marshal.Copy(data, 0, bmpData.Scan0, data.Length);

            bitmap.UnlockBits(bmpData);
        }

        /// <summary>
        /// 附加功能：将颜色转换为相对色(int)
        /// </summary>
        /// <param name="color">转换前的颜色(int)</param>
        /// <returns>转换后的相对颜色(int)</returns>
        public static int InvertedColor(int color)
        {
            return color ^ 0xFFFFFF;
        }
    }
}
