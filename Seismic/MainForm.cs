using System;
using System.Drawing;
using System.Windows.Forms;
using Unplugged.Segy;
using System.IO;
using System.Drawing.Imaging;
using ColorMap = SciColorMaps.ColorMap;

namespace Seismic
{

    public partial class MainForm : Form
    {
        ISegyFile line=null;
        double[] maxmin=null;
        string filename=null, filename_Drag_Drop = null;
        double[] usilenie = { 0, 0, 0 };
        bool main_input_correct=true,rect_correct=true,usilenie_correct=true,circle_correct = true,is_Drag_Drop=false, is_File_Ok=false;
        Bitmap[] rect_image = new Bitmap[3] { null, null, null };
        Bitmap[] circle_image= new Bitmap[3] { null, null, null };

        public static byte[][] rgbs = new[] { //цвета для стандартной палитры
                    new byte[] {255, 255, 000},
                    new byte[] {230, 0, 0},
                    new byte[] {0, 255, 0},
                    new byte[] {0, 0, 255},
                    new byte[] {0, 0, 0}
                  };
        public static float[] positions = new float[] { 0, 0.246f, 0.512f, 0.772f, 1 };//их позиции

        public MainForm()
        {
            InitializeComponent();
            foreach (var palette in ColorMap.Palettes)//добавление всех доступных палитр в combobox
            {
                comboBox1.Items.Add(palette);
            }
            comboBox1.Items.Add("default pallete");
            comboBox1.SelectedItem = "default pallete";//палитра по умолчанию 
            this.WindowState = FormWindowState.Maximized;//максимальный размер окна
            usilenie[0] = 0;
        }
        private void button1_Click(object sender, EventArgs e) //клик на кнопку открыть файл
        {
            if (!is_Drag_Drop)//если запуск произошел не из-за драг-дропа
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)//то показываем диалог на открытие файла
                    return;// если отмена то выходим
                filename = openFileDialog1.FileName;//имя файла
            }
            else
            {
                filename = filename_Drag_Drop;//имя файла
            }

            try
            {
                var reader = new SegyReader();//чтение
                line = reader.Read(filename);
            }
            catch (Exception ex)//если не получилось
            {
                is_File_Ok = false;
                MessageBox.Show(null, "Не удалось открыть файл: \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            is_File_Ok = true;
            label_name.Text = "Файл: " + Path.GetFileName(filename);
            label_traces_dots.Text = "Трасс / точек: " + line.Traces.Count.ToString() + " / " + line.Traces[0].Values.Count.ToString();
            Text = filename + " — файл открыт";
            FindStepSizeForTrace();
            is_Drag_Drop = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filename != null&&usilenie_correct&&main_input_correct)
            {
                if(usilenie[0]==1)
                    CreateUsilenie();
                maxmin = findMaxMin.Do(line,usilenie);
                PictureBox[] pictureBoxes = { pictureBox_rect, pictureBox_graph_axes_x, pictureBox_graph_axes_y };
                pictureBox_graph.Image = drawGraph.Do(line, maxmin, comboBox1.SelectedItem.ToString(), trackBar1.Value,usilenie,pictureBoxes, double.Parse(textBox_v.Text), double.Parse(textBox_t.Text));
                groupBox_graph_image.Text = "Радарограмма "+ Path.GetFileName(filename) + " (текущие параметры построения: дискретизация — " + Math.Round(double.Parse(textBox_t.Text), 5).ToString() + " нс, усиление — " + ((usilenie[0]==0.0) ? " ВЫКЛ)":" ВКЛ)") ;
            }
        }

        private void CreateUsilenie()
        {
            usilenie[1] = double.Parse(textBox_koeffX.Text);
            usilenie[2] = double.Parse(textBox_stepenX.Text);
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = "Количество цветов: " + trackBar1.Value;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (usilenie[0]==1)
                usilenie_correct = IsCorrect(textBox_koeffX);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            main_input_correct = IsCorrect(textBox_v) && IsCorrect(textBox_t);
            FindStepSizeForTrace();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            main_input_correct = IsCorrect(textBox_v) && IsCorrect(textBox_t);
            FindStepSizeForTrace();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            circle_correct = IsCorrect(textBox_r);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             rect_correct= IsCorrect(textBox_sideA)&& IsCorrect(textBox_sideB);
             FindStepSizeForTrace();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            rect_correct = IsCorrect(textBox_sideA) && IsCorrect(textBox_sideB);
            FindStepSizeForTrace();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (usilenie[0] == 1)
                usilenie_correct = IsCorrect(textBox_stepenX);
        }
        private bool IsCorrect(TextBox textbox)
        {
            if (!Double.TryParse(textbox.Text, out double nul)||nul<=0)
            {
                textbox.BackColor = Color.Red;
                return false;
            }
            else
            {
                textbox.BackColor = SystemColors.Window;
                return true;
            }
        }

