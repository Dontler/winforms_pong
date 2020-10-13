using System.Drawing;

namespace Pong.Lib.Drawable
{
    class Platform
    {
        private Rectangle _outline;
        private Bitmap _platformImg;

        private int _width;
        private int _height;

        public Rectangle Outline => _outline;
        public Bitmap PlatformImg => _platformImg;

        public Platform(int x, int y, int width, int height, Bitmap platformImg)
        {
            _width = width;
            _height = height;
            _outline = new Rectangle(x, y, width, height);
            _platformImg = platformImg;
        }

        public void Move(Direction direction, int delta)
        {
            if (direction == Direction.Up)
            {
                MoveUp(delta);
            }
            else
            {
                MoveDown(delta);
            }
        }

        private void MoveUp(int delta)
        {
            _outline.Y -= delta;
        }

        private void MoveDown(int delta)
        {
            _outline.Y += delta;
        }
    }
}
