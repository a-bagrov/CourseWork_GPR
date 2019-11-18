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
    class drawAxesOnCircle
    {
        public static Bitmap Do(Bitmap graph_original, double radius, int[] quantity, double quantity_of_dots_a, double quantity_of_dots_b, int space_for_axes, bool grid)
        {
            Bitmap graph =graph_original.Clone(new Rectangle(0,0,graph_original.Width,graph_original.Height),graph_original.PixelFormat);
            int step_size_x = (graph.Width - 60) / quantity[0], step_size_y = (graph.Height - 60) / quantity[1];
            double value=0;//, const_x= Math.Round(((graph.Width - 60) % quantity) * (Convert.ToDouble(radius)/ (graph.Width - 60))),const_y= Math.Round(((graph.Height - 60) % quantity) * ( Convert.ToDouble(radius)/ (graph.Height - 60) ));
            double scale_x = 2*radius / quantity[0], scale_y = 2*radius / quantity[1], font_size = 0;
            Graphics graph_graphics = Graphics.FromImage(graph);
            RectangleF rectf;
            if (!grid)
            {
                
                graph_graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graph_graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graph_graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graph_graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                
                font_size = Math.Floor(quantity_of_dots_a / 200 * 7);
                for (int i = 40; i < graph.Width - 19; i++)
                {
                    graph.SetPixel(i, 37, Color.Black);
                    graph.SetPixel(i, 38, Color.Black);
                }
                for (int i = 40; i < graph.Height - 19; i++)
                {

                    graph.SetPixel(37, i, Color.Black);
                    graph.SetPixel(38, i, Color.Black);
                }
            }
            for (int i=(graph.Width+20)/2;i<graph.Width-19;i+=step_size_x)
            {
                if (i == (graph.Width + 20) / 2 )
                {
                    if (grid)
                    {
                        for (int j = 40; j < graph.Height - 19; j++)
                            graph.SetPixel(i, j, Color.Gray);
                    }
                    else
                    {
                        value = 0;
                        rectf = new RectangleF(i - value.ToString().Length * 4, 18, value.ToString().Length * 10, 20);
                        graph_graphics.DrawString(value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, rectf);
                        graph_graphics.Flush();

                        graph.SetPixel(i, 34, Color.Black);
                        graph.SetPixel(i, 35, Color.Black);
                        graph.SetPixel(i, 36, Color.Black);
                        graph.SetPixel(i, 39, Color.Black);
                    }
                }
                else
                {
                    if (grid)
                    {
                        for (int j = 40; j < graph.Height - 19; j++)
                        {
                            graph.SetPixel(i, j, Color.Gray);
                            graph.SetPixel(graph.Width + 20 - i, j, Color.Gray);
                        }
                    }
                    else
                    { 
                        value = Math.Round(value + scale_x, 1);
                        rectf = new RectangleF(i - value.ToString().Length * 4, 17, value.ToString().Length * 10, 20);
                        graph_graphics.DrawString(value.ToString(), new Font("Arial", 9), Brushes.Black, rectf);
                        rectf = new RectangleF(graph.Width - i + value.ToString().Length * 3, 17, value.ToString().Length * 10, 20);
                        graph_graphics.DrawString(value.ToString(), new Font("Arial", 9), Brushes.Black, rectf);
                        graph_graphics.Flush();
                        
                        graph.SetPixel(i, 34, Color.Black);
                        graph.SetPixel(i, 35, Color.Black);
                        graph.SetPixel(i, 36, Color.Black);
                        graph.SetPixel(i, 39, Color.Black);
                        graph.SetPixel(graph.Width + 20 - i, 34, Color.Black);
                        graph.SetPixel(graph.Width + 20 - i, 35, Color.Black);
                        graph.SetPixel(graph.Width + 20 - i, 36, Color.Black);
                        graph.SetPixel(graph.Width + 20 - i, 39, Color.Black);
                    }
                }
            }

            for (int i = (graph.Height + 20) / 2; i < graph.Height - 19; i += step_size_y)
            {
                if (i == (graph.Height + 20) / 2)
                {
                    if (grid)
                    {
                        for (int j = 40; j < graph.Width - 19; j++)
                            graph.SetPixel(j, i, Color.Gray);
                    }
                    else
                    {
                        value = 0;
                        rectf = new RectangleF(25 - value.ToString().Length * 5, i - 5, value.ToString().Length * 10, 20);
                        graph_graphics.DrawString(value.ToString(), new Font("Arial", 9,FontStyle.Bold), Brushes.Black, rectf);
                        graph_graphics.Flush();


                        graph.SetPixel(34, i, Color.Black);
                        graph.SetPixel(35, i, Color.Black);
                        graph.SetPixel(36, i, Color.Black);
                        graph.SetPixel(39, i, Color.Black);
                    }
                }
                else
                {
                    if (grid)
                    {
                        for (int j = 40; j < graph.Width - 19; j++)
                        {
                            graph.SetPixel(j, i, Color.Gray);
                            graph.SetPixel(j, graph.Height + 20 - i, Color.Gray);
                        }
                    }
                    else
                    {
                        value = Math.Round(value + scale_y, 1);
                        rectf = new RectangleF(25 - value.ToString().Length * 5, i - 8, value.ToString().Length * 10, 20);
                        graph_graphics.DrawString(value.ToString(), new Font("Arial", 9), Brushes.Black, rectf);
                        rectf = new RectangleF(25 - value.ToString().Length * 5, graph.Height - i + 13, value.ToString().Length * 10, 20);
                        graph_graphics.DrawString(value.ToString(), new Font("Arial", 9), Brushes.Black, rectf);
                        graph_graphics.Flush();

                        graph.SetPixel(34, i, Color.Black);
                        graph.SetPixel(35, i, Color.Black);
                        graph.SetPixel(36, i, Color.Black);
                        graph.SetPixel(39, i, Color.Black);
                        graph.SetPixel(34, graph.Height + 20 - i, Color.Black);
                        graph.SetPixel(35, graph.Height + 20 - i, Color.Black);
                        graph.SetPixel(36, graph.Height + 20 - i, Color.Black);
                        graph.SetPixel(39, graph.Height + 20 - i, Color.Black);
                    }
                }
            }
            return graph;
        }
    }
}
