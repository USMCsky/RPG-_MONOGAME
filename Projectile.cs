using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace rpg
{
    class Projectile
    {
        private Vector2 position;
        private int speed = 1000;
        public int radius = 18;
        private Dir direction;

        public Projectile(Vector2 newPos, Dir newDir)
        {
            position = newPos;
            direction = newDir;
        }
        
        public Vector2 Position { 
            get { 
                return position; 
            } 
        }

        public void Update(GameTime gameTime) { 

        
        }
    }
}
