using System.Drawing;

namespace Ping_Pong_Logic
{
    /// <summary>
    /// This class describes the ball's behavior.
    /// </summary>
    public class Ball : IDrawable
    {
        public int Width { get; set; } 
        public int Height { get; set; }
        public int VelocityX { get; set; }
        public int VelocityY { get; set; }

        public Point Position { get; set; }

        public int Top { get; private set; }
        public int Bottom { get; private set; }
        public int Left { get; private set; }
        public int Right { get; private set; }

        public Brush BackColor { get; set; }

        public Ball(int width, int height, Point pos, int velocityX, int velocityY, Brush color)
        {
            Width = width;
            Height = height;

            Position = new Point(pos.X, pos.Y);
            Top = Position.Y;
            Bottom = Position.Y + Height;
            Left = Position.X;
            Right = Position.X + Width;

            VelocityX = velocityX;
            VelocityY = velocityY;

            BackColor = color;
        }

        // move
        public void Move()
        {
            Position = new Point(Position.X + VelocityX, Position.Y + VelocityY);
            Top = Position.Y;
            Bottom = Position.Y + Height;
            Left = Position.X;
            Right = Position.X + Width;
        }

        // draw a ball
        public void Draw(Graphics graphics)
        {
            graphics.FillEllipse(BackColor, Position.X, Position.Y, Width, Height);
        }
    }
}
