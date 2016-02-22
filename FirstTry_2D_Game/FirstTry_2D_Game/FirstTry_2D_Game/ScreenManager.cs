using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
namespace FirstTry_2D_Game
{
    public class ScreenManager
    {

        #region Variables
         
        /// <summary>
        /// Creating custom content manager
        /// </summary>
        ContentManager content;

        /// <summary>
        /// Current Screen that's being displayed
        /// </summary>
        GameScreen CurrentScreen;

        /// <summary>
        /// The new screen that will be taking effect
        /// </summary>
        GameScreen newScreen;

        /// <summary>
        /// Screen manager instance
        /// </summary>
        private static ScreenManager instance;

        /// <summary>
        /// Screen Stack
        /// </summary>
        Stack<GameScreen> ScreenStack = new Stack<GameScreen>();

        /// <summary>
        /// Screens width and height
        /// </summary>
        /// 
        Vector2 dimensions;

        #endregion

        #region Properties
        public static ScreenManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new ScreenManager();
                return instance;
            }
        }

        public Vector2 Dimensions
        {
            get { return dimensions; }
            set { dimensions = value; }
        }
        #endregion

        #region Main Methods

        public void AddScreen(GameScreen screen)
        {
            newScreen = screen;
            ScreenStack.Push(screen);
            CurrentScreen.UnloadContent();
            CurrentScreen = newScreen;
            CurrentScreen.LoadContent(content);
        }

        public void Initialize()
        {
            CurrentScreen = new SplashScreen();
        }
        public void LoadContent(ContentManager Content)
        {
            content = new ContentManager(Content.ServiceProvider, "Content");
            CurrentScreen.LoadContent(Content);
        }
        public void Update(GameTime gametime)
        {
            CurrentScreen.Update(gametime);
        }
        public void Draw(SpriteBatch spritebatch)
        {
            CurrentScreen.Draw(spritebatch);
        }


        #endregion
    }
}