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
using Amazon.KendraRanking;
using Amazon.KendraRanking.Model;

namespace Amazon.PowerShell.Cmdlets.KNRK
{
    /// <summary>
    /// Lists your rescore execution plans. A rescore execution plan is an Amazon Kendra Intelligent
    /// Ranking resource used for provisioning the <code>Rescore</code> API.
    /// </summary>
    [Cmdlet("Get", "KNRKRescoreExecutionPlanList")]
    [OutputType("Amazon.KendraRanking.Model.RescoreExecutionPlanSummary")]
    [AWSCmdlet("Calls the Amazon Kendra Intelligent Ranking ListRescoreExecutionPlans API operation.", Operation = new[] {"ListRescoreExecutionPlans"}, SelectReturnType = typeof(Amazon.KendraRanking.Model.ListRescoreExecutionPlansResponse))]
    [AWSCmdletOutput("Amazon.KendraRanking.Model.RescoreExecutionPlanSummary or Amazon.KendraRanking.Model.ListRescoreExecutionPlansResponse",
        "This cmdlet returns a collection of Amazon.KendraRanking.Model.RescoreExecutionPlanSummary objects.",
        "The service call response (type Amazon.KendraRanking.Model.ListRescoreExecutionPlansResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetKNRKRescoreExecutionPlanListCmdlet : AmazonKendraRankingClientCmdlet, IExecutor
    {
        
        #region Parameter MaxResult
        /// <summary>
        /// <para>
        /// <para>The maximum number of rescore execution plans to return.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MaxResults")]
        public System.Int32? MaxResult { get; set; }
        #endregion
        
        #region Parameter NextToken
        /// <summary>
        /// <para>
        /// <para>If the response is truncated, Amazon Kendra Intelligent Ranking returns a pagination
        /// token in the response. You can use this pagination token to retrieve the next set
        /// of rescore execution plans.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NextToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'SummaryItems'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.KendraRanking.Model.ListRescoreExecutionPlansResponse).
        /// Specifying the name of a property of type Amazon.KendraRanking.Model.ListRescoreExecutionPlansResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "SummaryItems";
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
                context.Select = CreateSelectDelegate<Amazon.KendraRanking.Model.ListRescoreExecutionPlansResponse, GetKNRKRescoreExecutionPlanListCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            context.MaxResult = this.MaxResult;
            context.NextToken = this.NextToken;
            
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
            var request = new Amazon.KendraRanking.Model.ListRescoreExecutionPlansRequest();
            
            if (cmdletContext.MaxResult != null)
            {
                request.MaxResults = cmdletContext.MaxResult.Value;
            }
            if (cmdletContext.NextToken != null)
            {
                request.NextToken = cmdletContext.NextToken;
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
        
        private Amazon.KendraRanking.Model.ListRescoreExecutionPlansResponse CallAWSServiceOperation(IAmazonKendraRanking client, Amazon.KendraRanking.Model.ListRescoreExecutionPlansRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Kendra Intelligent Ranking", "ListRescoreExecutionPlans");
            try
            {
                #if DESKTOP
                return client.ListRescoreExecutionPlans(request);
                #elif CORECLR
                return client.ListRescoreExecutionPlansAsync(request).GetAwaiter().GetResult();
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
            public System.Int32? MaxResult { get; set; }
            public System.String NextToken { get; set; }
            public System.Func<Amazon.KendraRanking.Model.ListRescoreExecutionPlansResponse, GetKNRKRescoreExecutionPlanListCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.SummaryItems;
        }
        
    }
}
