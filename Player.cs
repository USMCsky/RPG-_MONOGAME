using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace rpg
{
    class Player
    {
        // Fields
        private Vector2 position = new Vector2(500, 300);
        private int speed = 300;
        private Dir direction = Dir.Down;
        private bool isMoving = false;

        // Constructor
        public Vector2 Position { 
            get { return position; 
            } 
        }

        // Methods
        public void setX(float newX)
        {
            position.X = newX;
        }

        public void setY(float newY)
        {
            position.Y = newY;
        }


        // Update method to handle player movement
        public void Update(GameTime gameTime)
        {

            // Handle player movement based on keyboard input
            KeyboardState kState = Keyboard.GetState();
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            isMoving = false;

            // Determine direction based on key presses
            if (kState.IsKeyDown(Keys.A))
            {
                direction = Dir.Left;
                isMoving = true;
            }
            if (kState.IsKeyDown(Keys.D))
            {
                direction = Dir.Right;
                isMoving= true;
            }
            if (kState.IsKeyDown(Keys.W))
            {
                direction = Dir.Up;
                isMoving = true;
            }
            if (kState.IsKeyDown(Keys.S))
            {
                direction = Dir.Down;
                isMoving = true;
            }


            // Update player position based on direction and speed

            if (isMoving)
            {
                switch (direction)
                {
                    case Dir.Right:
                        position.X += speed * dt;
                        break;
                    case Dir.Left:
                        position.X -= speed * dt;
                        break;
                    case Dir.Up:
                        position.Y -= speed * dt;
                        break;
                    case Dir.Down:
                        position.Y += speed * dt;
                        break;
                }
            }
            }
    }
}
