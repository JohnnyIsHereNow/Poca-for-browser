﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PocaWebsite.UpdateProfileServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UpdateProfileServiceReference.IUpdateProfile")]
    public interface IUpdateProfile {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUpdateProfile/GetData", ReplyAction="http://tempuri.org/IUpdateProfile/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUpdateProfile/GetData", ReplyAction="http://tempuri.org/IUpdateProfile/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUpdateProfileChannel : PocaWebsite.UpdateProfileServiceReference.IUpdateProfile, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UpdateProfileClient : System.ServiceModel.ClientBase<PocaWebsite.UpdateProfileServiceReference.IUpdateProfile>, PocaWebsite.UpdateProfileServiceReference.IUpdateProfile {
        
        public UpdateProfileClient() {
        }
        
        public UpdateProfileClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UpdateProfileClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UpdateProfileClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UpdateProfileClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
    }
}