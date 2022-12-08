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
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

namespace Amazon.PowerShell.Cmdlets.DDB
{
    /// <summary>
    /// Exports table data to an S3 bucket. The table must have point in time recovery enabled,
    /// and you can export data from any time within the point in time recovery window.
    /// </summary>
    [Cmdlet("Export", "DDBTableToPointInTime", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.DynamoDBv2.Model.ExportDescription")]
    [AWSCmdlet("Calls the Amazon DynamoDB ExportTableToPointInTime API operation.", Operation = new[] {"ExportTableToPointInTime"}, SelectReturnType = typeof(Amazon.DynamoDBv2.Model.ExportTableToPointInTimeResponse))]
    [AWSCmdletOutput("Amazon.DynamoDBv2.Model.ExportDescription or Amazon.DynamoDBv2.Model.ExportTableToPointInTimeResponse",
        "This cmdlet returns an Amazon.DynamoDBv2.Model.ExportDescription object.",
        "The service call response (type Amazon.DynamoDBv2.Model.ExportTableToPointInTimeResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class ExportDDBTableToPointInTimeCmdlet : AmazonDynamoDBClientCmdlet, IExecutor
    {
        
        #region Parameter ExportFormat
        /// <summary>
        /// <para>
        /// <para>The format for the exported data. Valid values for <code>ExportFormat</code> are <code>DYNAMODB_JSON</code>
        /// or <code>ION</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.DynamoDBv2.ExportFormat")]
        public Amazon.DynamoDBv2.ExportFormat ExportFormat { get; set; }
        #endregion
        
        #region Parameter ExportTime
        /// <summary>
        /// <para>
        /// <para>Time in the past from which to export table data, counted in seconds from the start
        /// of the Unix epoch. The table export will be a snapshot of the table's state at this
        /// point in time.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.DateTime? ExportTime { get; set; }
        #endregion
        
        #region Parameter S3Bucket
        /// <summary>
        /// <para>
        /// <para>The name of the Amazon S3 bucket to export the snapshot to.</para>
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
        public System.String S3Bucket { get; set; }
        #endregion
        
        #region Parameter S3BucketOwner
        /// <summary>
        /// <para>
        /// <para>The ID of the Amazon Web Services account that owns the bucket the export will be
        /// stored in.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String S3BucketOwner { get; set; }
        #endregion
        
        #region Parameter S3Prefix
        /// <summary>
        /// <para>
        /// <para>The Amazon S3 bucket prefix to use as the file name and path of the exported snapshot.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String S3Prefix { get; set; }
        #endregion
        
        #region Parameter S3SseAlgorithm
        /// <summary>
        /// <para>
        /// <para>Type of encryption used on the bucket where export data will be stored. Valid values
        /// for <code>S3SseAlgorithm</code> are:</para><ul><li><para><code>AES256</code> - server-side encryption with Amazon S3 managed keys</para></li><li><para><code>KMS</code> - server-side encryption with KMS managed keys</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.DynamoDBv2.S3SseAlgorithm")]
        public Amazon.DynamoDBv2.S3SseAlgorithm S3SseAlgorithm { get; set; }
        #endregion
        
        #region Parameter S3SseKmsKeyId
        /// <summary>
        /// <para>
        /// <para>The ID of the KMS managed key used to encrypt the S3 bucket where export data will
        /// be stored (if applicable).</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String S3SseKmsKeyId { get; set; }
        #endregion
        
        #region Parameter TableArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) associated with the table to export.</para>
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
        public System.String TableArn { get; set; }
        #endregion
        
        #region Parameter ClientToken
        /// <summary>
        /// <para>
        /// <para>Providing a <code>ClientToken</code> makes the call to <code>ExportTableToPointInTimeInput</code>
        /// idempotent, meaning that multiple identical calls have the same effect as one single
        /// call.</para><para>A client token is valid for 8 hours after the first request that uses it is completed.
        /// After 8 hours, any request with the same client token is treated as a new request.
        /// Do not resubmit the same request with the same client token for more than 8 hours,
        /// or the result might not be idempotent.</para><para>If you submit a request with the same client token but a change in other parameters
        /// within the 8-hour idempotency window, DynamoDB returns an <code>ImportConflictException</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'ExportDescription'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.DynamoDBv2.Model.ExportTableToPointInTimeResponse).
        /// Specifying the name of a property of type Amazon.DynamoDBv2.Model.ExportTableToPointInTimeResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "ExportDescription";
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.TableArn), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Export-DDBTableToPointInTime (ExportTableToPointInTime)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.DynamoDBv2.Model.ExportTableToPointInTimeResponse, ExportDDBTableToPointInTimeCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            context.ClientToken = this.ClientToken;
            context.ExportFormat = this.ExportFormat;
            context.ExportTime = this.ExportTime;
            context.S3Bucket = this.S3Bucket;
            #if MODULAR
            if (this.S3Bucket == null && ParameterWasBound(nameof(this.S3Bucket)))
            {
                WriteWarning("You are passing $null as a value for parameter S3Bucket which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.S3BucketOwner = this.S3BucketOwner;
            context.S3Prefix = this.S3Prefix;
            context.S3SseAlgorithm = this.S3SseAlgorithm;
            context.S3SseKmsKeyId = this.S3SseKmsKeyId;
            context.TableArn = this.TableArn;
            #if MODULAR
            if (this.TableArn == null && ParameterWasBound(nameof(this.TableArn)))
            {
                WriteWarning("You are passing $null as a value for parameter TableArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.DynamoDBv2.Model.ExportTableToPointInTimeRequest();
            
            if (cmdletContext.ClientToken != null)
            {
                request.ClientToken = cmdletContext.ClientToken;
            }
            if (cmdletContext.ExportFormat != null)
            {
                request.ExportFormat = cmdletContext.ExportFormat;
            }
            if (cmdletContext.ExportTime != null)
            {
                request.ExportTime = cmdletContext.ExportTime.Value;
            }
            if (cmdletContext.S3Bucket != null)
            {
                request.S3Bucket = cmdletContext.S3Bucket;
            }
            if (cmdletContext.S3BucketOwner != null)
            {
                request.S3BucketOwner = cmdletContext.S3BucketOwner;
            }
            if (cmdletContext.S3Prefix != null)
            {
                request.S3Prefix = cmdletContext.S3Prefix;
            }
            if (cmdletContext.S3SseAlgorithm != null)
            {
                request.S3SseAlgorithm = cmdletContext.S3SseAlgorithm;
            }
            if (cmdletContext.S3SseKmsKeyId != null)
            {
                request.S3SseKmsKeyId = cmdletContext.S3SseKmsKeyId;
            }
            if (cmdletContext.TableArn != null)
            {
                request.TableArn = cmdletContext.TableArn;
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
        
        private Amazon.DynamoDBv2.Model.ExportTableToPointInTimeResponse CallAWSServiceOperation(IAmazonDynamoDB client, Amazon.DynamoDBv2.Model.ExportTableToPointInTimeRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon DynamoDB", "ExportTableToPointInTime");
            try
            {
                #if DESKTOP
                return client.ExportTableToPointInTime(request);
                #elif CORECLR
                return client.ExportTableToPointInTimeAsync(request).GetAwaiter().GetResult();
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
            public System.String ClientToken { get; set; }
            public Amazon.DynamoDBv2.ExportFormat ExportFormat { get; set; }
            public System.DateTime? ExportTime { get; set; }
            public System.String S3Bucket { get; set; }
            public System.String S3BucketOwner { get; set; }
            public System.String S3Prefix { get; set; }
            public Amazon.DynamoDBv2.S3SseAlgorithm S3SseAlgorithm { get; set; }
            public System.String S3SseKmsKeyId { get; set; }
            public System.String TableArn { get; set; }
            public System.Func<Amazon.DynamoDBv2.Model.ExportTableToPointInTimeResponse, ExportDDBTableToPointInTimeCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.ExportDescription;
        }
        
    }
}
