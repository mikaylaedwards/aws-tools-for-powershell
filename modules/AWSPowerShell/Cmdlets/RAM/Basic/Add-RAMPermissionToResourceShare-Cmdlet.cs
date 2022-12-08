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
using Amazon.RAM;
using Amazon.RAM.Model;

namespace Amazon.PowerShell.Cmdlets.RAM
{
    /// <summary>
    /// Adds or replaces the RAM permission for a resource type included in a resource share.
    /// You can have exactly one permission associated with each resource type in the resource
    /// share. You can add a new RAM permission only if there are currently no resources of
    /// that resource type currently in the resource share.
    /// </summary>
    [Cmdlet("Add", "RAMPermissionToResourceShare", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.Boolean")]
    [AWSCmdlet("Calls the AWS Resource Access Manager (RAM) AssociateResourceSharePermission API operation.", Operation = new[] {"AssociateResourceSharePermission"}, SelectReturnType = typeof(Amazon.RAM.Model.AssociateResourceSharePermissionResponse))]
    [AWSCmdletOutput("System.Boolean or Amazon.RAM.Model.AssociateResourceSharePermissionResponse",
        "This cmdlet returns a System.Boolean object.",
        "The service call response (type Amazon.RAM.Model.AssociateResourceSharePermissionResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class AddRAMPermissionToResourceShareCmdlet : AmazonRAMClientCmdlet, IExecutor
    {
        
        #region Parameter PermissionArn
        /// <summary>
        /// <para>
        /// <para>Specifies the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resoure Name (ARN)</a> of the RAM permission to associate with the resource share.
        /// To find the ARN for a permission, use either the <a>ListPermissions</a> operation
        /// or go to the <a href="https://console.aws.amazon.com/ram/home#Permissions:">Permissions
        /// library</a> page in the RAM console and then choose the name of the permission. The
        /// ARN is displayed on the detail page.</para>
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
        public System.String PermissionArn { get; set; }
        #endregion
        
        #region Parameter PermissionVersion
        /// <summary>
        /// <para>
        /// <para>Specifies the version of the RAM permission to associate with the resource share.
        /// If you don't specify this parameter, the operation uses the version designated as
        /// the default. You can use the <a>ListPermissionVersions</a> operation to discover the
        /// available versions of a permission.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? PermissionVersion { get; set; }
        #endregion
        
        #region Parameter Replace
        /// <summary>
        /// <para>
        /// <para>Specifies whether the specified permission should replace or add to the existing permission
        /// associated with the resource share. Use <code>true</code> to replace the current permissions.
        /// Use <code>false</code> to add the permission to the current permission. The default
        /// value is <code>false</code>.</para><note><para>A resource share can have only one permission per resource type. If a resource share
        /// already has a permission for the specified resource type and you don't set <code>replace</code>
        /// to <code>true</code> then the operation returns an error. This helps prevent accidental
        /// overwriting of a permission.</para></note>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? Replace { get; set; }
        #endregion
        
        #region Parameter ResourceShareArn
        /// <summary>
        /// <para>
        /// <para>Specifies the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resoure Name (ARN)</a> of the resource share to which you want to add or replace permissions.</para>
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
        public System.String ResourceShareArn { get; set; }
        #endregion
        
        #region Parameter ClientToken
        /// <summary>
        /// <para>
        /// <para>Specifies a unique, case-sensitive identifier that you provide to ensure the idempotency
        /// of the request. This lets you safely retry the request without accidentally performing
        /// the same operation a second time. Passing the same value to a later call to an operation
        /// requires that you also pass the same value for all other parameters. We recommend
        /// that you use a <a href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID
        /// type of value.</a>.</para><para>If you don't provide this value, then Amazon Web Services generates a random one for
        /// you.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'ReturnValue'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.RAM.Model.AssociateResourceSharePermissionResponse).
        /// Specifying the name of a property of type Amazon.RAM.Model.AssociateResourceSharePermissionResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "ReturnValue";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the PermissionArn parameter.
        /// The -PassThru parameter is deprecated, use -Select '^PermissionArn' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^PermissionArn' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.PermissionArn), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Add-RAMPermissionToResourceShare (AssociateResourceSharePermission)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.RAM.Model.AssociateResourceSharePermissionResponse, AddRAMPermissionToResourceShareCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.PermissionArn;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ClientToken = this.ClientToken;
            context.PermissionArn = this.PermissionArn;
            #if MODULAR
            if (this.PermissionArn == null && ParameterWasBound(nameof(this.PermissionArn)))
            {
                WriteWarning("You are passing $null as a value for parameter PermissionArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.PermissionVersion = this.PermissionVersion;
            context.Replace = this.Replace;
            context.ResourceShareArn = this.ResourceShareArn;
            #if MODULAR
            if (this.ResourceShareArn == null && ParameterWasBound(nameof(this.ResourceShareArn)))
            {
                WriteWarning("You are passing $null as a value for parameter ResourceShareArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.RAM.Model.AssociateResourceSharePermissionRequest();
            
            if (cmdletContext.ClientToken != null)
            {
                request.ClientToken = cmdletContext.ClientToken;
            }
            if (cmdletContext.PermissionArn != null)
            {
                request.PermissionArn = cmdletContext.PermissionArn;
            }
            if (cmdletContext.PermissionVersion != null)
            {
                request.PermissionVersion = cmdletContext.PermissionVersion.Value;
            }
            if (cmdletContext.Replace != null)
            {
                request.Replace = cmdletContext.Replace.Value;
            }
            if (cmdletContext.ResourceShareArn != null)
            {
                request.ResourceShareArn = cmdletContext.ResourceShareArn;
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
        
        private Amazon.RAM.Model.AssociateResourceSharePermissionResponse CallAWSServiceOperation(IAmazonRAM client, Amazon.RAM.Model.AssociateResourceSharePermissionRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Resource Access Manager (RAM)", "AssociateResourceSharePermission");
            try
            {
                #if DESKTOP
                return client.AssociateResourceSharePermission(request);
                #elif CORECLR
                return client.AssociateResourceSharePermissionAsync(request).GetAwaiter().GetResult();
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
            public System.String PermissionArn { get; set; }
            public System.Int32? PermissionVersion { get; set; }
            public System.Boolean? Replace { get; set; }
            public System.String ResourceShareArn { get; set; }
            public System.Func<Amazon.RAM.Model.AssociateResourceSharePermissionResponse, AddRAMPermissionToResourceShareCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.ReturnValue;
        }
        
    }
}
