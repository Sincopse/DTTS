﻿using DTTS.Controls;
using DTTS.GameObjects;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTTS.Scenes
{
    public class InfoLevel : Scene
    {
        private Wall wallTop, wallBottom, wallLeft, wallRight;

        // All gameObjects list for the player's collision check
        private readonly List<GameObject> colliders = new List<GameObject>();

        readonly List<Button> buttons = new List<Button>();
        Button backGameBtn, level1GameBtn, level2GameBtn;

        public override void LoadContent()
        {
            #region buttons
            backGameBtn = new Button(DTTSGame.instance.squareTexture, DTTSGame.instance.mainFont)
            {
                width = 300,
                Position = new Vector2(DTTSGame.screenWidth / 2 - 150, DTTSGame.screenHeight - 150),
                Text = "Back",
            };
            backGameBtn.Click += BackGameBtn_Click;
            buttons.Add(backGameBtn);

            level1GameBtn = new Button(DTTSGame.instance.squareTexture, DTTSGame.instance.mainFont)
            {
                width = 300,
                Position = new Vector2(DTTSGame.screenWidth / 2 - 150, DTTSGame.screenHeight - 290),
                Text = "Classic",
            };
            level1GameBtn.Click += LoadLevel1Btn_Click;
            buttons.Add(level1GameBtn);

            level2GameBtn = new Button(DTTSGame.instance.squareTexture, DTTSGame.instance.mainFont)
            {
                width = 300,
                Position = new Vector2(DTTSGame.screenWidth / 2 - 150, DTTSGame.screenHeight - 220),
                Text = "Single Spike",
            };
            level2GameBtn.Click += LoadLevel2Btn_Click;
            buttons.Add(level2GameBtn);
            #endregion

            #region walls
            wallTop = new Wall(DTTSGame.instance.squareTexture, new Vector2(0, 0), screenWidth, 50);
            wallBottom = new Wall(DTTSGame.instance.squareTexture, new Vector2(0, screenHeight - 50), screenWidth, 50);
            wallLeft = new Wall(DTTSGame.instance.squareTexture, new Vector2(0, 50), 50, screenHeight - 100);
            wallRight = new Wall(DTTSGame.instance.squareTexture, new Vector2(screenWidth - 50, 50), 50, screenHeight - 100);
            #endregion

            #region adding to colliders list
            colliders.Add(wallTop);
            colliders.Add(wallBottom);
            colliders.Add(wallLeft);
            colliders.Add(wallRight);
            #endregion
        }

        public override void Draw(GameTime gameTime)
        {
            _spriteBatch.Begin();

            //_spriteBatch.DrawString(game.mainFont, "High Score: " + game.highScore.highscore, new Vector2(205, 80), Color.White);
            _spriteBatch.DrawString(game.mainFont, "How to Play", new Vector2(224, 100), Color.White);

            foreach (var gameObject in colliders)
            {
                gameObject.Draw(_spriteBatch);
            }

            foreach (var button in buttons)
            {
                button.Draw(gameTime, _spriteBatch);
            }

            //game.player.Draw(_spriteBatch);

            if (game.player.powerup != null && !game.player.powerup.isActive)
            {
                _spriteBatch.DrawString(game.mainFont, "Press E to use " + game.player.powerup.ToString(), new Vector2(205, 100), Color.White, 0, new(0, 0), .5f, SpriteEffects.None, 0);
            }

            _spriteBatch.End();
        }

        public override void HandlePlayerScore()
        {
            throw new NotImplementedException();
        }

        // No restart needed for the menu
        public override void Restart() { }

        public override void Update(GameTime gameTime)
        {
            foreach (var button in buttons)
            {
                button.Update(gameTime);
            }
        }

        public void LoadLevel1Btn_Click(object sender, EventArgs e)
        {
        }

        public void LoadLevel2Btn_Click(object sender, EventArgs e)
        {
        }

        public void BackGameBtn_Click(object sender, EventArgs e)
        {
            DTTSGame.instance.ChangeScene(DTTSGame.instance.menu);
        }
    }
}
