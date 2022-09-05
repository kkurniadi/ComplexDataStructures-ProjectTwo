using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
// Kirsten Kurniadi, ID: 30045816
// Date: 5/09/2022
// A client interface that does not reference the third-party library
namespace Client
{
    [ServiceContract]
    internal interface IAstroContract
    {
        [OperationContract]
        double StarVelocity(double d1, double d2);

        [OperationContract]
        double StarDistance(double d);

        [OperationContract]
        double TempInKelvin(double d);

        [OperationContract]
        double EventHorizon(double d);
    }
}
