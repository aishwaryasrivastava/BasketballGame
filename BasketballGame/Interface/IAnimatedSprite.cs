using Microsoft.Xna.Framework.Graphics;

namespace BasketballGame.Interface
{
    public interface IAnimatedSprite
    {
        void Update();
        void Draw(SpriteBatch sb, int x, int y);
    }
}
