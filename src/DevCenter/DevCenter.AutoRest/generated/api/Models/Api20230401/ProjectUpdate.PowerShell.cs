// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401
{
    using Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.PowerShell;

    /// <summary>
    /// The project properties for partial update. Properties not provided in the update request will not be changed.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ProjectUpdateTypeConverter))]
    public partial class ProjectUpdate
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ProjectUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdate" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ProjectUpdate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ProjectUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdate" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ProjectUpdate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ProjectUpdate" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ProjectUpdate" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdate FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ProjectUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ProjectUpdate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdateInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdateProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdateInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ProjectUpdatePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITrackedResourceUpdateInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITrackedResourceUpdateInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITrackedResourceUpdateInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITrackedResourceUpdateInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("DevCenterId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdateInternal)this).DevCenterId = (string) content.GetValueForProperty("DevCenterId",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdateInternal)this).DevCenterId, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdateInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdateInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("MaxDevBoxesPerUser"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdateInternal)this).MaxDevBoxesPerUser = (int?) content.GetValueForProperty("MaxDevBoxesPerUser",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdateInternal)this).MaxDevBoxesPerUser, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ProjectUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ProjectUpdate(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdateInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdateProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdateInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ProjectUpdatePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITrackedResourceUpdateInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITrackedResourceUpdateInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITrackedResourceUpdateInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITrackedResourceUpdateInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("DevCenterId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdateInternal)this).DevCenterId = (string) content.GetValueForProperty("DevCenterId",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdateInternal)this).DevCenterId, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdateInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdateInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("MaxDevBoxesPerUser"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdateInternal)this).MaxDevBoxesPerUser = (int?) content.GetValueForProperty("MaxDevBoxesPerUser",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectUpdateInternal)this).MaxDevBoxesPerUser, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The project properties for partial update. Properties not provided in the update request will not be changed.
    [System.ComponentModel.TypeConverter(typeof(ProjectUpdateTypeConverter))]
    public partial interface IProjectUpdate

    {

    }
}