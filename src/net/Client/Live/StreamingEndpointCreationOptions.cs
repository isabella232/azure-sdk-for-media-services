﻿// Copyright 2014 Microsoft Corporation
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;

namespace Microsoft.WindowsAzure.MediaServices.Client
{
    /// <summary>
    /// The options to create a streaming endpoint, which contains
    /// all parameters and settings to configure a streaming endpoint
    /// </summary>
    public class StreamingEndpointCreationOptions
    {
        /// <summary>
        /// Gets or sets the name of the streaming endpoint.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets description or friendly name of the streaming endpoint.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets one or more "vanity" host names to be accepted by the streaming endpoint in addition to default endpoint name.
        /// </summary>
        public IEnumerable<string> CustomHostNames { get; set; }

        /// <summary>
        /// Gets or sets the streaming endpoint scale units.
        /// </summary>
        public int ScaleUnits { get; set; }

        /// <summary>
        /// Gets or sets cross site access policies policies to the streaming endpoint such as client access policy and cross domain access policy.
        /// </summary>
        public CrossSiteAccessPolicies CrossSiteAccessPolicies { get; set; }

        /// <summary>
        /// Gets or sets access control policies to the streaming endpoint such as IP Allow List, Akamai G2O authentication keys, etc.
        /// </summary>
        public StreamingEndpointAccessControl AccessControl { get; set; }

        /// <summary>
        /// Gets or sets custom asset cache lifetime for assets served through the streaming endpoint.
        /// </summary>
        public StreamingEndpointCacheControl CacheControl { get; set; }
        
        /// <summary>
        /// Creates an instance of StreamingEndpointCreationOptions class.
        /// </summary>
        public StreamingEndpointCreationOptions() {}

        /// <summary>
        /// Creates an instance of StreamingEndpointCreationOptions class.
        /// </summary>
        /// <param name="name">Name of the streaming endpoint to be created</param>
        /// <param name="scaleUnits">The streaming endpoint scale units.</param>
        public StreamingEndpointCreationOptions(string name, int scaleUnits)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("name");
            }
            if (scaleUnits < 0)
            {
                throw new ArgumentOutOfRangeException("scaleUnits");
            }

            Name = name;
            ScaleUnits = scaleUnits;
        }
    }
}
