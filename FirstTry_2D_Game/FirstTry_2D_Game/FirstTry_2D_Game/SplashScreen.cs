using System;
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
        SpriteFont font;
        SpriteFont Menu;


        public override void LoadContent(ContentManager Content)
        {
            base.LoadContent(Content);
            if (font == null)
                font = content.Load<SpriteFont>("Fonts/Header");
            if (Menu == null)
                Menu = content.Load<SpriteFont>("Fonts/Menu");
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }
        public override void Update(GameTime gametime)
        {
            keystate = Keyboard.GetState();
            if (keystate.IsKeyDown(Keys.Enter))
                ScreenManager.Instance.AddScreen(new TitleScreen());
            if (keystate.IsKeyDown(Keys.Escape))
                ScreenManager.Instance.AddScreen(new GameScreen());
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, "GenericGame", new Vector2(225, 100), Color.Black);
            spriteBatch.DrawString(Menu, "Enter - To Continue", new Vector2(285, 550), Color.Black);
        }
    }
}
