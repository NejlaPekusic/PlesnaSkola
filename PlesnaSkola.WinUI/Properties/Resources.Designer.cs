﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlesnaSkola.WinUI.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PlesnaSkola.WinUI.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap default_pic {
            get {
                object obj = ResourceManager.GetObject("default_pic", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap flash_logo {
            get {
                object obj = ResourceManager.GetObject("flash logo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email adresa nije u ispravnom formatu..
        /// </summary>
        internal static string Validation_EmailInvalid {
            get {
                return ResourceManager.GetString("Validation_EmailInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unos mora biti u numeričkom obliku..
        /// </summary>
        internal static string Validation_Number {
            get {
                return ResourceManager.GetString("Validation_Number", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Broj pasoša nije u ispravnom formatu (primjer: A1234567).
        /// </summary>
        internal static string Validation_PassportInvalid {
            get {
                return ResourceManager.GetString("Validation_PassportInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lozinke se moraju podudarati..
        /// </summary>
        internal static string Validation_Password {
            get {
                return ResourceManager.GetString("Validation_Password", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ovo polje je obavezno..
        /// </summary>
        internal static string Validation_Required {
            get {
                return ResourceManager.GetString("Validation_Required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dijete nema dovoljno godina za upis..
        /// </summary>
        internal static string Validation_UzrastClana {
            get {
                return ResourceManager.GetString("Validation_UzrastClana", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uzrast grupe nije odgovarajući..
        /// </summary>
        internal static string Validation_UzrastGrupe {
            get {
                return ResourceManager.GetString("Validation_UzrastGrupe", resourceCulture);
            }
        }
    }
}
