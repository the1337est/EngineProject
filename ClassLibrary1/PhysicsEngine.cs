using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.Diagnostics;

namespace Engine2D
{

    public class PhysicsEngine
    {

        public static PhysicsEngine Instance;

        public delegate void OnLogHandler(string message);

        public event OnLogHandler OnLog;

        public PhysicsEngine()
        {

            if (Instance == null)
            {

                Instance = this;

            }

           
        }

        public static void Log(string message)
        {
            
            System.Diagnostics.Debug.WriteLine(message);

            if (Instance != null)
            {

                if (Instance.OnLog != null)
                {

                    Instance.OnLog(message);

                }

            }
            else
            {

                System.Diagnostics.Debug.WriteLine("Unable to find a single instance of PhysicsEngine.");

            }

        }

    }

}

