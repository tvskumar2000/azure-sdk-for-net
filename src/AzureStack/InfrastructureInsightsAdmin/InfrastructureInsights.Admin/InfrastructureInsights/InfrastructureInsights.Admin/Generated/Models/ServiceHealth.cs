// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Management.InfrastructureInsights.Admin.Models
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Management;
    using Microsoft.AzureStack.Management.InfrastructureInsights;
    using Microsoft.AzureStack.Management.InfrastructureInsights.Admin;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Holds information about a services health.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ServiceHealth : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ServiceHealth class.
        /// </summary>
        public ServiceHealth()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceHealth class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Location where resource is location.</param>
        /// <param name="tags">List of key value pairs.</param>
        /// <param name="alertSummary">Gets or sets the alert summary.</param>
        /// <param name="healthState">Gets or sets the health status.</param>
        /// <param name="namespaceProperty">Gets or sets the name
        /// space.</param>
        /// <param name="registrationId">Gets or sets the registration
        /// id.</param>
        /// <param name="routePrefix">Gets or sets the route prefix.</param>
        /// <param name="displayName">Name of the alert.</param>
        /// <param name="serviceLocation">Location of the service.</param>
        /// <param name="infraURI">The route prefix to the alert.</param>
        public ServiceHealth(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), AlertSummary alertSummary = default(AlertSummary), string healthState = default(string), string namespaceProperty = default(string), string registrationId = default(string), string routePrefix = default(string), string displayName = default(string), string serviceLocation = default(string), string infraURI = default(string))
            : base(id, name, type, location, tags)
        {
            AlertSummary = alertSummary;
            HealthState = healthState;
            NamespaceProperty = namespaceProperty;
            RegistrationId = registrationId;
            RoutePrefix = routePrefix;
            DisplayName = displayName;
            ServiceLocation = serviceLocation;
            InfraURI = infraURI;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the alert summary.
        /// </summary>
        [JsonProperty(PropertyName = "properties.alertSummary")]
        public AlertSummary AlertSummary { get; set; }

        /// <summary>
        /// Gets or sets the health status.
        /// </summary>
        [JsonProperty(PropertyName = "properties.healthState")]
        public string HealthState { get; set; }

        /// <summary>
        /// Gets or sets the name space.
        /// </summary>
        [JsonProperty(PropertyName = "properties.namespace")]
        public string NamespaceProperty { get; set; }

        /// <summary>
        /// Gets or sets the registration id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.registrationId")]
        public string RegistrationId { get; set; }

        /// <summary>
        /// Gets or sets the route prefix.
        /// </summary>
        [JsonProperty(PropertyName = "properties.routePrefix")]
        public string RoutePrefix { get; set; }

        /// <summary>
        /// Gets or sets name of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets location of the service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceLocation")]
        public string ServiceLocation { get; set; }

        /// <summary>
        /// Gets or sets the route prefix to the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.infraURI")]
        public string InfraURI { get; set; }

    }
}
