﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dmarc.Admin.Api.Dao.GroupUser {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class GroupUserDaoResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal GroupUserDaoResources() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Dmarc.Admin.Api.Dao.GroupUser.GroupUserDaoResources", typeof(GroupUserDaoResources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
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
        ///    Looks up a localized string similar to DELETE FROM group_user_mapping 
        ///WHERE (group_id, user_id) 
        ///IN (.
        /// </summary>
        public static string DeleteGroupUser {
            get {
                return ResourceManager.GetString("DeleteGroupUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to (@a{0},@b{0}).
        /// </summary>
        public static string DeleteGroupUserValueFormatString {
            get {
                return ResourceManager.GetString("DeleteGroupUserValueFormatString", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to INSERT INTO group_user_mapping
        ///(group_id,
        ///user_id)
        ///VALUES.
        /// </summary>
        public static string InsertGroupUser {
            get {
                return ResourceManager.GetString("InsertGroupUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to (@a{0},@b{0}).
        /// </summary>
        public static string InsertGroupUserValueFormatString {
            get {
                return ResourceManager.GetString("InsertGroupUserValueFormatString", resourceCulture);
            }
        }
    }
}
