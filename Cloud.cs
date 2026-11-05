using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab7
{
    public class Cloud
    {
        private Point point;
        private int height, weight;
        
        private Bitmap picture;

        public Cloud()
        {
            point = new Point(0, 0);

            this.height = 50;
            this.weight = 50;

            picture = new Bitmap("Cloud (1).png");
        }

        public Cloud(int x, int y)
        {
            point = new Point(x, y);

            this.height = 50;
            this.weight = 50;

            Random random = new Random();

            picture = new Bitmap($"Cloud ({random.Next(1, 4)}).png");
        }

        public void Show(Graphics graphics)
        {
            graphics.DrawImage(picture, point.X, point.Y, weight, height);
        }
    }
}
