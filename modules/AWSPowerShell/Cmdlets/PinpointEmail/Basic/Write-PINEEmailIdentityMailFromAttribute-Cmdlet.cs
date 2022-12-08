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
using Amazon.PinpointEmail;
using Amazon.PinpointEmail.Model;

namespace Amazon.PowerShell.Cmdlets.PINE
{
    /// <summary>
    /// Used to enable or disable the custom Mail-From domain configuration for an email identity.
    /// </summary>
    [Cmdlet("Write", "PINEEmailIdentityMailFromAttribute", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("None")]
    [AWSCmdlet("Calls the Amazon Pinpoint Email PutEmailIdentityMailFromAttributes API operation.", Operation = new[] {"PutEmailIdentityMailFromAttributes"}, SelectReturnType = typeof(Amazon.PinpointEmail.Model.PutEmailIdentityMailFromAttributesResponse))]
    [AWSCmdletOutput("None or Amazon.PinpointEmail.Model.PutEmailIdentityMailFromAttributesResponse",
        "This cmdlet does not generate any output." +
        "The service response (type Amazon.PinpointEmail.Model.PutEmailIdentityMailFromAttributesResponse) can be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class WritePINEEmailIdentityMailFromAttributeCmdlet : AmazonPinpointEmailClientCmdlet, IExecutor
    {
        
        #region Parameter BehaviorOnMxFailure
        /// <summary>
        /// <para>
        /// <para>The action that you want Amazon Pinpoint to take if it can't read the required MX
        /// record when you send an email. When you set this value to <code>UseDefaultValue</code>,
        /// Amazon Pinpoint uses <i>amazonses.com</i> as the MAIL FROM domain. When you set this
        /// value to <code>RejectMessage</code>, Amazon Pinpoint returns a <code>MailFromDomainNotVerified</code>
        /// error, and doesn't attempt to deliver the email.</para><para>These behaviors are taken when the custom MAIL FROM domain configuration is in the
        /// <code>Pending</code>, <code>Failed</code>, and <code>TemporaryFailure</code> states.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.PinpointEmail.BehaviorOnMxFailure")]
        public Amazon.PinpointEmail.BehaviorOnMxFailure BehaviorOnMxFailure { get; set; }
        #endregion
        
        #region Parameter EmailIdentity
        /// <summary>
        /// <para>
        /// <para>The verified email identity that you want to set up the custom MAIL FROM domain for.</para>
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
        public System.String EmailIdentity { get; set; }
        #endregion
        
        #region Parameter MailFromDomain
        /// <summary>
        /// <para>
        /// <para> The custom MAIL FROM domain that you want the verified identity to use. The MAIL
        /// FROM domain must meet the following criteria:</para><ul><li><para>It has to be a subdomain of the verified identity.</para></li><li><para>It can't be used to receive email.</para></li><li><para>It can't be used in a "From" address if the MAIL FROM domain is a destination for
        /// feedback forwarding emails.</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String MailFromDomain { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The cmdlet doesn't have a return value by default.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.PinpointEmail.Model.PutEmailIdentityMailFromAttributesResponse).
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the EmailIdentity parameter.
        /// The -PassThru parameter is deprecated, use -Select '^EmailIdentity' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^EmailIdentity' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.EmailIdentity), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Write-PINEEmailIdentityMailFromAttribute (PutEmailIdentityMailFromAttributes)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.PinpointEmail.Model.PutEmailIdentityMailFromAttributesResponse, WritePINEEmailIdentityMailFromAttributeCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.EmailIdentity;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.BehaviorOnMxFailure = this.BehaviorOnMxFailure;
            context.EmailIdentity = this.EmailIdentity;
            #if MODULAR
            if (this.EmailIdentity == null && ParameterWasBound(nameof(this.EmailIdentity)))
            {
                WriteWarning("You are passing $null as a value for parameter EmailIdentity which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.MailFromDomain = this.MailFromDomain;
            
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
            var request = new Amazon.PinpointEmail.Model.PutEmailIdentityMailFromAttributesRequest();
            
            if (cmdletContext.BehaviorOnMxFailure != null)
            {
                request.BehaviorOnMxFailure = cmdletContext.BehaviorOnMxFailure;
            }
            if (cmdletContext.EmailIdentity != null)
            {
                request.EmailIdentity = cmdletContext.EmailIdentity;
            }
            if (cmdletContext.MailFromDomain != null)
            {
                request.MailFromDomain = cmdletContext.MailFromDomain;
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
        
        private Amazon.PinpointEmail.Model.PutEmailIdentityMailFromAttributesResponse CallAWSServiceOperation(IAmazonPinpointEmail client, Amazon.PinpointEmail.Model.PutEmailIdentityMailFromAttributesRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Pinpoint Email", "PutEmailIdentityMailFromAttributes");
            try
            {
                #if DESKTOP
                return client.PutEmailIdentityMailFromAttributes(request);
                #elif CORECLR
                return client.PutEmailIdentityMailFromAttributesAsync(request).GetAwaiter().GetResult();
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
            public Amazon.PinpointEmail.BehaviorOnMxFailure BehaviorOnMxFailure { get; set; }
            public System.String EmailIdentity { get; set; }
            public System.String MailFromDomain { get; set; }
            public System.Func<Amazon.PinpointEmail.Model.PutEmailIdentityMailFromAttributesResponse, WritePINEEmailIdentityMailFromAttributeCmdlet, object> Select { get; set; } =
                (response, cmdlet) => null;
        }
        
    }
}
