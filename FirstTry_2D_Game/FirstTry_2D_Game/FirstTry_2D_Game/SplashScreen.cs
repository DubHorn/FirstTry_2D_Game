﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace FirstTry_2D_Game
{
    public class SplashScreen : GameScreen
    {
        KeyboardState keystate;
        SpriteFont font, Menu /*,text*/ ;
        List<FadeAnimation> fade;
        List<Texture2D> images;
       // List<SoundEffect> sounds;
        FileManager fileManager;

        int imageNumber;

        public override void LoadContent(ContentManager Content)
        {
            base.LoadContent(Content);
            if (font == null)
                font = content.Load<SpriteFont>("Fonts/Header");
            if (Menu == null)
                Menu = content.Load<SpriteFont>("Fonts/Menu");
            imageNumber = 0;
            fileManager = new FileManager();
            fade = new List<FadeAnimation>();
            images = new List<Texture2D>();

            fileManager.LoadContent("Load/splash.cme", attributes, contents);

            for(int i = 0; i < attributes.Count; i++)
            {
                for(int j = 0; j < attributes[i].Count; j++)
                {
                    switch (attributes[i][j])
                    {
                        case "Image":
                            images.Add(content.Load<Texture2D>(contents[i][j]));
                            fade.Add(new FadeAnimation());
                            break;
                       // case "Sound":
                       //     sounds.Add(content.Load<SoundEffect>(contents[i][j]));
                       //     break;
                    }
                }
            }
            for (int i = 0; i < fade.Count; i++)
            {
                fade[i].LoadContent(content, images[i], "", Vector2.Zero);
                fade[i].Scale = 1.0f;
                fade[i].IsActive = true;
            }
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
            fileManager = null;
        }
        public override void Update(GameTime gametime)
        {
            keystate = Keyboard.GetState();
            //if (keystate.IsKeyDown(Keys.Enter))
            //    ScreenManager.Instance.AddScreen(new TitleScreen());
            //if (keystate.IsKeyDown(Keys.Escape))
            //    ScreenManager.Instance.AddScreen(new GameScreen());

            fade[imageNumber].Update(gametime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            fade[imageNumber].Draw(spriteBatch);
           // spriteBatch.DrawString(font, "GenericGame", new Vector2(225, 100), Color.Black);
           // spriteBatch.DrawString(Menu, "Enter - To Continue", new Vector2(285, 550), Color.Black);
        }
    }
}
