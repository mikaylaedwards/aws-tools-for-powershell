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
using Amazon.SecurityHub;
using Amazon.SecurityHub.Model;

namespace Amazon.PowerShell.Cmdlets.SHUB
{
    /// <summary>
    /// Provides details about a batch of security controls for the current Amazon Web Services
    /// account and Amazon Web Services Region.
    /// </summary>
    [Cmdlet("Get", "SHUBGetSecurityControl")]
    [OutputType("Amazon.SecurityHub.Model.BatchGetSecurityControlsResponse")]
    [AWSCmdlet("Calls the AWS Security Hub BatchGetSecurityControls API operation.", Operation = new[] {"BatchGetSecurityControls"}, SelectReturnType = typeof(Amazon.SecurityHub.Model.BatchGetSecurityControlsResponse))]
    [AWSCmdletOutput("Amazon.SecurityHub.Model.BatchGetSecurityControlsResponse",
        "This cmdlet returns an Amazon.SecurityHub.Model.BatchGetSecurityControlsResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetSHUBGetSecurityControlCmdlet : AmazonSecurityHubClientCmdlet, IExecutor
    {
        
        #region Parameter SecurityControlId
        /// <summary>
        /// <para>
        /// <para> A list of security controls (identified with <code>SecurityControlId</code>, <code>SecurityControlArn</code>,
        /// or a mix of both parameters). The security control ID or Amazon Resource Name (ARN)
        /// is the same across standards. </para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyCollection]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [Alias("SecurityControlIds")]
        public System.String[] SecurityControlId { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.SecurityHub.Model.BatchGetSecurityControlsResponse).
        /// Specifying the name of a property of type Amazon.SecurityHub.Model.BatchGetSecurityControlsResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        protected override void ProcessRecord()
        {
            this._AWSSignerType = "v4";
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.SecurityHub.Model.BatchGetSecurityControlsResponse, GetSHUBGetSecurityControlCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            if (this.SecurityControlId != null)
            {
                context.SecurityControlId = new List<System.String>(this.SecurityControlId);
            }
            #if MODULAR
            if (this.SecurityControlId == null && ParameterWasBound(nameof(this.SecurityControlId)))
            {
                WriteWarning("You are passing $null as a value for parameter SecurityControlId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            
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
            var request = new Amazon.SecurityHub.Model.BatchGetSecurityControlsRequest();
            
            if (cmdletContext.SecurityControlId != null)
            {
                request.SecurityControlIds = cmdletContext.SecurityControlId;
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
        
        private Amazon.SecurityHub.Model.BatchGetSecurityControlsResponse CallAWSServiceOperation(IAmazonSecurityHub client, Amazon.SecurityHub.Model.BatchGetSecurityControlsRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Security Hub", "BatchGetSecurityControls");
            try
            {
                #if DESKTOP
                return client.BatchGetSecurityControls(request);
                #elif CORECLR
                return client.BatchGetSecurityControlsAsync(request).GetAwaiter().GetResult();
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
            public List<System.String> SecurityControlId { get; set; }
            public System.Func<Amazon.SecurityHub.Model.BatchGetSecurityControlsResponse, GetSHUBGetSecurityControlCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
