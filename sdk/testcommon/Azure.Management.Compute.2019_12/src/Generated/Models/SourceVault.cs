// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Compute.Models
{
    /// <summary> The vault id is an Azure Resource Manager Resource id in the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}. </summary>
    public partial class SourceVault
    {
        /// <summary> Initializes a new instance of SourceVault. </summary>
        public SourceVault()
        {
        }

        /// <summary> Initializes a new instance of SourceVault. </summary>
        /// <param name="id"> Resource Id. </param>
        internal SourceVault(string id)
        {
            Id = id;
        }

        /// <summary> Resource Id. </summary>
        public string Id { get; set; }
    }
}