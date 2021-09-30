using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
   public class Rectangle
    {
        public Point Location { get; set; }
        public Color color { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public  bool Conteins(Point point)
        {
            return Location.X < point.X && point.X < Location.X + Width &&
                Location.Y < point.Y && point.Y < Location.Y + Height;
        }
        public  void Paint(Graphics graphics)
        {
            using (var brush = new SolidBrush(color))
            {
                graphics.FillRectangle(brush, Location.X, Location.Y, Width, Height);
                
            }
          

        }
    }
}