        public void FindStepSizeForTrace()
        {
            if (main_input_correct&&rect_correct&&filename!=null)
            {
                double side_a = 2*double.Parse(textBox_sideA.Text) / (double.Parse(textBox_v.Text) * double.Parse(textBox_t.Text));
                double side_b = 2*double.Parse(textBox_sideB.Text) / (double.Parse(textBox_v.Text) * double.Parse(textBox_t.Text));
                double p = 2 * (side_a + side_b);
                double stepsize = line.Traces.Count / p;
                if (stepsize<1)
                {
                    label_interpolation.Text = "Интерполяция: необходима";
                    label_trace_count.Text = "Требуется добавить трасс: "+ Math.Ceiling(line.Traces.Count / stepsize - line.Traces.Count).ToString()+ " ("+Math.Ceiling(line.Traces.Count / stepsize).ToString()+")";
                    label_trace_loses.Text = "Потери (трасс): 0";
                    label_trace_count.BackColor = Color.Red;
                    label_interpolation.BackColor = Color.Red;
                    label_trace_loses.BackColor = Color.Red;
                    label_stepsize.BackColor = Color.Red;
                }
                else
                {
                    if (Math.Truncate(stepsize)==stepsize)
                    {
                        label_interpolation.Text = "Интерполяция: не требуется";  
                        label_trace_count.Text = "Требуется добавить трасс: 0";
                        label_trace_loses.Text = "Потери (трасс): 0 (0%)";
                        label_interpolation.BackColor = Color.YellowGreen;
                        label_trace_count.BackColor = Color.YellowGreen;
                        label_trace_loses.BackColor = Color.YellowGreen;
                        label_stepsize.BackColor = Color.YellowGreen;
                    }
                    else
                    {
                        label_interpolation.Text = "Интерполяция: желательна";
                        label_trace_count.Text = "Требуется добавить трасс: " + Math.Ceiling(Math.Ceiling(stepsize) * p - line.Traces.Count).ToString() + " (" + Math.Ceiling(Math.Ceiling(stepsize) * p).ToString() + ")";
                        label_trace_loses.Text = "Потери (трасс): " + Math.Round(line.Traces.Count - Math.Floor(stepsize) * p,2).ToString() + " (" + Math.Round((line.Traces.Count - Math.Floor(stepsize) * p) / line.Traces.Count * 100, 2).ToString() + "%)";
                        if ((line.Traces.Count - Math.Floor(stepsize) * p)/ line.Traces.Count * 100 <10)
                        {
                            label_interpolation.Text = "Интерполяция: возможно желательна";
                            label_interpolation.BackColor = Color.YellowGreen;
                            label_trace_count.BackColor = Color.YellowGreen;
                            label_trace_loses.BackColor = Color.YellowGreen;
                            label_stepsize.BackColor = Color.YellowGreen;
                        }
                        else
                        {
                            label_interpolation.BackColor = Color.Yellow;
                            label_trace_count.BackColor = Color.Yellow;
                            label_trace_loses.BackColor = Color.Yellow;
                            label_stepsize.BackColor = Color.Yellow;
                        }
                    }
                }
                label_stepsize.Text = Math.Round(line.Traces.Count / (2 * (side_a + side_b)),2).ToString();
            }
        }
        private void button_draw_rect_Click(object sender, EventArgs e)
        {
            if (filename != null && main_input_correct && usilenie_correct && rect_correct)
            {
                if (double.Parse(textBox_sideA.Text) / (double.Parse(textBox_v.Text) * double.Parse(textBox_t.Text)) < line.Traces[0].Values.Count && double.Parse(textBox_sideB.Text) / (double.Parse(textBox_v.Text) * double.Parse(textBox_t.Text)) < line.Traces[0].Values.Count)
                {
                    if (usilenie[0] != 0)
                        CreateUsilenie();
                    maxmin = findMaxMin.Do(line, usilenie);
                    pictureBox_rect.Height = 480;
                    if (double.Parse(textBox_sideA.Text) == double.Parse(textBox_sideB.Text))
                    {
                        pictureBox_rect.Width = pictureBox_rect.Height;
                    }
                    else
                    {
                        if ((int)(pictureBox_rect.Height * (double.Parse(textBox_sideA.Text) / double.Parse(textBox_sideB.Text))) > 805)
                        {
                            pictureBox_rect.Width = 805;
                            pictureBox_rect.Height = (int)(pictureBox_rect.Height * (double.Parse(textBox_sideB.Text) / double.Parse(textBox_sideA.Text)));
                        }
                        else
                        {
                            pictureBox_rect.Width = (int)(pictureBox_rect.Height * (double.Parse(textBox_sideA.Text) / double.Parse(textBox_sideB.Text)));
                        }
                    }
                    int quantity_side_a = Convert.ToInt32(double.Parse(textBox_sideA.Text) / (double.Parse(textBox_v.Text) * double.Parse(textBox_t.Text)));
                    int quantity_side_b = Convert.ToInt32(double.Parse(textBox_sideB.Text) / (double.Parse(textBox_v.Text) * double.Parse(textBox_t.Text)));
                    int[] quantity = { quantity_side_a / 10, quantity_side_b / 10 };
                    if (quantity[0] == 0) quantity[0] = 1;
                    if (quantity[0] > 10) quantity[0] = 10;
                    if (quantity[1] == 0) quantity[1] = 1;
                    if (quantity[1] > 10) quantity[1] = 10;

                    rect_image[0] = drawRect.Do(line, double.Parse(textBox_sideA.Text), double.Parse(textBox_sideB.Text), double.Parse(textBox_v.Text), double.Parse(textBox_t.Text), maxmin, comboBox1.SelectedItem.ToString(), trackBar1.Value, usilenie);
                    rect_image[1] = drawAxesOnRect.Do(rect_image[0], double.Parse(textBox_sideA.Text), double.Parse(textBox_sideB.Text), quantity, 0, 0, 40, false);
                    rect_image[2] = drawAxesOnRect.Do(rect_image[1], double.Parse(textBox_sideA.Text), double.Parse(textBox_sideB.Text), quantity, 0, 0, 40, true);

                    pictureBox_rect.Image = rect_image[GetIndexForImageByRadioButtons(false)];
                    groupBox_rect_image.Text = "Прямоугольный профиль " + Path.GetFileName(filename) + " (текущие параметры построения: длина — " + Math.Round(double.Parse(textBox_sideA.Text), 1).ToString() + " см, ширина — " + Math.Round(double.Parse(textBox_sideB.Text), 1).ToString() + " см, скорость волны — " + Math.Round(double.Parse(textBox_v.Text), 1).ToString() + " см/нс,  дискретизация — " + Math.Round(double.Parse(textBox_t.Text), 5).ToString() + " нс, усиление — " + ((usilenie[0] == 0.0) ? " ВЫКЛ)" : " ВКЛ)");
                }
                else
                {
                    MessageBox.Show(null, "Недостаточно точек для построения. Уменьшите стороны колонны, или увеличьте дискретизацию или скорость волны, или выберите файл с большим количеством точек.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void radioButton_circle_pure_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_circle.Image = circle_image[GetIndexForImageByRadioButtons(true)];
        }

        private void radioButton_circle_axes_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_circle.Image = circle_image[GetIndexForImageByRadioButtons(true)];
        }


        private void pictureBox_graph_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)&& (Path.GetExtension(((string[])e.Data.GetData(DataFormats.FileDrop, false))[0])==".sgy"|| Path.GetExtension(((string[])e.Data.GetData(DataFormats.FileDrop, false))[0]) == ".SGY"))
                e.Effect = DragDropEffects.Copy;
            
        }

        private void pictureBox_graph_DragDrop(object sender, DragEventArgs e)
        {
            is_Drag_Drop = true;
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && main_input_correct && usilenie_correct)
            {
                e.Effect = DragDropEffects.Copy;
                string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                filename_Drag_Drop = FileList[0];
                button1_Click(null, null);
                is_Drag_Drop = false;
                if (is_File_Ok)
                    button2_Click(null, null);
            }
        }
        private void pictureBox_rect_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && (Path.GetExtension(((string[])e.Data.GetData(DataFormats.FileDrop, false))[0]) == ".sgy" || Path.GetExtension(((string[])e.Data.GetData(DataFormats.FileDrop, false))[0]) == ".SGY"))
                e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox_rect_DragDrop(object sender, DragEventArgs e)
        {
            is_Drag_Drop = true;
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && main_input_correct && usilenie_correct)
            {
                e.Effect = DragDropEffects.Copy;
                string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                filename_Drag_Drop = FileList[0];
                button1_Click(null, null);
                is_Drag_Drop = false;
                if (is_File_Ok)
                    button_draw_rect_Click(null, null);
            }
        }

        private void pictureBox_circle_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && (Path.GetExtension(((string[])e.Data.GetData(DataFormats.FileDrop, false))[0]) == ".sgy" || Path.GetExtension(((string[])e.Data.GetData(DataFormats.FileDrop, false))[0]) == ".SGY"))
                e.Effect = DragDropEffects.Copy;
        }

        
        private void pictureBox_circle_DragDrop(object sender, DragEventArgs e)
        {
            is_Drag_Drop = true;
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && main_input_correct && usilenie_correct)
            {
                e.Effect = DragDropEffects.Copy;
                string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                filename_Drag_Drop = FileList[0];
                button1_Click(null, null);
                is_Drag_Drop = false;
                if (is_File_Ok)
                    button_draw_circle_Click(null, null);
            }
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && (Path.GetExtension(((string[])e.Data.GetData(DataFormats.FileDrop, false))[0]) == ".sgy" || Path.GetExtension(((string[])e.Data.GetData(DataFormats.FileDrop, false))[0]) == ".SGY"))
                e.Effect = DragDropEffects.Copy;
        }


        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            is_Drag_Drop = true;
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && main_input_correct && usilenie_correct)
            {
                e.Effect = DragDropEffects.Copy;
                string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                filename_Drag_Drop = FileList[0];
                button1_Click(null, null);
                is_Drag_Drop = false;
            }
        }

        private void radioButton_circle_grid_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_circle.Image = circle_image[GetIndexForImageByRadioButtons(true)];
        }

        private void radioButton_rect_pure_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_rect.Image = rect_image[GetIndexForImageByRadioButtons(false)];
        }

        private void radioButton_rect_grid_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_rect.Image = rect_image[GetIndexForImageByRadioButtons(false)];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllowDrop = true;
            DragEnter += new DragEventHandler(MainForm_DragEnter);
            DragDrop += new DragEventHandler(MainForm_DragDrop);

            pictureBox_graph.AllowDrop = true;
            pictureBox_graph.DragEnter += new DragEventHandler(pictureBox_graph_DragEnter);
            pictureBox_graph.DragDrop += new DragEventHandler(pictureBox_graph_DragDrop);

            pictureBox_rect.AllowDrop = true;
            pictureBox_rect.DragEnter += new DragEventHandler(pictureBox_rect_DragEnter);
            pictureBox_rect.DragDrop += new DragEventHandler(pictureBox_rect_DragDrop);

            pictureBox_circle.AllowDrop = true;
            pictureBox_circle.DragEnter += new DragEventHandler(pictureBox_circle_DragEnter);
            pictureBox_circle.DragDrop += new DragEventHandler(pictureBox_circle_DragDrop);
        }

        private void button_save_cirle_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = Path.GetFileName(filename) + " circle " + Math.Round(double.Parse(textBox_r.Text), 1).ToString() + "x" + Math.Round(double.Parse(textBox_r.Text), 1).ToString();
            if (circle_image[0] != null&&saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (saveFileDialog1.FilterIndex == 1)
                        circle_image[GetIndexForImageByRadioButtons(true)].Save(saveFileDialog1.FileName, ImageFormat.Png);
                    else
                        circle_image[GetIndexForImageByRadioButtons(true)].Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(null, "Не удалось сохранить файл\n Ошибка: "+ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(null,"Файл сохранен.","Радарограмма",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_rect.Image = rect_image[GetIndexForImageByRadioButtons(false)];
        }
        private int GetIndexForImageByRadioButtons(bool rect0_circle1)
        {
            if (!rect0_circle1) //rect
            {
                if (radioButton_rect_pure.Checked == true)
                    return 0;
                else
                        if (radioButton_rect_axes.Checked == true)
                    return 1;
                else
                    return 2;
            }
            else
            {
                if (radioButton_circle_pure.Checked == true)
                    return 0;
                else
                        if (radioButton_circle_axes.Checked == true)
                    return 1;
                else
                    return 2;
            }
        }
        private void button_save_rect_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = Path.GetFileName(filename) + " rectangle " + Math.Round(double.Parse(textBox_sideA.Text), 1).ToString() + "x" + Math.Round(double.Parse(textBox_sideB.Text), 1).ToString();
            if (rect_image[0] != null && saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (saveFileDialog1.FilterIndex == 1)
                        rect_image[GetIndexForImageByRadioButtons(false)].Save(saveFileDialog1.FileName, ImageFormat.Png);
                    else
                        rect_image[GetIndexForImageByRadioButtons(false)].Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(null, "Не удалось сохранить файл\n Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(null, "Файл сохранен.", "Радарограмма", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_draw_circle_Click(object sender, EventArgs e)
        {
            if (filename != null && circle_correct && usilenie_correct&&main_input_correct)
            {
                if ((2 * Double.Parse(textBox_r.Text) / (Double.Parse(textBox_v.Text) * Double.Parse(textBox_t.Text)) < line.Traces[0].Values.Count))
                {
                    if (usilenie[0] != 0)
                        CreateUsilenie();
                    maxmin = findMaxMin.Do(line, usilenie);
                    int quantity_r = Convert.ToInt32(double.Parse(textBox_r.Text) / (double.Parse(textBox_v.Text) * double.Parse(textBox_t.Text)));
                    int[] quantity = { quantity_r / 10, quantity_r / 10 };
                    if (quantity[0] < 3)
                    {
                        quantity[0] = 3;
                        quantity[1] = 3;
                    }
                    if (quantity[0] > 10)
                    {
                        quantity[0] = 11;
                        quantity[1] = 11;
                    }
                    if (quantity[0] % 2 == 0)
                    {
                        quantity[0] = quantity[0] + 1;
                        quantity[1] = quantity[1] + 1;
                    }

                    circle_image[0] = drawCircle.Do(line, double.Parse(textBox_r.Text), double.Parse(textBox_v.Text), double.Parse(textBox_t.Text), maxmin, comboBox1.SelectedItem.ToString(), trackBar1.Value, usilenie);
                    circle_image[1] = drawAxesOnCircle.Do(circle_image[0].Clone(new Rectangle(0, 0, circle_image[0].Width, circle_image[0].Height), circle_image[0].PixelFormat), double.Parse(textBox_r.Text), quantity, 0, 0, 40, false);
                    circle_image[2] = drawAxesOnCircle.Do(circle_image[1], double.Parse(textBox_r.Text), quantity, 0, 0, 40, true);

                    pictureBox_circle.Image = circle_image[GetIndexForImageByRadioButtons(true)];
                    groupBox_circle_image.Text = "Круглый профиль " + Path.GetFileName(filename) + " (текущие параметры построения: радиус — " + Math.Round(double.Parse(textBox_r.Text), 1).ToString() + " см, скорость волны — " + Math.Round(double.Parse(textBox_v.Text), 1).ToString() + " см/нс,  дискретизация — " + Math.Round(double.Parse(textBox_t.Text), 5).ToString() + " нс, усиление — " + ((usilenie[0] == 0.0) ? " ВЫКЛ)" : " ВКЛ)");
                    label_circle_start_end.Visible = true;
                }
                else
                {
                    MessageBox.Show(null, "Недостаточно точек для построения. Уменьшите радиус, или увеличьте дискретизацию или скорость волны, или выберите файл с большим количеством точек.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (usilenie[0] == 0)
            {
                pictureBox3.Image = Properties.Resources.on;
                usilenie[0] = 1;
                usilenie_correct = IsCorrect(textBox_koeffX) && IsCorrect(textBox_stepenX);
            }
            else
            {
                pictureBox3.Image = Properties.Resources.off;
                usilenie[0] = 0;
                textBox_koeffX.BackColor = SystemColors.Window;
                textBox_stepenX.BackColor = SystemColors.Window;
                usilenie_correct = true;
            }
        }
    }
}
