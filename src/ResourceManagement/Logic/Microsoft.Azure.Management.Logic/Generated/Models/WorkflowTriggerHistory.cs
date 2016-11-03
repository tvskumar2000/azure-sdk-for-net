// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    [JsonTransformation]
    public partial class WorkflowTriggerHistory : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the WorkflowTriggerHistory class.
        /// </summary>
        public WorkflowTriggerHistory() { }

        /// <summary>
        /// Initializes a new instance of the WorkflowTriggerHistory class.
        /// </summary>
        public WorkflowTriggerHistory(string id = default(string), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), WorkflowStatus? status = default(WorkflowStatus?), string code = default(string), object error = default(object), string trackingId = default(string), Correlation correlation = default(Correlation), ContentLink inputsLink = default(ContentLink), ContentLink outputsLink = default(ContentLink), bool? fired = default(bool?), ResourceReference run = default(ResourceReference), string name = default(string), string type = default(string))
            : base(id)
        {
            StartTime = startTime;
            EndTime = endTime;
            Status = status;
            Code = code;
            Error = error;
            TrackingId = trackingId;
            Correlation = correlation;
            InputsLink = inputsLink;
            OutputsLink = outputsLink;
            Fired = fired;
            Run = run;
            Name = name;
            Type = type;
        }

        /// <summary>
        /// Gets gets the start time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets gets the end time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets gets the status. Possible values include: 'NotSpecified',
        /// 'Paused', 'Running', 'Waiting', 'Succeeded', 'Skipped',
        /// 'Suspended', 'Cancelled', 'Failed', 'Faulted', 'TimedOut',
        /// 'Aborted', 'Ignored'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public WorkflowStatus? Status { get; private set; }

        /// <summary>
        /// Gets gets the code.
        /// </summary>
        [JsonProperty(PropertyName = "properties.code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets gets the error.
        /// </summary>
        [JsonProperty(PropertyName = "properties.error")]
        public object Error { get; private set; }

        /// <summary>
        /// Gets gets the tracking id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.trackingId")]
        public string TrackingId { get; private set; }

        /// <summary>
        /// Gets or sets gets or sets the run correlation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.correlation")]
        public Correlation Correlation { get; set; }

        /// <summary>
        /// Gets gets the link to input parameters.
        /// </summary>
        [JsonProperty(PropertyName = "properties.inputsLink")]
        public ContentLink InputsLink { get; private set; }

        /// <summary>
        /// Gets gets the link to output parameters.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outputsLink")]
        public ContentLink OutputsLink { get; private set; }

        /// <summary>
        /// Gets gets a value indicating whether trigger was fired.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fired")]
        public bool? Fired { get; private set; }

        /// <summary>
        /// Gets gets the reference to workflow run.
        /// </summary>
        [JsonProperty(PropertyName = "properties.run")]
        public ResourceReference Run { get; private set; }

        /// <summary>
        /// Gets gets the workflow trigger history name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets gets the workflow trigger history type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}