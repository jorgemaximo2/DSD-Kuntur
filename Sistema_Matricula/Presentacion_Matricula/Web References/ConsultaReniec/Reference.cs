﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.261
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.261.
// 
#pragma warning disable 1591

namespace Presentacion_Matricula.ConsultaReniec {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="PersonaServiceImplServiceSoapBinding", Namespace="http://ws.service.dsd.upc.edu.pe/")]
    public partial class PersonaServiceImplService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback obtenerPersonaDNIOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public PersonaServiceImplService() {
            this.Url = global::Presentacion_Matricula.Properties.Settings.Default.Presentacion_Matricula_ConsultaReniec_PersonaServiceImplService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
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
        public event obtenerPersonaDNICompletedEventHandler obtenerPersonaDNICompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://ws.service.dsd.upc.edu.pe/", ResponseNamespace="http://ws.service.dsd.upc.edu.pe/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public persona obtenerPersonaDNI([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string dni) {
            object[] results = this.Invoke("obtenerPersonaDNI", new object[] {
                        dni});
            return ((persona)(results[0]));
        }
        
        /// <remarks/>
        public void obtenerPersonaDNIAsync(string dni) {
            this.obtenerPersonaDNIAsync(dni, null);
        }
        
        /// <remarks/>
        public void obtenerPersonaDNIAsync(string dni, object userState) {
            if ((this.obtenerPersonaDNIOperationCompleted == null)) {
                this.obtenerPersonaDNIOperationCompleted = new System.Threading.SendOrPostCallback(this.OnobtenerPersonaDNIOperationCompleted);
            }
            this.InvokeAsync("obtenerPersonaDNI", new object[] {
                        dni}, this.obtenerPersonaDNIOperationCompleted, userState);
        }
        
        private void OnobtenerPersonaDNIOperationCompleted(object arg) {
            if ((this.obtenerPersonaDNICompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.obtenerPersonaDNICompleted(this, new obtenerPersonaDNICompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.service.dsd.upc.edu.pe/")]
    public partial class persona {
        
        private string apellidoMaternoField;
        
        private string apellidoPaternoField;
        
        private string dniField;
        
        private string fechaNacimientoField;
        
        private string nombresField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string apellidoMaterno {
            get {
                return this.apellidoMaternoField;
            }
            set {
                this.apellidoMaternoField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string apellidoPaterno {
            get {
                return this.apellidoPaternoField;
            }
            set {
                this.apellidoPaternoField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string dni {
            get {
                return this.dniField;
            }
            set {
                this.dniField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fechaNacimiento {
            get {
                return this.fechaNacimientoField;
            }
            set {
                this.fechaNacimientoField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nombres {
            get {
                return this.nombresField;
            }
            set {
                this.nombresField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void obtenerPersonaDNICompletedEventHandler(object sender, obtenerPersonaDNICompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class obtenerPersonaDNICompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal obtenerPersonaDNICompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public persona Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((persona)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591