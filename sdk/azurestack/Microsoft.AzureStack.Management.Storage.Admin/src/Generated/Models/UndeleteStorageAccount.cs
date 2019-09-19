// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Storage.Admin.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Undelete storage account information.
    /// </summary>
    public partial class UndeleteStorageAccount
    {
        /// <summary>
        /// Initializes a new instance of the UndeleteStorageAccount class.
        /// </summary>
        public UndeleteStorageAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UndeleteStorageAccount class.
        /// </summary>
        /// <param name="accountId">The internal wac id for storage
        /// account.</param>
        /// <param name="newAccountName">The new account name for the restored
        /// account if defined.</param>
        public UndeleteStorageAccount(string accountId = default(string), string newAccountName = default(string))
        {
            AccountId = accountId;
            NewAccountName = newAccountName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the internal wac id for storage account.
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        public string AccountId { get; private set; }

        /// <summary>
        /// Gets the new account name for the restored account if defined.
        /// </summary>
        [JsonProperty(PropertyName = "newAccountName")]
        public string NewAccountName { get; private set; }

    }
}
