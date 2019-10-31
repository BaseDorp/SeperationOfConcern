using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestingMovement
{
    class Input
    {
        public Vector2 direction;

        public Input()
        {
            
        }

        public void Update(GameTime gameTime)
        {
            KeyboardInput();
        }

        public void KeyboardInput()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.W) || Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                direction += new Vector2(0, -1);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S) || Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                direction += new Vector2(0, 1);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A) || Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                direction += new Vector2(-1, 0);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D) || Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                direction += new Vector2(1, 0);
            }
            if (direction.Length() > 1)
            {
                direction.Normalize();
            }
            else
            {
                direction += new Vector2(0,0);
            }
        }
    }
}
