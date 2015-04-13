using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Engine2D
{

    public class PhysicsObject 
    {
        //When we assign a Rigidbody to this object, we assign this object as the parent
        Rigidbody _Rigidbody;
        /*public Rigidbody Rigidbody
        {

            get
            {

                return _Rigidbody;

            }


            set
            {

                if (value != null)
                {
               

                    _Rigidbody = value;
                    _Rigidbody.PhysicsObject = this;

                }
                else
                {

                    //Throw an error for trying to assign a null Rigidbody

                }


            }

        }*/

//        public Collider Collider;//Need to assign collider in the same fashion as the rigidbody

        public Vector2 Position;


        //Quaternion Rotation;
        
    }

}
