using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
//using BasketballGame.Commands;
//using BasketballGame.Level;
using Microsoft.Xna.Framework.Media;
using BasketballGame.Interface;
using BasketballGame.StageList;
using System;
//using BasketballGame.State.Mario2;

namespace BasketballGame.StageList
{
    public class MainStage //: IStage
    {
        /*
        public static LevelContent _levelContent;
        public static Collision.Collision Collider;
        private static MainLevelHandler _playerInputHandler;

        public static MainLevelHandler PlayerInputHandlerInstance
        {
            get
            {
                Debug.Assert(_playerInputHandler != null, "_playerInputHandler != null");
                return _playerInputHandler;
            }
        }

        private static LevelContent _stageInstance;

        public static LevelContent StageInstance
        {
            get
            {
                Debug.Assert(_stageInstance != null, "_gameInstance != null");
                return _stageInstance;
            }
        }

        public MainStage()
        {
            Game1.GameInstance.HUD.display = true;
            Game1.Camera.Limits = new Rectangle(0, 0, 1920, 240);
            World.WorldInstance.isUnderLevel = false;
            _levelContent = new LevelContent("Content/level.json");
            _stageInstance = _levelContent;
            _playerInputHandler = new MainLevelHandler();
            PlayerInputHandlerInstance.Initialize();
            MediaPlayer.Stop();
            MediaPlayer.Play(BackgroundMusic.MainLevel);
            MediaPlayer.IsRepeating = true;
            Collider = new Collision.Collision(_levelContent);

        }

        public void UpdateGameItem()
        {
            _levelContent.Update();
        }

        public void Update(GameTime gameTime)
        {
            var elapsed = (float)gameTime.ElapsedGameTime.TotalSeconds;
            PlayerInputHandlerInstance.HandleInput(elapsed);
            Collider.Update();

            if (Game1.GameInstance.timer.timeRemaining() == 0)
            {
                World.WorldInstance.stage = GoGameOver();
            }
        }

        public void Draw(SpriteBatch spriteBatch, SpriteFont font)
        {
            _levelContent.Draw(spriteBatch);
        }

        private IStage GoGameOver()
        {
            return new GameOverStage();
        }

        public int GetMarioState()
        {
            if (_levelContent.Mario.MarioState is MarioCrouchState2 || _levelContent.Mario.MarioState is MarioCrouchStarState2)
                return 0;
            if (_levelContent.Mario.MarioState is SuperMarioCrouchState2 || _levelContent.Mario.MarioState is SuperMarioCrouchStarState2)
                return 1;
            if (_levelContent.Mario.MarioState is FireMarioCrouchState2 || _levelContent.Mario.MarioState is FireMarioCrouchStarState2)
                return 2;
            return 0;
        }
        */
    }
}
