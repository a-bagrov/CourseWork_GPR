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
    class drawAxesOnRect
    {
        public static Bitmap Do(Bitmap graph_original, double side_a, double side_b, int[] quantity, double quantity_of_dots_a, double quantity_of_dots_b, int space_for_axes, bool grid)
        {
            Bitmap graph = graph_original.Clone(new Rectangle(0, 0, graph_original.Width, graph_original.Height), graph_original.PixelFormat);
            int step_size_x = (graph.Width-60) / quantity[0], step_size_y = (graph.Height - 60) / quantity[1];
            double value;
            double scale_x = side_a / quantity[0], scale_y = side_b / quantity[1];
            if ((graph.Width - 60) % quantity[0] != 0)
                if (scale_x % quantity[0] > 5)
                    scale_x = Math.Floor(side_a / quantity[0]);
                else
                    scale_x = Math.Floor(side_a / quantity[0]);
            if ((graph.Height - 60) % quantity[0] != 0)
                if (scale_y % quantity[1] > 5)
                    scale_y = Math.Floor(side_b / quantity[1]);
                else
                    scale_y = Math.Floor(side_b / quantity[1]);
            if (!grid)
            {
                RectangleF rectf;
                Graphics graph_graphics = Graphics.FromImage(graph);
                graph_graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graph_graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graph_graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graph_graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                for (int i = 40; i < graph.Width - 19; i++) //x
                {
                    graph.SetPixel(i, 37, Color.Black);
                    graph.SetPixel(i, 38, Color.Black);
                }

                for (int i = 40; i < graph.Height - 19; i++) //y
                {
                    graph.SetPixel(37, i, Color.Black);
                    graph.SetPixel(38, i, Color.Black);
                }

                for (int i = 40; i < graph.Width - 19; i += step_size_x) //labels on x
                {

                    value = Math.Round(scale_x * ((i - 40) / step_size_x), 1);
                    rectf = new RectangleF(i - value.ToString().Length * 4, ((i - 40) / step_size_x) % 2 == 0 ? 17 : 5, value.ToString().Length * 10, 20);
                    graph_graphics.DrawString(value.ToString(), new Font("Arial", 9), Brushes.Black, rectf);
                    graph_graphics.Flush();

                    if (((i - 40) / step_size_x) % 2 != 0)
                    {
                        graph.SetPixel(i, 33, Color.Black);
                        graph.SetPixel(i, 32, Color.Black);
                        graph.SetPixel(i, 31, Color.Black);
                        graph.SetPixel(i, 30, Color.Black);
                        graph.SetPixel(i, 29, Color.Black);
                        graph.SetPixel(i, 28, Color.Black);
                        graph.SetPixel(i, 27, Color.Black);
                        graph.SetPixel(i, 26, Color.Black);
                    }
                    graph.SetPixel(i, 34, Color.Black);
                    graph.SetPixel(i, 35, Color.Black);
                    graph.SetPixel(i, 36, Color.Black);
                    graph.SetPixel(i, 39, Color.Black);

                }

                for (int i = 40; i < graph.Height - 19; i += step_size_y) //labels on y
                {


                    value = Math.Round(scale_y * ((i - 40) / step_size_y), 1);
                    rectf = new RectangleF(25 - value.ToString().Length * 5, i - 8, value.ToString().Length * 10, 20);
                    graph_graphics.DrawString(value.ToString(), new Font("Arial", 9), Brushes.Black, rectf);
                    graph_graphics.Flush();

                    graph.SetPixel(34, i, Color.Black);
                    graph.SetPixel(35, i, Color.Black);
                    graph.SetPixel(36, i, Color.Black);
                    graph.SetPixel(39, i, Color.Black);
                }
            }
            else
            {
                for (int i = 40; i < graph.Width - 19; i += step_size_x) //grid lines on x
                {
                    for (int j = 40; j < graph.Height - 19; j++)
                        graph.SetPixel(i, j, Color.Gray);
                }

                for (int i = 40; i < graph.Height - 19; i += step_size_y) //grid lines on y
                {
                    for(int j = 40; j < graph.Width - 19; j++)
                            graph.SetPixel(j, i, Color.Gray);
                }
            }
            return graph;
        }
    }
}
