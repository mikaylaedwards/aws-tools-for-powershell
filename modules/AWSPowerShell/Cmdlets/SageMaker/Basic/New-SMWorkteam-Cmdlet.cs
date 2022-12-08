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
using Amazon.SageMaker;
using Amazon.SageMaker.Model;

namespace Amazon.PowerShell.Cmdlets.SM
{
    /// <summary>
    /// Creates a new work team for labeling your data. A work team is defined by one or more
    /// Amazon Cognito user pools. You must first create the user pools before you can create
    /// a work team.
    /// 
    ///  
    /// <para>
    /// You cannot create more than 25 work teams in an account and region.
    /// </para>
    /// </summary>
    [Cmdlet("New", "SMWorkteam", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the Amazon SageMaker Service CreateWorkteam API operation.", Operation = new[] {"CreateWorkteam"}, SelectReturnType = typeof(Amazon.SageMaker.Model.CreateWorkteamResponse))]
    [AWSCmdletOutput("System.String or Amazon.SageMaker.Model.CreateWorkteamResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.SageMaker.Model.CreateWorkteamResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewSMWorkteamCmdlet : AmazonSageMakerClientCmdlet, IExecutor
    {
        
        #region Parameter Description
        /// <summary>
        /// <para>
        /// <para>A description of the work team.</para>
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
        public System.String Description { get; set; }
        #endregion
        
        #region Parameter MemberDefinition
        /// <summary>
        /// <para>
        /// <para>A list of <code>MemberDefinition</code> objects that contains objects that identify
        /// the workers that make up the work team. </para><para>Workforces can be created using Amazon Cognito or your own OIDC Identity Provider
        /// (IdP). For private workforces created using Amazon Cognito use <code>CognitoMemberDefinition</code>.
        /// For workforces created using your own OIDC identity provider (IdP) use <code>OidcMemberDefinition</code>.
        /// Do not provide input for both of these parameters in a single request.</para><para>For workforces created using Amazon Cognito, private work teams correspond to Amazon
        /// Cognito <i>user groups</i> within the user pool used to create a workforce. All of
        /// the <code>CognitoMemberDefinition</code> objects that make up the member definition
        /// must have the same <code>ClientId</code> and <code>UserPool</code> values. To add
        /// a Amazon Cognito user group to an existing worker pool, see <a href="">Adding groups
        /// to a User Pool</a>. For more information about user pools, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools.html">Amazon
        /// Cognito User Pools</a>.</para><para>For workforces created using your own OIDC IdP, specify the user groups that you want
        /// to include in your private work team in <code>OidcMemberDefinition</code> by listing
        /// those groups in <code>Groups</code>.</para>
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
        [Alias("MemberDefinitions")]
        public Amazon.SageMaker.Model.MemberDefinition[] MemberDefinition { get; set; }
        #endregion
        
        #region Parameter NotificationConfiguration_NotificationTopicArn
        /// <summary>
        /// <para>
        /// <para>The ARN for the Amazon SNS topic to which notifications should be published.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NotificationConfiguration_NotificationTopicArn { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>An array of key-value pairs.</para><para>For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resource-tags.html">Resource
        /// Tag</a> and <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html#allocation-what">Using
        /// Cost Allocation Tags</a> in the <i> Amazon Web Services Billing and Cost Management
        /// User Guide</i>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.SageMaker.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter WorkforceName
        /// <summary>
        /// <para>
        /// <para>The name of the workforce.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String WorkforceName { get; set; }
        #endregion
        
        #region Parameter WorkteamName
        /// <summary>
        /// <para>
        /// <para>The name of the work team. Use this name to identify the work team.</para>
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
        public System.String WorkteamName { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'WorkteamArn'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.SageMaker.Model.CreateWorkteamResponse).
        /// Specifying the name of a property of type Amazon.SageMaker.Model.CreateWorkteamResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "WorkteamArn";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the WorkteamName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^WorkteamName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^WorkteamName' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.WorkteamName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-SMWorkteam (CreateWorkteam)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.SageMaker.Model.CreateWorkteamResponse, NewSMWorkteamCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.WorkteamName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.Description = this.Description;
            #if MODULAR
            if (this.Description == null && ParameterWasBound(nameof(this.Description)))
            {
                WriteWarning("You are passing $null as a value for parameter Description which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.MemberDefinition != null)
            {
                context.MemberDefinition = new List<Amazon.SageMaker.Model.MemberDefinition>(this.MemberDefinition);
            }
            #if MODULAR
            if (this.MemberDefinition == null && ParameterWasBound(nameof(this.MemberDefinition)))
            {
                WriteWarning("You are passing $null as a value for parameter MemberDefinition which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.NotificationConfiguration_NotificationTopicArn = this.NotificationConfiguration_NotificationTopicArn;
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.SageMaker.Model.Tag>(this.Tag);
            }
            context.WorkforceName = this.WorkforceName;
            context.WorkteamName = this.WorkteamName;
            #if MODULAR
            if (this.WorkteamName == null && ParameterWasBound(nameof(this.WorkteamName)))
            {
                WriteWarning("You are passing $null as a value for parameter WorkteamName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.SageMaker.Model.CreateWorkteamRequest();
            
            if (cmdletContext.Description != null)
            {
                request.Description = cmdletContext.Description;
            }
            if (cmdletContext.MemberDefinition != null)
            {
                request.MemberDefinitions = cmdletContext.MemberDefinition;
            }
            
             // populate NotificationConfiguration
            var requestNotificationConfigurationIsNull = true;
            request.NotificationConfiguration = new Amazon.SageMaker.Model.NotificationConfiguration();
            System.String requestNotificationConfiguration_notificationConfiguration_NotificationTopicArn = null;
            if (cmdletContext.NotificationConfiguration_NotificationTopicArn != null)
            {
                requestNotificationConfiguration_notificationConfiguration_NotificationTopicArn = cmdletContext.NotificationConfiguration_NotificationTopicArn;
            }
            if (requestNotificationConfiguration_notificationConfiguration_NotificationTopicArn != null)
            {
                request.NotificationConfiguration.NotificationTopicArn = requestNotificationConfiguration_notificationConfiguration_NotificationTopicArn;
                requestNotificationConfigurationIsNull = false;
            }
             // determine if request.NotificationConfiguration should be set to null
            if (requestNotificationConfigurationIsNull)
            {
                request.NotificationConfiguration = null;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            if (cmdletContext.WorkforceName != null)
            {
                request.WorkforceName = cmdletContext.WorkforceName;
            }
            if (cmdletContext.WorkteamName != null)
            {
                request.WorkteamName = cmdletContext.WorkteamName;
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
        
        private Amazon.SageMaker.Model.CreateWorkteamResponse CallAWSServiceOperation(IAmazonSageMaker client, Amazon.SageMaker.Model.CreateWorkteamRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon SageMaker Service", "CreateWorkteam");
            try
            {
                #if DESKTOP
                return client.CreateWorkteam(request);
                #elif CORECLR
                return client.CreateWorkteamAsync(request).GetAwaiter().GetResult();
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
            public System.String Description { get; set; }
            public List<Amazon.SageMaker.Model.MemberDefinition> MemberDefinition { get; set; }
            public System.String NotificationConfiguration_NotificationTopicArn { get; set; }
            public List<Amazon.SageMaker.Model.Tag> Tag { get; set; }
            public System.String WorkforceName { get; set; }
            public System.String WorkteamName { get; set; }
            public System.Func<Amazon.SageMaker.Model.CreateWorkteamResponse, NewSMWorkteamCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.WorkteamArn;
        }
        
    }
}
