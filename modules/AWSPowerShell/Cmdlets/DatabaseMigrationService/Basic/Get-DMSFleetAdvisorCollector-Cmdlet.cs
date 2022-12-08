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
using Amazon.DatabaseMigrationService;
using Amazon.DatabaseMigrationService.Model;

namespace Amazon.PowerShell.Cmdlets.DMS
{
    /// <summary>
    /// Returns a list of the Fleet Advisor collectors in your account.
    /// </summary>
    [Cmdlet("Get", "DMSFleetAdvisorCollector")]
    [OutputType("Amazon.DatabaseMigrationService.Model.CollectorResponse")]
    [AWSCmdlet("Calls the AWS Database Migration Service DescribeFleetAdvisorCollectors API operation.", Operation = new[] {"DescribeFleetAdvisorCollectors"}, SelectReturnType = typeof(Amazon.DatabaseMigrationService.Model.DescribeFleetAdvisorCollectorsResponse))]
    [AWSCmdletOutput("Amazon.DatabaseMigrationService.Model.CollectorResponse or Amazon.DatabaseMigrationService.Model.DescribeFleetAdvisorCollectorsResponse",
        "This cmdlet returns a collection of Amazon.DatabaseMigrationService.Model.CollectorResponse objects.",
        "The service call response (type Amazon.DatabaseMigrationService.Model.DescribeFleetAdvisorCollectorsResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetDMSFleetAdvisorCollectorCmdlet : AmazonDatabaseMigrationServiceClientCmdlet, IExecutor
    {
        
        #region Parameter Filter
        /// <summary>
        /// <para>
        /// <para> If you specify any of the following filters, the output includes information for
        /// only those collectors that meet the filter criteria:</para><ul><li><para><code>collector-referenced-id</code> – The ID of the collector agent, for example
        /// <code>d4610ac5-e323-4ad9-bc50-eaf7249dfe9d</code>.</para></li><li><para><code>collector-name</code> – The name of the collector agent.</para></li></ul><para>An example is: <code>describe-fleet-advisor-collectors --filter Name="collector-referenced-id",Values="d4610ac5-e323-4ad9-bc50-eaf7249dfe9d"</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Filters")]
        public Amazon.DatabaseMigrationService.Model.Filter[] Filter { get; set; }
        #endregion
        
        #region Parameter MaxRecord
        /// <summary>
        /// <para>
        /// <para>Sets the maximum number of records returned in the response.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MaxRecords")]
        public System.Int32? MaxRecord { get; set; }
        #endregion
        
        #region Parameter NextToken
        /// <summary>
        /// <para>
        /// <para>If <code>NextToken</code> is returned by a previous response, there are more results
        /// available. The value of <code>NextToken</code> is a unique pagination token for each
        /// page. Make the call again using the returned token to retrieve the next page. Keep
        /// all other arguments unchanged. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NextToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Collectors'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.DatabaseMigrationService.Model.DescribeFleetAdvisorCollectorsResponse).
        /// Specifying the name of a property of type Amazon.DatabaseMigrationService.Model.DescribeFleetAdvisorCollectorsResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Collectors";
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
                context.Select = CreateSelectDelegate<Amazon.DatabaseMigrationService.Model.DescribeFleetAdvisorCollectorsResponse, GetDMSFleetAdvisorCollectorCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            if (this.Filter != null)
            {
                context.Filter = new List<Amazon.DatabaseMigrationService.Model.Filter>(this.Filter);
            }
            context.MaxRecord = this.MaxRecord;
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
            var request = new Amazon.DatabaseMigrationService.Model.DescribeFleetAdvisorCollectorsRequest();
            
            if (cmdletContext.Filter != null)
            {
                request.Filters = cmdletContext.Filter;
            }
            if (cmdletContext.MaxRecord != null)
            {
                request.MaxRecords = cmdletContext.MaxRecord.Value;
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
        
        private Amazon.DatabaseMigrationService.Model.DescribeFleetAdvisorCollectorsResponse CallAWSServiceOperation(IAmazonDatabaseMigrationService client, Amazon.DatabaseMigrationService.Model.DescribeFleetAdvisorCollectorsRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Database Migration Service", "DescribeFleetAdvisorCollectors");
            try
            {
                #if DESKTOP
                return client.DescribeFleetAdvisorCollectors(request);
                #elif CORECLR
                return client.DescribeFleetAdvisorCollectorsAsync(request).GetAwaiter().GetResult();
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
            public List<Amazon.DatabaseMigrationService.Model.Filter> Filter { get; set; }
            public System.Int32? MaxRecord { get; set; }
            public System.String NextToken { get; set; }
            public System.Func<Amazon.DatabaseMigrationService.Model.DescribeFleetAdvisorCollectorsResponse, GetDMSFleetAdvisorCollectorCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Collectors;
        }
        
    }
}
