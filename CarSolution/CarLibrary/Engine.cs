using System;
using System.Collections.Generic;
using System.Text;

namespace CarLibrary
{
    public abstract class Engine
    {
        /// <summary>
        /// Starts de engine
        /// </summary>
        /// <returns></returns>
        public string StartEngine()
        {
            return "Started";
        }

        /// <summary>
        /// Stops de engine
        /// </summary>
        /// <returns></returns>
        public string StopEngine()
        {
            return "Stopped";
        }
    }
}
