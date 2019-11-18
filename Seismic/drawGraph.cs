using System.Drawing;
using Unplugged.Segy;
using SciColorMaps;
using System;
using System.Windows.Forms;

namespace Seismic
{
    class drawGraph
    {
        public static Bitmap Do(ISegyFile line, double[] maxmin,string pallete,int quantity_of_colors,double[] usilenie, PictureBox[] pictureBoxes, double v, double t)
        {
            ITrace trace = line.Traces[0];//создаем переменную типа трасса

            Bitmap graph = new Bitmap(line.Traces.Count, trace.Values.Count);//создаем битмап для изображения
            ColorMap cmap;//создаем палитру
            if (pallete == "default pallete")//если выбрана палитра по умолчанию
                cmap = new ColorMap("my_own_colormap", maxmin[0], maxmin[1], quantity_of_colors, MainForm.rgbs, MainForm.positions);//инициализируем ее по умолчанию
            else
                cmap = new ColorMap(pallete, maxmin[0], maxmin[1], quantity_of_colors);//если нет, то инициализируем ее в соответствии с входными параметрами
            byte[] color;//массив байтов - цвет точки
            int j = 1;//счетчик

            for (int i = 0; i < line.Traces.Count; i++)//цикл по трассам от 0 до количества трасс
            {
                trace = line.Traces[i];//текущая трасса
                j = 0;//обнуление счетчика отвечающего за номер точки
                foreach (var sampleValue in trace.Values)//перебор всех точек в текущей трассе
                {
                    if (usilenie[0] == 0)//если усиление не требуется
                        color = cmap[sampleValue];//цвет определяется без усиления
                    else
                        color = cmap[sampleValue * usilenie[1] * Math.Pow(j, usilenie[2])];//иначе с учетом усиления
                    graph.SetPixel(i, j, Color.FromArgb(color[0], color[1], color[2]));//рисуем пиксель на битмапе
                    j++;//увеличиваем номер точки
                }
            }
            drawAxesForGraph.Do(pictureBoxes, line.Traces.Count, line.Traces[0].Values.Count*t, v, t, 10, false);//рисуем оси
            return graph;//возвращаем изображение
        }
    }
}
