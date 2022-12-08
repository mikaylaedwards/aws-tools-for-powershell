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
using Amazon.RoboMaker;
using Amazon.RoboMaker.Model;

namespace Amazon.PowerShell.Cmdlets.ROBO
{
    /// <summary>
    /// Starts a new simulation job batch. The batch is defined using one or more <code>SimulationJobRequest</code>
    /// objects.
    /// </summary>
    [Cmdlet("Start", "ROBOSimulationJobBatch", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.RoboMaker.Model.StartSimulationJobBatchResponse")]
    [AWSCmdlet("Calls the AWS RoboMaker StartSimulationJobBatch API operation.", Operation = new[] {"StartSimulationJobBatch"}, SelectReturnType = typeof(Amazon.RoboMaker.Model.StartSimulationJobBatchResponse))]
    [AWSCmdletOutput("Amazon.RoboMaker.Model.StartSimulationJobBatchResponse",
        "This cmdlet returns an Amazon.RoboMaker.Model.StartSimulationJobBatchResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class StartROBOSimulationJobBatchCmdlet : AmazonRoboMakerClientCmdlet, IExecutor
    {
        
        #region Parameter ClientRequestToken
        /// <summary>
        /// <para>
        /// <para>Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        public System.String ClientRequestToken { get; set; }
        #endregion
        
        #region Parameter CreateSimulationJobRequest
        /// <summary>
        /// <para>
        /// <para>A list of simulation job requests to create in the batch.</para>
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
        [Alias("CreateSimulationJobRequests")]
        public Amazon.RoboMaker.Model.SimulationJobRequest[] CreateSimulationJobRequest { get; set; }
        #endregion
        
        #region Parameter BatchPolicy_MaxConcurrency
        /// <summary>
        /// <para>
        /// <para>The number of active simulation jobs create as part of the batch that can be in an
        /// active state at the same time. </para><para>Active states include: <code>Pending</code>,<code>Preparing</code>, <code>Running</code>,
        /// <code>Restarting</code>, <code>RunningFailed</code> and <code>Terminating</code>.
        /// All other states are terminal states. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? BatchPolicy_MaxConcurrency { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>A map that contains tag keys and tag values that are attached to the deployment job
        /// batch.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public System.Collections.Hashtable Tag { get; set; }
        #endregion
        
        #region Parameter BatchPolicy_TimeoutInSecond
        /// <summary>
        /// <para>
        /// <para>The amount of time, in seconds, to wait for the batch to complete. </para><para>If a batch times out, and there are pending requests that were failing due to an internal
        /// failure (like <code>InternalServiceError</code>), they will be moved to the failed
        /// list and the batch status will be <code>Failed</code>. If the pending requests were
        /// failing for any other reason, the failed pending requests will be moved to the failed
        /// list and the batch status will be <code>TimedOut</code>. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("BatchPolicy_TimeoutInSeconds")]
        public System.Int64? BatchPolicy_TimeoutInSecond { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.RoboMaker.Model.StartSimulationJobBatchResponse).
        /// Specifying the name of a property of type Amazon.RoboMaker.Model.StartSimulationJobBatchResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the ClientRequestToken parameter.
        /// The -PassThru parameter is deprecated, use -Select '^ClientRequestToken' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^ClientRequestToken' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.ClientRequestToken), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Start-ROBOSimulationJobBatch (StartSimulationJobBatch)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.RoboMaker.Model.StartSimulationJobBatchResponse, StartROBOSimulationJobBatchCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.ClientRequestToken;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.BatchPolicy_MaxConcurrency = this.BatchPolicy_MaxConcurrency;
            context.BatchPolicy_TimeoutInSecond = this.BatchPolicy_TimeoutInSecond;
            context.ClientRequestToken = this.ClientRequestToken;
            if (this.CreateSimulationJobRequest != null)
            {
                context.CreateSimulationJobRequest = new List<Amazon.RoboMaker.Model.SimulationJobRequest>(this.CreateSimulationJobRequest);
            }
            #if MODULAR
            if (this.CreateSimulationJobRequest == null && ParameterWasBound(nameof(this.CreateSimulationJobRequest)))
            {
                WriteWarning("You are passing $null as a value for parameter CreateSimulationJobRequest which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.Tag != null)
            {
                context.Tag = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.Tag.Keys)
                {
                    context.Tag.Add((String)hashKey, (String)(this.Tag[hashKey]));
                }
            }
            
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
            var request = new Amazon.RoboMaker.Model.StartSimulationJobBatchRequest();
            
            
             // populate BatchPolicy
            var requestBatchPolicyIsNull = true;
            request.BatchPolicy = new Amazon.RoboMaker.Model.BatchPolicy();
            System.Int32? requestBatchPolicy_batchPolicy_MaxConcurrency = null;
            if (cmdletContext.BatchPolicy_MaxConcurrency != null)
            {
                requestBatchPolicy_batchPolicy_MaxConcurrency = cmdletContext.BatchPolicy_MaxConcurrency.Value;
            }
            if (requestBatchPolicy_batchPolicy_MaxConcurrency != null)
            {
                request.BatchPolicy.MaxConcurrency = requestBatchPolicy_batchPolicy_MaxConcurrency.Value;
                requestBatchPolicyIsNull = false;
            }
            System.Int64? requestBatchPolicy_batchPolicy_TimeoutInSecond = null;
            if (cmdletContext.BatchPolicy_TimeoutInSecond != null)
            {
                requestBatchPolicy_batchPolicy_TimeoutInSecond = cmdletContext.BatchPolicy_TimeoutInSecond.Value;
            }
            if (requestBatchPolicy_batchPolicy_TimeoutInSecond != null)
            {
                request.BatchPolicy.TimeoutInSeconds = requestBatchPolicy_batchPolicy_TimeoutInSecond.Value;
                requestBatchPolicyIsNull = false;
            }
             // determine if request.BatchPolicy should be set to null
            if (requestBatchPolicyIsNull)
            {
                request.BatchPolicy = null;
            }
            if (cmdletContext.ClientRequestToken != null)
            {
                request.ClientRequestToken = cmdletContext.ClientRequestToken;
            }
            if (cmdletContext.CreateSimulationJobRequest != null)
            {
                request.CreateSimulationJobRequests = cmdletContext.CreateSimulationJobRequest;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
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
        
        private Amazon.RoboMaker.Model.StartSimulationJobBatchResponse CallAWSServiceOperation(IAmazonRoboMaker client, Amazon.RoboMaker.Model.StartSimulationJobBatchRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS RoboMaker", "StartSimulationJobBatch");
            try
            {
                #if DESKTOP
                return client.StartSimulationJobBatch(request);
                #elif CORECLR
                return client.StartSimulationJobBatchAsync(request).GetAwaiter().GetResult();
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
            public System.Int32? BatchPolicy_MaxConcurrency { get; set; }
            public System.Int64? BatchPolicy_TimeoutInSecond { get; set; }
            public System.String ClientRequestToken { get; set; }
            public List<Amazon.RoboMaker.Model.SimulationJobRequest> CreateSimulationJobRequest { get; set; }
            public Dictionary<System.String, System.String> Tag { get; set; }
            public System.Func<Amazon.RoboMaker.Model.StartSimulationJobBatchResponse, StartROBOSimulationJobBatchCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
