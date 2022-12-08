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
using Amazon.AuditManager;
using Amazon.AuditManager.Model;

namespace Amazon.PowerShell.Cmdlets.AUDM
{
    /// <summary>
    /// Returns a framework from Audit Manager.
    /// </summary>
    [Cmdlet("Get", "AUDMAssessmentFramework")]
    [OutputType("Amazon.AuditManager.Model.Framework")]
    [AWSCmdlet("Calls the AWS Audit Manager GetAssessmentFramework API operation.", Operation = new[] {"GetAssessmentFramework"}, SelectReturnType = typeof(Amazon.AuditManager.Model.GetAssessmentFrameworkResponse))]
    [AWSCmdletOutput("Amazon.AuditManager.Model.Framework or Amazon.AuditManager.Model.GetAssessmentFrameworkResponse",
        "This cmdlet returns an Amazon.AuditManager.Model.Framework object.",
        "The service call response (type Amazon.AuditManager.Model.GetAssessmentFrameworkResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetAUDMAssessmentFrameworkCmdlet : AmazonAuditManagerClientCmdlet, IExecutor
    {
        
        #region Parameter FrameworkId
        /// <summary>
        /// <para>
        /// <para> The identifier for the framework. </para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String FrameworkId { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Framework'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.AuditManager.Model.GetAssessmentFrameworkResponse).
        /// Specifying the name of a property of type Amazon.AuditManager.Model.GetAssessmentFrameworkResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Framework";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the FrameworkId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^FrameworkId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^FrameworkId' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            this._AWSSignerType = "v4";
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.AuditManager.Model.GetAssessmentFrameworkResponse, GetAUDMAssessmentFrameworkCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.FrameworkId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.FrameworkId = this.FrameworkId;
            #if MODULAR
            if (this.FrameworkId == null && ParameterWasBound(nameof(this.FrameworkId)))
            {
                WriteWarning("You are passing $null as a value for parameter FrameworkId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.AuditManager.Model.GetAssessmentFrameworkRequest();
            
            if (cmdletContext.FrameworkId != null)
            {
                request.FrameworkId = cmdletContext.FrameworkId;
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
        
        private Amazon.AuditManager.Model.GetAssessmentFrameworkResponse CallAWSServiceOperation(IAmazonAuditManager client, Amazon.AuditManager.Model.GetAssessmentFrameworkRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Audit Manager", "GetAssessmentFramework");
            try
            {
                #if DESKTOP
                return client.GetAssessmentFramework(request);
                #elif CORECLR
                return client.GetAssessmentFrameworkAsync(request).GetAwaiter().GetResult();
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
            public System.String FrameworkId { get; set; }
            public System.Func<Amazon.AuditManager.Model.GetAssessmentFrameworkResponse, GetAUDMAssessmentFrameworkCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Framework;
        }
        
    }
}
