using SciColorMaps;
using System;
using System.Drawing;
using System.Windows.Forms;
using Unplugged.Segy;

namespace Seismic
{
    class drawRect
    {
        public static byte[] color = null;
        //Bitmap graph;

        public static Bitmap Do(ISegyFile line, double side_a, double side_b, double v, double t, double[] maxmin, string pallete, int quantity_of_colors, double[] usilenie)
        {
            Bitmap graph;
            double quantity_of_dots_a = 0, quantity_of_dots_b = 0, x_for_a_quantity_of_traces = 0,koeff_i=0;
            int  quantity_of_traces_a = 0, quantity_of_traces_b = 0, curr_trace = 0,quantity_of_dots=0,step_size_for_trace=0,n=0;
            const int space_for_axes = 40;
            ColorMap cmap;//инициализация палитры
            if (pallete == "default pallete")
                cmap = new ColorMap("my_own_colormap", maxmin[0], maxmin[1], quantity_of_colors, MainForm.rgbs, MainForm.positions);
            else
                cmap = new ColorMap(pallete, maxmin[0], maxmin[1], quantity_of_colors);
            if (side_a == side_b)//если колонна квадратная
            {
                quantity_of_dots_a = Math.Round(2*side_a / (v * t));//количество точек
                quantity_of_dots_b = quantity_of_dots_a;//по сторонам количество точек одинаковое
                step_size_for_trace = Convert.ToInt32(Math.Floor(line.Traces.Count / (4 * quantity_of_dots_a)));//шаг для трассы
                quantity_of_traces_a = line.Traces.Count;//количество трасс
                graph = new Bitmap((int)quantity_of_dots_a + space_for_axes+20, (int)quantity_of_dots_a + space_for_axes+20);//создание битмапа


                for (int k = 0; k < 4; k++)//цикл по треугольникам
                {
                    curr_trace = quantity_of_traces_a / 4 * k;//текущая трасса в зависимости от треугольника
                    for (int i = 0; i < quantity_of_dots_a; i++)//цикл по основанию треугольника (ось х)
                    {
                        curr_trace = curr_trace + step_size_for_trace;//изменяем трассу на шаг
                        for (int j = 0; j < i; j++)//цикл по высоте треугольника (ось у)
                        {
                            if (j > quantity_of_dots_a - i)//если перешли половину 
                                continue;//то пропускаем итеррацию
                            GetColor(usilenie, cmap, line, curr_trace, j);//получаем цвет
                            switch (k)
                            {
                                case 0://рисуем левый треугольник
                                    graph.SetPixel(space_for_axes + j, space_for_axes + i, Color.FromArgb(color[0], color[1], color[2]));//left
                                    break;
                                case 1://рисуем нижний треугольник
                                    graph.SetPixel(space_for_axes + i, space_for_axes + Convert.ToInt32(quantity_of_dots_a - j), Color.FromArgb(color[0], color[1], color[2]));//down
                                    break;
                                case 2://рисуем правый треугольник
                                    graph.SetPixel(space_for_axes + Convert.ToInt32(quantity_of_dots_a - j), space_for_axes + Convert.ToInt32(quantity_of_dots_a - i) , Color.FromArgb(color[0], color[1], color[2]));//right
                                    break;
                                case 3://рисуем верхний треугольник
                                    graph.SetPixel(space_for_axes + Convert.ToInt32(quantity_of_dots_a - i), space_for_axes + j, Color.FromArgb(color[0], color[1], color[2]));//up
                                    break;
                            }
                        }
                    }
                }
            }
            else
            {
                quantity_of_dots_a = Math.Round(2*side_a / (v * t));//количество точек по длине
                quantity_of_dots_b = Math.Round(2*side_b / (v * t));//количество точек по ширине
                x_for_a_quantity_of_traces = line.Traces.Count / (2 + 2 * (side_b / side_a));//неизвестная для распеределения трасс  по сторонам
                quantity_of_traces_a = Convert.ToInt32(2 * x_for_a_quantity_of_traces);//количество трасс по длине
                quantity_of_traces_b = Convert.ToInt32(2 * x_for_a_quantity_of_traces*(side_b/side_a));//количество трасс по ширине
                step_size_for_trace = Convert.ToInt32(Math.Floor(line.Traces.Count / (2 * quantity_of_dots_a + 2 * quantity_of_dots_b)));//шаг для трассы
                graph = new Bitmap((int)quantity_of_dots_a+ space_for_axes + 20, (int)quantity_of_dots_b+ space_for_axes + 20);//создание битмапа для изображения
                for (int k = 0; k < 4; k++)//цикл по треугольникам
                {
                    switch (k)//инициализация начальных данных
                    {
                        case 0://левый треугольник
                            quantity_of_dots = (int)quantity_of_dots_b;//длина основания равна ширине изображения
                            koeff_i = side_a / side_b;//кофэфициент равен длина / ширина = тангенс угла между диагональю и шириной
                            break;

                        case 1://нижний треугольник
                            quantity_of_dots = (int)quantity_of_dots_a;//длина основания равна длине изображения
                            koeff_i = side_b / side_a;//коэффициент равен ширина / длина = тангенс угла между диагональю и длиной
                            break;
                        case 2://правый треугольник
                            quantity_of_dots = (int)quantity_of_dots_b;//длина основания равна ширине изображения
                            koeff_i = side_a / side_b;//кофэфициент равен длина / ширина = тангенс угла между диагональю и шириной
                            break;
                        case 3:
                            quantity_of_dots = (int)quantity_of_dots_a;//длина основания равна длине изображения
                            koeff_i = side_b / side_a;//коэффициент равен ширина / длина = тангенс угла между диагональю и длиной
                            break;
                    }

                    for (int i = 0; i < quantity_of_dots; i++)//цикл по основанию треугольника
                    {
                        curr_trace = curr_trace + step_size_for_trace;//увеличение текущей трассы на шаг
                        if (i<quantity_of_dots/2)//если двигаясь по основанию перешли половину
                            n = Convert.ToInt32(Math.Floor(koeff_i * i));//то координата диагонали увеличивается с увеличением n
                        else
                            n = Convert.ToInt32(Math.Floor(koeff_i * (quantity_of_dots-i)));//иначе уменьшается

                        for (int j = 0; j <= n; j++)//цикл по высоте от основания до начала диагонали в прямоугольнике (стороны треугольника)
                        { 
                            GetColor(usilenie, cmap, line, curr_trace, j);//получить цвет
                            switch (k)//определение номера треугольника
                            {
                                case 0://левый треугольник
                                    graph.SetPixel(space_for_axes + j, space_for_axes + i, Color.FromArgb(color[0], color[1], color[2]));//ставим пиксель
                                    break;
                                case 1://нижний треугольник
                                    graph.SetPixel(space_for_axes + i, space_for_axes + Convert.ToInt32(quantity_of_dots_b - j), Color.FromArgb(color[0], color[1], color[2]));////ставим пиксель
                                    break;
                                case 2://правый треугольник
                                    graph.SetPixel(space_for_axes + Convert.ToInt32(quantity_of_dots_a - j), space_for_axes + Convert.ToInt32(quantity_of_dots_b - i), Color.FromArgb(color[0], color[1], color[2]));////ставим пиксель
                                    break;
                                case 3://верхний треугольник
                                    graph.SetPixel(space_for_axes + Convert.ToInt32(quantity_of_dots_a - i), space_for_axes + j, Color.FromArgb(color[0], color[1], color[2]));////ставим пиксель
                                    break;
                            }
                        }
                    }
                }
            }
            return graph;//возвращаем изображение            
        }

        public static void GetColor(double[] usilenie, ColorMap cmap, ISegyFile line, int curr_trace, int j)
        {
            if (usilenie[0] == 0)
                color = cmap[line.Traces[curr_trace].Values[j]];
            else
                color = cmap[line.Traces[curr_trace].Values[j] * usilenie[1] * Math.Pow(j, usilenie[2])];
        }
    }
}