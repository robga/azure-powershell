// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.ResourceManager.Common.Tags;
using Microsoft.Rest.Azure;
using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;
using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using CNM = Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using System.Linq;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "LoadBalancerBackendAddressPool"), OutputType(typeof(PSBackendAddressPool))]
    public partial class NewAzureLoadBalancerBackendPool : NetworkBaseCmdlet
    {
        [Parameter(
            Mandatory = true,
            HelpMessage = "The resource group name of the load balancer.",
            ValueFromPipelineByPropertyName = true)]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        [SupportsWildcards]
        public string ResourceGroupName { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "The name of the load balancer.",
            ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        [SupportsWildcards]
        public string LoadBalancerName { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "The name of the backend pool.",
            ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        [SupportsWildcards]
        public string BackendAddressPoolName { get; set; }


        public override void Execute()
        {
            base.Execute();

            BackendAddressPool existingloadBalancerBackendAddressPool = null; 
            try
            {
                existingloadBalancerBackendAddressPool = this.NetworkClient.NetworkManagementClient.LoadBalancerBackendAddressPools.Get(this.ResourceGroupName, this.LoadBalancerName, this.BackendAddressPoolName);
            }
            catch (Rest.Azure.CloudException exception)
            {
                if (exception.Response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    existingloadBalancerBackendAddressPool = null;
                }
                else
                {
                    throw;
                }
            }

            if (existingloadBalancerBackendAddressPool != null)
            {
                var existingLoadBalancerBackendAddressPoolModel = NetworkResourceManagerProfile.Mapper.Map<PSBackendAddressPool>(existingloadBalancerBackendAddressPool);
                existingLoadBalancerBackendAddressPoolModel.LoadBalancerBackendAddresses = existingLoadBalancerBackendAddressPoolModel.LoadBalancerBackendAddresses.ToList();
                WriteObject(existingLoadBalancerBackendAddressPoolModel);
            }
            else
            {
                var backendAddressPool = new BackendAddressPool();
                var loadBalancerBackendAddressPool = this.NetworkClient.NetworkManagementClient.LoadBalancerBackendAddressPools.CreateOrUpdate(this.ResourceGroupName, this.LoadBalancerName, this.BackendAddressPoolName, backendAddressPool);
                var loadBalancerBackendAddressPoolModel = NetworkResourceManagerProfile.Mapper.Map<PSBackendAddressPool>(loadBalancerBackendAddressPool);
                loadBalancerBackendAddressPool.LoadBalancerBackendAddresses = loadBalancerBackendAddressPool.LoadBalancerBackendAddresses.ToList();
                WriteObject(loadBalancerBackendAddressPoolModel);
            }
        }
    }
}
