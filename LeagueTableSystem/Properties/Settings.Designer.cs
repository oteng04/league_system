﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeagueTableSystem.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Programming sample\\MyProj" +
            "ect\\LeagueTableSystem\\LeagueTableSystem\\SqlDatabase.mdf\";Integrated Security=Tru" +
            "e\r\n\r\n")]
        public string Leagues {
            get {
                return ((string)(this["Leagues"]));
            }
            set {
                this["Leagues"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Programming sample\\MyProj" +
            "ect\\LeagueTableSystem\\LeagueTableSystem\\SqlDatabase.mdf\";Integrated Security=Tru" +
            "e\r\n\r\n")]
        public string Teams {
            get {
                return ((string)(this["Teams"]));
            }
            set {
                this["Teams"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Programming sample\\MyProj" +
            "ect\\LeagueTableSystem\\LeagueTableSystem\\SqlDatabase.mdf\";Integrated Security=Tru" +
            "e\r\n\r\n")]
        public string Records {
            get {
                return ((string)(this["Records"]));
            }
            set {
                this["Records"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Programming sample\\MyProj" +
            "ect\\LeagueTableSystem\\LeagueTableSystem\\SqlDatabase.mdf\";Integrated Security=Tru" +
            "e\r\n\r\n\r\n")]
        public string Fixtures {
            get {
                return ((string)(this["Fixtures"]));
            }
            set {
                this["Fixtures"] = value;
            }
        }
    }
}
