// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Extensions;

    /// <summary>Multi subnet ip configuration for an availability group listener.</summary>
    public partial class MultiSubnetIPConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IMultiSubnetIPConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IMultiSubnetIPConfigurationInternal
    {

        /// <summary>Internal Acessors for PrivateIPAddress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IPrivateIPAddress Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IMultiSubnetIPConfigurationInternal.PrivateIPAddress { get => (this._privateIPAddress = this._privateIPAddress ?? new Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.PrivateIPAddress()); set { {_privateIPAddress = value;} } }

        /// <summary>Backing field for <see cref="PrivateIPAddress" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IPrivateIPAddress _privateIPAddress;

        /// <summary>Private IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IPrivateIPAddress PrivateIPAddress { get => (this._privateIPAddress = this._privateIPAddress ?? new Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.PrivateIPAddress()); set => this._privateIPAddress = value; }

        /// <summary>Private IP address bound to the availability group listener.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Inlined)]
        public string PrivateIPAddressIpaddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IPrivateIPAddressInternal)PrivateIPAddress).IPAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IPrivateIPAddressInternal)PrivateIPAddress).IPAddress = value ?? null; }

        /// <summary>Subnet used to include private IP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Inlined)]
        public string PrivateIPAddressSubnetResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IPrivateIPAddressInternal)PrivateIPAddress).SubnetResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IPrivateIPAddressInternal)PrivateIPAddress).SubnetResourceId = value ?? null; }

        /// <summary>Backing field for <see cref="SqlVirtualMachineInstance" /> property.</summary>
        private string _sqlVirtualMachineInstance;

        /// <summary>
        /// SQL virtual machine instance resource id that are enrolled into the availability group listener.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public string SqlVirtualMachineInstance { get => this._sqlVirtualMachineInstance; set => this._sqlVirtualMachineInstance = value; }

        /// <summary>Creates an new <see cref="MultiSubnetIPConfiguration" /> instance.</summary>
        public MultiSubnetIPConfiguration()
        {

        }
    }
    /// Multi subnet ip configuration for an availability group listener.
    public partial interface IMultiSubnetIPConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.IJsonSerializable
    {
        /// <summary>Private IP address bound to the availability group listener.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Private IP address bound to the availability group listener.",
        SerializedName = @"ipAddress",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateIPAddressIpaddress { get; set; }
        /// <summary>Subnet used to include private IP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subnet used to include private IP.",
        SerializedName = @"subnetResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateIPAddressSubnetResourceId { get; set; }
        /// <summary>
        /// SQL virtual machine instance resource id that are enrolled into the availability group listener.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"SQL virtual machine instance resource id that are enrolled into the availability group listener.",
        SerializedName = @"sqlVirtualMachineInstance",
        PossibleTypes = new [] { typeof(string) })]
        string SqlVirtualMachineInstance { get; set; }

    }
    /// Multi subnet ip configuration for an availability group listener.
    internal partial interface IMultiSubnetIPConfigurationInternal

    {
        /// <summary>Private IP address.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IPrivateIPAddress PrivateIPAddress { get; set; }
        /// <summary>Private IP address bound to the availability group listener.</summary>
        string PrivateIPAddressIpaddress { get; set; }
        /// <summary>Subnet used to include private IP.</summary>
        string PrivateIPAddressSubnetResourceId { get; set; }
        /// <summary>
        /// SQL virtual machine instance resource id that are enrolled into the availability group listener.
        /// </summary>
        string SqlVirtualMachineInstance { get; set; }

    }
}