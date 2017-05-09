namespace Tomoram_2._0
{
    partial class Form1
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
            this.glControl1 = new OpenTK.GLControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.quadsButton1 = new System.Windows.Forms.RadioButton();
            this.textureButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar_min = new System.Windows.Forms.TrackBar();
            this.trackBar_width = new System.Windows.Forms.TrackBar();
            this.label_min = new System.Windows.Forms.Label();
            this.label_max = new System.Windows.Forms.Label();
            this.label_width = new System.Windows.Forms.Label();
            this.label_show_min = new System.Windows.Forms.Label();
            this.label_show_width = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_width)).BeginInit();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(33, 38);
            this.glControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(402, 373);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(480, 38);
            this.trackBar1.Maximum = 77;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(442, 69);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // quadsButton1
            // 
            this.quadsButton1.AutoSize = true;
            this.quadsButton1.Checked = true;
            this.quadsButton1.Location = new System.Drawing.Point(69, 437);
            this.quadsButton1.Name = "quadsButton1";
            this.quadsButton1.Size = new System.Drawing.Size(81, 24);
            this.quadsButton1.TabIndex = 3;
            this.quadsButton1.TabStop = true;
            this.quadsButton1.Text = "Quads";
            this.quadsButton1.UseVisualStyleBackColor = true;
            // 
            // textureButton2
            // 
            this.textureButton2.AutoSize = true;
            this.textureButton2.Location = new System.Drawing.Point(280, 437);
            this.textureButton2.Name = "textureButton2";
            this.textureButton2.Size = new System.Drawing.Size(87, 24);
            this.textureButton2.TabIndex = 4;
            this.textureButton2.Text = "Texture";
            this.textureButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Текущий уровень = 10";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBar_min
            // 
            this.trackBar_min.Location = new System.Drawing.Point(480, 179);
            this.trackBar_min.Maximum = 4000;
            this.trackBar_min.Name = "trackBar_min";
            this.trackBar_min.Size = new System.Drawing.Size(340, 69);
            this.trackBar_min.TabIndex = 6;
            this.trackBar_min.Scroll += new System.EventHandler(this.trackBar_min_Scroll);
            // 
            // trackBar_width
            // 
            this.trackBar_width.Location = new System.Drawing.Point(480, 289);
            this.trackBar_width.Maximum = 4000;
            this.trackBar_width.Minimum = 1;
            this.trackBar_width.Name = "trackBar_width";
            this.trackBar_width.Size = new System.Drawing.Size(340, 69);
            this.trackBar_width.TabIndex = 7;
            this.trackBar_width.Value = 2000;
            this.trackBar_width.Scroll += new System.EventHandler(this.trackBar_width_Scroll);
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Location = new System.Drawing.Point(481, 400);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(170, 20);
            this.label_min.TabIndex = 8;
            this.label_min.Text = "Текущий минимум = 0";
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Location = new System.Drawing.Point(481, 361);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(204, 20);
            this.label_max.TabIndex = 9;
            this.label_max.Text = "Текущий максимум = 2000\r\n";
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.Location = new System.Drawing.Point(481, 437);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(188, 20);
            this.label_width.TabIndex = 10;
            this.label_width.Text = "Текущая ширина = 2000\r\n";
            // 
            // label_show_min
            // 
            this.label_show_min.AutoSize = true;
            this.label_show_min.Location = new System.Drawing.Point(481, 146);
            this.label_show_min.Name = "label_show_min";
            this.label_show_min.Size = new System.Drawing.Size(217, 20);
            this.label_show_min.TabIndex = 11;
            this.label_show_min.Text = "Минимальное значение TF:";
            // 
            // label_show_width
            // 
            this.label_show_width.AutoSize = true;
            this.label_show_width.Location = new System.Drawing.Point(485, 269);
            this.label_show_width.Name = "label_show_width";
            this.label_show_width.Size = new System.Drawing.Size(94, 20);
            this.label_show_width.TabIndex = 12;
            this.label_show_width.Text = "Ширина TF:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 478);
            this.Controls.Add(this.label_show_width);
            this.Controls.Add(this.label_show_min);
            this.Controls.Add(this.label_width);
            this.Controls.Add(this.label_max);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.trackBar_width);
            this.Controls.Add(this.trackBar_min);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textureButton2);
            this.Controls.Add(this.quadsButton1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_width)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.RadioButton quadsButton1;
        private System.Windows.Forms.RadioButton textureButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_min;
        private System.Windows.Forms.TrackBar trackBar_width;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Label label_width;
        private System.Windows.Forms.Label label_show_min;
        private System.Windows.Forms.Label label_show_width;
    }
}

