using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CarWcfService
{

    [ServiceContract]
    public interface ICarWcf
    {
        /// <summary>
        /// Moves the car forward
        /// </summary>
        /// <param name="meters">Decimal, Number of meters</param>
        /// <returns></returns>
        [OperationContract]
        string MoveForward(decimal meters);

        /// <summary>
        /// Moves the car backwards
        /// </summary>
        /// <param name="meters">Decimal, Number of meters</param>
        /// <returns></returns>
        [OperationContract]
        string MoveBackwards(decimal meters);


    }

}
