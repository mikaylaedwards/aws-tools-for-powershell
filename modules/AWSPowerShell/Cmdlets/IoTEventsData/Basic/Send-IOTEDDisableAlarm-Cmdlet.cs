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
using Amazon.IoTEventsData;
using Amazon.IoTEventsData.Model;

namespace Amazon.PowerShell.Cmdlets.IOTED
{
    /// <summary>
    /// Disables one or more alarms. The alarms change to the <code>DISABLED</code> state
    /// after you disable them.
    /// </summary>
    [Cmdlet("Send", "IOTEDDisableAlarm", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.IoTEventsData.Model.BatchAlarmActionErrorEntry")]
    [AWSCmdlet("Calls the AWS IoT Events Data BatchDisableAlarm API operation.", Operation = new[] {"BatchDisableAlarm"}, SelectReturnType = typeof(Amazon.IoTEventsData.Model.BatchDisableAlarmResponse))]
    [AWSCmdletOutput("Amazon.IoTEventsData.Model.BatchAlarmActionErrorEntry or Amazon.IoTEventsData.Model.BatchDisableAlarmResponse",
        "This cmdlet returns a collection of Amazon.IoTEventsData.Model.BatchAlarmActionErrorEntry objects.",
        "The service call response (type Amazon.IoTEventsData.Model.BatchDisableAlarmResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class SendIOTEDDisableAlarmCmdlet : AmazonIoTEventsDataClientCmdlet, IExecutor
    {
        
        #region Parameter DisableActionRequest
        /// <summary>
        /// <para>
        /// <para>The list of disable action requests. You can specify up to 10 requests per operation.</para>
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
        [Alias("DisableActionRequests")]
        public Amazon.IoTEventsData.Model.DisableAlarmActionRequest[] DisableActionRequest { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'ErrorEntries'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.IoTEventsData.Model.BatchDisableAlarmResponse).
        /// Specifying the name of a property of type Amazon.IoTEventsData.Model.BatchDisableAlarmResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "ErrorEntries";
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.DisableActionRequest), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Send-IOTEDDisableAlarm (BatchDisableAlarm)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.IoTEventsData.Model.BatchDisableAlarmResponse, SendIOTEDDisableAlarmCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            if (this.DisableActionRequest != null)
            {
                context.DisableActionRequest = new List<Amazon.IoTEventsData.Model.DisableAlarmActionRequest>(this.DisableActionRequest);
            }
            #if MODULAR
            if (this.DisableActionRequest == null && ParameterWasBound(nameof(this.DisableActionRequest)))
            {
                WriteWarning("You are passing $null as a value for parameter DisableActionRequest which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.IoTEventsData.Model.BatchDisableAlarmRequest();
            
            if (cmdletContext.DisableActionRequest != null)
            {
                request.DisableActionRequests = cmdletContext.DisableActionRequest;
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
        
        private Amazon.IoTEventsData.Model.BatchDisableAlarmResponse CallAWSServiceOperation(IAmazonIoTEventsData client, Amazon.IoTEventsData.Model.BatchDisableAlarmRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS IoT Events Data", "BatchDisableAlarm");
            try
            {
                #if DESKTOP
                return client.BatchDisableAlarm(request);
                #elif CORECLR
                return client.BatchDisableAlarmAsync(request).GetAwaiter().GetResult();
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
            public List<Amazon.IoTEventsData.Model.DisableAlarmActionRequest> DisableActionRequest { get; set; }
            public System.Func<Amazon.IoTEventsData.Model.BatchDisableAlarmResponse, SendIOTEDDisableAlarmCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.ErrorEntries;
        }
        
    }
}
