﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManualPatcher.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ManualPatcher.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        public static byte[] NXPatcher_EXE {
            get {
                object obj = ResourceManager.GetObject("NXPatcher_EXE", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [fileassociations]
        ///patch = read
        ///exe = split
        ///wz = version
        ///
        ///[read]
        ///usefastpatchtype = 0
        ///outputfolder = Patcher
        ///ifbackup = 1
        ///backupdir = v{nxpatcher:version}
        ///ifdeltxt = 0
        ///deltxt = delfiles.txt
        ///ifautoapply = 1
        ///
        ///[hijack]
        ///usefastpatchtype = {read:usefastpatchtype}
        ///outputfolder = {read:outputfolder}
        ///ifbackup = {read:ifbackupfiles}
        ///backupdir = {read:backupdir}
        ///ifdeltxt = {read:ifdeltxt}
        ///deltxt = {read:deltxt}
        ///ifautoapply = {read:ifautoapply}
        ///
        ///[split]
        ///ifoutputbase = 1
        ///outputbase = {nxpatcher [rest of string was truncated]&quot;;.
        /// </summary>
        public static string NXPatcher_INI {
            get {
                return ResourceManager.GetString("NXPatcher_INI", resourceCulture);
            }
        }
    }
}