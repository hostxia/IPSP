﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPSP.Win.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseCaseDto", Namespace="http://schemas.datacontract.org/2004/07/IPSP.Case.Dto")]
    [System.SerializableAttribute()]
    public partial class BaseCaseDto : IPSP.Win.ServiceReference1.EntityDto {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IPSP.Win.ServiceReference1.ClientDto TheClientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int n_ClientIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string s_CaseNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string s_CaseSerialField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public IPSP.Win.ServiceReference1.ClientDto TheClient {
            get {
                return this.TheClientField;
            }
            set {
                if ((object.ReferenceEquals(this.TheClientField, value) != true)) {
                    this.TheClientField = value;
                    this.RaisePropertyChanged("TheClient");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int n_ClientID {
            get {
                return this.n_ClientIDField;
            }
            set {
                if ((this.n_ClientIDField.Equals(value) != true)) {
                    this.n_ClientIDField = value;
                    this.RaisePropertyChanged("n_ClientID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string s_CaseName {
            get {
                return this.s_CaseNameField;
            }
            set {
                if ((object.ReferenceEquals(this.s_CaseNameField, value) != true)) {
                    this.s_CaseNameField = value;
                    this.RaisePropertyChanged("s_CaseName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string s_CaseSerial {
            get {
                return this.s_CaseSerialField;
            }
            set {
                if ((object.ReferenceEquals(this.s_CaseSerialField, value) != true)) {
                    this.s_CaseSerialField = value;
                    this.RaisePropertyChanged("s_CaseSerial");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityDtoOfint", Namespace="http://schemas.datacontract.org/2004/07/Abp.Application.Services.Dto")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(IPSP.Win.ServiceReference1.EntityDto))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(IPSP.Win.ServiceReference1.ClientDto))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(IPSP.Win.ServiceReference1.BaseCaseDto))]
    public partial class EntityDtoOfint : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int Idk__BackingFieldField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Id>k__BackingField", IsRequired=true)]
        public int Idk__BackingField {
            get {
                return this.Idk__BackingFieldField;
            }
            set {
                if ((this.Idk__BackingFieldField.Equals(value) != true)) {
                    this.Idk__BackingFieldField = value;
                    this.RaisePropertyChanged("Idk__BackingField");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityDto", Namespace="http://schemas.datacontract.org/2004/07/Abp.Application.Services.Dto")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(IPSP.Win.ServiceReference1.ClientDto))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(IPSP.Win.ServiceReference1.BaseCaseDto))]
    public partial class EntityDto : IPSP.Win.ServiceReference1.EntityDtoOfint {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClientDto", Namespace="http://schemas.datacontract.org/2004/07/IPSP.Client.Dto")]
    [System.SerializableAttribute()]
    public partial class ClientDto : IPSP.Win.ServiceReference1.EntityDto {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IPSP.Win.ServiceReference1.BaseCaseDto[] BaseCasesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string s_NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public IPSP.Win.ServiceReference1.BaseCaseDto[] BaseCases {
            get {
                return this.BaseCasesField;
            }
            set {
                if ((object.ReferenceEquals(this.BaseCasesField, value) != true)) {
                    this.BaseCasesField = value;
                    this.RaisePropertyChanged("BaseCases");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string s_Name {
            get {
                return this.s_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.s_NameField, value) != true)) {
                    this.s_NameField = value;
                    this.RaisePropertyChanged("s_Name");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IBaseCaseService")]
    public interface IBaseCaseService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBaseCaseService/GetBaseCaseByClient", ReplyAction="http://tempuri.org/IBaseCaseService/GetBaseCaseByClientResponse")]
        IPSP.Win.ServiceReference1.BaseCaseDto[] GetBaseCaseByClient(int nClientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBaseCaseService/GetBaseCaseByClient", ReplyAction="http://tempuri.org/IBaseCaseService/GetBaseCaseByClientResponse")]
        System.Threading.Tasks.Task<IPSP.Win.ServiceReference1.BaseCaseDto[]> GetBaseCaseByClientAsync(int nClientId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBaseCaseServiceChannel : IPSP.Win.ServiceReference1.IBaseCaseService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BaseCaseServiceClient : System.ServiceModel.ClientBase<IPSP.Win.ServiceReference1.IBaseCaseService>, IPSP.Win.ServiceReference1.IBaseCaseService {
        
        public BaseCaseServiceClient() {
        }
        
        public BaseCaseServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BaseCaseServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BaseCaseServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BaseCaseServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public IPSP.Win.ServiceReference1.BaseCaseDto[] GetBaseCaseByClient(int nClientId) {
            return base.Channel.GetBaseCaseByClient(nClientId);
        }
        
        public System.Threading.Tasks.Task<IPSP.Win.ServiceReference1.BaseCaseDto[]> GetBaseCaseByClientAsync(int nClientId) {
            return base.Channel.GetBaseCaseByClientAsync(nClientId);
        }
    }
}
