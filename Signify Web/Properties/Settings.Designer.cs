﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankMisr.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://parabank.parasoft.com/parabank/index.htm")]
        public string Frontend_URL {
            get {
                return ((string)(this["Frontend_URL"]));
            }
            set {
                this["Frontend_URL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public double timeToWaitInMinutes {
            get {
                return ((double)(this["timeToWaitInMinutes"]));
            }
            set {
                this["timeToWaitInMinutes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>mramsis@lavad.app</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection toMails {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["toMails"]));
            }
            set {
                this["toMails"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("en")]
        public global::Config.Languages Language {
            get {
                return ((global::Config.Languages)(this["Language"]));
            }
            set {
                this["Language"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RunHeadless {
            get {
                return ((bool)(this["RunHeadless"]));
            }
            set {
                this["RunHeadless"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool FireExceptionOnBrowserConsoleErrors {
            get {
                return ((bool)(this["FireExceptionOnBrowserConsoleErrors"]));
            }
            set {
                this["FireExceptionOnBrowserConsoleErrors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("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")]
        public string SENDGRID_API_KEY {
            get {
                return ((string)(this["SENDGRID_API_KEY"]));
            }
            set {
                this["SENDGRID_API_KEY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mena.guerges@gmail.com")]
        public string FromMail {
            get {
                return ((string)(this["FromMail"]));
            }
            set {
                this["FromMail"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://parabank.parasoft.com/parabank/index.htm")]
        public string Backend_URL {
            get {
                return ((string)(this["Backend_URL"]));
            }
            set {
                this["Backend_URL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mm@mm.com")]
        public string BackendEmail {
            get {
                return ((string)(this["BackendEmail"]));
            }
            set {
                this["BackendEmail"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("123456")]
        public string BackendPassword {
            get {
                return ((string)(this["BackendPassword"]));
            }
            set {
                this["BackendPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("john")]
        public string AccountUsername {
            get {
                return ((string)(this["AccountUsername"]));
            }
            set {
                this["AccountUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("demo")]
        public string AccountPassword {
            get {
                return ((string)(this["AccountPassword"]));
            }
            set {
                this["AccountPassword"] = value;
            }
        }
    }
}
