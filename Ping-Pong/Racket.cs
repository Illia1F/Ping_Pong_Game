using System;
using System.Drawing;

namespace Ping_Pong_Logic
{
    /// <summary>
    /// This class describes a racket's behavior.
    /// </summary>
    public class Racket : IDrawable
    {
        public int Width { get; set; }       public int Height { get; set; }

        public Point Position { get; private set; }
        public int Top { get; private set; }
        public int Bottom { get; private set; }
        public int Left { get; private set; }
        public int Right { get; private set; }

        public Brush BackColor { get; set; }

        public Racket(int width, int height, Point pos, Brush color)
        {
            Width = width;
            Height = height;

            Position = new Point(pos.X - Width / 2, pos.Y - Height / 2);
            Top = Position.Y;
            Bottom = Position.Y + Height;
            Left = Position.X;
            Right = Position.X + Width;

            BackColor = color;
        }

        // move to destY with velocityY
        public void Move(int destY, int velocityY)
        {
            int step = 0;
            int offset = Math.Abs(Position.Y - destY);
            if (offset < velocityY)
                step = offset;
            else step = velocityY;

            if (destY > Position.Y)
                Move(Position.Y + step);
            else Move(Position.Y - step);
        }

        // mouse tracking
        public void Move(int destY)
        {
            Position = new Point(Position.X, destY);
            Top = Position.Y;
            Bottom = Position.Y + Height;
            Left = Position.X;
            Right = Position.X + Width;
        }

        // draw a racket
        public void Draw(Graphics graphics)
        {
            graphics.FillRectangle(BackColor, Position.X, Position.Y, Width, Height);
        }
    }
}
