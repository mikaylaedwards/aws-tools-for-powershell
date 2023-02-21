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
using Amazon.Tnb;
using Amazon.Tnb.Model;

namespace Amazon.PowerShell.Cmdlets.TNB
{
    /// <summary>
    /// Gets the contents of a network package.
    /// 
    ///  
    /// <para>
    /// A network package is a .zip file in CSAR (Cloud Service Archive) format defines the
    /// function packages you want to deploy and the Amazon Web Services infrastructure you
    /// want to deploy them on.
    /// </para>
    /// </summary>
    [Cmdlet("Get", "TNBSolNetworkPackageContent")]
    [OutputType("Amazon.Tnb.Model.GetSolNetworkPackageContentResponse")]
    [AWSCmdlet("Calls the AWS Telco Network Builder GetSolNetworkPackageContent API operation.", Operation = new[] {"GetSolNetworkPackageContent"}, SelectReturnType = typeof(Amazon.Tnb.Model.GetSolNetworkPackageContentResponse))]
    [AWSCmdletOutput("Amazon.Tnb.Model.GetSolNetworkPackageContentResponse",
        "This cmdlet returns an Amazon.Tnb.Model.GetSolNetworkPackageContentResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetTNBSolNetworkPackageContentCmdlet : AmazonTnbClientCmdlet, IExecutor
    {
        
        #region Parameter Accept
        /// <summary>
        /// <para>
        /// <para>The format of the package you want to download from the network package.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.Tnb.PackageContentType")]
        public Amazon.Tnb.PackageContentType Accept { get; set; }
        #endregion
        
        #region Parameter NsdInfoId
        /// <summary>
        /// <para>
        /// <para>ID of the network service descriptor in the network package.</para>
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
        public System.String NsdInfoId { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Tnb.Model.GetSolNetworkPackageContentResponse).
        /// Specifying the name of a property of type Amazon.Tnb.Model.GetSolNetworkPackageContentResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the NsdInfoId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^NsdInfoId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^NsdInfoId' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            this._AWSSignerType = "v4";
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Tnb.Model.GetSolNetworkPackageContentResponse, GetTNBSolNetworkPackageContentCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.NsdInfoId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.Accept = this.Accept;
            #if MODULAR
            if (this.Accept == null && ParameterWasBound(nameof(this.Accept)))
            {
                WriteWarning("You are passing $null as a value for parameter Accept which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.NsdInfoId = this.NsdInfoId;
            #if MODULAR
            if (this.NsdInfoId == null && ParameterWasBound(nameof(this.NsdInfoId)))
            {
                WriteWarning("You are passing $null as a value for parameter NsdInfoId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.Tnb.Model.GetSolNetworkPackageContentRequest();
            
            if (cmdletContext.Accept != null)
            {
                request.Accept = cmdletContext.Accept;
            }
            if (cmdletContext.NsdInfoId != null)
            {
                request.NsdInfoId = cmdletContext.NsdInfoId;
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
        
        private Amazon.Tnb.Model.GetSolNetworkPackageContentResponse CallAWSServiceOperation(IAmazonTnb client, Amazon.Tnb.Model.GetSolNetworkPackageContentRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Telco Network Builder", "GetSolNetworkPackageContent");
            try
            {
                #if DESKTOP
                return client.GetSolNetworkPackageContent(request);
                #elif CORECLR
                return client.GetSolNetworkPackageContentAsync(request).GetAwaiter().GetResult();
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
            public Amazon.Tnb.PackageContentType Accept { get; set; }
            public System.String NsdInfoId { get; set; }
            public System.Func<Amazon.Tnb.Model.GetSolNetworkPackageContentResponse, GetTNBSolNetworkPackageContentCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
