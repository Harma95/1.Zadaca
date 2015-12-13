using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace PongGame
{
    public class Paddle : Sprite
    {
        private const float InitalSpeed = 0.9f;
        private const int PaddleHeight=20;
        private const int PaddleWidth = 200;
        public float Speed { get; set; }
        public Paddle(Texture2D spriteTexture)
            : base(spriteTexture, PaddleWidth, PaddleHeight)
        {
            Speed = InitalSpeed;
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Size, Color.Black);
        }
    }
}
