﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Frontendowa_aplikacja.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/Serwer")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ile_wierszy", ReplyAction="http://tempuri.org/IService1/ile_wierszyResponse")]
        int ile_wierszy();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ile_wierszy", ReplyAction="http://tempuri.org/IService1/ile_wierszyResponse")]
        System.Threading.Tasks.Task<int> ile_wierszyAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/wczytaj_id", ReplyAction="http://tempuri.org/IService1/wczytaj_idResponse")]
        int wczytaj_id(int var);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/wczytaj_id", ReplyAction="http://tempuri.org/IService1/wczytaj_idResponse")]
        System.Threading.Tasks.Task<int> wczytaj_idAsync(int var);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/zwroc_imie", ReplyAction="http://tempuri.org/IService1/zwroc_imieResponse")]
        string zwroc_imie(int var);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/zwroc_imie", ReplyAction="http://tempuri.org/IService1/zwroc_imieResponse")]
        System.Threading.Tasks.Task<string> zwroc_imieAsync(int var);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/zwroc_rase", ReplyAction="http://tempuri.org/IService1/zwroc_raseResponse")]
        string zwroc_rase(int var);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/zwroc_rase", ReplyAction="http://tempuri.org/IService1/zwroc_raseResponse")]
        System.Threading.Tasks.Task<string> zwroc_raseAsync(int var);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/zwroc_wiek", ReplyAction="http://tempuri.org/IService1/zwroc_wiekResponse")]
        System.Nullable<int> zwroc_wiek(int var);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/zwroc_wiek", ReplyAction="http://tempuri.org/IService1/zwroc_wiekResponse")]
        System.Threading.Tasks.Task<System.Nullable<int>> zwroc_wiekAsync(int var);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/zwroc_kontakt", ReplyAction="http://tempuri.org/IService1/zwroc_kontaktResponse")]
        string zwroc_kontakt(int var);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/zwroc_kontakt", ReplyAction="http://tempuri.org/IService1/zwroc_kontaktResponse")]
        System.Threading.Tasks.Task<string> zwroc_kontaktAsync(int var);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/zwroc_zdj", ReplyAction="http://tempuri.org/IService1/zwroc_zdjResponse")]
        string zwroc_zdj(int var);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/zwroc_zdj", ReplyAction="http://tempuri.org/IService1/zwroc_zdjResponse")]
        System.Threading.Tasks.Task<string> zwroc_zdjAsync(int var);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        Frontendowa_aplikacja.ServiceReference1.CompositeType GetDataUsingDataContract(Frontendowa_aplikacja.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Frontendowa_aplikacja.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(Frontendowa_aplikacja.ServiceReference1.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Frontendowa_aplikacja.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Frontendowa_aplikacja.ServiceReference1.IService1>, Frontendowa_aplikacja.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int ile_wierszy() {
            return base.Channel.ile_wierszy();
        }
        
        public System.Threading.Tasks.Task<int> ile_wierszyAsync() {
            return base.Channel.ile_wierszyAsync();
        }
        
        public int wczytaj_id(int var) {
            return base.Channel.wczytaj_id(var);
        }
        
        public System.Threading.Tasks.Task<int> wczytaj_idAsync(int var) {
            return base.Channel.wczytaj_idAsync(var);
        }
        
        public string zwroc_imie(int var) {
            return base.Channel.zwroc_imie(var);
        }
        
        public System.Threading.Tasks.Task<string> zwroc_imieAsync(int var) {
            return base.Channel.zwroc_imieAsync(var);
        }
        
        public string zwroc_rase(int var) {
            return base.Channel.zwroc_rase(var);
        }
        
        public System.Threading.Tasks.Task<string> zwroc_raseAsync(int var) {
            return base.Channel.zwroc_raseAsync(var);
        }
        
        public System.Nullable<int> zwroc_wiek(int var) {
            return base.Channel.zwroc_wiek(var);
        }
        
        public System.Threading.Tasks.Task<System.Nullable<int>> zwroc_wiekAsync(int var) {
            return base.Channel.zwroc_wiekAsync(var);
        }
        
        public string zwroc_kontakt(int var) {
            return base.Channel.zwroc_kontakt(var);
        }
        
        public System.Threading.Tasks.Task<string> zwroc_kontaktAsync(int var) {
            return base.Channel.zwroc_kontaktAsync(var);
        }
        
        public string zwroc_zdj(int var) {
            return base.Channel.zwroc_zdj(var);
        }
        
        public System.Threading.Tasks.Task<string> zwroc_zdjAsync(int var) {
            return base.Channel.zwroc_zdjAsync(var);
        }
        
        public Frontendowa_aplikacja.ServiceReference1.CompositeType GetDataUsingDataContract(Frontendowa_aplikacja.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Frontendowa_aplikacja.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(Frontendowa_aplikacja.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
