﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceClient.CalculatorReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorReference.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/add", ReplyAction="http://tempuri.org/ICalculator/addResponse")]
        double add(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/add", ReplyAction="http://tempuri.org/ICalculator/addResponse")]
        System.Threading.Tasks.Task<double> addAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/sub", ReplyAction="http://tempuri.org/ICalculator/subResponse")]
        double sub(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/sub", ReplyAction="http://tempuri.org/ICalculator/subResponse")]
        System.Threading.Tasks.Task<double> subAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/mult", ReplyAction="http://tempuri.org/ICalculator/multResponse")]
        double mult(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/mult", ReplyAction="http://tempuri.org/ICalculator/multResponse")]
        System.Threading.Tasks.Task<double> multAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/div", ReplyAction="http://tempuri.org/ICalculator/divResponse")]
        double div(double m1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/div", ReplyAction="http://tempuri.org/ICalculator/divResponse")]
        System.Threading.Tasks.Task<double> divAsync(double m1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/sumPerm", ReplyAction="http://tempuri.org/ICalculator/sumPermResponse")]
        double sumPerm(double n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/sumPerm", ReplyAction="http://tempuri.org/ICalculator/sumPermResponse")]
        System.Threading.Tasks.Task<double> sumPermAsync(double n);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : WcfServiceClient.CalculatorReference.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<WcfServiceClient.CalculatorReference.ICalculator>, WcfServiceClient.CalculatorReference.ICalculator {
        
        public CalculatorClient() {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double add(double n1, double n2) {
            return base.Channel.add(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> addAsync(double n1, double n2) {
            return base.Channel.addAsync(n1, n2);
        }
        
        public double sub(double n1, double n2) {
            return base.Channel.sub(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> subAsync(double n1, double n2) {
            return base.Channel.subAsync(n1, n2);
        }
        
        public double mult(double n1, double n2) {
            return base.Channel.mult(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> multAsync(double n1, double n2) {
            return base.Channel.multAsync(n1, n2);
        }
        
        public double div(double m1, double n2) {
            return base.Channel.div(m1, n2);
        }
        
        public System.Threading.Tasks.Task<double> divAsync(double m1, double n2) {
            return base.Channel.divAsync(m1, n2);
        }
        
        public double sumPerm(double n) {
            return base.Channel.sumPerm(n);
        }
        
        public System.Threading.Tasks.Task<double> sumPermAsync(double n) {
            return base.Channel.sumPermAsync(n);
        }
    }
}
