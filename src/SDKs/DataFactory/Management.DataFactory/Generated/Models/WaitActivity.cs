// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactory;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This activity suspends pipeline execution for the specified interval.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Wait")]
    [Rest.Serialization.JsonTransformation]
    public partial class WaitActivity : ControlActivity
    {
        /// <summary>
        /// Initializes a new instance of the WaitActivity class.
        /// </summary>
        public WaitActivity()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WaitActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="waitTimeInSeconds">Duration in seconds.</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        public WaitActivity(string name, int waitTimeInSeconds, string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>))
            : base(name, description, dependsOn)
        {
            WaitTimeInSeconds = waitTimeInSeconds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets duration in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.waitTimeInSeconds")]
        public int WaitTimeInSeconds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
