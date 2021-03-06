// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Monitor.Management.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Monitor;
    using Microsoft.Azure.Management.Monitor.Management;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The claims for a rule management event data source.
    /// </summary>
    public partial class RuleManagementEventClaimsDataSource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RuleManagementEventClaimsDataSource class.
        /// </summary>
        public RuleManagementEventClaimsDataSource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RuleManagementEventClaimsDataSource class.
        /// </summary>
        /// <param name="emailAddress">the email address.</param>
        public RuleManagementEventClaimsDataSource(string emailAddress = default(string))
        {
            EmailAddress = emailAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        [JsonProperty(PropertyName = "emailAddress")]
        public string EmailAddress { get; set; }

    }
}
