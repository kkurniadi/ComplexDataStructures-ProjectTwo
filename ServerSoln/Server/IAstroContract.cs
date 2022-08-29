using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using AstroMath;
// Kirsten Kurniadi, ID: 30045816
// Date: 29/08/2022
// An interface that references the third-party library
namespace Server
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
