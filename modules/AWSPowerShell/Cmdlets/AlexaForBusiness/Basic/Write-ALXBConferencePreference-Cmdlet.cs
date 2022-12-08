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
using Amazon.AlexaForBusiness;
using Amazon.AlexaForBusiness.Model;

namespace Amazon.PowerShell.Cmdlets.ALXB
{
    /// <summary>
    /// Sets the conference preferences on a specific conference provider at the account level.
    /// </summary>
    [Cmdlet("Write", "ALXBConferencePreference", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("None")]
    [AWSCmdlet("Calls the Alexa For Business PutConferencePreference API operation.", Operation = new[] {"PutConferencePreference"}, SelectReturnType = typeof(Amazon.AlexaForBusiness.Model.PutConferencePreferenceResponse))]
    [AWSCmdletOutput("None or Amazon.AlexaForBusiness.Model.PutConferencePreferenceResponse",
        "This cmdlet does not generate any output." +
        "The service response (type Amazon.AlexaForBusiness.Model.PutConferencePreferenceResponse) can be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class WriteALXBConferencePreferenceCmdlet : AmazonAlexaForBusinessClientCmdlet, IExecutor
    {
        
        #region Parameter ConferencePreference_DefaultConferenceProviderArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the default conference provider.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        public System.String ConferencePreference_DefaultConferenceProviderArn { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The cmdlet doesn't have a return value by default.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.AlexaForBusiness.Model.PutConferencePreferenceResponse).
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the ConferencePreference_DefaultConferenceProviderArn parameter.
        /// The -PassThru parameter is deprecated, use -Select '^ConferencePreference_DefaultConferenceProviderArn' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^ConferencePreference_DefaultConferenceProviderArn' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.ConferencePreference_DefaultConferenceProviderArn), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Write-ALXBConferencePreference (PutConferencePreference)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.AlexaForBusiness.Model.PutConferencePreferenceResponse, WriteALXBConferencePreferenceCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.ConferencePreference_DefaultConferenceProviderArn;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ConferencePreference_DefaultConferenceProviderArn = this.ConferencePreference_DefaultConferenceProviderArn;
            
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
            var request = new Amazon.AlexaForBusiness.Model.PutConferencePreferenceRequest();
            
            
             // populate ConferencePreference
            var requestConferencePreferenceIsNull = true;
            request.ConferencePreference = new Amazon.AlexaForBusiness.Model.ConferencePreference();
            System.String requestConferencePreference_conferencePreference_DefaultConferenceProviderArn = null;
            if (cmdletContext.ConferencePreference_DefaultConferenceProviderArn != null)
            {
                requestConferencePreference_conferencePreference_DefaultConferenceProviderArn = cmdletContext.ConferencePreference_DefaultConferenceProviderArn;
            }
            if (requestConferencePreference_conferencePreference_DefaultConferenceProviderArn != null)
            {
                request.ConferencePreference.DefaultConferenceProviderArn = requestConferencePreference_conferencePreference_DefaultConferenceProviderArn;
                requestConferencePreferenceIsNull = false;
            }
             // determine if request.ConferencePreference should be set to null
            if (requestConferencePreferenceIsNull)
            {
                request.ConferencePreference = null;
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
        
        private Amazon.AlexaForBusiness.Model.PutConferencePreferenceResponse CallAWSServiceOperation(IAmazonAlexaForBusiness client, Amazon.AlexaForBusiness.Model.PutConferencePreferenceRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Alexa For Business", "PutConferencePreference");
            try
            {
                #if DESKTOP
                return client.PutConferencePreference(request);
                #elif CORECLR
                return client.PutConferencePreferenceAsync(request).GetAwaiter().GetResult();
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
            public System.String ConferencePreference_DefaultConferenceProviderArn { get; set; }
            public System.Func<Amazon.AlexaForBusiness.Model.PutConferencePreferenceResponse, WriteALXBConferencePreferenceCmdlet, object> Select { get; set; } =
                (response, cmdlet) => null;
        }
        
    }
}
