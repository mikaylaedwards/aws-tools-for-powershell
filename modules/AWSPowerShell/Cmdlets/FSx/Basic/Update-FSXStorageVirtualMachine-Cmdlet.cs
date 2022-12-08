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
using Amazon.FSx;
using Amazon.FSx.Model;

namespace Amazon.PowerShell.Cmdlets.FSX
{
    /// <summary>
    /// Updates an Amazon FSx for ONTAP storage virtual machine (SVM).
    /// </summary>
    [Cmdlet("Update", "FSXStorageVirtualMachine", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.FSx.Model.StorageVirtualMachine")]
    [AWSCmdlet("Calls the Amazon FSx UpdateStorageVirtualMachine API operation.", Operation = new[] {"UpdateStorageVirtualMachine"}, SelectReturnType = typeof(Amazon.FSx.Model.UpdateStorageVirtualMachineResponse))]
    [AWSCmdletOutput("Amazon.FSx.Model.StorageVirtualMachine or Amazon.FSx.Model.UpdateStorageVirtualMachineResponse",
        "This cmdlet returns an Amazon.FSx.Model.StorageVirtualMachine object.",
        "The service call response (type Amazon.FSx.Model.UpdateStorageVirtualMachineResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class UpdateFSXStorageVirtualMachineCmdlet : AmazonFSxClientCmdlet, IExecutor
    {
        
        #region Parameter ClientRequestToken
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientRequestToken { get; set; }
        #endregion
        
        #region Parameter SelfManagedActiveDirectoryConfiguration_DnsIp
        /// <summary>
        /// <para>
        /// <para>A list of up to three IP addresses of DNS servers or domain controllers in the self-managed
        /// AD directory.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ActiveDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration_DnsIps")]
        public System.String[] SelfManagedActiveDirectoryConfiguration_DnsIp { get; set; }
        #endregion
        
        #region Parameter SelfManagedActiveDirectoryConfiguration_Password
        /// <summary>
        /// <para>
        /// <para>The password for the service account on your self-managed AD domain that Amazon FSx
        /// will use to join to your AD domain.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ActiveDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration_Password")]
        public System.String SelfManagedActiveDirectoryConfiguration_Password { get; set; }
        #endregion
        
        #region Parameter StorageVirtualMachineId
        /// <summary>
        /// <para>
        /// <para>The ID of the SVM that you want to update, in the format <code>svm-0123456789abcdef0</code>.</para>
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
        public System.String StorageVirtualMachineId { get; set; }
        #endregion
        
        #region Parameter SvmAdminPassword
        /// <summary>
        /// <para>
        /// <para>Enter a new SvmAdminPassword if you are updating it.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String SvmAdminPassword { get; set; }
        #endregion
        
        #region Parameter SelfManagedActiveDirectoryConfiguration_UserName
        /// <summary>
        /// <para>
        /// <para>The user name for the service account on your self-managed AD domain that Amazon FSx
        /// will use to join to your AD domain. This account must have the permission to join
        /// computers to the domain in the organizational unit provided in <code>OrganizationalUnitDistinguishedName</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ActiveDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration_UserName")]
        public System.String SelfManagedActiveDirectoryConfiguration_UserName { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'StorageVirtualMachine'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.FSx.Model.UpdateStorageVirtualMachineResponse).
        /// Specifying the name of a property of type Amazon.FSx.Model.UpdateStorageVirtualMachineResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "StorageVirtualMachine";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the StorageVirtualMachineId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^StorageVirtualMachineId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^StorageVirtualMachineId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.StorageVirtualMachineId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-FSXStorageVirtualMachine (UpdateStorageVirtualMachine)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.FSx.Model.UpdateStorageVirtualMachineResponse, UpdateFSXStorageVirtualMachineCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.StorageVirtualMachineId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (this.SelfManagedActiveDirectoryConfiguration_DnsIp != null)
            {
                context.SelfManagedActiveDirectoryConfiguration_DnsIp = new List<System.String>(this.SelfManagedActiveDirectoryConfiguration_DnsIp);
            }
            context.SelfManagedActiveDirectoryConfiguration_Password = this.SelfManagedActiveDirectoryConfiguration_Password;
            context.SelfManagedActiveDirectoryConfiguration_UserName = this.SelfManagedActiveDirectoryConfiguration_UserName;
            context.ClientRequestToken = this.ClientRequestToken;
            context.StorageVirtualMachineId = this.StorageVirtualMachineId;
            #if MODULAR
            if (this.StorageVirtualMachineId == null && ParameterWasBound(nameof(this.StorageVirtualMachineId)))
            {
                WriteWarning("You are passing $null as a value for parameter StorageVirtualMachineId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.SvmAdminPassword = this.SvmAdminPassword;
            
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
            var request = new Amazon.FSx.Model.UpdateStorageVirtualMachineRequest();
            
            
             // populate ActiveDirectoryConfiguration
            var requestActiveDirectoryConfigurationIsNull = true;
            request.ActiveDirectoryConfiguration = new Amazon.FSx.Model.UpdateSvmActiveDirectoryConfiguration();
            Amazon.FSx.Model.SelfManagedActiveDirectoryConfigurationUpdates requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration = null;
            
             // populate SelfManagedActiveDirectoryConfiguration
            var requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfigurationIsNull = true;
            requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration = new Amazon.FSx.Model.SelfManagedActiveDirectoryConfigurationUpdates();
            List<System.String> requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration_selfManagedActiveDirectoryConfiguration_DnsIp = null;
            if (cmdletContext.SelfManagedActiveDirectoryConfiguration_DnsIp != null)
            {
                requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration_selfManagedActiveDirectoryConfiguration_DnsIp = cmdletContext.SelfManagedActiveDirectoryConfiguration_DnsIp;
            }
            if (requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration_selfManagedActiveDirectoryConfiguration_DnsIp != null)
            {
                requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration.DnsIps = requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration_selfManagedActiveDirectoryConfiguration_DnsIp;
                requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfigurationIsNull = false;
            }
            System.String requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration_selfManagedActiveDirectoryConfiguration_Password = null;
            if (cmdletContext.SelfManagedActiveDirectoryConfiguration_Password != null)
            {
                requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration_selfManagedActiveDirectoryConfiguration_Password = cmdletContext.SelfManagedActiveDirectoryConfiguration_Password;
            }
            if (requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration_selfManagedActiveDirectoryConfiguration_Password != null)
            {
                requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration.Password = requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration_selfManagedActiveDirectoryConfiguration_Password;
                requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfigurationIsNull = false;
            }
            System.String requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration_selfManagedActiveDirectoryConfiguration_UserName = null;
            if (cmdletContext.SelfManagedActiveDirectoryConfiguration_UserName != null)
            {
                requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration_selfManagedActiveDirectoryConfiguration_UserName = cmdletContext.SelfManagedActiveDirectoryConfiguration_UserName;
            }
            if (requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration_selfManagedActiveDirectoryConfiguration_UserName != null)
            {
                requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration.UserName = requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration_selfManagedActiveDirectoryConfiguration_UserName;
                requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfigurationIsNull = false;
            }
             // determine if requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration should be set to null
            if (requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfigurationIsNull)
            {
                requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration = null;
            }
            if (requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration != null)
            {
                request.ActiveDirectoryConfiguration.SelfManagedActiveDirectoryConfiguration = requestActiveDirectoryConfiguration_activeDirectoryConfiguration_SelfManagedActiveDirectoryConfiguration;
                requestActiveDirectoryConfigurationIsNull = false;
            }
             // determine if request.ActiveDirectoryConfiguration should be set to null
            if (requestActiveDirectoryConfigurationIsNull)
            {
                request.ActiveDirectoryConfiguration = null;
            }
            if (cmdletContext.ClientRequestToken != null)
            {
                request.ClientRequestToken = cmdletContext.ClientRequestToken;
            }
            if (cmdletContext.StorageVirtualMachineId != null)
            {
                request.StorageVirtualMachineId = cmdletContext.StorageVirtualMachineId;
            }
            if (cmdletContext.SvmAdminPassword != null)
            {
                request.SvmAdminPassword = cmdletContext.SvmAdminPassword;
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
        
        private Amazon.FSx.Model.UpdateStorageVirtualMachineResponse CallAWSServiceOperation(IAmazonFSx client, Amazon.FSx.Model.UpdateStorageVirtualMachineRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon FSx", "UpdateStorageVirtualMachine");
            try
            {
                #if DESKTOP
                return client.UpdateStorageVirtualMachine(request);
                #elif CORECLR
                return client.UpdateStorageVirtualMachineAsync(request).GetAwaiter().GetResult();
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
            public List<System.String> SelfManagedActiveDirectoryConfiguration_DnsIp { get; set; }
            public System.String SelfManagedActiveDirectoryConfiguration_Password { get; set; }
            public System.String SelfManagedActiveDirectoryConfiguration_UserName { get; set; }
            public System.String ClientRequestToken { get; set; }
            public System.String StorageVirtualMachineId { get; set; }
            public System.String SvmAdminPassword { get; set; }
            public System.Func<Amazon.FSx.Model.UpdateStorageVirtualMachineResponse, UpdateFSXStorageVirtualMachineCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.StorageVirtualMachine;
        }
        
    }
}
