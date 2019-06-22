using System.Drawing;

namespace Ping_Pong_Logic
{
    /// <summary>
    /// This interface is inherited by objects that can appear in the pictureBox.
    /// </summary>
    public interface IDrawable
    {
        int Width { get; }
        int Height { get; }
        Brush BackColor { get; }
        void Draw(Graphics graphics);
    }
}
