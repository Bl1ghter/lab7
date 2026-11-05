using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            graphics = this.CreateGraphics();
        }

        private List<Cloud> Clouds = new List<Cloud>();
        private List<FlyWeightCloud> FlyWeightClouds = new List<FlyWeightCloud>();
        private Random random = new Random();
        private Graphics graphics;

        Parameter parameter = new Parameter();

        private void BtnCloud_Click(object sender, EventArgs e)
        {
            Cloud cloud = new Cloud(random.Next(50, this.Width - 50), random.Next(50, this.Height - 100));

            Clouds.Add(cloud);

            cloud.Show(graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlyWeightCloud flyWeightCloud = new FlyWeightCloud(random.Next(50, this.Width - 50), random.Next(50, this.Height - 100), parameter);

            FlyWeightClouds.Add(flyWeightCloud);

            flyWeightCloud.Show(graphics, SystemColors.Control);
        }

        private void AnimateClouds()
        {
            if(FlyWeightClouds.Count > 0)
            {
                foreach (var cloud in FlyWeightClouds)
                {
                    cloud.point.X += random.Next(-10, 11);
                    cloud.point.Y += random.Next(-10, 11);

                    cloud.Show(graphics, SystemColors.Control);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AnimateClouds();
        }
    }
}
