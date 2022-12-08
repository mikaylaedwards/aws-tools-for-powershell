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
using Amazon.OpenSearchServerless;
using Amazon.OpenSearchServerless.Model;

namespace Amazon.PowerShell.Cmdlets.OSS
{
    /// <summary>
    /// Specifies a security configuration for OpenSearch Serverless. For more information,
    /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-saml.html">SAML
    /// authentication for Amazon OpenSearch Serverless</a>.
    /// </summary>
    [Cmdlet("New", "OSSSecurityConfig", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.OpenSearchServerless.Model.SecurityConfigDetail")]
    [AWSCmdlet("Calls the OpenSearch Serverless CreateSecurityConfig API operation.", Operation = new[] {"CreateSecurityConfig"}, SelectReturnType = typeof(Amazon.OpenSearchServerless.Model.CreateSecurityConfigResponse))]
    [AWSCmdletOutput("Amazon.OpenSearchServerless.Model.SecurityConfigDetail or Amazon.OpenSearchServerless.Model.CreateSecurityConfigResponse",
        "This cmdlet returns an Amazon.OpenSearchServerless.Model.SecurityConfigDetail object.",
        "The service call response (type Amazon.OpenSearchServerless.Model.CreateSecurityConfigResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewOSSSecurityConfigCmdlet : AmazonOpenSearchServerlessClientCmdlet, IExecutor
    {
        
        #region Parameter Description
        /// <summary>
        /// <para>
        /// <para>A description of the security configuration.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Description { get; set; }
        #endregion
        
        #region Parameter SamlOptions_GroupAttribute
        /// <summary>
        /// <para>
        /// <para>The group attribute for this SAML integration.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String SamlOptions_GroupAttribute { get; set; }
        #endregion
        
        #region Parameter SamlOptions_Metadata
        /// <summary>
        /// <para>
        /// <para>The XML IdP metadata file generated from your identity provider.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String SamlOptions_Metadata { get; set; }
        #endregion
        
        #region Parameter Name
        /// <summary>
        /// <para>
        /// <para>The name of the security configuration.</para>
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
        public System.String Name { get; set; }
        #endregion
        
        #region Parameter SamlOptions_SessionTimeout
        /// <summary>
        /// <para>
        /// <para>The session timeout, in minutes. Minimum is 15 minutes and maximum is 1440 minutes
        /// (24 hours or 1 day). Default is 60 minutes.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? SamlOptions_SessionTimeout { get; set; }
        #endregion
        
        #region Parameter Type
        /// <summary>
        /// <para>
        /// <para>The type of security configuration.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.OpenSearchServerless.SecurityConfigType")]
        public Amazon.OpenSearchServerless.SecurityConfigType Type { get; set; }
        #endregion
        
        #region Parameter SamlOptions_UserAttribute
        /// <summary>
        /// <para>
        /// <para>A user attribute for this SAML integration.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String SamlOptions_UserAttribute { get; set; }
        #endregion
        
        #region Parameter ClientToken
        /// <summary>
        /// <para>
        /// <para>Unique, case-sensitive identifier to ensure idempotency of the request.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'SecurityConfigDetail'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.OpenSearchServerless.Model.CreateSecurityConfigResponse).
        /// Specifying the name of a property of type Amazon.OpenSearchServerless.Model.CreateSecurityConfigResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "SecurityConfigDetail";
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.Name), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-OSSSecurityConfig (CreateSecurityConfig)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.OpenSearchServerless.Model.CreateSecurityConfigResponse, NewOSSSecurityConfigCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            context.ClientToken = this.ClientToken;
            context.Description = this.Description;
            context.Name = this.Name;
            #if MODULAR
            if (this.Name == null && ParameterWasBound(nameof(this.Name)))
            {
                WriteWarning("You are passing $null as a value for parameter Name which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.SamlOptions_GroupAttribute = this.SamlOptions_GroupAttribute;
            context.SamlOptions_Metadata = this.SamlOptions_Metadata;
            context.SamlOptions_SessionTimeout = this.SamlOptions_SessionTimeout;
            context.SamlOptions_UserAttribute = this.SamlOptions_UserAttribute;
            context.Type = this.Type;
            #if MODULAR
            if (this.Type == null && ParameterWasBound(nameof(this.Type)))
            {
                WriteWarning("You are passing $null as a value for parameter Type which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.OpenSearchServerless.Model.CreateSecurityConfigRequest();
            
            if (cmdletContext.ClientToken != null)
            {
                request.ClientToken = cmdletContext.ClientToken;
            }
            if (cmdletContext.Description != null)
            {
                request.Description = cmdletContext.Description;
            }
            if (cmdletContext.Name != null)
            {
                request.Name = cmdletContext.Name;
            }
            
             // populate SamlOptions
            var requestSamlOptionsIsNull = true;
            request.SamlOptions = new Amazon.OpenSearchServerless.Model.SamlConfigOptions();
            System.String requestSamlOptions_samlOptions_GroupAttribute = null;
            if (cmdletContext.SamlOptions_GroupAttribute != null)
            {
                requestSamlOptions_samlOptions_GroupAttribute = cmdletContext.SamlOptions_GroupAttribute;
            }
            if (requestSamlOptions_samlOptions_GroupAttribute != null)
            {
                request.SamlOptions.GroupAttribute = requestSamlOptions_samlOptions_GroupAttribute;
                requestSamlOptionsIsNull = false;
            }
            System.String requestSamlOptions_samlOptions_Metadata = null;
            if (cmdletContext.SamlOptions_Metadata != null)
            {
                requestSamlOptions_samlOptions_Metadata = cmdletContext.SamlOptions_Metadata;
            }
            if (requestSamlOptions_samlOptions_Metadata != null)
            {
                request.SamlOptions.Metadata = requestSamlOptions_samlOptions_Metadata;
                requestSamlOptionsIsNull = false;
            }
            System.Int32? requestSamlOptions_samlOptions_SessionTimeout = null;
            if (cmdletContext.SamlOptions_SessionTimeout != null)
            {
                requestSamlOptions_samlOptions_SessionTimeout = cmdletContext.SamlOptions_SessionTimeout.Value;
            }
            if (requestSamlOptions_samlOptions_SessionTimeout != null)
            {
                request.SamlOptions.SessionTimeout = requestSamlOptions_samlOptions_SessionTimeout.Value;
                requestSamlOptionsIsNull = false;
            }
            System.String requestSamlOptions_samlOptions_UserAttribute = null;
            if (cmdletContext.SamlOptions_UserAttribute != null)
            {
                requestSamlOptions_samlOptions_UserAttribute = cmdletContext.SamlOptions_UserAttribute;
            }
            if (requestSamlOptions_samlOptions_UserAttribute != null)
            {
                request.SamlOptions.UserAttribute = requestSamlOptions_samlOptions_UserAttribute;
                requestSamlOptionsIsNull = false;
            }
             // determine if request.SamlOptions should be set to null
            if (requestSamlOptionsIsNull)
            {
                request.SamlOptions = null;
            }
            if (cmdletContext.Type != null)
            {
                request.Type = cmdletContext.Type;
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
        
        private Amazon.OpenSearchServerless.Model.CreateSecurityConfigResponse CallAWSServiceOperation(IAmazonOpenSearchServerless client, Amazon.OpenSearchServerless.Model.CreateSecurityConfigRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "OpenSearch Serverless", "CreateSecurityConfig");
            try
            {
                #if DESKTOP
                return client.CreateSecurityConfig(request);
                #elif CORECLR
                return client.CreateSecurityConfigAsync(request).GetAwaiter().GetResult();
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
            public System.String ClientToken { get; set; }
            public System.String Description { get; set; }
            public System.String Name { get; set; }
            public System.String SamlOptions_GroupAttribute { get; set; }
            public System.String SamlOptions_Metadata { get; set; }
            public System.Int32? SamlOptions_SessionTimeout { get; set; }
            public System.String SamlOptions_UserAttribute { get; set; }
            public Amazon.OpenSearchServerless.SecurityConfigType Type { get; set; }
            public System.Func<Amazon.OpenSearchServerless.Model.CreateSecurityConfigResponse, NewOSSSecurityConfigCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.SecurityConfigDetail;
        }
        
    }
}
