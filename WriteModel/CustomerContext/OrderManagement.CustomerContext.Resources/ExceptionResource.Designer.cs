﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderManagement.CustomerContext.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ExceptionResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExceptionResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OrderManagement.CustomerContext.Resources.ExceptionResource", typeof(ExceptionResource).Assembly);
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
        ///   Looks up a localized string similar to Customer IS Not Exist..
        /// </summary>
        public static string CustomerISNotExist {
            get {
                return ResourceManager.GetString("CustomerISNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Customer Is Required..
        /// </summary>
        public static string CustomerIsRequired {
            get {
                return ResourceManager.GetString("CustomerIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to National code is Duplicated..
        /// </summary>
        public static string DuplicatedNationalCode {
            get {
                return ResourceManager.GetString("DuplicatedNationalCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to First name is required..
        /// </summary>
        public static string FirstNameIsRequired {
            get {
                return ResourceManager.GetString("FirstNameIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Last name is required..
        /// </summary>
        public static string LastNameIsRequired {
            get {
                return ResourceManager.GetString("LastNameIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to National code is required..
        /// </summary>
        public static string NationalCodeIsRequired {
            get {
                return ResourceManager.GetString("NationalCodeIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to National code length should be ten characters..
        /// </summary>
        public static string NationalCodeLengthShouldBeTenCharacters {
            get {
                return ResourceManager.GetString("NationalCodeLengthShouldBeTenCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to National code should be digit characters..
        /// </summary>
        public static string NationalCodeShouldBeDigitCharacters {
            get {
                return ResourceManager.GetString("NationalCodeShouldBeDigitCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Order Date Is Not Valid..
        /// </summary>
        public static string OrderDateIsNotValid {
            get {
                return ResourceManager.GetString("OrderDateIsNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Order Should Have At Least One Item.
        /// </summary>
        public static string OrderShouldHaveAtLeastOneItem {
            get {
                return ResourceManager.GetString("OrderShouldHaveAtLeastOneItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable To Add Null Order To Customer..
        /// </summary>
        public static string UnableToAddNullOrderToCustomer {
            get {
                return ResourceManager.GetString("UnableToAddNullOrderToCustomer", resourceCulture);
            }
        }
    }
}
