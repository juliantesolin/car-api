using CarLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CarWcfService
{

    public class CarWcf : ICarWcf
    {
        public string MoveForward(decimal meters)
        {
            string result = String.Empty;

            try
            {
                Car car = new Car(new V8());

                result = car.MoveForward(meters);

            }
            catch
            {
                result = "An error occurred, please make sure you inserted a correct value";
            }

            return result;
        }
        public string MoveBackwards(decimal meters)
        {
            string result = String.Empty;

            try
            {
                Car car = new Car(new V8());

                result = car.MoveBackwards(meters);

            }
            catch
            {
                result = "An error occurred, please make sure you inserted a correct value";
            }

            return result;
        }
    }
}
