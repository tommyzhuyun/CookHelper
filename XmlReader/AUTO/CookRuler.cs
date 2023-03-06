using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace CookHelper
{
    public partial class CookRuler : Form
    {
        private int value1, value2, value3;
        private int LineImage = Color.Black.ToArgb();
        private readonly Bitmap MABI;
        private readonly Bitmap ICON;
        private bool HighDPI;

        public CookRuler(int v1, int v2, int v3, bool HighDPI)
        {
            InitializeComponent();
            this.HighDPI = HighDPI;
            value1 = v1;
            value2 = v2;
            value3 = v3;
            changed = false;
            MABI = Properties.Resources.MABI;
            ICON = ChangeBackImage();
        }
        public void Update(int v1, int v2, int v3, bool HighDPI)
        {
            this.HighDPI = HighDPI;
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

        private bool changed;
        private void CookRuler_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                changed = !changed;
                LineImage = InvertedColor(LineImage);
                RulerImage();
            }
        }

        private Bitmap ChangeBackImage()
        {
            Bitmap ICON = new Bitmap(MABI.Width, MABI.Height);
            using (Graphics g = Graphics.FromImage(ICON))
            {
                g.DrawImage(Properties.Resources.MABI, 0, 0);
            }
            int ControlColor = SystemColors.Control.ToArgb();
            int[] data = CopyToArray(ICON);

            for (int x = 0; x < ICON.Width; x++)//228
            {
                for (int y = 0; y < ICON.Height; y++)
                {
                    if (data[x + y * ICON.Width] != ControlColor)
                    {
                        data[x + y * ICON.Width] = InvertedColor(data[x + y * ICON.Width]);
                    }
                }
            }
            CopyFromArray(data, ICON);
            return ICON;
        }

        private void RulerImage()
        {
            int sum = value3 + value2 + value1;
            Rectangle RulerLocation = new Rectangle(98, 43, 243, 9); //341-97
            int point1 = (value1) * (RulerLocation.Width) / sum;
            int point2 = (value1 + value2) * (RulerLocation.Width) / sum;
            int point3 = (value1 + value2 + value3) * (RulerLocation.Width) / sum;

            Rectangle P1 = new Rectangle(RulerLocation.X,
                                        RulerLocation.Y,
                                        point1,
                                        RulerLocation.Height);
            Rectangle P2 = new Rectangle(RulerLocation.X + point1,
                                        RulerLocation.Y,
                                        point2 - point1,
                                        RulerLocation.Height);
            Rectangle P3 = new Rectangle(RulerLocation.X + point2,
                                        RulerLocation.Y,
                                        point3 - point2,
                                        RulerLocation.Height);
            float dx = 96, dy = 96;
            Bitmap BackImage = new Bitmap(Width, Height);

            using (Graphics g = Graphics.FromImage(BackImage))
            using (Pen Line = new Pen(Color.FromArgb(LineImage)))
            using (Pen ControlP = new Pen(SystemColors.Control))
            {
                if (HighDPI)
                {
                    dx = g.DpiX;
                    dy = g.DpiY;
                }
                //Console.WriteLine(dx + " " + dy);
                g.Clear(SystemColors.Control);
                Rectangle left = OnScalRectangle(20, 54, MABI.Width, MABI.Height, dx, dy);
                Rectangle right = OnScalRectangle(290, 54, MABI.Width, MABI.Height, dx, dy);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                if (!changed)
                {
                    g.DrawImage(MABI, left.X, left.Y, left.Width, left.Height);
                    g.DrawImage(MABI, right.X, right.Y, right.Width, right.Height);
                }
                else
                {
                    g.DrawImage(ICON, left.X, left.Y, left.Width, left.Height);
                    g.DrawImage(ICON, right.X, right.Y, right.Width, right.Height);
                }
                g.DrawRectangle(Line, OnScalRectangle(0, -1, 354, 53, dx, dy));//浓度框
                g.DrawLine(Line, OnScalPoint(97, 34, dx, dy), OnScalPoint(97, 51, dx, dy));
                g.DrawLine(Line, OnScalPoint(341, 34, dx, dy), OnScalPoint(341, 51, dx, dy));
                g.DrawRectangle(Line, OnScalRectangle(97, 58, 69, 35, dx, dy));//确认
                g.DrawRectangle(Line, OnScalRectangle(189, 58, 69, 35, dx, dy));//取消

                g.FillRectangle(Brushes.Yellow, OnScalRectangle(P1, dx, dy));
                if (value2 != 0)
                {
                    g.FillRectangle(Brushes.Cyan, OnScalRectangle(P2, dx, dy));
                    g.DrawLine(Line, OnScalPoint(P2.X, P2.Top - 9, dx, dy), OnScalPoint(P2.X, P2.Bottom, dx, dy));
                }
                if (value3 != 0)
                {
                    g.FillRectangle(Brushes.HotPink, OnScalRectangle(P3, dx, dy));
                    g.DrawLine(Line, OnScalPoint(P3.X, P3.Top - 9, dx, dy), OnScalPoint(P3.X, P3.Bottom, dx, dy));
                }
            }

            Ruler.Image?.Dispose();
            Ruler.Image = BackImage;
        }

        private Point OnScalPoint(int x, int y, float dx, float dy)
        {
            return new Point((int)(x * dx / 96), (int)(y * dy / 96)); 
        }

        private Rectangle OnScalRectangle(int x, int y, int width, int height,  float dx, float dy)
        {
            return new Rectangle((int)(x * dx / 96), (int)(y * dy / 96), (int)(width * dx / 96), (int)(height * dy / 96));
        }

        private Rectangle OnScalRectangle(Rectangle re, float dx, float dy)
        {
            return new Rectangle((int)(re.X * dx / 96), (int)(re.Y * dy / 96), (int)(re.Width * dx / 96), (int)(re.Height * dy / 96));
        }

        private void CookRuler_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            //Console.WriteLine(key);
            if (key == (char)Keys.Escape)
            {
                this.Close();
            }
            else if (key == 'w')
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
            var bmpData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.WriteOnly, bitmap.PixelFormat);

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
