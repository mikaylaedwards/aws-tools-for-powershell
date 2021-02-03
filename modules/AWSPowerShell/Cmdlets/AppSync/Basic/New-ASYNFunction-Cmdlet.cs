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
using Amazon.AppSync;
using Amazon.AppSync.Model;

namespace Amazon.PowerShell.Cmdlets.ASYN
{
    /// <summary>
    /// Creates a <code>Function</code> object.
    /// 
    ///  
    /// <para>
    /// A function is a reusable entity. Multiple functions can be used to compose the resolver
    /// logic.
    /// </para>
    /// </summary>
    [Cmdlet("New", "ASYNFunction", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.AppSync.Model.FunctionConfiguration")]
    [AWSCmdlet("Calls the AWS AppSync CreateFunction API operation.", Operation = new[] {"CreateFunction"}, SelectReturnType = typeof(Amazon.AppSync.Model.CreateFunctionResponse))]
    [AWSCmdletOutput("Amazon.AppSync.Model.FunctionConfiguration or Amazon.AppSync.Model.CreateFunctionResponse",
        "This cmdlet returns an Amazon.AppSync.Model.FunctionConfiguration object.",
        "The service call response (type Amazon.AppSync.Model.CreateFunctionResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewASYNFunctionCmdlet : AmazonAppSyncClientCmdlet, IExecutor
    {
        
        #region Parameter ApiId
        /// <summary>
        /// <para>
        /// <para>The GraphQL API ID.</para>
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
        public System.String ApiId { get; set; }
        #endregion
        
        #region Parameter SyncConfig_ConflictDetection
        /// <summary>
        /// <para>
        /// <para>The Conflict Detection strategy to use.</para><ul><li><para><b>VERSION</b>: Detect conflicts based on object versions for this resolver.</para></li><li><para><b>NONE</b>: Do not detect conflicts when executing this resolver.</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.AppSync.ConflictDetectionType")]
        public Amazon.AppSync.ConflictDetectionType SyncConfig_ConflictDetection { get; set; }
        #endregion
        
        #region Parameter SyncConfig_ConflictHandler
        /// <summary>
        /// <para>
        /// <para>The Conflict Resolution strategy to perform in the event of a conflict.</para><ul><li><para><b>OPTIMISTIC_CONCURRENCY</b>: Resolve conflicts by rejecting mutations when versions
        /// do not match the latest version at the server.</para></li><li><para><b>AUTOMERGE</b>: Resolve conflicts with the Automerge conflict resolution strategy.</para></li><li><para><b>LAMBDA</b>: Resolve conflicts with a Lambda function supplied in the LambdaConflictHandlerConfig.</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.AppSync.ConflictHandlerType")]
        public Amazon.AppSync.ConflictHandlerType SyncConfig_ConflictHandler { get; set; }
        #endregion
        
        #region Parameter DataSourceName
        /// <summary>
        /// <para>
        /// <para>The <code>Function</code><code>DataSource</code> name.</para>
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
        public System.String DataSourceName { get; set; }
        #endregion
        
        #region Parameter Description
        /// <summary>
        /// <para>
        /// <para>The <code>Function</code> description.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Description { get; set; }
        #endregion
        
        #region Parameter FunctionVersion
        /// <summary>
        /// <para>
        /// <para>The <code>version</code> of the request mapping template. Currently the supported
        /// value is 2018-05-29. </para>
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
        public System.String FunctionVersion { get; set; }
        #endregion
        
        #region Parameter LambdaConflictHandlerConfig_LambdaConflictHandlerArn
        /// <summary>
        /// <para>
        /// <para>The Arn for the Lambda function to use as the Conflict Handler.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SyncConfig_LambdaConflictHandlerConfig_LambdaConflictHandlerArn")]
        public System.String LambdaConflictHandlerConfig_LambdaConflictHandlerArn { get; set; }
        #endregion
        
        #region Parameter Name
        /// <summary>
        /// <para>
        /// <para>The <code>Function</code> name. The function name does not have to be unique.</para>
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
        public System.String Name { get; set; }
        #endregion
        
        #region Parameter RequestMappingTemplate
        /// <summary>
        /// <para>
        /// <para>The <code>Function</code> request mapping template. Functions support only the 2018-05-29
        /// version of the request mapping template.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String RequestMappingTemplate { get; set; }
        #endregion
        
        #region Parameter ResponseMappingTemplate
        /// <summary>
        /// <para>
        /// <para>The <code>Function</code> response mapping template. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ResponseMappingTemplate { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'FunctionConfiguration'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.AppSync.Model.CreateFunctionResponse).
        /// Specifying the name of a property of type Amazon.AppSync.Model.CreateFunctionResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "FunctionConfiguration";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the ApiId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^ApiId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^ApiId' instead. This parameter will be removed in a future version.")]
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
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.ApiId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-ASYNFunction (CreateFunction)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.AppSync.Model.CreateFunctionResponse, NewASYNFunctionCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.ApiId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ApiId = this.ApiId;
            #if MODULAR
            if (this.ApiId == null && ParameterWasBound(nameof(this.ApiId)))
            {
                WriteWarning("You are passing $null as a value for parameter ApiId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.DataSourceName = this.DataSourceName;
            #if MODULAR
            if (this.DataSourceName == null && ParameterWasBound(nameof(this.DataSourceName)))
            {
                WriteWarning("You are passing $null as a value for parameter DataSourceName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Description = this.Description;
            context.FunctionVersion = this.FunctionVersion;
            #if MODULAR
            if (this.FunctionVersion == null && ParameterWasBound(nameof(this.FunctionVersion)))
            {
                WriteWarning("You are passing $null as a value for parameter FunctionVersion which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Name = this.Name;
            #if MODULAR
            if (this.Name == null && ParameterWasBound(nameof(this.Name)))
            {
                WriteWarning("You are passing $null as a value for parameter Name which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.RequestMappingTemplate = this.RequestMappingTemplate;
            context.ResponseMappingTemplate = this.ResponseMappingTemplate;
            context.SyncConfig_ConflictDetection = this.SyncConfig_ConflictDetection;
            context.SyncConfig_ConflictHandler = this.SyncConfig_ConflictHandler;
            context.LambdaConflictHandlerConfig_LambdaConflictHandlerArn = this.LambdaConflictHandlerConfig_LambdaConflictHandlerArn;
            
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
            var request = new Amazon.AppSync.Model.CreateFunctionRequest();
            
            if (cmdletContext.ApiId != null)
            {
                request.ApiId = cmdletContext.ApiId;
            }
            if (cmdletContext.DataSourceName != null)
            {
                request.DataSourceName = cmdletContext.DataSourceName;
            }
            if (cmdletContext.Description != null)
            {
                request.Description = cmdletContext.Description;
            }
            if (cmdletContext.FunctionVersion != null)
            {
                request.FunctionVersion = cmdletContext.FunctionVersion;
            }
            if (cmdletContext.Name != null)
            {
                request.Name = cmdletContext.Name;
            }
            if (cmdletContext.RequestMappingTemplate != null)
            {
                request.RequestMappingTemplate = cmdletContext.RequestMappingTemplate;
            }
            if (cmdletContext.ResponseMappingTemplate != null)
            {
                request.ResponseMappingTemplate = cmdletContext.ResponseMappingTemplate;
            }
            
             // populate SyncConfig
            var requestSyncConfigIsNull = true;
            request.SyncConfig = new Amazon.AppSync.Model.SyncConfig();
            Amazon.AppSync.ConflictDetectionType requestSyncConfig_syncConfig_ConflictDetection = null;
            if (cmdletContext.SyncConfig_ConflictDetection != null)
            {
                requestSyncConfig_syncConfig_ConflictDetection = cmdletContext.SyncConfig_ConflictDetection;
            }
            if (requestSyncConfig_syncConfig_ConflictDetection != null)
            {
                request.SyncConfig.ConflictDetection = requestSyncConfig_syncConfig_ConflictDetection;
                requestSyncConfigIsNull = false;
            }
            Amazon.AppSync.ConflictHandlerType requestSyncConfig_syncConfig_ConflictHandler = null;
            if (cmdletContext.SyncConfig_ConflictHandler != null)
            {
                requestSyncConfig_syncConfig_ConflictHandler = cmdletContext.SyncConfig_ConflictHandler;
            }
            if (requestSyncConfig_syncConfig_ConflictHandler != null)
            {
                request.SyncConfig.ConflictHandler = requestSyncConfig_syncConfig_ConflictHandler;
                requestSyncConfigIsNull = false;
            }
            Amazon.AppSync.Model.LambdaConflictHandlerConfig requestSyncConfig_syncConfig_LambdaConflictHandlerConfig = null;
            
             // populate LambdaConflictHandlerConfig
            var requestSyncConfig_syncConfig_LambdaConflictHandlerConfigIsNull = true;
            requestSyncConfig_syncConfig_LambdaConflictHandlerConfig = new Amazon.AppSync.Model.LambdaConflictHandlerConfig();
            System.String requestSyncConfig_syncConfig_LambdaConflictHandlerConfig_lambdaConflictHandlerConfig_LambdaConflictHandlerArn = null;
            if (cmdletContext.LambdaConflictHandlerConfig_LambdaConflictHandlerArn != null)
            {
                requestSyncConfig_syncConfig_LambdaConflictHandlerConfig_lambdaConflictHandlerConfig_LambdaConflictHandlerArn = cmdletContext.LambdaConflictHandlerConfig_LambdaConflictHandlerArn;
            }
            if (requestSyncConfig_syncConfig_LambdaConflictHandlerConfig_lambdaConflictHandlerConfig_LambdaConflictHandlerArn != null)
            {
                requestSyncConfig_syncConfig_LambdaConflictHandlerConfig.LambdaConflictHandlerArn = requestSyncConfig_syncConfig_LambdaConflictHandlerConfig_lambdaConflictHandlerConfig_LambdaConflictHandlerArn;
                requestSyncConfig_syncConfig_LambdaConflictHandlerConfigIsNull = false;
            }
             // determine if requestSyncConfig_syncConfig_LambdaConflictHandlerConfig should be set to null
            if (requestSyncConfig_syncConfig_LambdaConflictHandlerConfigIsNull)
            {
                requestSyncConfig_syncConfig_LambdaConflictHandlerConfig = null;
            }
            if (requestSyncConfig_syncConfig_LambdaConflictHandlerConfig != null)
            {
                request.SyncConfig.LambdaConflictHandlerConfig = requestSyncConfig_syncConfig_LambdaConflictHandlerConfig;
                requestSyncConfigIsNull = false;
            }
             // determine if request.SyncConfig should be set to null
            if (requestSyncConfigIsNull)
            {
                request.SyncConfig = null;
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
        
        private Amazon.AppSync.Model.CreateFunctionResponse CallAWSServiceOperation(IAmazonAppSync client, Amazon.AppSync.Model.CreateFunctionRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS AppSync", "CreateFunction");
            try
            {
                #if DESKTOP
                return client.CreateFunction(request);
                #elif CORECLR
                return client.CreateFunctionAsync(request).GetAwaiter().GetResult();
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
            public System.String ApiId { get; set; }
            public System.String DataSourceName { get; set; }
            public System.String Description { get; set; }
            public System.String FunctionVersion { get; set; }
            public System.String Name { get; set; }
            public System.String RequestMappingTemplate { get; set; }
            public System.String ResponseMappingTemplate { get; set; }
            public Amazon.AppSync.ConflictDetectionType SyncConfig_ConflictDetection { get; set; }
            public Amazon.AppSync.ConflictHandlerType SyncConfig_ConflictHandler { get; set; }
            public System.String LambdaConflictHandlerConfig_LambdaConflictHandlerArn { get; set; }
            public System.Func<Amazon.AppSync.Model.CreateFunctionResponse, NewASYNFunctionCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.FunctionConfiguration;
        }
        
    }
}
