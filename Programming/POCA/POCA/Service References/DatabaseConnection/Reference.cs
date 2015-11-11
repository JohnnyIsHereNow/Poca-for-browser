﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace POCA.DatabaseConnection {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DatabaseConnection.IDbConnectionService")]
    public interface IDbConnectionService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IDbConnectionService/CreateConnection", ReplyAction="http://tempuri.org/IDbConnectionService/CreateConnectionResponse")]
        System.IAsyncResult BeginCreateConnection(System.AsyncCallback callback, object asyncState);
        
        void EndCreateConnection(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IDbConnectionService/CloseConnection", ReplyAction="http://tempuri.org/IDbConnectionService/CloseConnectionResponse")]
        System.IAsyncResult BeginCloseConnection(System.AsyncCallback callback, object asyncState);
        
        void EndCloseConnection(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDbConnectionServiceChannel : POCA.DatabaseConnection.IDbConnectionService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DbConnectionServiceClient : System.ServiceModel.ClientBase<POCA.DatabaseConnection.IDbConnectionService>, POCA.DatabaseConnection.IDbConnectionService {
        
        private BeginOperationDelegate onBeginCreateConnectionDelegate;
        
        private EndOperationDelegate onEndCreateConnectionDelegate;
        
        private System.Threading.SendOrPostCallback onCreateConnectionCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseConnectionDelegate;
        
        private EndOperationDelegate onEndCloseConnectionDelegate;
        
        private System.Threading.SendOrPostCallback onCloseConnectionCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public DbConnectionServiceClient() {
        }
        
        public DbConnectionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DbConnectionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DbConnectionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DbConnectionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CreateConnectionCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseConnectionCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult POCA.DatabaseConnection.IDbConnectionService.BeginCreateConnection(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginCreateConnection(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void POCA.DatabaseConnection.IDbConnectionService.EndCreateConnection(System.IAsyncResult result) {
            base.Channel.EndCreateConnection(result);
        }
        
        private System.IAsyncResult OnBeginCreateConnection(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((POCA.DatabaseConnection.IDbConnectionService)(this)).BeginCreateConnection(callback, asyncState);
        }
        
        private object[] OnEndCreateConnection(System.IAsyncResult result) {
            ((POCA.DatabaseConnection.IDbConnectionService)(this)).EndCreateConnection(result);
            return null;
        }
        
        private void OnCreateConnectionCompleted(object state) {
            if ((this.CreateConnectionCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CreateConnectionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CreateConnectionAsync() {
            this.CreateConnectionAsync(null);
        }
        
        public void CreateConnectionAsync(object userState) {
            if ((this.onBeginCreateConnectionDelegate == null)) {
                this.onBeginCreateConnectionDelegate = new BeginOperationDelegate(this.OnBeginCreateConnection);
            }
            if ((this.onEndCreateConnectionDelegate == null)) {
                this.onEndCreateConnectionDelegate = new EndOperationDelegate(this.OnEndCreateConnection);
            }
            if ((this.onCreateConnectionCompletedDelegate == null)) {
                this.onCreateConnectionCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCreateConnectionCompleted);
            }
            base.InvokeAsync(this.onBeginCreateConnectionDelegate, null, this.onEndCreateConnectionDelegate, this.onCreateConnectionCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult POCA.DatabaseConnection.IDbConnectionService.BeginCloseConnection(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginCloseConnection(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void POCA.DatabaseConnection.IDbConnectionService.EndCloseConnection(System.IAsyncResult result) {
            base.Channel.EndCloseConnection(result);
        }
        
        private System.IAsyncResult OnBeginCloseConnection(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((POCA.DatabaseConnection.IDbConnectionService)(this)).BeginCloseConnection(callback, asyncState);
        }
        
        private object[] OnEndCloseConnection(System.IAsyncResult result) {
            ((POCA.DatabaseConnection.IDbConnectionService)(this)).EndCloseConnection(result);
            return null;
        }
        
        private void OnCloseConnectionCompleted(object state) {
            if ((this.CloseConnectionCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseConnectionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseConnectionAsync() {
            this.CloseConnectionAsync(null);
        }
        
        public void CloseConnectionAsync(object userState) {
            if ((this.onBeginCloseConnectionDelegate == null)) {
                this.onBeginCloseConnectionDelegate = new BeginOperationDelegate(this.OnBeginCloseConnection);
            }
            if ((this.onEndCloseConnectionDelegate == null)) {
                this.onEndCloseConnectionDelegate = new EndOperationDelegate(this.OnEndCloseConnection);
            }
            if ((this.onCloseConnectionCompletedDelegate == null)) {
                this.onCloseConnectionCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseConnectionCompleted);
            }
            base.InvokeAsync(this.onBeginCloseConnectionDelegate, null, this.onEndCloseConnectionDelegate, this.onCloseConnectionCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override POCA.DatabaseConnection.IDbConnectionService CreateChannel() {
            return new DbConnectionServiceClientChannel(this);
        }
        
        private class DbConnectionServiceClientChannel : ChannelBase<POCA.DatabaseConnection.IDbConnectionService>, POCA.DatabaseConnection.IDbConnectionService {
            
            public DbConnectionServiceClientChannel(System.ServiceModel.ClientBase<POCA.DatabaseConnection.IDbConnectionService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginCreateConnection(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("CreateConnection", _args, callback, asyncState);
                return _result;
            }
            
            public void EndCreateConnection(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("CreateConnection", _args, result);
            }
            
            public System.IAsyncResult BeginCloseConnection(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("CloseConnection", _args, callback, asyncState);
                return _result;
            }
            
            public void EndCloseConnection(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("CloseConnection", _args, result);
            }
        }
    }
}
