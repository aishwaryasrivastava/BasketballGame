
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BasketballGame.Interface
{
    public interface IStage
    {
        void UpdateGameItem();
        void Update(GameTime gameTime);
        void Draw(SpriteBatch spriteBatch, SpriteFont font);
        int GetMarioState();
    }
}
