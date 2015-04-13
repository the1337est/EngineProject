using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Engine2D
{
    class Shape : PhysicsObject
    {

        

    }

    class Rect : Shape
    {


        Vector2 Size;

        public Rect(Vector2 position, Vector2 size)
        {

            this.Position = position;
            this.Size = size;


        }
       
 
    }
}


