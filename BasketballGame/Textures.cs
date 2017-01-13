using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BasketballGame
{
    public static class Textures
    {
        public static Texture2D MarioIdleRight;
        public static Texture2D MarioIdleLeft;
        public static Texture2D MarioMovingRight;
        public static Texture2D MarioMovingLeft;
        public static Texture2D MarioJumpingRight;
        public static Texture2D MarioJumpingLeft;
        public static Texture2D MarioCrouchRight;
        public static Texture2D MarioCrouchLeft;

        public static Texture2D LuigiIdleRight;
        public static Texture2D LuigiIdleLeft;
        public static Texture2D LuigiMovingRight;
        public static Texture2D LuigiMovingLeft;
        public static Texture2D LuigiJumpingRight;
        public static Texture2D LuigiJumpingLeft;
        public static Texture2D LuigiCrouchRight;
        public static Texture2D LuigiCrouchLeft;

        public static Texture2D LuigiHoop;
        public static Texture2D MarioHoop;
        public static Texture2D Basketball;

        public static void LoadSpriteSheet(ContentManager content)
        {
            MarioIdleRight = content.Load<Texture2D>("MarioSprites/MarioIdleRight");
            MarioIdleLeft = content.Load<Texture2D>("MarioSprites/MarioIdleLeft");
            MarioMovingRight = content.Load<Texture2D>("MarioSprites/MarioMovingRight");
            MarioMovingLeft = content.Load<Texture2D>("MarioSprites/MarioMovingLeft");
            MarioJumpingRight = content.Load<Texture2D>("MarioSprites/MarioJumpingRight");
            MarioJumpingLeft = content.Load<Texture2D>("MarioSprites/MarioJumpingLeft");
            MarioCrouchRight = content.Load<Texture2D>("MarioSprites/MarioCrouchRight");
            MarioCrouchLeft = content.Load<Texture2D>("MarioSprites/MarioCrouchLeft");

            LuigiIdleRight = content.Load<Texture2D>("LuigiSprites/LuigiIdleRight");
            LuigiIdleLeft = content.Load<Texture2D>("LuigiSprites/LuigiIdleLeft");
            LuigiMovingRight = content.Load<Texture2D>("LuigiSprites/LuigiMovingRight");
            LuigiMovingLeft = content.Load<Texture2D>("LuigiSprites/LuigiMovingLeft");
            LuigiJumpingRight = content.Load<Texture2D>("LuigiSprites/LuigiJumpingRight");
            LuigiJumpingLeft = content.Load<Texture2D>("LuigiSprites/LuigiJumpingLeft");
            LuigiCrouchRight = content.Load<Texture2D>("LuigiSprites/LuigiCrouchRight");
            LuigiCrouchLeft = content.Load<Texture2D>("LuigiSprites/LuigiCrouchLeft");

            LuigiHoop = content.Load<Texture2D>("Misc/Luigi_hoop");
            MarioHoop = content.Load<Texture2D>("Misc/Mario_hoop");
            Basketball = content.Load<Texture2D>("Misc/basketball_sprite");
        }
    }
}
