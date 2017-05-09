using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tomoram_2._0
{
    public partial class Form1 : Form
    {
        Bin bin = new Bin();
        View view = new View();
        bool loaded = false;
        bool needReload = false;
        int currentLayer = 0;
        int FrameCount;
        DateTime NextFPSUpdate; //= DateTime.Now.AddSeconds(1);

        void displayFPS() //функция обновления fps
        {
            if (DateTime.Now >= NextFPSUpdate)
            {
                Text = String.Format("CT Visualizer (fps = {0})", FrameCount);
                NextFPSUpdate = DateTime.Now.AddSeconds(1);
                FrameCount = 0;
            }
            FrameCount++;
        }

        public Form1()
        {
            InitializeComponent();
            label1.Text = "Текущий уровень = ";
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                bin.readBin(str);
                trackBar1.SetRange(0, Bin.Z - 1);
                //trackBar_layers.SetRange(0, Bin.Z - 1);
                view.SetupView(glControl1.Width, glControl1.Height);
                loaded = true;
                glControl1.Invalidate();
            }
            //label_max.Text = "" + (Bin.Z - 1);
            label1.Text = "Текущий уровень = " + currentLayer;
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (loaded)
            {
                if (quadsButton1.Checked)
                {
                    view.DrawQuads(currentLayer);
                }
                if (textureButton2.Checked)
                {
                    if (needReload)
                    {
                        view.generateTextureImage(currentLayer);
                        view.Load2DTexture();
                        needReload = false;
                    }
                    view.DrawTexture();
                }
                glControl1.SwapBuffers();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            currentLayer = trackBar1.Value;
            label1.Text = "Текущий уровень = " + currentLayer;
            needReload = true;
            //Refresh();
        }

        void Application_Idle(object sender, EventArgs e) //проявляет на занятость окно формы
        {
            while (glControl1.IsIdle)
            {
                displayFPS();
                glControl1.Invalidate(); //заставлет снова рендериться
            }
        }

        private void Form1_Load_1(object sender, EventArgs e) //конструктор формы
        {
            Application.Idle += Application_Idle;
        }

        private void trackBar_min_Scroll(object sender, EventArgs e)
        {
            view.SetMinMaxTransferFunction(trackBar_min.Value, trackBar_min.Value + trackBar_width.Value);
            label_min.Text = "Текущий минимум = " + trackBar_min.Value;
            label_max.Text = "Текущий максимум = " + (trackBar_min.Value + trackBar_width.Value);
            needReload = true;
            //Refresh();
        }

        private void trackBar_width_Scroll(object sender, EventArgs e)
        {
            view.SetMinMaxTransferFunction(trackBar_min.Value, trackBar_min.Value + trackBar_width.Value);
            label_width.Text = "Текущая ширина = " + trackBar_width.Value;
            label_max.Text = "Текущий максимум = " + (trackBar_min.Value + trackBar_width.Value);
            needReload = true;
            //Refresh();
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void trackBar2_Scroll(object sender, EventArgs e)
        //{
        //    view.SetMinMaxTransferFunction(trackBar_min.Value, trackBar_min.Value + trackBar_width.Value);
        //    label_min.Text = "Текущий минимум = " + trackBar_min.Value;
        //    label_TFMaxCurrent.Text = "Текущий максимум = " + (trackBar_TFMin.Value + trackBar_TFHeight.Value);
        //    needReload = true;
        //}
    }
}
