﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceAppWCF.ProductServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductServiceReference.IProductService")]
    public interface IProductService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/DoWork", ReplyAction="http://tempuri.org/IProductService/DoWorkResponse")]
        string DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/DoWork", ReplyAction="http://tempuri.org/IProductService/DoWorkResponse")]
        System.Threading.Tasks.Task<string> DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductList", ReplyAction="http://tempuri.org/IProductService/ProductListResponse")]
        System.Collections.Generic.List<WcfService.ProductDTO> ProductList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/ProductList", ReplyAction="http://tempuri.org/IProductService/ProductListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WcfService.ProductDTO>> ProductListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductServiceChannel : ServiceAppWCF.ProductServiceReference.IProductService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductServiceClient : System.ServiceModel.ClientBase<ServiceAppWCF.ProductServiceReference.IProductService>, ServiceAppWCF.ProductServiceReference.IProductService {
        
        public ProductServiceClient() {
        }
        
        public ProductServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string DoWork() {
            return base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task<string> DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public System.Collections.Generic.List<WcfService.ProductDTO> ProductList() {
            return base.Channel.ProductList();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WcfService.ProductDTO>> ProductListAsync() {
            return base.Channel.ProductListAsync();
        }
    }
}
