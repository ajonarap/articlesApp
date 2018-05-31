﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Ten kod źródłowy został wygenerowany automatycznie przez Microsoft.VSDesigner, wersja 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace ClientArticleApp.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebServiceArticleAppSoap", Namespace="http://tempuri.org/")]
    public partial class WebServiceArticleApp : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback DisplayArticlesOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetEmptyArticleOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddArticleOperationCompleted;
        
        private System.Threading.SendOrPostCallback EditArticleOperationCompleted;
        
        private System.Threading.SendOrPostCallback FindArticleOperationCompleted;
        
        private System.Threading.SendOrPostCallback FindArticleToEditOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteArticleOperationCompleted;
        
        private System.Threading.SendOrPostCallback PublishedArticleOperationCompleted;
        
        private System.Threading.SendOrPostCallback ListPublishedArticlesOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebServiceArticleApp() {
            this.Url = global::ClientArticleApp.Properties.Settings.Default.ClientArticleApp_localhost_WebServiceArticleApp;
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
        public event DisplayArticlesCompletedEventHandler DisplayArticlesCompleted;
        
        /// <remarks/>
        public event GetEmptyArticleCompletedEventHandler GetEmptyArticleCompleted;
        
        /// <remarks/>
        public event AddArticleCompletedEventHandler AddArticleCompleted;
        
        /// <remarks/>
        public event EditArticleCompletedEventHandler EditArticleCompleted;
        
        /// <remarks/>
        public event FindArticleCompletedEventHandler FindArticleCompleted;
        
        /// <remarks/>
        public event FindArticleToEditCompletedEventHandler FindArticleToEditCompleted;
        
        /// <remarks/>
        public event DeleteArticleCompletedEventHandler DeleteArticleCompleted;
        
        /// <remarks/>
        public event PublishedArticleCompletedEventHandler PublishedArticleCompleted;
        
        /// <remarks/>
        public event ListPublishedArticlesCompletedEventHandler ListPublishedArticlesCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DisplayArticles", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ArticleDTO[] DisplayArticles() {
            object[] results = this.Invoke("DisplayArticles", new object[0]);
            return ((ArticleDTO[])(results[0]));
        }
        
        /// <remarks/>
        public void DisplayArticlesAsync() {
            this.DisplayArticlesAsync(null);
        }
        
        /// <remarks/>
        public void DisplayArticlesAsync(object userState) {
            if ((this.DisplayArticlesOperationCompleted == null)) {
                this.DisplayArticlesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDisplayArticlesOperationCompleted);
            }
            this.InvokeAsync("DisplayArticles", new object[0], this.DisplayArticlesOperationCompleted, userState);
        }
        
        private void OnDisplayArticlesOperationCompleted(object arg) {
            if ((this.DisplayArticlesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DisplayArticlesCompleted(this, new DisplayArticlesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetEmptyArticle", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public AddArticleDTO GetEmptyArticle() {
            object[] results = this.Invoke("GetEmptyArticle", new object[0]);
            return ((AddArticleDTO)(results[0]));
        }
        
        /// <remarks/>
        public void GetEmptyArticleAsync() {
            this.GetEmptyArticleAsync(null);
        }
        
        /// <remarks/>
        public void GetEmptyArticleAsync(object userState) {
            if ((this.GetEmptyArticleOperationCompleted == null)) {
                this.GetEmptyArticleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEmptyArticleOperationCompleted);
            }
            this.InvokeAsync("GetEmptyArticle", new object[0], this.GetEmptyArticleOperationCompleted, userState);
        }
        
        private void OnGetEmptyArticleOperationCompleted(object arg) {
            if ((this.GetEmptyArticleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetEmptyArticleCompleted(this, new GetEmptyArticleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddArticle", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddArticle(AddArticleDTO article) {
            this.Invoke("AddArticle", new object[] {
                        article});
        }
        
        /// <remarks/>
        public void AddArticleAsync(AddArticleDTO article) {
            this.AddArticleAsync(article, null);
        }
        
        /// <remarks/>
        public void AddArticleAsync(AddArticleDTO article, object userState) {
            if ((this.AddArticleOperationCompleted == null)) {
                this.AddArticleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddArticleOperationCompleted);
            }
            this.InvokeAsync("AddArticle", new object[] {
                        article}, this.AddArticleOperationCompleted, userState);
        }
        
        private void OnAddArticleOperationCompleted(object arg) {
            if ((this.AddArticleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddArticleCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/EditArticle", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public AddArticleDTO EditArticle(AddArticleDTO article) {
            object[] results = this.Invoke("EditArticle", new object[] {
                        article});
            return ((AddArticleDTO)(results[0]));
        }
        
        /// <remarks/>
        public void EditArticleAsync(AddArticleDTO article) {
            this.EditArticleAsync(article, null);
        }
        
        /// <remarks/>
        public void EditArticleAsync(AddArticleDTO article, object userState) {
            if ((this.EditArticleOperationCompleted == null)) {
                this.EditArticleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEditArticleOperationCompleted);
            }
            this.InvokeAsync("EditArticle", new object[] {
                        article}, this.EditArticleOperationCompleted, userState);
        }
        
        private void OnEditArticleOperationCompleted(object arg) {
            if ((this.EditArticleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EditArticleCompleted(this, new EditArticleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FindArticle", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ArticleDTO FindArticle([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idArticle) {
            object[] results = this.Invoke("FindArticle", new object[] {
                        idArticle});
            return ((ArticleDTO)(results[0]));
        }
        
        /// <remarks/>
        public void FindArticleAsync(System.Nullable<int> idArticle) {
            this.FindArticleAsync(idArticle, null);
        }
        
        /// <remarks/>
        public void FindArticleAsync(System.Nullable<int> idArticle, object userState) {
            if ((this.FindArticleOperationCompleted == null)) {
                this.FindArticleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindArticleOperationCompleted);
            }
            this.InvokeAsync("FindArticle", new object[] {
                        idArticle}, this.FindArticleOperationCompleted, userState);
        }
        
        private void OnFindArticleOperationCompleted(object arg) {
            if ((this.FindArticleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FindArticleCompleted(this, new FindArticleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FindArticleToEdit", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public AddArticleDTO FindArticleToEdit([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idArticle) {
            object[] results = this.Invoke("FindArticleToEdit", new object[] {
                        idArticle});
            return ((AddArticleDTO)(results[0]));
        }
        
        /// <remarks/>
        public void FindArticleToEditAsync(System.Nullable<int> idArticle) {
            this.FindArticleToEditAsync(idArticle, null);
        }
        
        /// <remarks/>
        public void FindArticleToEditAsync(System.Nullable<int> idArticle, object userState) {
            if ((this.FindArticleToEditOperationCompleted == null)) {
                this.FindArticleToEditOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindArticleToEditOperationCompleted);
            }
            this.InvokeAsync("FindArticleToEdit", new object[] {
                        idArticle}, this.FindArticleToEditOperationCompleted, userState);
        }
        
        private void OnFindArticleToEditOperationCompleted(object arg) {
            if ((this.FindArticleToEditCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FindArticleToEditCompleted(this, new FindArticleToEditCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteArticle", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteArticle(int id) {
            this.Invoke("DeleteArticle", new object[] {
                        id});
        }
        
        /// <remarks/>
        public void DeleteArticleAsync(int id) {
            this.DeleteArticleAsync(id, null);
        }
        
        /// <remarks/>
        public void DeleteArticleAsync(int id, object userState) {
            if ((this.DeleteArticleOperationCompleted == null)) {
                this.DeleteArticleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteArticleOperationCompleted);
            }
            this.InvokeAsync("DeleteArticle", new object[] {
                        id}, this.DeleteArticleOperationCompleted, userState);
        }
        
        private void OnDeleteArticleOperationCompleted(object arg) {
            if ((this.DeleteArticleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteArticleCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/PublishedArticle", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void PublishedArticle(int id) {
            this.Invoke("PublishedArticle", new object[] {
                        id});
        }
        
        /// <remarks/>
        public void PublishedArticleAsync(int id) {
            this.PublishedArticleAsync(id, null);
        }
        
        /// <remarks/>
        public void PublishedArticleAsync(int id, object userState) {
            if ((this.PublishedArticleOperationCompleted == null)) {
                this.PublishedArticleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPublishedArticleOperationCompleted);
            }
            this.InvokeAsync("PublishedArticle", new object[] {
                        id}, this.PublishedArticleOperationCompleted, userState);
        }
        
        private void OnPublishedArticleOperationCompleted(object arg) {
            if ((this.PublishedArticleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PublishedArticleCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ListPublishedArticles", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ArticleDTO[] ListPublishedArticles() {
            object[] results = this.Invoke("ListPublishedArticles", new object[0]);
            return ((ArticleDTO[])(results[0]));
        }
        
        /// <remarks/>
        public void ListPublishedArticlesAsync() {
            this.ListPublishedArticlesAsync(null);
        }
        
        /// <remarks/>
        public void ListPublishedArticlesAsync(object userState) {
            if ((this.ListPublishedArticlesOperationCompleted == null)) {
                this.ListPublishedArticlesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListPublishedArticlesOperationCompleted);
            }
            this.InvokeAsync("ListPublishedArticles", new object[0], this.ListPublishedArticlesOperationCompleted, userState);
        }
        
        private void OnListPublishedArticlesOperationCompleted(object arg) {
            if ((this.ListPublishedArticlesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListPublishedArticlesCompleted(this, new ListPublishedArticlesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ArticleDTO {
        
        private int articleIdField;
        
        private string titleField;
        
        private string leadField;
        
        private string contentField;
        
        private int categoryIdField;
        
        private ArticleTagDTO[] tagsField;
        
        private bool publishedField;
        
        /// <remarks/>
        public int ArticleId {
            get {
                return this.articleIdField;
            }
            set {
                this.articleIdField = value;
            }
        }
        
        /// <remarks/>
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string Lead {
            get {
                return this.leadField;
            }
            set {
                this.leadField = value;
            }
        }
        
        /// <remarks/>
        public string Content {
            get {
                return this.contentField;
            }
            set {
                this.contentField = value;
            }
        }
        
        /// <remarks/>
        public int CategoryId {
            get {
                return this.categoryIdField;
            }
            set {
                this.categoryIdField = value;
            }
        }
        
        /// <remarks/>
        public ArticleTagDTO[] Tags {
            get {
                return this.tagsField;
            }
            set {
                this.tagsField = value;
            }
        }
        
        /// <remarks/>
        public bool Published {
            get {
                return this.publishedField;
            }
            set {
                this.publishedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ArticleTagDTO {
        
        private int tagIdField;
        
        private string nameField;
        
        /// <remarks/>
        public int TagId {
            get {
                return this.tagIdField;
            }
            set {
                this.tagIdField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class AddArticleTagDTO {
        
        private int tagIdField;
        
        private string nameField;
        
        private bool selectedField;
        
        /// <remarks/>
        public int TagId {
            get {
                return this.tagIdField;
            }
            set {
                this.tagIdField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public bool Selected {
            get {
                return this.selectedField;
            }
            set {
                this.selectedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class AddArticleDTO {
        
        private int articleIdField;
        
        private string titleField;
        
        private string leadField;
        
        private string contentField;
        
        private int categoryIdField;
        
        private AddArticleTagDTO[] tagsField;
        
        private bool publishedField;
        
        /// <remarks/>
        public int ArticleId {
            get {
                return this.articleIdField;
            }
            set {
                this.articleIdField = value;
            }
        }
        
        /// <remarks/>
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string Lead {
            get {
                return this.leadField;
            }
            set {
                this.leadField = value;
            }
        }
        
        /// <remarks/>
        public string Content {
            get {
                return this.contentField;
            }
            set {
                this.contentField = value;
            }
        }
        
        /// <remarks/>
        public int CategoryId {
            get {
                return this.categoryIdField;
            }
            set {
                this.categoryIdField = value;
            }
        }
        
        /// <remarks/>
        public AddArticleTagDTO[] Tags {
            get {
                return this.tagsField;
            }
            set {
                this.tagsField = value;
            }
        }
        
        /// <remarks/>
        public bool Published {
            get {
                return this.publishedField;
            }
            set {
                this.publishedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void DisplayArticlesCompletedEventHandler(object sender, DisplayArticlesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DisplayArticlesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DisplayArticlesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ArticleDTO[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ArticleDTO[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetEmptyArticleCompletedEventHandler(object sender, GetEmptyArticleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetEmptyArticleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetEmptyArticleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public AddArticleDTO Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((AddArticleDTO)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void AddArticleCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void EditArticleCompletedEventHandler(object sender, EditArticleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EditArticleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EditArticleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public AddArticleDTO Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((AddArticleDTO)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void FindArticleCompletedEventHandler(object sender, FindArticleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FindArticleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FindArticleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ArticleDTO Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ArticleDTO)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void FindArticleToEditCompletedEventHandler(object sender, FindArticleToEditCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FindArticleToEditCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FindArticleToEditCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public AddArticleDTO Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((AddArticleDTO)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void DeleteArticleCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void PublishedArticleCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void ListPublishedArticlesCompletedEventHandler(object sender, ListPublishedArticlesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListPublishedArticlesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ListPublishedArticlesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ArticleDTO[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ArticleDTO[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591