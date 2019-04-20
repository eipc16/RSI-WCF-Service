using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceContract
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Calculator : ICalculator
    {

        private double sum = 0.0;

        public double add(double n1, double n2)
        {
            return n1 + n2;
        }

        public double mult(double n1, double n2)
        {
            return n1 * n2;
        }

        public double sub(double n1, double n2)
        {
            return n1 - n2;
        }

        public double div(double n1, double n2)
        {
            if(n2 != 0)
            {
                return n1 / n2;
            } else
            {
                throw new DivideByZeroException($"You can't divide by {n2}!");
            }
        }

        public double sumPerm(double n)
        {
            sum += n;
            return sum;
        }
    }
}
