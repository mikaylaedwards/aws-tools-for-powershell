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
    /// Adds a new conference provider under the user's AWS account.
    /// </summary>
    [Cmdlet("New", "ALXBConferenceProvider", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the Alexa For Business CreateConferenceProvider API operation.", Operation = new[] {"CreateConferenceProvider"}, SelectReturnType = typeof(Amazon.AlexaForBusiness.Model.CreateConferenceProviderResponse))]
    [AWSCmdletOutput("System.String or Amazon.AlexaForBusiness.Model.CreateConferenceProviderResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.AlexaForBusiness.Model.CreateConferenceProviderResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewALXBConferenceProviderCmdlet : AmazonAlexaForBusinessClientCmdlet, IExecutor
    {
        
        #region Parameter ClientRequestToken
        /// <summary>
        /// <para>
        /// <para>The request token of the client.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientRequestToken { get; set; }
        #endregion
        
        #region Parameter IPDialIn_CommsProtocol
        /// <summary>
        /// <para>
        /// <para>The protocol, including SIP, SIPS, and H323.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.AlexaForBusiness.CommsProtocol")]
        public Amazon.AlexaForBusiness.CommsProtocol IPDialIn_CommsProtocol { get; set; }
        #endregion
        
        #region Parameter ConferenceProviderName
        /// <summary>
        /// <para>
        /// <para>The name of the conference provider.</para>
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
        public System.String ConferenceProviderName { get; set; }
        #endregion
        
        #region Parameter ConferenceProviderType
        /// <summary>
        /// <para>
        /// <para>Represents a type within a list of predefined types.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.AlexaForBusiness.ConferenceProviderType")]
        public Amazon.AlexaForBusiness.ConferenceProviderType ConferenceProviderType { get; set; }
        #endregion
        
        #region Parameter PSTNDialIn_CountryCode
        /// <summary>
        /// <para>
        /// <para>The zip code.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String PSTNDialIn_CountryCode { get; set; }
        #endregion
        
        #region Parameter IPDialIn_Endpoint
        /// <summary>
        /// <para>
        /// <para>The IP address.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String IPDialIn_Endpoint { get; set; }
        #endregion
        
        #region Parameter PSTNDialIn_OneClickIdDelay
        /// <summary>
        /// <para>
        /// <para>The delay duration before Alexa enters the conference ID with dual-tone multi-frequency
        /// (DTMF). Each number on the dial pad corresponds to a DTMF tone, which is how we send
        /// data over the telephone network.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String PSTNDialIn_OneClickIdDelay { get; set; }
        #endregion
        
        #region Parameter PSTNDialIn_OneClickPinDelay
        /// <summary>
        /// <para>
        /// <para>The delay duration before Alexa enters the conference pin with dual-tone multi-frequency
        /// (DTMF). Each number on the dial pad corresponds to a DTMF tone, which is how we send
        /// data over the telephone network.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String PSTNDialIn_OneClickPinDelay { get; set; }
        #endregion
        
        #region Parameter PSTNDialIn_PhoneNumber
        /// <summary>
        /// <para>
        /// <para>The phone number to call to join the conference.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String PSTNDialIn_PhoneNumber { get; set; }
        #endregion
        
        #region Parameter MeetingSetting_RequirePin
        /// <summary>
        /// <para>
        /// <para>The values that indicate whether the pin is always required.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.AlexaForBusiness.RequirePin")]
        public Amazon.AlexaForBusiness.RequirePin MeetingSetting_RequirePin { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>The tags to be added to the specified resource. Do not provide system tags.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.AlexaForBusiness.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'ConferenceProviderArn'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.AlexaForBusiness.Model.CreateConferenceProviderResponse).
        /// Specifying the name of a property of type Amazon.AlexaForBusiness.Model.CreateConferenceProviderResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "ConferenceProviderArn";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the ConferenceProviderName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^ConferenceProviderName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^ConferenceProviderName' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.ConferenceProviderName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-ALXBConferenceProvider (CreateConferenceProvider)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.AlexaForBusiness.Model.CreateConferenceProviderResponse, NewALXBConferenceProviderCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.ConferenceProviderName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ClientRequestToken = this.ClientRequestToken;
            context.ConferenceProviderName = this.ConferenceProviderName;
            #if MODULAR
            if (this.ConferenceProviderName == null && ParameterWasBound(nameof(this.ConferenceProviderName)))
            {
                WriteWarning("You are passing $null as a value for parameter ConferenceProviderName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.ConferenceProviderType = this.ConferenceProviderType;
            #if MODULAR
            if (this.ConferenceProviderType == null && ParameterWasBound(nameof(this.ConferenceProviderType)))
            {
                WriteWarning("You are passing $null as a value for parameter ConferenceProviderType which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.IPDialIn_CommsProtocol = this.IPDialIn_CommsProtocol;
            context.IPDialIn_Endpoint = this.IPDialIn_Endpoint;
            context.MeetingSetting_RequirePin = this.MeetingSetting_RequirePin;
            #if MODULAR
            if (this.MeetingSetting_RequirePin == null && ParameterWasBound(nameof(this.MeetingSetting_RequirePin)))
            {
                WriteWarning("You are passing $null as a value for parameter MeetingSetting_RequirePin which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.PSTNDialIn_CountryCode = this.PSTNDialIn_CountryCode;
            context.PSTNDialIn_OneClickIdDelay = this.PSTNDialIn_OneClickIdDelay;
            context.PSTNDialIn_OneClickPinDelay = this.PSTNDialIn_OneClickPinDelay;
            context.PSTNDialIn_PhoneNumber = this.PSTNDialIn_PhoneNumber;
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.AlexaForBusiness.Model.Tag>(this.Tag);
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
            var request = new Amazon.AlexaForBusiness.Model.CreateConferenceProviderRequest();
            
            if (cmdletContext.ClientRequestToken != null)
            {
                request.ClientRequestToken = cmdletContext.ClientRequestToken;
            }
            if (cmdletContext.ConferenceProviderName != null)
            {
                request.ConferenceProviderName = cmdletContext.ConferenceProviderName;
            }
            if (cmdletContext.ConferenceProviderType != null)
            {
                request.ConferenceProviderType = cmdletContext.ConferenceProviderType;
            }
            
             // populate IPDialIn
            var requestIPDialInIsNull = true;
            request.IPDialIn = new Amazon.AlexaForBusiness.Model.IPDialIn();
            Amazon.AlexaForBusiness.CommsProtocol requestIPDialIn_iPDialIn_CommsProtocol = null;
            if (cmdletContext.IPDialIn_CommsProtocol != null)
            {
                requestIPDialIn_iPDialIn_CommsProtocol = cmdletContext.IPDialIn_CommsProtocol;
            }
            if (requestIPDialIn_iPDialIn_CommsProtocol != null)
            {
                request.IPDialIn.CommsProtocol = requestIPDialIn_iPDialIn_CommsProtocol;
                requestIPDialInIsNull = false;
            }
            System.String requestIPDialIn_iPDialIn_Endpoint = null;
            if (cmdletContext.IPDialIn_Endpoint != null)
            {
                requestIPDialIn_iPDialIn_Endpoint = cmdletContext.IPDialIn_Endpoint;
            }
            if (requestIPDialIn_iPDialIn_Endpoint != null)
            {
                request.IPDialIn.Endpoint = requestIPDialIn_iPDialIn_Endpoint;
                requestIPDialInIsNull = false;
            }
             // determine if request.IPDialIn should be set to null
            if (requestIPDialInIsNull)
            {
                request.IPDialIn = null;
            }
            
             // populate MeetingSetting
            var requestMeetingSettingIsNull = true;
            request.MeetingSetting = new Amazon.AlexaForBusiness.Model.MeetingSetting();
            Amazon.AlexaForBusiness.RequirePin requestMeetingSetting_meetingSetting_RequirePin = null;
            if (cmdletContext.MeetingSetting_RequirePin != null)
            {
                requestMeetingSetting_meetingSetting_RequirePin = cmdletContext.MeetingSetting_RequirePin;
            }
            if (requestMeetingSetting_meetingSetting_RequirePin != null)
            {
                request.MeetingSetting.RequirePin = requestMeetingSetting_meetingSetting_RequirePin;
                requestMeetingSettingIsNull = false;
            }
             // determine if request.MeetingSetting should be set to null
            if (requestMeetingSettingIsNull)
            {
                request.MeetingSetting = null;
            }
            
             // populate PSTNDialIn
            var requestPSTNDialInIsNull = true;
            request.PSTNDialIn = new Amazon.AlexaForBusiness.Model.PSTNDialIn();
            System.String requestPSTNDialIn_pSTNDialIn_CountryCode = null;
            if (cmdletContext.PSTNDialIn_CountryCode != null)
            {
                requestPSTNDialIn_pSTNDialIn_CountryCode = cmdletContext.PSTNDialIn_CountryCode;
            }
            if (requestPSTNDialIn_pSTNDialIn_CountryCode != null)
            {
                request.PSTNDialIn.CountryCode = requestPSTNDialIn_pSTNDialIn_CountryCode;
                requestPSTNDialInIsNull = false;
            }
            System.String requestPSTNDialIn_pSTNDialIn_OneClickIdDelay = null;
            if (cmdletContext.PSTNDialIn_OneClickIdDelay != null)
            {
                requestPSTNDialIn_pSTNDialIn_OneClickIdDelay = cmdletContext.PSTNDialIn_OneClickIdDelay;
            }
            if (requestPSTNDialIn_pSTNDialIn_OneClickIdDelay != null)
            {
                request.PSTNDialIn.OneClickIdDelay = requestPSTNDialIn_pSTNDialIn_OneClickIdDelay;
                requestPSTNDialInIsNull = false;
            }
            System.String requestPSTNDialIn_pSTNDialIn_OneClickPinDelay = null;
            if (cmdletContext.PSTNDialIn_OneClickPinDelay != null)
            {
                requestPSTNDialIn_pSTNDialIn_OneClickPinDelay = cmdletContext.PSTNDialIn_OneClickPinDelay;
            }
            if (requestPSTNDialIn_pSTNDialIn_OneClickPinDelay != null)
            {
                request.PSTNDialIn.OneClickPinDelay = requestPSTNDialIn_pSTNDialIn_OneClickPinDelay;
                requestPSTNDialInIsNull = false;
            }
            System.String requestPSTNDialIn_pSTNDialIn_PhoneNumber = null;
            if (cmdletContext.PSTNDialIn_PhoneNumber != null)
            {
                requestPSTNDialIn_pSTNDialIn_PhoneNumber = cmdletContext.PSTNDialIn_PhoneNumber;
            }
            if (requestPSTNDialIn_pSTNDialIn_PhoneNumber != null)
            {
                request.PSTNDialIn.PhoneNumber = requestPSTNDialIn_pSTNDialIn_PhoneNumber;
                requestPSTNDialInIsNull = false;
            }
             // determine if request.PSTNDialIn should be set to null
            if (requestPSTNDialInIsNull)
            {
                request.PSTNDialIn = null;
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
        
        private Amazon.AlexaForBusiness.Model.CreateConferenceProviderResponse CallAWSServiceOperation(IAmazonAlexaForBusiness client, Amazon.AlexaForBusiness.Model.CreateConferenceProviderRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Alexa For Business", "CreateConferenceProvider");
            try
            {
                #if DESKTOP
                return client.CreateConferenceProvider(request);
                #elif CORECLR
                return client.CreateConferenceProviderAsync(request).GetAwaiter().GetResult();
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
            public System.String ClientRequestToken { get; set; }
            public System.String ConferenceProviderName { get; set; }
            public Amazon.AlexaForBusiness.ConferenceProviderType ConferenceProviderType { get; set; }
            public Amazon.AlexaForBusiness.CommsProtocol IPDialIn_CommsProtocol { get; set; }
            public System.String IPDialIn_Endpoint { get; set; }
            public Amazon.AlexaForBusiness.RequirePin MeetingSetting_RequirePin { get; set; }
            public System.String PSTNDialIn_CountryCode { get; set; }
            public System.String PSTNDialIn_OneClickIdDelay { get; set; }
            public System.String PSTNDialIn_OneClickPinDelay { get; set; }
            public System.String PSTNDialIn_PhoneNumber { get; set; }
            public List<Amazon.AlexaForBusiness.Model.Tag> Tag { get; set; }
            public System.Func<Amazon.AlexaForBusiness.Model.CreateConferenceProviderResponse, NewALXBConferenceProviderCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.ConferenceProviderArn;
        }
        
    }
}
