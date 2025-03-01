/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.Route53Resolver;
using Amazon.Route53Resolver.Model;

namespace Amazon.PowerShell.Cmdlets.R53R
{
    /// <summary>
    /// Updates the specified firewall rule.
    /// </summary>
    [Cmdlet("Edit", "R53RFirewallRule", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.Route53Resolver.Model.FirewallRule")]
    [AWSCmdlet("Calls the Amazon Route 53 Resolver UpdateFirewallRule API operation.", Operation = new[] {"UpdateFirewallRule"}, SelectReturnType = typeof(Amazon.Route53Resolver.Model.UpdateFirewallRuleResponse))]
    [AWSCmdletOutput("Amazon.Route53Resolver.Model.FirewallRule or Amazon.Route53Resolver.Model.UpdateFirewallRuleResponse",
        "This cmdlet returns an Amazon.Route53Resolver.Model.FirewallRule object.",
        "The service call response (type Amazon.Route53Resolver.Model.UpdateFirewallRuleResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class EditR53RFirewallRuleCmdlet : AmazonRoute53ResolverClientCmdlet, IExecutor
    {
        
        #region Parameter Action
        /// <summary>
        /// <para>
        /// <para>The action that DNS Firewall should take on a DNS query when it matches one of the
        /// domains in the rule's domain list:</para><ul><li><para><code>ALLOW</code> - Permit the request to go through.</para></li><li><para><code>ALERT</code> - Permit the request to go through but send an alert to the logs.</para></li><li><para><code>BLOCK</code> - Disallow the request. This option requires additional details
        /// in the rule's <code>BlockResponse</code>. </para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.Route53Resolver.Action")]
        public Amazon.Route53Resolver.Action Action { get; set; }
        #endregion
        
        #region Parameter BlockOverrideDnsType
        /// <summary>
        /// <para>
        /// <para>The DNS record's type. This determines the format of the record value that you provided
        /// in <code>BlockOverrideDomain</code>. Used for the rule action <code>BLOCK</code> with
        /// a <code>BlockResponse</code> setting of <code>OVERRIDE</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.Route53Resolver.BlockOverrideDnsType")]
        public Amazon.Route53Resolver.BlockOverrideDnsType BlockOverrideDnsType { get; set; }
        #endregion
        
        #region Parameter BlockOverrideDomain
        /// <summary>
        /// <para>
        /// <para>The custom DNS record to send back in response to the query. Used for the rule action
        /// <code>BLOCK</code> with a <code>BlockResponse</code> setting of <code>OVERRIDE</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String BlockOverrideDomain { get; set; }
        #endregion
        
        #region Parameter BlockOverrideTtl
        /// <summary>
        /// <para>
        /// <para>The recommended amount of time, in seconds, for the DNS resolver or web browser to
        /// cache the provided override record. Used for the rule action <code>BLOCK</code> with
        /// a <code>BlockResponse</code> setting of <code>OVERRIDE</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? BlockOverrideTtl { get; set; }
        #endregion
        
        #region Parameter BlockResponse
        /// <summary>
        /// <para>
        /// <para>The way that you want DNS Firewall to block the request. Used for the rule action
        /// setting <code>BLOCK</code>.</para><ul><li><para><code>NODATA</code> - Respond indicating that the query was successful, but no response
        /// is available for it.</para></li><li><para><code>NXDOMAIN</code> - Respond indicating that the domain name that's in the query
        /// doesn't exist.</para></li><li><para><code>OVERRIDE</code> - Provide a custom override in the response. This option requires
        /// custom handling details in the rule's <code>BlockOverride*</code> settings. </para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.Route53Resolver.BlockResponse")]
        public Amazon.Route53Resolver.BlockResponse BlockResponse { get; set; }
        #endregion
        
        #region Parameter FirewallDomainListId
        /// <summary>
        /// <para>
        /// <para>The ID of the domain list to use in the rule. </para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String FirewallDomainListId { get; set; }
        #endregion
        
        #region Parameter FirewallRuleGroupId
        /// <summary>
        /// <para>
        /// <para>The unique identifier of the firewall rule group for the rule. </para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String FirewallRuleGroupId { get; set; }
        #endregion
        
        #region Parameter Name
        /// <summary>
        /// <para>
        /// <para>The name of the rule.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Name { get; set; }
        #endregion
        
        #region Parameter Priority
        /// <summary>
        /// <para>
        /// <para>The setting that determines the processing order of the rule in the rule group. DNS
        /// Firewall processes the rules in a rule group by order of priority, starting from the
        /// lowest setting.</para><para>You must specify a unique priority for each rule in a rule group. To make it easier
        /// to insert rules later, leave space between the numbers, for example, use 100, 200,
        /// and so on. You can change the priority setting for the rules in a rule group at any
        /// time.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? Priority { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'FirewallRule'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Route53Resolver.Model.UpdateFirewallRuleResponse).
        /// Specifying the name of a property of type Amazon.Route53Resolver.Model.UpdateFirewallRuleResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "FirewallRule";
        #endregion
        
        #region Parameter Force
        /// <summary>
        /// This parameter overrides confirmation prompts to force 
        /// the cmdlet to continue its operation. This parameter should always
        /// be used with caution.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter Force { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            this._AWSSignerType = "v4";
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.FirewallRuleGroupId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Edit-R53RFirewallRule (UpdateFirewallRule)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Route53Resolver.Model.UpdateFirewallRuleResponse, EditR53RFirewallRuleCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            context.Action = this.Action;
            context.BlockOverrideDnsType = this.BlockOverrideDnsType;
            context.BlockOverrideDomain = this.BlockOverrideDomain;
            context.BlockOverrideTtl = this.BlockOverrideTtl;
            context.BlockResponse = this.BlockResponse;
            context.FirewallDomainListId = this.FirewallDomainListId;
            #if MODULAR
            if (this.FirewallDomainListId == null && ParameterWasBound(nameof(this.FirewallDomainListId)))
            {
                WriteWarning("You are passing $null as a value for parameter FirewallDomainListId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.FirewallRuleGroupId = this.FirewallRuleGroupId;
            #if MODULAR
            if (this.FirewallRuleGroupId == null && ParameterWasBound(nameof(this.FirewallRuleGroupId)))
            {
                WriteWarning("You are passing $null as a value for parameter FirewallRuleGroupId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Name = this.Name;
            context.Priority = this.Priority;
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.Route53Resolver.Model.UpdateFirewallRuleRequest();
            
            if (cmdletContext.Action != null)
            {
                request.Action = cmdletContext.Action;
            }
            if (cmdletContext.BlockOverrideDnsType != null)
            {
                request.BlockOverrideDnsType = cmdletContext.BlockOverrideDnsType;
            }
            if (cmdletContext.BlockOverrideDomain != null)
            {
                request.BlockOverrideDomain = cmdletContext.BlockOverrideDomain;
            }
            if (cmdletContext.BlockOverrideTtl != null)
            {
                request.BlockOverrideTtl = cmdletContext.BlockOverrideTtl.Value;
            }
            if (cmdletContext.BlockResponse != null)
            {
                request.BlockResponse = cmdletContext.BlockResponse;
            }
            if (cmdletContext.FirewallDomainListId != null)
            {
                request.FirewallDomainListId = cmdletContext.FirewallDomainListId;
            }
            if (cmdletContext.FirewallRuleGroupId != null)
            {
                request.FirewallRuleGroupId = cmdletContext.FirewallRuleGroupId;
            }
            if (cmdletContext.Name != null)
            {
                request.Name = cmdletContext.Name;
            }
            if (cmdletContext.Priority != null)
            {
                request.Priority = cmdletContext.Priority.Value;
            }
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            try
            {
                var response = CallAWSServiceOperation(client, request);
                object pipelineOutput = null;
                pipelineOutput = cmdletContext.Select(response, this);
                output = new CmdletOutput
                {
                    PipelineOutput = pipelineOutput,
                    ServiceResponse = response
                };
            }
            catch (Exception e)
            {
                output = new CmdletOutput { ErrorResponse = e };
            }
            
            return output;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.Route53Resolver.Model.UpdateFirewallRuleResponse CallAWSServiceOperation(IAmazonRoute53Resolver client, Amazon.Route53Resolver.Model.UpdateFirewallRuleRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Route 53 Resolver", "UpdateFirewallRule");
            try
            {
                #if DESKTOP
                return client.UpdateFirewallRule(request);
                #elif CORECLR
                return client.UpdateFirewallRuleAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public Amazon.Route53Resolver.Action Action { get; set; }
            public Amazon.Route53Resolver.BlockOverrideDnsType BlockOverrideDnsType { get; set; }
            public System.String BlockOverrideDomain { get; set; }
            public System.Int32? BlockOverrideTtl { get; set; }
            public Amazon.Route53Resolver.BlockResponse BlockResponse { get; set; }
            public System.String FirewallDomainListId { get; set; }
            public System.String FirewallRuleGroupId { get; set; }
            public System.String Name { get; set; }
            public System.Int32? Priority { get; set; }
            public System.Func<Amazon.Route53Resolver.Model.UpdateFirewallRuleResponse, EditR53RFirewallRuleCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.FirewallRule;
        }
        
    }
}
