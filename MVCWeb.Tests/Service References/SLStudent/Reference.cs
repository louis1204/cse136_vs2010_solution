﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCWeb.Tests.SLStudent {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SLStudent.ISLStudent")]
    public interface ISLStudent {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISLStudent/GetStudent", ReplyAction="http://tempuri.org/ISLStudent/GetStudentResponse")]
        MVCWeb.SLStudent.Student GetStudent(string id, ref string[] errors);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISLStudent/InsertStudent", ReplyAction="http://tempuri.org/ISLStudent/InsertStudentResponse")]
        void InsertStudent(MVCWeb.SLStudent.Student student, ref string[] errors);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISLStudent/DeleteStudent", ReplyAction="http://tempuri.org/ISLStudent/DeleteStudentResponse")]
        void DeleteStudent(string id, ref string[] errors);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISLStudent/GetStudentList", ReplyAction="http://tempuri.org/ISLStudent/GetStudentListResponse")]
        MVCWeb.SLStudent.Student[] GetStudentList(ref string[] errors);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISLStudentChannel : MVCWeb.Tests.SLStudent.ISLStudent, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SLStudentClient : System.ServiceModel.ClientBase<MVCWeb.Tests.SLStudent.ISLStudent>, MVCWeb.Tests.SLStudent.ISLStudent {
        
        public SLStudentClient() {
        }
        
        public SLStudentClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SLStudentClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SLStudentClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SLStudentClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MVCWeb.SLStudent.Student GetStudent(string id, ref string[] errors) {
            return base.Channel.GetStudent(id, ref errors);
        }
        
        public void InsertStudent(MVCWeb.SLStudent.Student student, ref string[] errors) {
            base.Channel.InsertStudent(student, ref errors);
        }
        
        public void DeleteStudent(string id, ref string[] errors) {
            base.Channel.DeleteStudent(id, ref errors);
        }
        
        public MVCWeb.SLStudent.Student[] GetStudentList(ref string[] errors) {
            return base.Channel.GetStudentList(ref errors);
        }
    }
}