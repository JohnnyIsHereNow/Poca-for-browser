﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PocaWebsite.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IRandomNumbers")]
    public interface IRandomNumbers {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRandomNumbers/GetNumber", ReplyAction="http://tempuri.org/IRandomNumbers/GetNumberResponse")]
        string GetNumber();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRandomNumbers/GetNumber", ReplyAction="http://tempuri.org/IRandomNumbers/GetNumberResponse")]
        System.Threading.Tasks.Task<string> GetNumberAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRandomNumbersChannel : PocaWebsite.ServiceReference1.IRandomNumbers, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RandomNumbersClient : System.ServiceModel.ClientBase<PocaWebsite.ServiceReference1.IRandomNumbers>, PocaWebsite.ServiceReference1.IRandomNumbers {
        
        public RandomNumbersClient() {
        }
        
        public RandomNumbersClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RandomNumbersClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RandomNumbersClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RandomNumbersClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetNumber() {
            return base.Channel.GetNumber();
        }
        
        public System.Threading.Tasks.Task<string> GetNumberAsync() {
            return base.Channel.GetNumberAsync();
        }
    }
}