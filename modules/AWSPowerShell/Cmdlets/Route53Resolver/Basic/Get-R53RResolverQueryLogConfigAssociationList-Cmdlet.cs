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
    /// Lists information about associations between Amazon VPCs and query logging configurations.<br/><br/>This cmdlet automatically pages all available results to the pipeline - parameters related to iteration are only needed if you want to manually control the paginated output. To disable autopagination, use -NoAutoIteration.
    /// </summary>
    [Cmdlet("Get", "R53RResolverQueryLogConfigAssociationList")]
    [OutputType("Amazon.Route53Resolver.Model.ListResolverQueryLogConfigAssociationsResponse")]
    [AWSCmdlet("Calls the Amazon Route 53 Resolver ListResolverQueryLogConfigAssociations API operation.", Operation = new[] {"ListResolverQueryLogConfigAssociations"}, SelectReturnType = typeof(Amazon.Route53Resolver.Model.ListResolverQueryLogConfigAssociationsResponse))]
    [AWSCmdletOutput("Amazon.Route53Resolver.Model.ListResolverQueryLogConfigAssociationsResponse",
        "This cmdlet returns an Amazon.Route53Resolver.Model.ListResolverQueryLogConfigAssociationsResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetR53RResolverQueryLogConfigAssociationListCmdlet : AmazonRoute53ResolverClientCmdlet, IExecutor
    {
        
        #region Parameter Filter
        /// <summary>
        /// <para>
        /// <para>An optional specification to return a subset of query logging associations.</para><note><para>If you submit a second or subsequent <code>ListResolverQueryLogConfigAssociations</code>
        /// request and specify the <code>NextToken</code> parameter, you must use the same values
        /// for <code>Filters</code>, if any, as in the previous request.</para></note>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Filters")]
        public Amazon.Route53Resolver.Model.Filter[] Filter { get; set; }
        #endregion
        
        #region Parameter SortBy
        /// <summary>
        /// <para>
        /// <para>The element that you want Resolver to sort query logging associations by. </para><note><para>If you submit a second or subsequent <code>ListResolverQueryLogConfigAssociations</code>
        /// request and specify the <code>NextToken</code> parameter, you must use the same value
        /// for <code>SortBy</code>, if any, as in the previous request.</para></note><para>Valid values include the following elements:</para><ul><li><para><code>CreationTime</code>: The ID of the query logging association.</para></li><li><para><code>Error</code>: If the value of <code>Status</code> is <code>FAILED</code>, the
        /// value of <code>Error</code> indicates the cause: </para><ul><li><para><code>DESTINATION_NOT_FOUND</code>: The specified destination (for example, an Amazon
        /// S3 bucket) was deleted.</para></li><li><para><code>ACCESS_DENIED</code>: Permissions don't allow sending logs to the destination.</para></li></ul><para>If <code>Status</code> is a value other than <code>FAILED</code>, <code>ERROR</code>
        /// is null.</para></li><li><para><code>Id</code>: The ID of the query logging association</para></li><li><para><code>ResolverQueryLogConfigId</code>: The ID of the query logging configuration</para></li><li><para><code>ResourceId</code>: The ID of the VPC that is associated with the query logging
        /// configuration</para></li><li><para><code>Status</code>: The current status of the configuration. Valid values include
        /// the following:</para><ul><li><para><code>CREATING</code>: Resolver is creating an association between an Amazon VPC
        /// and a query logging configuration.</para></li><li><para><code>CREATED</code>: The association between an Amazon VPC and a query logging configuration
        /// was successfully created. Resolver is logging queries that originate in the specified
        /// VPC.</para></li><li><para><code>DELETING</code>: Resolver is deleting this query logging association.</para></li><li><para><code>FAILED</code>: Resolver either couldn't create or couldn't delete the query
        /// logging association. Here are two common causes:</para><ul><li><para>The specified destination (for example, an Amazon S3 bucket) was deleted.</para></li><li><para>Permissions don't allow sending logs to the destination.</para></li></ul></li></ul></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String SortBy { get; set; }
        #endregion
        
        #region Parameter SortOrder
        /// <summary>
        /// <para>
        /// <para>If you specified a value for <code>SortBy</code>, the order that you want query logging
        /// associations to be listed in, <code>ASCENDING</code> or <code>DESCENDING</code>.</para><note><para>If you submit a second or subsequent <code>ListResolverQueryLogConfigAssociations</code>
        /// request and specify the <code>NextToken</code> parameter, you must use the same value
        /// for <code>SortOrder</code>, if any, as in the previous request.</para></note>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.Route53Resolver.SortOrder")]
        public Amazon.Route53Resolver.SortOrder SortOrder { get; set; }
        #endregion
        
        #region Parameter MaxResult
        /// <summary>
        /// <para>
        /// <para>The maximum number of query logging associations that you want to return in the response
        /// to a <code>ListResolverQueryLogConfigAssociations</code> request. If you don't specify
        /// a value for <code>MaxResults</code>, Resolver returns up to 100 query logging associations.
        /// </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MaxResults")]
        public System.Int32? MaxResult { get; set; }
        #endregion
        
        #region Parameter NextToken
        /// <summary>
        /// <para>
        /// <para>For the first <code>ListResolverQueryLogConfigAssociations</code> request, omit this
        /// value.</para><para>If there are more than <code>MaxResults</code> query logging associations that match
        /// the values that you specify for <code>Filters</code>, you can submit another <code>ListResolverQueryLogConfigAssociations</code>
        /// request to get the next group of associations. In the next request, specify the value
        /// of <code>NextToken</code> from the previous response. </para>
        /// </para>
        /// <para>
        /// <br/><b>Note:</b> This parameter is only used if you are manually controlling output pagination of the service API call.
        /// <br/>In order to manually control output pagination, use '-NextToken $null' for the first call and '-NextToken $AWSHistory.LastServiceResponse.NextToken' for subsequent calls.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NextToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Route53Resolver.Model.ListResolverQueryLogConfigAssociationsResponse).
        /// Specifying the name of a property of type Amazon.Route53Resolver.Model.ListResolverQueryLogConfigAssociationsResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter NoAutoIteration
        /// <summary>
        /// By default the cmdlet will auto-iterate and retrieve all results to the pipeline by performing multiple
        /// service calls. If set, the cmdlet will retrieve only the next 'page' of results using the value of NextToken
        /// as the start point.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter NoAutoIteration { get; set; }
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
                context.Select = CreateSelectDelegate<Amazon.Route53Resolver.Model.ListResolverQueryLogConfigAssociationsResponse, GetR53RResolverQueryLogConfigAssociationListCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            if (this.Filter != null)
            {
                context.Filter = new List<Amazon.Route53Resolver.Model.Filter>(this.Filter);
            }
            context.MaxResult = this.MaxResult;
            context.NextToken = this.NextToken;
            context.SortBy = this.SortBy;
            context.SortOrder = this.SortOrder;
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            var useParameterSelect = this.Select.StartsWith("^");
            
            // create request and set iteration invariants
            var request = new Amazon.Route53Resolver.Model.ListResolverQueryLogConfigAssociationsRequest();
            
            if (cmdletContext.Filter != null)
            {
                request.Filters = cmdletContext.Filter;
            }
            if (cmdletContext.MaxResult != null)
            {
                request.MaxResults = cmdletContext.MaxResult.Value;
            }
            if (cmdletContext.SortBy != null)
            {
                request.SortBy = cmdletContext.SortBy;
            }
            if (cmdletContext.SortOrder != null)
            {
                request.SortOrder = cmdletContext.SortOrder;
            }
            
            // Initialize loop variant and commence piping
            var _nextToken = cmdletContext.NextToken;
            var _userControllingPaging = this.NoAutoIteration.IsPresent || ParameterWasBound(nameof(this.NextToken));
            
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            do
            {
                request.NextToken = _nextToken;
                
                CmdletOutput output;
                
                try
                {
                    
                    var response = CallAWSServiceOperation(client, request);
                    
                    object pipelineOutput = null;
                    if (!useParameterSelect)
                    {
                        pipelineOutput = cmdletContext.Select(response, this);
                    }
                    output = new CmdletOutput
                    {
                        PipelineOutput = pipelineOutput,
                        ServiceResponse = response
                    };
                    
                    _nextToken = response.NextToken;
                }
                catch (Exception e)
                {
                    output = new CmdletOutput { ErrorResponse = e };
                }
                
                ProcessOutput(output);
                
            } while (!_userControllingPaging && AutoIterationHelpers.HasValue(_nextToken));
            
            if (useParameterSelect)
            {
                WriteObject(cmdletContext.Select(null, this));
            }
            
            
            return null;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.Route53Resolver.Model.ListResolverQueryLogConfigAssociationsResponse CallAWSServiceOperation(IAmazonRoute53Resolver client, Amazon.Route53Resolver.Model.ListResolverQueryLogConfigAssociationsRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Route 53 Resolver", "ListResolverQueryLogConfigAssociations");
            try
            {
                #if DESKTOP
                return client.ListResolverQueryLogConfigAssociations(request);
                #elif CORECLR
                return client.ListResolverQueryLogConfigAssociationsAsync(request).GetAwaiter().GetResult();
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
            public List<Amazon.Route53Resolver.Model.Filter> Filter { get; set; }
            public System.Int32? MaxResult { get; set; }
            public System.String NextToken { get; set; }
            public System.String SortBy { get; set; }
            public Amazon.Route53Resolver.SortOrder SortOrder { get; set; }
            public System.Func<Amazon.Route53Resolver.Model.ListResolverQueryLogConfigAssociationsResponse, GetR53RResolverQueryLogConfigAssociationListCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
