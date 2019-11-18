namespace Seismic
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_open = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label_name = new System.Windows.Forms.Label();
            this.button_draw_seismogramm = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_r = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_circle = new System.Windows.Forms.GroupBox();
            this.button_save_circle = new System.Windows.Forms.Button();
            this.button_draw_circle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton_circle_grid = new System.Windows.Forms.RadioButton();
            this.radioButton_circle_pure = new System.Windows.Forms.RadioButton();
            this.radioButton_circle_axes = new System.Windows.Forms.RadioButton();
            this.groupBox_rect = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_rect_grid = new System.Windows.Forms.RadioButton();
            this.radioButton_rect_axes = new System.Windows.Forms.RadioButton();
            this.radioButton_rect_pure = new System.Windows.Forms.RadioButton();
            this.button_draw_rect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_stepsize = new System.Windows.Forms.Label();
            this.button_save_rect = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_sideB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_sideA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_t = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_v = new System.Windows.Forms.TextBox();
            this.groupBox_params = new System.Windows.Forms.GroupBox();
            this.groupBox_pallete = new System.Windows.Forms.GroupBox();
            this.groupBox_usilenie = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_stepenX = new System.Windows.Forms.TextBox();
            this.textBox_koeffX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox_graph_image = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_graph_axes_y = new System.Windows.Forms.PictureBox();
            this.pictureBox_graph_axes_x = new System.Windows.Forms.PictureBox();
            this.pictureBox_graph = new System.Windows.Forms.PictureBox();
            this.groupBox_circle_image = new System.Windows.Forms.GroupBox();
            this.label_circle_start_end = new System.Windows.Forms.Label();
            this.pictureBox_circle = new System.Windows.Forms.PictureBox();
            this.groupBox_rect_image = new System.Windows.Forms.GroupBox();
            this.pictureBox_rect = new System.Windows.Forms.PictureBox();
            this.groupBox_open = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label_traces_dots = new System.Windows.Forms.Label();
            this.groupBox_info = new System.Windows.Forms.GroupBox();
            this.label_trace_loses = new System.Windows.Forms.Label();
            this.label_trace_count = new System.Windows.Forms.Label();
            this.label_interpolation = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox_circle.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox_rect.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_params.SuspendLayout();
            this.groupBox_pallete.SuspendLayout();
            this.groupBox_usilenie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox_graph_image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_graph_axes_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_graph_axes_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_graph)).BeginInit();
            this.groupBox_circle_image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_circle)).BeginInit();
            this.groupBox_rect_image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_rect)).BeginInit();
            this.groupBox_open.SuspendLayout();
            this.groupBox_info.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_open
            // 
            this.button_open.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_open.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_open.Location = new System.Drawing.Point(33, 63);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(238, 88);
            this.button_open.TabIndex = 0;
            this.button_open.Text = "Открыть файл...";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "SEG-Y file(*.sgy)|*.sgy|All files(*.*)|*.*";
            // 
            // label_name
            // 
            this.label_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(9, 35);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(166, 25);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Файл не открыт";
            // 
            // button_draw_seismogramm
            // 
            this.button_draw_seismogramm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_draw_seismogramm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_draw_seismogramm.Location = new System.Drawing.Point(33, 157);
            this.button_draw_seismogramm.Name = "button_draw_seismogramm";
            this.button_draw_seismogramm.Size = new System.Drawing.Size(238, 88);
            this.button_draw_seismogramm.TabIndex = 1;
            this.button_draw_seismogramm.Text = "Построить график";
            this.button_draw_seismogramm.UseVisualStyleBackColor = true;
            this.button_draw_seismogramm.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(268, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 33);
            this.comboBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(286, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Палитра";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(30, 25);
            this.trackBar1.Maximum = 256;
            this.trackBar1.Minimum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(225, 69);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.TickFrequency = 15;
            this.trackBar1.Value = 128;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Количество цветов: 128";
            // 
            // textBox_r
            // 
            this.textBox_r.Location = new System.Drawing.Point(238, 48);
            this.textBox_r.Name = "textBox_r";
            this.textBox_r.Size = new System.Drawing.Size(100, 30);
            this.textBox_r.TabIndex = 8;
            this.textBox_r.Text = "10";
            this.textBox_r.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Радиус колонны (см)";
            // 
            // groupBox_circle
            // 
            this.groupBox_circle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox_circle.Controls.Add(this.button_save_circle);
            this.groupBox_circle.Controls.Add(this.button_draw_circle);
            this.groupBox_circle.Controls.Add(this.textBox_r);
            this.groupBox_circle.Controls.Add(this.label4);
            this.groupBox_circle.Controls.Add(this.groupBox4);
            this.groupBox_circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_circle.Location = new System.Drawing.Point(1248, 15);
            this.groupBox_circle.Name = "groupBox_circle";
            this.groupBox_circle.Size = new System.Drawing.Size(440, 292);
            this.groupBox_circle.TabIndex = 18;
            this.groupBox_circle.TabStop = false;
            this.groupBox_circle.Text = "Круглый профиль";
            // 
            // button_save_circle
            // 
            this.button_save_circle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_save_circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save_circle.Location = new System.Drawing.Point(214, 180);
            this.button_save_circle.Name = "button_save_circle";
            this.button_save_circle.Size = new System.Drawing.Size(208, 69);
            this.button_save_circle.TabIndex = 10;
            this.button_save_circle.Text = "Сохранить";
            this.button_save_circle.UseVisualStyleBackColor = true;
            this.button_save_circle.Click += new System.EventHandler(this.button_save_cirle_Click_1);
            // 
            // button_draw_circle
            // 
            this.button_draw_circle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_draw_circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_draw_circle.Location = new System.Drawing.Point(214, 105);
            this.button_draw_circle.Name = "button_draw_circle";
            this.button_draw_circle.Size = new System.Drawing.Size(208, 69);
            this.button_draw_circle.TabIndex = 9;
            this.button_draw_circle.Text = "Построить график";
            this.button_draw_circle.UseVisualStyleBackColor = true;
            this.button_draw_circle.Click += new System.EventHandler(this.button_draw_circle_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton_circle_grid);
            this.groupBox4.Controls.Add(this.radioButton_circle_pure);
            this.groupBox4.Controls.Add(this.radioButton_circle_axes);
            this.groupBox4.Location = new System.Drawing.Point(8, 108);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(189, 177);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Изображение";
            // 
            // radioButton_circle_grid
            // 
            this.radioButton_circle_grid.AutoSize = true;
            this.radioButton_circle_grid.Location = new System.Drawing.Point(9, 117);
            this.radioButton_circle_grid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_circle_grid.Name = "radioButton_circle_grid";
            this.radioButton_circle_grid.Size = new System.Drawing.Size(147, 29);
            this.radioButton_circle_grid.TabIndex = 17;
            this.radioButton_circle_grid.Text = "Оси и сетка";
            this.radioButton_circle_grid.UseVisualStyleBackColor = true;
            this.radioButton_circle_grid.CheckedChanged += new System.EventHandler(this.radioButton_circle_grid_CheckedChanged);
            // 
            // radioButton_circle_pure
            // 
            this.radioButton_circle_pure.AutoSize = true;
            this.radioButton_circle_pure.Location = new System.Drawing.Point(9, 34);
            this.radioButton_circle_pure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_circle_pure.Name = "radioButton_circle_pure";
            this.radioButton_circle_pure.Size = new System.Drawing.Size(119, 29);
            this.radioButton_circle_pure.TabIndex = 15;
            this.radioButton_circle_pure.Text = "Без осей";
            this.radioButton_circle_pure.UseVisualStyleBackColor = true;
            this.radioButton_circle_pure.CheckedChanged += new System.EventHandler(this.radioButton_circle_pure_CheckedChanged);
            // 
            // radioButton_circle_axes
            // 
            this.radioButton_circle_axes.AutoSize = true;
            this.radioButton_circle_axes.Checked = true;
            this.radioButton_circle_axes.Location = new System.Drawing.Point(9, 77);
            this.radioButton_circle_axes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_circle_axes.Name = "radioButton_circle_axes";
            this.radioButton_circle_axes.Size = new System.Drawing.Size(136, 29);
            this.radioButton_circle_axes.TabIndex = 16;
            this.radioButton_circle_axes.TabStop = true;
            this.radioButton_circle_axes.Text = "Коорд. оси";
            this.radioButton_circle_axes.UseVisualStyleBackColor = true;
            this.radioButton_circle_axes.CheckedChanged += new System.EventHandler(this.radioButton_circle_axes_CheckedChanged);
            // 
            // groupBox_rect
            // 
            this.groupBox_rect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox_rect.Controls.Add(this.groupBox3);
            this.groupBox_rect.Controls.Add(this.button_draw_rect);
            this.groupBox_rect.Controls.Add(this.groupBox2);
            this.groupBox_rect.Controls.Add(this.button_save_rect);
            this.groupBox_rect.Controls.Add(this.label10);
            this.groupBox_rect.Controls.Add(this.textBox_sideB);
            this.groupBox_rect.Controls.Add(this.label9);
            this.groupBox_rect.Controls.Add(this.textBox_sideA);
            this.groupBox_rect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_rect.Location = new System.Drawing.Point(316, 15);
            this.groupBox_rect.Name = "groupBox_rect";
            this.groupBox_rect.Size = new System.Drawing.Size(510, 292);
            this.groupBox_rect.TabIndex = 17;
            this.groupBox_rect.TabStop = false;
            this.groupBox_rect.Text = "Квадратный\\прямоугольный профиль";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_rect_grid);
            this.groupBox3.Controls.Add(this.radioButton_rect_axes);
            this.groupBox3.Controls.Add(this.radioButton_rect_pure);
            this.groupBox3.Location = new System.Drawing.Point(8, 106);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(189, 177);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Изображение";
            // 
            // radioButton_rect_grid
            // 
            this.radioButton_rect_grid.AutoSize = true;
            this.radioButton_rect_grid.Location = new System.Drawing.Point(21, 123);
            this.radioButton_rect_grid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_rect_grid.Name = "radioButton_rect_grid";
            this.radioButton_rect_grid.Size = new System.Drawing.Size(147, 29);
            this.radioButton_rect_grid.TabIndex = 20;
            this.radioButton_rect_grid.Text = "Оси и сетка";
            this.radioButton_rect_grid.UseVisualStyleBackColor = true;
            this.radioButton_rect_grid.CheckedChanged += new System.EventHandler(this.radioButton_rect_grid_CheckedChanged);
            // 
            // radioButton_rect_axes
            // 
            this.radioButton_rect_axes.AutoSize = true;
            this.radioButton_rect_axes.Checked = true;
            this.radioButton_rect_axes.Location = new System.Drawing.Point(21, 83);
            this.radioButton_rect_axes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_rect_axes.Name = "radioButton_rect_axes";
            this.radioButton_rect_axes.Size = new System.Drawing.Size(136, 29);
            this.radioButton_rect_axes.TabIndex = 19;
            this.radioButton_rect_axes.TabStop = true;
            this.radioButton_rect_axes.Text = "Коорд. оси";
            this.radioButton_rect_axes.UseVisualStyleBackColor = true;
            this.radioButton_rect_axes.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton_rect_pure
            // 
            this.radioButton_rect_pure.AutoSize = true;
            this.radioButton_rect_pure.Location = new System.Drawing.Point(21, 40);
            this.radioButton_rect_pure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_rect_pure.Name = "radioButton_rect_pure";
            this.radioButton_rect_pure.Size = new System.Drawing.Size(119, 29);
            this.radioButton_rect_pure.TabIndex = 18;
            this.radioButton_rect_pure.Text = "Без осей";
            this.radioButton_rect_pure.UseVisualStyleBackColor = true;
            this.radioButton_rect_pure.CheckedChanged += new System.EventHandler(this.radioButton_rect_pure_CheckedChanged);
            // 
            // button_draw_rect
            // 
            this.button_draw_rect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_draw_rect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_draw_rect.Location = new System.Drawing.Point(216, 123);
            this.button_draw_rect.Name = "button_draw_rect";
            this.button_draw_rect.Size = new System.Drawing.Size(273, 71);
            this.button_draw_rect.TabIndex = 6;
            this.button_draw_rect.Text = "Построить график";
            this.button_draw_rect.UseVisualStyleBackColor = true;
            this.button_draw_rect.Click += new System.EventHandler(this.button_draw_rect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_stepsize);
            this.groupBox2.Location = new System.Drawing.Point(312, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(190, 72);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Шаг для трассы";
            // 
            // label_stepsize
            // 
            this.label_stepsize.AutoSize = true;
            this.label_stepsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_stepsize.Location = new System.Drawing.Point(16, 28);
            this.label_stepsize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_stepsize.Name = "label_stepsize";
            this.label_stepsize.Size = new System.Drawing.Size(27, 29);
            this.label_stepsize.TabIndex = 32;
            this.label_stepsize.Text = "0";
            // 
            // button_save_rect
            // 
            this.button_save_rect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_save_rect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save_rect.Location = new System.Drawing.Point(216, 200);
            this.button_save_rect.Name = "button_save_rect";
            this.button_save_rect.Size = new System.Drawing.Size(273, 71);
            this.button_save_rect.TabIndex = 7;
            this.button_save_rect.Text = "Сохранить";
            this.button_save_rect.UseVisualStyleBackColor = true;
            this.button_save_rect.Click += new System.EventHandler(this.button_save_rect_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Ширина (см)";
            // 
            // textBox_sideB
            // 
            this.textBox_sideB.Location = new System.Drawing.Point(202, 74);
            this.textBox_sideB.Name = "textBox_sideB";
            this.textBox_sideB.Size = new System.Drawing.Size(100, 30);
            this.textBox_sideB.TabIndex = 5;
            this.textBox_sideB.Text = "10";
            this.textBox_sideB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Длина (см)";
            // 
            // textBox_sideA
            // 
            this.textBox_sideA.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_sideA.Location = new System.Drawing.Point(202, 35);
            this.textBox_sideA.Name = "textBox_sideA";
            this.textBox_sideA.Size = new System.Drawing.Size(100, 30);
            this.textBox_sideA.TabIndex = 4;
            this.textBox_sideA.Text = "10";
            this.textBox_sideA.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Скорость волны (см\\нс)";
            // 
            // textBox_t
            // 
            this.textBox_t.Location = new System.Drawing.Point(250, 65);
            this.textBox_t.Name = "textBox_t";
            this.textBox_t.Size = new System.Drawing.Size(100, 30);
            this.textBox_t.TabIndex = 3;
            this.textBox_t.Text = "1";
            this.textBox_t.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Дискретизация (нс)";
            // 
            // textBox_v
            // 
            this.textBox_v.Location = new System.Drawing.Point(250, 25);
            this.textBox_v.Name = "textBox_v";
            this.textBox_v.Size = new System.Drawing.Size(100, 30);
            this.textBox_v.TabIndex = 2;
            this.textBox_v.Text = "1";
            this.textBox_v.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // groupBox_params
            // 
            this.groupBox_params.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_params.Controls.Add(this.textBox_t);
            this.groupBox_params.Controls.Add(this.label6);
            this.groupBox_params.Controls.Add(this.textBox_v);
            this.groupBox_params.Controls.Add(this.label5);
            this.groupBox_params.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_params.Location = new System.Drawing.Point(9, 315);
            this.groupBox_params.Name = "groupBox_params";
            this.groupBox_params.Size = new System.Drawing.Size(370, 117);
            this.groupBox_params.TabIndex = 16;
            this.groupBox_params.TabStop = false;
            this.groupBox_params.Text = "Параметры построения";
            // 
            // groupBox_pallete
            // 
            this.groupBox_pallete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_pallete.Controls.Add(this.label3);
            this.groupBox_pallete.Controls.Add(this.trackBar1);
            this.groupBox_pallete.Controls.Add(this.comboBox1);
            this.groupBox_pallete.Controls.Add(this.label2);
            this.groupBox_pallete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_pallete.Location = new System.Drawing.Point(664, 315);
            this.groupBox_pallete.Name = "groupBox_pallete";
            this.groupBox_pallete.Size = new System.Drawing.Size(477, 117);
            this.groupBox_pallete.TabIndex = 26;
            this.groupBox_pallete.TabStop = false;
            this.groupBox_pallete.Text = "Настройки отображения";
            // 
            // groupBox_usilenie
            // 
            this.groupBox_usilenie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_usilenie.Controls.Add(this.pictureBox3);
            this.groupBox_usilenie.Controls.Add(this.label8);
            this.groupBox_usilenie.Controls.Add(this.textBox_stepenX);
            this.groupBox_usilenie.Controls.Add(this.textBox_koeffX);
            this.groupBox_usilenie.Controls.Add(this.label11);
            this.groupBox_usilenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_usilenie.Location = new System.Drawing.Point(386, 315);
            this.groupBox_usilenie.Name = "groupBox_usilenie";
            this.groupBox_usilenie.Size = new System.Drawing.Size(267, 117);
            this.groupBox_usilenie.TabIndex = 26;
            this.groupBox_usilenie.TabStop = false;
            this.groupBox_usilenie.Text = "Усиление";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(22, 40);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "коэфф. Х";
            // 
            // textBox_stepenX
            // 
            this.textBox_stepenX.Location = new System.Drawing.Point(189, 66);
            this.textBox_stepenX.Name = "textBox_stepenX";
            this.textBox_stepenX.Size = new System.Drawing.Size(70, 30);
            this.textBox_stepenX.TabIndex = 12;
            this.textBox_stepenX.Text = "1";
            this.textBox_stepenX.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox_koeffX
            // 
            this.textBox_koeffX.Location = new System.Drawing.Point(189, 22);
            this.textBox_koeffX.Name = "textBox_koeffX";
            this.textBox_koeffX.Size = new System.Drawing.Size(70, 30);
            this.textBox_koeffX.TabIndex = 11;
            this.textBox_koeffX.Text = "1";
            this.textBox_koeffX.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "степень Х";
            // 
            // groupBox_graph_image
            // 
            this.groupBox_graph_image.Controls.Add(this.label1);
            this.groupBox_graph_image.Controls.Add(this.pictureBox_graph_axes_y);
            this.groupBox_graph_image.Controls.Add(this.pictureBox_graph_axes_x);
            this.groupBox_graph_image.Controls.Add(this.pictureBox_graph);
            this.groupBox_graph_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_graph_image.Location = new System.Drawing.Point(8, 18);
            this.groupBox_graph_image.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_graph_image.Name = "groupBox_graph_image";
            this.groupBox_graph_image.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_graph_image.Size = new System.Drawing.Size(1624, 943);
            this.groupBox_graph_image.TabIndex = 27;
            this.groupBox_graph_image.TabStop = false;
            this.groupBox_graph_image.Text = "Радарограмма";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "0";
            // 
            // pictureBox_graph_axes_y
            // 
            this.pictureBox_graph_axes_y.Location = new System.Drawing.Point(9, 89);
            this.pictureBox_graph_axes_y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_graph_axes_y.Name = "pictureBox_graph_axes_y";
            this.pictureBox_graph_axes_y.Size = new System.Drawing.Size(60, 846);
            this.pictureBox_graph_axes_y.TabIndex = 4;
            this.pictureBox_graph_axes_y.TabStop = false;
            // 
            // pictureBox_graph_axes_x
            // 
            this.pictureBox_graph_axes_x.Location = new System.Drawing.Point(69, 28);
            this.pictureBox_graph_axes_x.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_graph_axes_x.Name = "pictureBox_graph_axes_x";
            this.pictureBox_graph_axes_x.Size = new System.Drawing.Size(1550, 62);
            this.pictureBox_graph_axes_x.TabIndex = 3;
            this.pictureBox_graph_axes_x.TabStop = false;
            // 
            // pictureBox_graph
            // 
            this.pictureBox_graph.Location = new System.Drawing.Point(69, 89);
            this.pictureBox_graph.Name = "pictureBox_graph";
            this.pictureBox_graph.Size = new System.Drawing.Size(1530, 831);
            this.pictureBox_graph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_graph.TabIndex = 2;
            this.pictureBox_graph.TabStop = false;
            // 
            // groupBox_circle_image
            // 
            this.groupBox_circle_image.Controls.Add(this.label_circle_start_end);
            this.groupBox_circle_image.Controls.Add(this.pictureBox_circle);
            this.groupBox_circle_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_circle_image.Location = new System.Drawing.Point(1727, 817);
            this.groupBox_circle_image.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_circle_image.Name = "groupBox_circle_image";
            this.groupBox_circle_image.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_circle_image.Size = new System.Drawing.Size(801, 752);
            this.groupBox_circle_image.TabIndex = 28;
            this.groupBox_circle_image.TabStop = false;
            this.groupBox_circle_image.Text = "Круглый профиль";
            // 
            // label_circle_start_end
            // 
            this.label_circle_start_end.AutoSize = true;
            this.label_circle_start_end.BackColor = System.Drawing.Color.Transparent;
            this.label_circle_start_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_circle_start_end.Location = new System.Drawing.Point(724, 368);
            this.label_circle_start_end.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_circle_start_end.Name = "label_circle_start_end";
            this.label_circle_start_end.Size = new System.Drawing.Size(53, 50);
            this.label_circle_start_end.TabIndex = 34;
            this.label_circle_start_end.Text = "0\'\r\n360\'";
            this.label_circle_start_end.Visible = false;
            // 
            // pictureBox_circle
            // 
            this.pictureBox_circle.Location = new System.Drawing.Point(10, 52);
            this.pictureBox_circle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_circle.Name = "pictureBox_circle";
            this.pictureBox_circle.Size = new System.Drawing.Size(682, 700);
            this.pictureBox_circle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_circle.TabIndex = 10;
            this.pictureBox_circle.TabStop = false;
            // 
            // groupBox_rect_image
            // 
            this.groupBox_rect_image.Controls.Add(this.pictureBox_rect);
            this.groupBox_rect_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_rect_image.Location = new System.Drawing.Point(1640, 18);
            this.groupBox_rect_image.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_rect_image.Name = "groupBox_rect_image";
            this.groupBox_rect_image.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_rect_image.Size = new System.Drawing.Size(1232, 798);
            this.groupBox_rect_image.TabIndex = 29;
            this.groupBox_rect_image.TabStop = false;
            this.groupBox_rect_image.Text = "Прямоугольный профиль";
            // 
            // pictureBox_rect
            // 
            this.pictureBox_rect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_rect.Location = new System.Drawing.Point(9, 51);
            this.pictureBox_rect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_rect.Name = "pictureBox_rect";
            this.pictureBox_rect.Size = new System.Drawing.Size(1208, 738);
            this.pictureBox_rect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_rect.TabIndex = 10;
            this.pictureBox_rect.TabStop = false;
            // 
            // groupBox_open
            // 
            this.groupBox_open.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox_open.Controls.Add(this.button_open);
            this.groupBox_open.Controls.Add(this.button_draw_seismogramm);
            this.groupBox_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_open.Location = new System.Drawing.Point(9, 15);
            this.groupBox_open.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_open.Name = "groupBox_open";
            this.groupBox_open.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_open.Size = new System.Drawing.Size(300, 292);
            this.groupBox_open.TabIndex = 15;
            this.groupBox_open.TabStop = false;
            this.groupBox_open.Text = "Открыть файл";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Изображение PNG (*.png)|*.png|Изображение JPEG (*.jpeg)|*.jpeg";
            // 
            // label_traces_dots
            // 
            this.label_traces_dots.AutoSize = true;
            this.label_traces_dots.Location = new System.Drawing.Point(9, 80);
            this.label_traces_dots.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_traces_dots.Name = "label_traces_dots";
            this.label_traces_dots.Size = new System.Drawing.Size(185, 25);
            this.label_traces_dots.TabIndex = 30;
            this.label_traces_dots.Text = "Трасс / точек: 0 / 0";
            // 
            // groupBox_info
            // 
            this.groupBox_info.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox_info.Controls.Add(this.label_trace_loses);
            this.groupBox_info.Controls.Add(this.label_trace_count);
            this.groupBox_info.Controls.Add(this.label_interpolation);
            this.groupBox_info.Controls.Add(this.label_traces_dots);
            this.groupBox_info.Controls.Add(this.label_name);
            this.groupBox_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_info.Location = new System.Drawing.Point(834, 15);
            this.groupBox_info.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_info.Size = new System.Drawing.Size(406, 292);
            this.groupBox_info.TabIndex = 31;
            this.groupBox_info.TabStop = false;
            this.groupBox_info.Text = "Информация";
            // 
            // label_trace_loses
            // 
            this.label_trace_loses.AutoSize = true;
            this.label_trace_loses.Location = new System.Drawing.Point(9, 234);
            this.label_trace_loses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_trace_loses.Name = "label_trace_loses";
            this.label_trace_loses.Size = new System.Drawing.Size(224, 25);
            this.label_trace_loses.TabIndex = 34;
            this.label_trace_loses.Text = "Потери (трасс): 0 (0%)";
            // 
            // label_trace_count
            // 
            this.label_trace_count.AutoSize = true;
            this.label_trace_count.Location = new System.Drawing.Point(9, 180);
            this.label_trace_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_trace_count.Name = "label_trace_count";
            this.label_trace_count.Size = new System.Drawing.Size(282, 25);
            this.label_trace_count.TabIndex = 33;
            this.label_trace_count.Text = "Требуется добавить трасс: 0\r\n";
            // 
            // label_interpolation
            // 
            this.label_interpolation.AutoSize = true;
            this.label_interpolation.Location = new System.Drawing.Point(9, 126);
            this.label_interpolation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_interpolation.Name = "label_interpolation";
            this.label_interpolation.Size = new System.Drawing.Size(291, 25);
            this.label_interpolation.TabIndex = 32;
            this.label_interpolation.Text = "Интерполяция:  не требуется";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox_usilenie);
            this.groupBox1.Controls.Add(this.groupBox_circle);
            this.groupBox1.Controls.Add(this.groupBox_pallete);
            this.groupBox1.Controls.Add(this.groupBox_params);
            this.groupBox1.Controls.Add(this.groupBox_rect);
            this.groupBox1.Controls.Add(this.groupBox_open);
            this.groupBox1.Controls.Add(this.groupBox_info);
            this.groupBox1.Location = new System.Drawing.Point(18, 988);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1701, 462);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2564, 1343);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_graph_image);
            this.Controls.Add(this.groupBox_rect_image);
            this.Controls.Add(this.groupBox_circle_image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Радарограмма";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox_circle.ResumeLayout(false);
            this.groupBox_circle.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox_rect.ResumeLayout(false);
            this.groupBox_rect.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_params.ResumeLayout(false);
            this.groupBox_params.PerformLayout();
            this.groupBox_pallete.ResumeLayout(false);
            this.groupBox_pallete.PerformLayout();
            this.groupBox_usilenie.ResumeLayout(false);
            this.groupBox_usilenie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox_graph_image.ResumeLayout(false);
            this.groupBox_graph_image.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_graph_axes_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_graph_axes_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_graph)).EndInit();
            this.groupBox_circle_image.ResumeLayout(false);
            this.groupBox_circle_image.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_circle)).EndInit();
            this.groupBox_rect_image.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_rect)).EndInit();
            this.groupBox_open.ResumeLayout(false);
            this.groupBox_info.ResumeLayout(false);
            this.groupBox_info.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_draw_seismogramm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox_circle;
        private System.Windows.Forms.TextBox textBox_r;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox_circle;
        private System.Windows.Forms.GroupBox groupBox_rect;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_sideB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_sideA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_t;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_v;
        private System.Windows.Forms.GroupBox groupBox_params;
        private System.Windows.Forms.GroupBox groupBox_pallete;
        private System.Windows.Forms.GroupBox groupBox_usilenie;
        private System.Windows.Forms.TextBox textBox_koeffX;
        private System.Windows.Forms.TextBox textBox_stepenX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox_graph_image;
        private System.Windows.Forms.GroupBox groupBox_circle_image;
        private System.Windows.Forms.GroupBox groupBox_rect_image;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_draw_circle;
        private System.Windows.Forms.Button button_draw_rect;
        private System.Windows.Forms.GroupBox groupBox_open;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button_save_circle;
        private System.Windows.Forms.Button button_save_rect;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox_graph;
        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.Label label_stepsize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label_circle_start_end;
        private System.Windows.Forms.PictureBox pictureBox_graph_axes_y;
        private System.Windows.Forms.PictureBox pictureBox_graph_axes_x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_rect;
        private System.Windows.Forms.RadioButton radioButton_circle_grid;
        private System.Windows.Forms.RadioButton radioButton_circle_axes;
        private System.Windows.Forms.RadioButton radioButton_circle_pure;
        private System.Windows.Forms.RadioButton radioButton_rect_grid;
        private System.Windows.Forms.RadioButton radioButton_rect_axes;
        private System.Windows.Forms.RadioButton radioButton_rect_pure;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label label_name;
        public System.Windows.Forms.Label label_traces_dots;
        public System.Windows.Forms.Label label_interpolation;
        public System.Windows.Forms.Label label_trace_loses;
        public System.Windows.Forms.Label label_trace_count;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

