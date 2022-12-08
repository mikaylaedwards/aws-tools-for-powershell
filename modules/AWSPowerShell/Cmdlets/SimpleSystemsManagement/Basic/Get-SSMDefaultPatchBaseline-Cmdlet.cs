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
using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;

namespace Amazon.PowerShell.Cmdlets.SSM
{
    /// <summary>
    /// Retrieves the default patch baseline. Amazon Web Services Systems Manager supports
    /// creating multiple default patch baselines. For example, you can create a default patch
    /// baseline for each operating system.
    /// 
    ///  
    /// <para>
    /// If you don't specify an operating system value, the default patch baseline for Windows
    /// is returned.
    /// </para>
    /// </summary>
    [Cmdlet("Get", "SSMDefaultPatchBaseline")]
    [OutputType("Amazon.SimpleSystemsManagement.Model.GetDefaultPatchBaselineResponse")]
    [AWSCmdlet("Calls the AWS Systems Manager GetDefaultPatchBaseline API operation.", Operation = new[] {"GetDefaultPatchBaseline"}, SelectReturnType = typeof(Amazon.SimpleSystemsManagement.Model.GetDefaultPatchBaselineResponse))]
    [AWSCmdletOutput("Amazon.SimpleSystemsManagement.Model.GetDefaultPatchBaselineResponse",
        "This cmdlet returns an Amazon.SimpleSystemsManagement.Model.GetDefaultPatchBaselineResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetSSMDefaultPatchBaselineCmdlet : AmazonSimpleSystemsManagementClientCmdlet, IExecutor
    {
        
        #region Parameter OperatingSystem
        /// <summary>
        /// <para>
        /// <para>Returns the default patch baseline for the specified operating system.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        [AWSConstantClassSource("Amazon.SimpleSystemsManagement.OperatingSystem")]
        public Amazon.SimpleSystemsManagement.OperatingSystem OperatingSystem { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.SimpleSystemsManagement.Model.GetDefaultPatchBaselineResponse).
        /// Specifying the name of a property of type Amazon.SimpleSystemsManagement.Model.GetDefaultPatchBaselineResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the OperatingSystem parameter.
        /// The -PassThru parameter is deprecated, use -Select '^OperatingSystem' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^OperatingSystem' instead. This parameter will be removed in a future version.")]
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
                context.Select = CreateSelectDelegate<Amazon.SimpleSystemsManagement.Model.GetDefaultPatchBaselineResponse, GetSSMDefaultPatchBaselineCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.OperatingSystem;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.OperatingSystem = this.OperatingSystem;
            
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
            var request = new Amazon.SimpleSystemsManagement.Model.GetDefaultPatchBaselineRequest();
            
            if (cmdletContext.OperatingSystem != null)
            {
                request.OperatingSystem = cmdletContext.OperatingSystem;
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
        
        private Amazon.SimpleSystemsManagement.Model.GetDefaultPatchBaselineResponse CallAWSServiceOperation(IAmazonSimpleSystemsManagement client, Amazon.SimpleSystemsManagement.Model.GetDefaultPatchBaselineRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Systems Manager", "GetDefaultPatchBaseline");
            try
            {
                #if DESKTOP
                return client.GetDefaultPatchBaseline(request);
                #elif CORECLR
                return client.GetDefaultPatchBaselineAsync(request).GetAwaiter().GetResult();
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
            public Amazon.SimpleSystemsManagement.OperatingSystem OperatingSystem { get; set; }
            public System.Func<Amazon.SimpleSystemsManagement.Model.GetDefaultPatchBaselineResponse, GetSSMDefaultPatchBaselineCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
