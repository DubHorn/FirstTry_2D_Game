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
    public class TitleScreen : GameScreen
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
            if (keystate.IsKeyDown(Keys.L))
                ScreenManager.Instance.AddScreen(new SplashScreen());
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, "TitleScreen", new Vector2(245, 100), Color.Black);
            spriteBatch.DrawString(Menu, "Enter - To Continue", new Vector2(300, 340), Color.Black);
            spriteBatch.DrawString(Menu, "C - Credits", new Vector2(348, 390), Color.Black);
            spriteBatch.DrawString(Menu, "Esc - Exit", new Vector2(353, 430), Color.Black);
        }
    }
}
