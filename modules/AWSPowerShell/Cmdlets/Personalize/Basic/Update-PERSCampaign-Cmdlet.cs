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
using Amazon.Personalize;
using Amazon.Personalize.Model;

namespace Amazon.PowerShell.Cmdlets.PERS
{
    /// <summary>
    /// Updates a campaign by either deploying a new solution or changing the value of the
    /// campaign's <code>minProvisionedTPS</code> parameter.
    /// 
    ///  
    /// <para>
    /// To update a campaign, the campaign status must be ACTIVE or CREATE FAILED. Check the
    /// campaign status using the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeCampaign.html">DescribeCampaign</a>
    /// operation.
    /// </para><note><para>
    /// You can still get recommendations from a campaign while an update is in progress.
    /// The campaign will use the previous solution version and campaign configuration to
    /// generate recommendations until the latest campaign update status is <code>Active</code>.
    /// 
    /// </para></note><para>
    /// For more information on campaigns, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateCampaign.html">CreateCampaign</a>.
    /// </para>
    /// </summary>
    [Cmdlet("Update", "PERSCampaign", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the AWS Personalize UpdateCampaign API operation.", Operation = new[] {"UpdateCampaign"}, SelectReturnType = typeof(Amazon.Personalize.Model.UpdateCampaignResponse))]
    [AWSCmdletOutput("System.String or Amazon.Personalize.Model.UpdateCampaignResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.Personalize.Model.UpdateCampaignResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class UpdatePERSCampaignCmdlet : AmazonPersonalizeClientCmdlet, IExecutor
    {
        
        #region Parameter CampaignArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the campaign.</para>
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
        public System.String CampaignArn { get; set; }
        #endregion
        
        #region Parameter CampaignConfig_ItemExplorationConfig
        /// <summary>
        /// <para>
        /// <para>Specifies the exploration configuration hyperparameters, including <code>explorationWeight</code>
        /// and <code>explorationItemAgeCutOff</code>, you want to use to configure the amount
        /// of item exploration Amazon Personalize uses when recommending items. Provide <code>itemExplorationConfig</code>
        /// data only if your solution uses the <a href="https://docs.aws.amazon.com/personalize/latest/dg/native-recipe-new-item-USER_PERSONALIZATION.html">User-Personalization</a>
        /// recipe.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Collections.Hashtable CampaignConfig_ItemExplorationConfig { get; set; }
        #endregion
        
        #region Parameter MinProvisionedTPS
        /// <summary>
        /// <para>
        /// <para>Specifies the requested minimum provisioned transactions (recommendations) per second
        /// that Amazon Personalize will support. A high <code>minProvisionedTPS</code> will increase
        /// your bill. We recommend starting with 1 for <code>minProvisionedTPS</code> (the default).
        /// Track your usage using Amazon CloudWatch metrics, and increase the <code>minProvisionedTPS</code>
        /// as necessary.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? MinProvisionedTPS { get; set; }
        #endregion
        
        #region Parameter SolutionVersionArn
        /// <summary>
        /// <para>
        /// <para>The ARN of a new solution version to deploy.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String SolutionVersionArn { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'CampaignArn'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Personalize.Model.UpdateCampaignResponse).
        /// Specifying the name of a property of type Amazon.Personalize.Model.UpdateCampaignResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "CampaignArn";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the CampaignArn parameter.
        /// The -PassThru parameter is deprecated, use -Select '^CampaignArn' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^CampaignArn' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.CampaignArn), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-PERSCampaign (UpdateCampaign)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Personalize.Model.UpdateCampaignResponse, UpdatePERSCampaignCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.CampaignArn;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.CampaignArn = this.CampaignArn;
            #if MODULAR
            if (this.CampaignArn == null && ParameterWasBound(nameof(this.CampaignArn)))
            {
                WriteWarning("You are passing $null as a value for parameter CampaignArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.CampaignConfig_ItemExplorationConfig != null)
            {
                context.CampaignConfig_ItemExplorationConfig = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.CampaignConfig_ItemExplorationConfig.Keys)
                {
                    context.CampaignConfig_ItemExplorationConfig.Add((String)hashKey, (String)(this.CampaignConfig_ItemExplorationConfig[hashKey]));
                }
            }
            context.MinProvisionedTPS = this.MinProvisionedTPS;
            context.SolutionVersionArn = this.SolutionVersionArn;
            
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
            var request = new Amazon.Personalize.Model.UpdateCampaignRequest();
            
            if (cmdletContext.CampaignArn != null)
            {
                request.CampaignArn = cmdletContext.CampaignArn;
            }
            
             // populate CampaignConfig
            var requestCampaignConfigIsNull = true;
            request.CampaignConfig = new Amazon.Personalize.Model.CampaignConfig();
            Dictionary<System.String, System.String> requestCampaignConfig_campaignConfig_ItemExplorationConfig = null;
            if (cmdletContext.CampaignConfig_ItemExplorationConfig != null)
            {
                requestCampaignConfig_campaignConfig_ItemExplorationConfig = cmdletContext.CampaignConfig_ItemExplorationConfig;
            }
            if (requestCampaignConfig_campaignConfig_ItemExplorationConfig != null)
            {
                request.CampaignConfig.ItemExplorationConfig = requestCampaignConfig_campaignConfig_ItemExplorationConfig;
                requestCampaignConfigIsNull = false;
            }
             // determine if request.CampaignConfig should be set to null
            if (requestCampaignConfigIsNull)
            {
                request.CampaignConfig = null;
            }
            if (cmdletContext.MinProvisionedTPS != null)
            {
                request.MinProvisionedTPS = cmdletContext.MinProvisionedTPS.Value;
            }
            if (cmdletContext.SolutionVersionArn != null)
            {
                request.SolutionVersionArn = cmdletContext.SolutionVersionArn;
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
        
        private Amazon.Personalize.Model.UpdateCampaignResponse CallAWSServiceOperation(IAmazonPersonalize client, Amazon.Personalize.Model.UpdateCampaignRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Personalize", "UpdateCampaign");
            try
            {
                #if DESKTOP
                return client.UpdateCampaign(request);
                #elif CORECLR
                return client.UpdateCampaignAsync(request).GetAwaiter().GetResult();
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
            public System.String CampaignArn { get; set; }
            public Dictionary<System.String, System.String> CampaignConfig_ItemExplorationConfig { get; set; }
            public System.Int32? MinProvisionedTPS { get; set; }
            public System.String SolutionVersionArn { get; set; }
            public System.Func<Amazon.Personalize.Model.UpdateCampaignResponse, UpdatePERSCampaignCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.CampaignArn;
        }
        
    }
}
