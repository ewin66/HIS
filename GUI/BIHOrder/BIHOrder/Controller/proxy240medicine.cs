﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// 此源代码由 wsdl 自动生成, Version=4.0.30319.33440。
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="MedServiceSoap", Namespace="http://www.wecare.cn/")]
public partial class MedService : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback FireBirdOperationCompleted;
    
    private System.Threading.SendOrPostCallback RecipeServcieOperationCompleted;
    
    /// <remarks/>
    public MedService() {
        this.Url = "http://10.37.0.240:9010/MedService.asmx";
    }
    
    /// <remarks/>
    public event FireBirdCompletedEventHandler FireBirdCompleted;
    
    /// <remarks/>
    public event RecipeServcieCompletedEventHandler RecipeServcieCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.wecare.cn/med", RequestNamespace="http://www.wecare.cn/", ResponseNamespace="http://www.wecare.cn/", Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public string FireBird(string request) {
        object[] results = this.Invoke("FireBird", new object[] {
                    request});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginFireBird(string request, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("FireBird", new object[] {
                    request}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndFireBird(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void FireBirdAsync(string request) {
        this.FireBirdAsync(request, null);
    }
    
    /// <remarks/>
    public void FireBirdAsync(string request, object userState) {
        if ((this.FireBirdOperationCompleted == null)) {
            this.FireBirdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFireBirdOperationCompleted);
        }
        this.InvokeAsync("FireBird", new object[] {
                    request}, this.FireBirdOperationCompleted, userState);
    }
    
    private void OnFireBirdOperationCompleted(object arg) {
        if ((this.FireBirdCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.FireBirdCompleted(this, new FireBirdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.wecare.cn/med", RequestNamespace="http://www.wecare.cn/", ResponseNamespace="http://www.wecare.cn/", Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public string RecipeServcie(string request) {
        object[] results = this.Invoke("RecipeServcie", new object[] {
                    request});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginRecipeServcie(string request, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("RecipeServcie", new object[] {
                    request}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndRecipeServcie(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void RecipeServcieAsync(string request) {
        this.RecipeServcieAsync(request, null);
    }
    
    /// <remarks/>
    public void RecipeServcieAsync(string request, object userState) {
        if ((this.RecipeServcieOperationCompleted == null)) {
            this.RecipeServcieOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRecipeServcieOperationCompleted);
        }
        this.InvokeAsync("RecipeServcie", new object[] {
                    request}, this.RecipeServcieOperationCompleted, userState);
    }
    
    private void OnRecipeServcieOperationCompleted(object arg) {
        if ((this.RecipeServcieCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RecipeServcieCompleted(this, new RecipeServcieCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
public delegate void FireBirdCompletedEventHandler(object sender, FireBirdCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class FireBirdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal FireBirdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public string Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
public delegate void RecipeServcieCompletedEventHandler(object sender, RecipeServcieCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class RecipeServcieCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RecipeServcieCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public string Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}