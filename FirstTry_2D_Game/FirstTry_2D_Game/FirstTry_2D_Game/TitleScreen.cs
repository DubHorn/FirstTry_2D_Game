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

        public override void LoadContent(ContentManager Content)
        {
            base.LoadContent(Content);
            if (font == null)
                font = content.Load<SpriteFont>("Fonts/Header");
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }
        public override void Update(GameTime gametime)
        {
            keystate = Keyboard.GetState();
            if (keystate.IsKeyDown(Keys.Enter))
                ScreenManager.Instance.AddScreen(new SplashScreen());
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, "TitleScreen", new Vector2(100, 100), Color.Black);
        }
    }
}
