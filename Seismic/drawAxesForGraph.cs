using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seismic
{
    class drawAxesForGraph
    {
        public static void Do(PictureBox[] pictureBoxes, double side_a, double side_b, double v, double t,int quantity, bool dotsTraces_0_timeDistance_1)
        {
            Bitmap x, y;
            const int shift_for_last_label=13;
            x = new Bitmap(pictureBoxes[1].Width, 40);
            y = new Bitmap(40, pictureBoxes[2].Height);
            int step_size_x = (pictureBoxes[1].Width- shift_for_last_label) / quantity, step_size_y = (pictureBoxes[2].Height- shift_for_last_label+3) / quantity;
            double value; 
            double scale_x = 0, scale_y = 0;
            if (pictureBoxes[0].Width % 10 == 0)
                scale_x = side_a / quantity;
            else
                scale_x = Math.Floor(side_a / quantity);
            if (pictureBoxes[0].Height % 10 == 0)
                scale_y = side_b / quantity;
            else
                scale_y = Math.Floor(side_b / quantity);
            Graphics graph_graphics = Graphics.FromImage(x);
            graph_graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graph_graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graph_graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graph_graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            RectangleF rectf;
            for (int i =0; i <= pictureBoxes[1].Width- shift_for_last_label; i++)
            {
                if (i  % step_size_x == 0)
                {
                    if (i != 0)
                    {
                        value = Math.Round(scale_x * (i  / step_size_x), 2);
                        rectf = new RectangleF(i - value.ToString().Length * 4, 17, value.ToString().Length * 10, 20);
                        graph_graphics.DrawString(value.ToString(), new Font("Arial", 9), Brushes.Black, rectf);
                        graph_graphics.Flush();
                    }
                    x.SetPixel(i, 34, Color.Black);
                    x.SetPixel(i, 35, Color.Black);
                    x.SetPixel(i, 36, Color.Black);
                    x.SetPixel(i, 39, Color.Black);
                }
                x.SetPixel(i, 37, Color.Black);
                x.SetPixel(i, 38, Color.Black);
            }

            graph_graphics = Graphics.FromImage(y);
            for (int i = 0; i <= pictureBoxes[2].Height- shift_for_last_label+3; i++)
            {
                if (i % step_size_y == 0)
                {
                    if (i != 0)
                    {
                        value = Math.Round(scale_y * (i  / step_size_y), 2);
                        rectf = new RectangleF(25 - value.ToString().Length * 5, i - 8, value.ToString().Length * 10, 20);
                        graph_graphics.DrawString(value.ToString(), new Font("Arial", 9), Brushes.Black, rectf);
                        graph_graphics.Flush();
                    }
                    y.SetPixel(34, i, Color.Black);
                    y.SetPixel(35, i, Color.Black);
                    y.SetPixel(36, i, Color.Black);
                    y.SetPixel(39, i, Color.Black);
                }
                y.SetPixel(37, i, Color.Black);
                y.SetPixel(38, i, Color.Black);
            }
            pictureBoxes[1].Image = x;
            pictureBoxes[2].Image = y;
        }
    }
}
