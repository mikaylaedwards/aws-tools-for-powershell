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
using Amazon.Mobile;
using Amazon.Mobile.Model;

namespace Amazon.PowerShell.Cmdlets.MOBL
{
    /// <summary>
    /// Update an existing project.
    /// </summary>
    [Cmdlet("Update", "MOBLProject", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.Mobile.Model.ProjectDetails")]
    [AWSCmdlet("Calls the AWS Mobile UpdateProject API operation.", Operation = new[] {"UpdateProject"}, SelectReturnType = typeof(Amazon.Mobile.Model.UpdateProjectResponse))]
    [AWSCmdletOutput("Amazon.Mobile.Model.ProjectDetails or Amazon.Mobile.Model.UpdateProjectResponse",
        "This cmdlet returns an Amazon.Mobile.Model.ProjectDetails object.",
        "The service call response (type Amazon.Mobile.Model.UpdateProjectResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class UpdateMOBLProjectCmdlet : AmazonMobileClientCmdlet, IExecutor
    {
        
        #region Parameter Content
        /// <summary>
        /// <para>
        /// <para> ZIP or YAML file which contains project configuration to be updated. This should
        /// be the contents of the file downloaded from the URL provided in an export project
        /// operation. </para>
        /// </para>
        /// <para>The cmdlet will automatically convert the supplied parameter of type string, string[], System.IO.FileInfo or System.IO.Stream to byte[] before supplying it to the service.</para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Contents")]
        [Amazon.PowerShell.Common.MemoryStreamParameterConverter]
        public byte[] Content { get; set; }
        #endregion
        
        #region Parameter ProjectId
        /// <summary>
        /// <para>
        /// <para> Unique project identifier. </para>
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
        public System.String ProjectId { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Details'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Mobile.Model.UpdateProjectResponse).
        /// Specifying the name of a property of type Amazon.Mobile.Model.UpdateProjectResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Details";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the ProjectId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^ProjectId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^ProjectId' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.ProjectId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-MOBLProject (UpdateProject)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Mobile.Model.UpdateProjectResponse, UpdateMOBLProjectCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.ProjectId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.Content = this.Content;
            context.ProjectId = this.ProjectId;
            #if MODULAR
            if (this.ProjectId == null && ParameterWasBound(nameof(this.ProjectId)))
            {
                WriteWarning("You are passing $null as a value for parameter ProjectId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            System.IO.MemoryStream _ContentStream = null;
            
            try
            {
                var cmdletContext = context as CmdletContext;
                // create request
                var request = new Amazon.Mobile.Model.UpdateProjectRequest();
                
                if (cmdletContext.Content != null)
                {
                    _ContentStream = new System.IO.MemoryStream(cmdletContext.Content);
                    request.Contents = _ContentStream;
                }
                if (cmdletContext.ProjectId != null)
                {
                    request.ProjectId = cmdletContext.ProjectId;
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
            finally
            {
                if( _ContentStream != null)
                {
                    _ContentStream.Dispose();
                }
            }
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.Mobile.Model.UpdateProjectResponse CallAWSServiceOperation(IAmazonMobile client, Amazon.Mobile.Model.UpdateProjectRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Mobile", "UpdateProject");
            try
            {
                #if DESKTOP
                return client.UpdateProject(request);
                #elif CORECLR
                return client.UpdateProjectAsync(request).GetAwaiter().GetResult();
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
            public byte[] Content { get; set; }
            public System.String ProjectId { get; set; }
            public System.Func<Amazon.Mobile.Model.UpdateProjectResponse, UpdateMOBLProjectCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Details;
        }
        
    }
}
