﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Resources.ManagementGroups.Common {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.Resources.ManagementGroups.Common.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to Are you sure you want to create a new management group named &quot;{0}&quot;?.
        /// </summary>
        internal static string NewManagementGroupShouldProcessAction
        {
            get
            {
                return ResourceManager.GetString("NewManagementGroupShouldProcessAction", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Creating management group &quot;{0}&quot;.
        /// </summary>
        internal static string NewManagementGroupShouldProcessTarget
        {
            get
            {
                return ResourceManager.GetString("NewManagementGroupShouldProcessTarget", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to add subscription {0} to group &quot;{1}&quot;?.
        /// </summary>
        internal static string NewManagementGroupSubShouldProcessAction
        {
            get
            {
                return ResourceManager.GetString("NewManagementGroupSubShouldProcessAction", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Adding subscription {0} to group &quot;{1}&quot;.
        /// </summary>
        internal static string NewManagementGroupSubShouldProcessTarget
        {
            get
            {
                return ResourceManager.GetString("NewManagementGroupSubShouldProcessTarget", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Removing management group &quot;{0}&quot;.
        /// </summary>
        internal static string RemoveManagementGroupShouldProcessAction
        {
            get
            {
                return ResourceManager.GetString("RemoveManagementGroupShouldProcessAction", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove management group &quot;{0}&quot;?.
        /// </summary>
        internal static string RemoveManagementGroupShouldProcessTarget
        {
            get
            {
                return ResourceManager.GetString("RemoveManagementGroupShouldProcessTarget", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Removing subscription {0} from group &quot;{1}&quot;.
        /// </summary>
        internal static string RemoveManagementGroupSubShouldProcessAction
        {
            get
            {
                return ResourceManager.GetString("RemoveManagementGroupSubShouldProcessAction", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove subscription {0} from group &quot;{1}&quot;?.
        /// </summary>
        internal static string RemoveManagementGroupSubShouldProcessTarget
        {
            get
            {
                return ResourceManager.GetString("RemoveManagementGroupSubShouldProcessTarget", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Updating management group &quot;{0}&quot;.
        /// </summary>
        internal static string UpdateManagementGroupShouldProcessAction
        {
            get
            {
                return ResourceManager.GetString("UpdateManagementGroupShouldProcessAction", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to update management group &quot;{0}&quot;?.
        /// </summary>
        internal static string UpdateManagementGroupShouldProcessTarget
        {
            get
            {
                return ResourceManager.GetString("UpdateManagementGroupShouldProcessTarget", resourceCulture);
            }
        }

    }
}
