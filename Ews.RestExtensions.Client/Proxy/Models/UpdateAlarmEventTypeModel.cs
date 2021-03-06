﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Ews.RestExtensions.Client.Proxy.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Describes how a Trend will be patched.
    /// </summary>
    public partial class UpdateAlarmEventTypeModel
    {
        /// <summary>
        /// Initializes a new instance of the UpdateAlarmEventTypeModel class.
        /// </summary>
        public UpdateAlarmEventTypeModel() { }

        /// <summary>
        /// Initializes a new instance of the UpdateAlarmEventTypeModel class.
        /// </summary>
        public UpdateAlarmEventTypeModel(string name = default(string), string description = default(string))
        {
            Name = name;
            Description = description;
        }

        /// <summary>
        /// Name of the entity.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional description of the AlarmEventType.
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

    }
}
