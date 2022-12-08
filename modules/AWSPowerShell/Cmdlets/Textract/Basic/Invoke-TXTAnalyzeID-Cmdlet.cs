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
using Amazon.Textract;
using Amazon.Textract.Model;

namespace Amazon.PowerShell.Cmdlets.TXT
{
    /// <summary>
    /// Analyzes identity documents for relevant information. This information is extracted
    /// and returned as <code>IdentityDocumentFields</code>, which records both the normalized
    /// field and value of the extracted text.Unlike other Amazon Textract operations, <code>AnalyzeID</code>
    /// doesn't return any Geometry data.
    /// </summary>
    [Cmdlet("Invoke", "TXTAnalyzeID", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.Textract.Model.AnalyzeIDResponse")]
    [AWSCmdlet("Calls the Amazon Textract AnalyzeID API operation.", Operation = new[] {"AnalyzeID"}, SelectReturnType = typeof(Amazon.Textract.Model.AnalyzeIDResponse))]
    [AWSCmdletOutput("Amazon.Textract.Model.AnalyzeIDResponse",
        "This cmdlet returns an Amazon.Textract.Model.AnalyzeIDResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class InvokeTXTAnalyzeIDCmdlet : AmazonTextractClientCmdlet, IExecutor
    {
        
        #region Parameter DocumentPage
        /// <summary>
        /// <para>
        /// <para>The document being passed to AnalyzeID.</para>
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
        [Alias("DocumentPages")]
        public Amazon.Textract.Model.Document[] DocumentPage { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Textract.Model.AnalyzeIDResponse).
        /// Specifying the name of a property of type Amazon.Textract.Model.AnalyzeIDResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.DocumentPage), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Invoke-TXTAnalyzeID (AnalyzeID)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Textract.Model.AnalyzeIDResponse, InvokeTXTAnalyzeIDCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            if (this.DocumentPage != null)
            {
                context.DocumentPage = new List<Amazon.Textract.Model.Document>(this.DocumentPage);
            }
            #if MODULAR
            if (this.DocumentPage == null && ParameterWasBound(nameof(this.DocumentPage)))
            {
                WriteWarning("You are passing $null as a value for parameter DocumentPage which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.Textract.Model.AnalyzeIDRequest();
            
            if (cmdletContext.DocumentPage != null)
            {
                request.DocumentPages = cmdletContext.DocumentPage;
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
        
        private Amazon.Textract.Model.AnalyzeIDResponse CallAWSServiceOperation(IAmazonTextract client, Amazon.Textract.Model.AnalyzeIDRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Textract", "AnalyzeID");
            try
            {
                #if DESKTOP
                return client.AnalyzeID(request);
                #elif CORECLR
                return client.AnalyzeIDAsync(request).GetAwaiter().GetResult();
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
            public List<Amazon.Textract.Model.Document> DocumentPage { get; set; }
            public System.Func<Amazon.Textract.Model.AnalyzeIDResponse, InvokeTXTAnalyzeIDCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
