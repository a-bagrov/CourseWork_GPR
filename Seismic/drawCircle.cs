using System;
using System.Drawing;
using Unplugged.Segy;
using SciColorMaps;
using System.Windows.Forms;

namespace Seismic
{
    class drawCircle
    {
        public static Bitmap Do(ISegyFile line, double radius, double v, double t, double[] maxmin, string pallete, int quantity_of_colors,double[] usilenie)
        {
            double x, y, changing_radius;
            double angle=0;//угол = 0
            int quantity_of_dots = Convert.ToInt32(Math.Floor((2*radius) / (v * t)));//количество пикселей в одном радиусе
            double step_size_for_angle = 360.0 / (line.Traces.Count-1);//шаг для трассы в градусах

            ColorMap cmap;//инициализация палитры
            if (pallete == "default pallete")
                cmap = new ColorMap("my_own_colormap", maxmin[0], maxmin[1], quantity_of_colors, MainForm.rgbs, MainForm.positions);
            else
                cmap = new ColorMap(pallete, maxmin[0], maxmin[1], quantity_of_colors);

            byte[] color;//массив байтов для цвета
            int i = line.Traces.Count-1;//текущая трасса
            const int space_for_axes = 40;//место для осей
            //создание битмапа для изображения
            Bitmap graph = new Bitmap(2*Convert.ToInt32(quantity_of_dots)+space_for_axes+20, 2*Convert.ToInt32(quantity_of_dots) + space_for_axes + 20);
            while (angle < 360)//пока угол меньше 360
            {
                changing_radius = quantity_of_dots;//текущий радиус - количество точек
                for (int j = 0; j < quantity_of_dots; j++)//цикл от 0 до количества точек
                {
                    if (usilenie[0]==0)//определение цвета в зависимосто от усиления
                        color = cmap[line.Traces[i].Values[j]];
                    else
                        color = cmap[line.Traces[i].Values[j]*usilenie[1]*Math.Pow(j+1,usilenie[2])];
                    x = quantity_of_dots + (changing_radius * Math.Cos(angle*Math.PI/180.0));//определение координаты х
                    y = quantity_of_dots + (changing_radius * Math.Sin(angle * Math.PI / 180.0));//определение координаты у
                    graph.SetPixel((int)x+ space_for_axes, (int)y+ space_for_axes, Color.FromArgb(color[0], color[1], color[2]));//отрисовка пикселся на битмапе
                    changing_radius = changing_radius-1;//текущий радиус на 1 меньше
                }
                i--;//следующая трасса
                angle += step_size_for_angle;//следующий угол
            }
            
            return graph;//вернуть изображение

        }
    }
}
