// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Insights.Models;

namespace Microsoft.Azure.Management.Insights.Models
{
    /// <summary>
    /// A rule management event data source.
    /// </summary>
    public partial class RuleManagementEventDataSource : RuleDataSource
    {
        private RuleManagementEventClaimsDataSource _claims;
        
        /// <summary>
        /// Optional. Gets or sets the claims.
        /// </summary>
        public RuleManagementEventClaimsDataSource Claims
        {
            get { return this._claims; }
            set { this._claims = value; }
        }
        
        private string _eventName;
        
        /// <summary>
        /// Optional. Gets or sets the event name.
        /// </summary>
        public string EventName
        {
            get { return this._eventName; }
            set { this._eventName = value; }
        }
        
        private string _eventSource;
        
        /// <summary>
        /// Optional. Gets or sets the event source.
        /// </summary>
        public string EventSource
        {
            get { return this._eventSource; }
            set { this._eventSource = value; }
        }
        
        private string _level;
        
        /// <summary>
        /// Optional. Gets or sets the level.
        /// </summary>
        public string Level
        {
            get { return this._level; }
            set { this._level = value; }
        }
        
        private string _operationName;
        
        /// <summary>
        /// Optional. Gets or sets the operation name.
        /// </summary>
        public string OperationName
        {
            get { return this._operationName; }
            set { this._operationName = value; }
        }
        
        private string _resourceGroupName;
        
        /// <summary>
        /// Optional. Gets or sets the resource group name.
        /// </summary>
        public string ResourceGroupName
        {
            get { return this._resourceGroupName; }
            set { this._resourceGroupName = value; }
        }
        
        private string _resourceProviderName;
        
        /// <summary>
        /// Optional. Gets or sets the resource provider name.
        /// </summary>
        public string ResourceProviderName
        {
            get { return this._resourceProviderName; }
            set { this._resourceProviderName = value; }
        }
        
        private string _resourceUri;
        
        /// <summary>
        /// Optional. Gets or sets the resource uri.
        /// </summary>
        public string ResourceUri
        {
            get { return this._resourceUri; }
            set { this._resourceUri = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Optional. Gets or sets the status.
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private string _subStatus;
        
        /// <summary>
        /// Optional. Gets or sets the substatus.
        /// </summary>
        public string SubStatus
        {
            get { return this._subStatus; }
            set { this._subStatus = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RuleManagementEventDataSource
        /// class.
        /// </summary>
        public RuleManagementEventDataSource()
        {
        }
    }
}
