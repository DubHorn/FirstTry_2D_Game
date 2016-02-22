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
    public class GameScreen
    {
        protected ContentManager content;

        public virtual void LoadContent(ContentManager Content)
        {
            content = new ContentManager(Content.ServiceProvider, "Content");
        }

        public virtual void UnloadContent()
        {
            content.Unload();
        }
        public virtual void Update(GameTime gametime)
        {

        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}