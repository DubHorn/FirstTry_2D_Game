using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace FirstTry_2D_Game
{
    class FadeAnimation : Animation
    {
        bool increase;
        float fadespeed;
        TimeSpan defaultTime, timer;
        bool startTimer;
        float activateValue;
        bool stopUpdating;
        float defaultAlpha;

        public override void LoadContent(ContentManager Content, Texture2D image, string text, Vector2 postion)
        {
            base.LoadContent(Content, image, text, postion);
            increase = false;
            fadespeed = 1.0f;
            defaultTime = new TimeSpan(0, 0, 1);
            timer = defaultTime;
            activateValue = 0.0f;
            stopUpdating = false;
            defaultAlpha = alpha;
        }
    }
}
