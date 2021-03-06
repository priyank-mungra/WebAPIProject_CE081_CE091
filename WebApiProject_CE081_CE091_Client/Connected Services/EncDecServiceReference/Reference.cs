//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFProject_CE091_CE081_Client.EncDecServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EncDecServiceReference.IEncDecService")]
    public interface IEncDecService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEncDecService/EncryptData", ReplyAction="http://tempuri.org/IEncDecService/EncryptDataResponse")]
        string EncryptData(string key, string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEncDecService/EncryptData", ReplyAction="http://tempuri.org/IEncDecService/EncryptDataResponse")]
        System.Threading.Tasks.Task<string> EncryptDataAsync(string key, string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEncDecService/DecryptData", ReplyAction="http://tempuri.org/IEncDecService/DecryptDataResponse")]
        string DecryptData(string key, string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEncDecService/DecryptData", ReplyAction="http://tempuri.org/IEncDecService/DecryptDataResponse")]
        System.Threading.Tasks.Task<string> DecryptDataAsync(string key, string data);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEncDecServiceChannel : WCFProject_CE091_CE081_Client.EncDecServiceReference.IEncDecService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EncDecServiceClient : System.ServiceModel.ClientBase<WCFProject_CE091_CE081_Client.EncDecServiceReference.IEncDecService>, WCFProject_CE091_CE081_Client.EncDecServiceReference.IEncDecService {
        
        public EncDecServiceClient() {
        }
        
        public EncDecServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EncDecServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EncDecServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EncDecServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string EncryptData(string key, string data) {
            return base.Channel.EncryptData(key, data);
        }
        
        public System.Threading.Tasks.Task<string> EncryptDataAsync(string key, string data) {
            return base.Channel.EncryptDataAsync(key, data);
        }
        
        public string DecryptData(string key, string data) {
            return base.Channel.DecryptData(key, data);
        }
        
        public System.Threading.Tasks.Task<string> DecryptDataAsync(string key, string data) {
            return base.Channel.DecryptDataAsync(key, data);
        }
    }
}
