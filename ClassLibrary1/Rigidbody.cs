using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;



namespace Engine2D
{

    class Rigidbody
    {

        public PhysicsObject PhysicsObject;

        public Vector2 Velocity;
        public float Mass;


        public void AddForce(PhysicsObject physicsObject, Vector2 force)
        {
 


        }


        //Add force relative to Rigidbody position (position is gotten from the parent PhysicsObject)
        public void AddExplosionForce(Vector2 position, float radius)
        {

            
            //Velocity += null; //something that has to do with radius and distance from Position to position which we will add later

            float distance = Vector2.Distance(PhysicsObject.Position, position);

            Vector2 direction = position - PhysicsObject.Position;
            
            direction.Normalize(); //Point of this is so we can multiply the radius with it and get an offset towards the position and find out if we're in the radius. ok

            if (Vector2.Distance(PhysicsObject.Position, position + direction * radius) < distance)
            {  
                
                //if the distance from object to position+radius is smaller than the distance from position to object position we have an affection for the added force
               
                //And as a result get the percentage of affection
                //Affected by force
                float radiusCoverage = distance - radius;

            }

        }

    }

}
