﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.586
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GsmStat.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("12345")]
        public string LotusPassword {
            get {
                return ((string)(this["LotusPassword"]));
            }
            set {
                this["LotusPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("RUnotes/РУ/АОНК")]
        public string LotusServer {
            get {
                return ((string)(this["LotusServer"]));
            }
            set {
                this["LotusServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mail\\biskubkn.nsf")]
        public string LotusDatabase {
            get {
                return ((string)(this["LotusDatabase"]));
            }
            set {
                this["LotusDatabase"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Дышлюк А.Н./РУ/АОНК")]
        public string LotusSendTo {
            get {
                return ((string)(this["LotusSendTo"]));
            }
            set {
                this["LotusSendTo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Бискуб К.Н./РУ/АОНК")]
        public string LotusCopyTo {
            get {
                return ((string)(this["LotusCopyTo"]));
            }
            set {
                this["LotusCopyTo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Отдел АСУ. Рассылка автоматических отчетов.")]
        public string LotusSubject {
            get {
                return ((string)(this["LotusSubject"]));
            }
            set {
                this["LotusSubject"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("d:\\Работа\\Кайерканский\\!МТБ\\Отчеты\\")]
        public string LotusDir {
            get {
                return ((string)(this["LotusDir"]));
            }
            set {
                this["LotusDir"] = value;
            }
        }
    }
}
