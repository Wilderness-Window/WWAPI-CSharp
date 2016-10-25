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
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WWAPI.WWAPI {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WWAPISoap", Namespace="http://www.wilderness-window.com/")]
    public partial class WWAPI : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private authentication authenticationValueField;
        
        private System.Threading.SendOrPostCallback GetAvailabilityByDayOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetWildernessPropertiesOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WWAPI() {
            this.Url = global::WWAPI.Properties.Settings.Default.WWAPI_WWAPI_WWAPI;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public authentication authenticationValue {
            get {
                return this.authenticationValueField;
            }
            set {
                this.authenticationValueField = value;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetAvailabilityByDayCompletedEventHandler GetAvailabilityByDayCompleted;
        
        /// <remarks/>
        public event GetWildernessPropertiesCompletedEventHandler GetWildernessPropertiesCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("authenticationValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.wilderness-window.com/GetAvailabilityByDay", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("GetAvailabilityByDayResponse", Namespace="http://www.wilderness-window.com/")]
        public GetAvailabilityByDayResponse GetAvailabilityByDay([System.Xml.Serialization.XmlElementAttribute("GetAvailabilityByDay", Namespace="http://www.wilderness-window.com/")] GetAvailabilityByDay GetAvailabilityByDay1) {
            object[] results = this.Invoke("GetAvailabilityByDay", new object[] {
                        GetAvailabilityByDay1});
            return ((GetAvailabilityByDayResponse)(results[0]));
        }
        
        /// <remarks/>
        public void GetAvailabilityByDayAsync(GetAvailabilityByDay GetAvailabilityByDay1) {
            this.GetAvailabilityByDayAsync(GetAvailabilityByDay1, null);
        }
        
        /// <remarks/>
        public void GetAvailabilityByDayAsync(GetAvailabilityByDay GetAvailabilityByDay1, object userState) {
            if ((this.GetAvailabilityByDayOperationCompleted == null)) {
                this.GetAvailabilityByDayOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAvailabilityByDayOperationCompleted);
            }
            this.InvokeAsync("GetAvailabilityByDay", new object[] {
                        GetAvailabilityByDay1}, this.GetAvailabilityByDayOperationCompleted, userState);
        }
        
        private void OnGetAvailabilityByDayOperationCompleted(object arg) {
            if ((this.GetAvailabilityByDayCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAvailabilityByDayCompleted(this, new GetAvailabilityByDayCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("authenticationValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.wilderness-window.com/GetWildernessProperties", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("GetWildernessPropertiesResponse", Namespace="http://www.wilderness-window.com/")]
        public GetWildernessPropertiesResponse GetWildernessProperties([System.Xml.Serialization.XmlElementAttribute("GetWildernessProperties", Namespace="http://www.wilderness-window.com/")] GetWildernessProperties GetWildernessProperties1) {
            object[] results = this.Invoke("GetWildernessProperties", new object[] {
                        GetWildernessProperties1});
            return ((GetWildernessPropertiesResponse)(results[0]));
        }
        
        /// <remarks/>
        public void GetWildernessPropertiesAsync(GetWildernessProperties GetWildernessProperties1) {
            this.GetWildernessPropertiesAsync(GetWildernessProperties1, null);
        }
        
        /// <remarks/>
        public void GetWildernessPropertiesAsync(GetWildernessProperties GetWildernessProperties1, object userState) {
            if ((this.GetWildernessPropertiesOperationCompleted == null)) {
                this.GetWildernessPropertiesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetWildernessPropertiesOperationCompleted);
            }
            this.InvokeAsync("GetWildernessProperties", new object[] {
                        GetWildernessProperties1}, this.GetWildernessPropertiesOperationCompleted, userState);
        }
        
        private void OnGetWildernessPropertiesOperationCompleted(object arg) {
            if ((this.GetWildernessPropertiesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetWildernessPropertiesCompleted(this, new GetWildernessPropertiesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.wilderness-window.com/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.wilderness-window.com/", IsNullable=false)]
    public partial class authentication : System.Web.Services.Protocols.SoapHeader {
        
        private string usernameField;
        
        private string passwordField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.wilderness-window.com/")]
    public partial class GetAvailabilityByDay {
        
        private string propertyListField;
        
        private System.DateTime startDateField;
        
        private long numberOfDaysField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PropertyList {
            get {
                return this.propertyListField;
            }
            set {
                this.propertyListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime StartDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long NumberOfDays {
            get {
                return this.numberOfDaysField;
            }
            set {
                this.numberOfDaysField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.wilderness-window.com/")]
    public partial class GetAvailabilityByDayResponse {
        
        private GetAvailabilityByDayResponseAvailabilityByDay availabilityByDayField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GetAvailabilityByDayResponseAvailabilityByDay AvailabilityByDay {
            get {
                return this.availabilityByDayField;
            }
            set {
                this.availabilityByDayField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.wilderness-window.com/")]
    public partial class GetAvailabilityByDayResponseAvailabilityByDay {
        
        private GetAvailabilityByDayResponseAvailabilityByDayErrorResponse[] errorResponse_ResponseField;
        
        private GetAvailabilityByDayResponseAvailabilityByDayAvailabilityByDay[] availabilityByDay_ResponseField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ErrorResponse", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public GetAvailabilityByDayResponseAvailabilityByDayErrorResponse[] ErrorResponse_Response {
            get {
                return this.errorResponse_ResponseField;
            }
            set {
                this.errorResponse_ResponseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AvailabilityByDay", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public GetAvailabilityByDayResponseAvailabilityByDayAvailabilityByDay[] AvailabilityByDay_Response {
            get {
                return this.availabilityByDay_ResponseField;
            }
            set {
                this.availabilityByDay_ResponseField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.wilderness-window.com/")]
    public partial class GetAvailabilityByDayResponseAvailabilityByDayErrorResponse {
        
        private string errorCodeField;
        
        private string errorDescriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ErrorCode {
            get {
                return this.errorCodeField;
            }
            set {
                this.errorCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ErrorDescription {
            get {
                return this.errorDescriptionField;
            }
            set {
                this.errorDescriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.wilderness-window.com/")]
    public partial class GetAvailabilityByDayResponseAvailabilityByDayAvailabilityByDay {
        
        private System.DateTime dateField;
        
        private string propertyCodeField;
        
        private GetAvailabilityByDayResponseAvailabilityByDayAvailabilityByDayRoomType roomTypeField;
        
        private long roomsAvailField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime Date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PropertyCode {
            get {
                return this.propertyCodeField;
            }
            set {
                this.propertyCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GetAvailabilityByDayResponseAvailabilityByDayAvailabilityByDayRoomType RoomType {
            get {
                return this.roomTypeField;
            }
            set {
                this.roomTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long RoomsAvail {
            get {
                return this.roomsAvailField;
            }
            set {
                this.roomsAvailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.wilderness-window.com/")]
    public enum GetAvailabilityByDayResponseAvailabilityByDayAvailabilityByDayRoomType {
        
        /// <remarks/>
        Family,
        
        /// <remarks/>
        Twin,
        
        /// <remarks/>
        _Double,
        
        /// <remarks/>
        Honeymoon,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.wilderness-window.com/")]
    public partial class GetWildernessProperties {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.wilderness-window.com/")]
    public partial class GetWildernessPropertiesResponse {
        
        private GetWildernessPropertiesResponseResponse responseField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GetWildernessPropertiesResponseResponse Response {
            get {
                return this.responseField;
            }
            set {
                this.responseField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.wilderness-window.com/")]
    public partial class GetWildernessPropertiesResponseResponse {
        
        private GetWildernessPropertiesResponseResponseErrorResponse[] errorResponse_ResponseField;
        
        private GetWildernessPropertiesResponseResponseWildernessSuppliers[] wildernessSuppliers_ResponseField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ErrorResponse", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public GetWildernessPropertiesResponseResponseErrorResponse[] ErrorResponse_Response {
            get {
                return this.errorResponse_ResponseField;
            }
            set {
                this.errorResponse_ResponseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("WildernessSuppliers", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public GetWildernessPropertiesResponseResponseWildernessSuppliers[] WildernessSuppliers_Response {
            get {
                return this.wildernessSuppliers_ResponseField;
            }
            set {
                this.wildernessSuppliers_ResponseField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.wilderness-window.com/")]
    public partial class GetWildernessPropertiesResponseResponseErrorResponse {
        
        private string errorCodeField;
        
        private string errorDescriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ErrorCode {
            get {
                return this.errorCodeField;
            }
            set {
                this.errorCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ErrorDescription {
            get {
                return this.errorDescriptionField;
            }
            set {
                this.errorDescriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.wilderness-window.com/")]
    public partial class GetWildernessPropertiesResponseResponseWildernessSuppliers {
        
        private string supplierCodeField;
        
        private string supplierNameField;
        
        private string supplierLocationField;
        
        private string countryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierCode {
            get {
                return this.supplierCodeField;
            }
            set {
                this.supplierCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierName {
            get {
                return this.supplierNameField;
            }
            set {
                this.supplierNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string SupplierLocation {
            get {
                return this.supplierLocationField;
            }
            set {
                this.supplierLocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string Country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void GetAvailabilityByDayCompletedEventHandler(object sender, GetAvailabilityByDayCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAvailabilityByDayCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAvailabilityByDayCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GetAvailabilityByDayResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GetAvailabilityByDayResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void GetWildernessPropertiesCompletedEventHandler(object sender, GetWildernessPropertiesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetWildernessPropertiesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetWildernessPropertiesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GetWildernessPropertiesResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GetWildernessPropertiesResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591