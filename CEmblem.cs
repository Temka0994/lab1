using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureForm
{
    internal class CEmblem
    {
        const int DefaultRadius = 50;
        private Graphics graphics;
        private int line;
        public int X { get; set; } 
        public int Y { get; set; } 
        public int Line
        { 
            get
            {
                return line;
            }
            set
            {
                line = value >= 200 ? 200 : value;
                line = value <= 5 ? 5 : value;
            }
        }
        public CEmblem(Graphics graphics, int X, int Y)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Line = DefaultRadius;
        }
        public CEmblem(Graphics graphics, int X, int Y, int Radius)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Line = Radius;
        }
        private void Draw(Pen pen)
        {
            Rectangle circle = new Rectangle(X + Line, Y - Line, 2 * Line, 2 * Line);
            Rectangle rectangle = new Rectangle(X - Line, Y - Line, 2 * Line, 2 * Line);
            Point[] triangle =
            {
                new Point(X - 3 * Line, Y),
                new Point(X - Line, Y - Line),
                new Point(X - Line, Y + Line)
            };
            
            graphics.DrawEllipse(pen, circle);
            graphics.DrawRectangle(pen, rectangle);
            graphics.DrawPolygon(pen, triangle);
            
        }
        public void Show()
        {
            Draw(Pens.Red);
        }
        public void Hide()
        {
            Draw(Pens.White);
        }
        public void Expand()
        {
            Hide();
        
Line++;
            Show();
        }
        public void Expand(int dR)
        {
            Hide();
            Line = Line + dR;
            Show();
        }
        public void Collapse()
        {
            Hide();
            Line--;
            Show();
        }
        public void Collapse(int dR)
        {
            Hide();
            Line = Line - dR;
            Show();
        }
        public void Move(int dX, int dY)
        {
            Hide();
            X = X + dX;
            Y = Y + dY;
            Show();
        }
    }
}
