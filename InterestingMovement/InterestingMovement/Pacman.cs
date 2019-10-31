using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestingMovement
{
    class Pacman : Sprite
    {
        Input input;
       

        public Pacman(Game game) : base(game)
        {
            input = new Input();
        }

        public override void Update(GameTime gameTime)
        {
            UpdateSpeed();
            this.Direction = input.direction;
            input.Update(gameTime);

            //Rotation
            RotationAngleKey = (float)System.Math.Atan2(
                    this.Direction.X,
                    this.Direction.Y * -1); //y axis is flipped already
            //Find angle in degrees
            this.Rotate = (float)MathHelper.ToDegrees(
                RotationAngleKey - (float)(System.Math.PI / 2)); //image is rotated facing right already hence the -1/2 PI


            // Gets time since last update to correct movement speed
            float time = (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            // Moves pacman based off time (1000 miliseconds in a second
            Location = Location + ((Direction * Speed) * (time / 1000));
        }

        private void UpdateSpeed()
        {
            //Speed for next frame
            if (Keyboard.GetState().GetPressedKeys().Length > 0)
            {
                this.Speed = 200;
            }
            else
            {
                this.Speed = 0;
            }
        }
    }
}
