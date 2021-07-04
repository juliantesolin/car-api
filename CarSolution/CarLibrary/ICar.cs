using System;
using System.Collections.Generic;
using System.Text;

namespace CarLibrary
{
    public interface ICar
    {
        /// <summary>
        /// Moves the car forward
        /// </summary>
        /// <param name="meters">Number of meters to move</param>
        /// <returns></returns>
        public string MoveForward(decimal meters);

        /// <summary>
        /// Moves the car backwards
        /// </summary>
        /// <param name="meters">Number of meters to move<</param>
        /// <returns></returns>
        public string MoveBackwards(decimal meters);
    }
}
