using System;
using System.Collections.Generic;
using System.Text;

namespace CarLibrary
{
    public class Car
    {
        private Engine _engine;

        public Car(Engine engine)
        {
            _engine = engine;
        }

        public string MoveForward(decimal meters)
        {
            return $"Moved Forward { meters } meters";
        }

        public string MoveBackwards(decimal meters)
        {
            return $"Moved Backwards { meters } meters";
        }
    }
}
