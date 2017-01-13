using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using BasketballGame.Interface;

namespace BasketballGame
{
    public class Animation : IAnimatedSprite
    {
        private readonly Texture2D _texture;
        private readonly int _totalFrames;
        private readonly int _speed;
        private int _delay;
        private int _currentFrame;

        public Animation(Texture2D texture, int frames = 1, int speed = 1, int currentframe = 0)
        {
            _texture = texture;
            _totalFrames = frames;
            _speed = speed;
            _delay = 0;
            _currentFrame = currentframe;
        }

        public void Update()
        {
            _delay++;
            if (_delay % _speed == 0)
            {
                _currentFrame++;

                if (_currentFrame == _totalFrames)
                {
                    _currentFrame = 0;
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch, int x, int y)
        {
            int width = _texture.Width / _totalFrames;
            int height = _texture.Height;

            Rectangle sourceRectangle = new Rectangle(width * _currentFrame, 0, width, height);
            Rectangle destinationRectangle = new Rectangle(x, y, width, height);

            spriteBatch.Draw(_texture, destinationRectangle, sourceRectangle, Color.White);
        }

    }
}
