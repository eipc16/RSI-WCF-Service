using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceContract
{

    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        double add(double n1, double n2);

        [OperationContract]
        double sub(double n1, double n2);

        [OperationContract]
        double mult(double n1, double n2);

        [OperationContract]
        double div(double m1, double n2);

        [OperationContract]
        double sumPerm(double n);
    }
}
