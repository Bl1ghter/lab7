using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class Parameter
    {
        public Random random = new Random();

        public List<Bitmap> Pictures = new List<Bitmap>();

        public Parameter()
        {
            Pictures.Add(new Bitmap("Cloud (1).png"));
            Pictures.Add(new Bitmap("Cloud (2).png"));
            Pictures.Add(new Bitmap("Cloud (3).png"));
        }
    }

    public class FlyWeightCloud
    {
        public Point point;
        private int height, weight;

        private Parameter parameter;

        private int pictureIndex;

        public FlyWeightCloud()
        {
            point = new Point(0, 0);

            this.height = 50;
            this.weight = 50;

        }

        public FlyWeightCloud(int x, int y, Parameter parameter)
        {
            point = new Point(x, y);

            this.height = 50;
            this.weight = 50;

            this.parameter = parameter;

            pictureIndex = parameter.random.Next(0, parameter.Pictures.Count);
        }

        public void Show(Graphics graphics, Color color)
        {
            graphics.FillRectangle(new SolidBrush(color), point.X - weight / 2, point.Y - height / 2, weight * 2, height * 2);

            graphics.DrawImage(parameter.Pictures[pictureIndex], point.X, point.Y, weight, height);
        }

    }
}
