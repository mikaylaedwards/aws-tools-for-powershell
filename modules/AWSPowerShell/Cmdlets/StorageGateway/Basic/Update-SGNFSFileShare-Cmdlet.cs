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
using Amazon.StorageGateway;
using Amazon.StorageGateway.Model;

namespace Amazon.PowerShell.Cmdlets.SG
{
    /// <summary>
    /// Updates a Network File System (NFS) file share. This operation is only supported in
    /// S3 File Gateways.
    /// 
    ///  <note><para>
    /// To leave a file share field unchanged, set the corresponding input field to null.
    /// </para></note><para>
    /// Updates the following file share settings:
    /// </para><ul><li><para>
    /// Default storage class for your S3 bucket
    /// </para></li><li><para>
    /// Metadata defaults for your S3 bucket
    /// </para></li><li><para>
    /// Allowed NFS clients for your file share
    /// </para></li><li><para>
    /// Squash settings
    /// </para></li><li><para>
    /// Write status of your file share
    /// </para></li></ul>
    /// </summary>
    [Cmdlet("Update", "SGNFSFileShare", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the AWS Storage Gateway UpdateNFSFileShare API operation.", Operation = new[] {"UpdateNFSFileShare"}, SelectReturnType = typeof(Amazon.StorageGateway.Model.UpdateNFSFileShareResponse))]
    [AWSCmdletOutput("System.String or Amazon.StorageGateway.Model.UpdateNFSFileShareResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.StorageGateway.Model.UpdateNFSFileShareResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class UpdateSGNFSFileShareCmdlet : AmazonStorageGatewayClientCmdlet, IExecutor
    {
        
        #region Parameter AuditDestinationARN
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the storage used for audit logs.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String AuditDestinationARN { get; set; }
        #endregion
        
        #region Parameter CacheAttributes_CacheStaleTimeoutInSecond
        /// <summary>
        /// <para>
        /// <para>Refreshes a file share's cache by using Time To Live (TTL). TTL is the length of time
        /// since the last refresh after which access to the directory would cause the file gateway
        /// to first refresh that directory's contents from the Amazon S3 bucket or Amazon FSx
        /// file system. The TTL duration is in seconds.</para><para>Valid Values:0, 300 to 2,592,000 seconds (5 minutes to 30 days)</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("CacheAttributes_CacheStaleTimeoutInSeconds")]
        public System.Int32? CacheAttributes_CacheStaleTimeoutInSecond { get; set; }
        #endregion
        
        #region Parameter ClientList
        /// <summary>
        /// <para>
        /// <para>The list of clients that are allowed to access the S3 File Gateway. The list must
        /// contain either valid IP addresses or valid CIDR blocks.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String[] ClientList { get; set; }
        #endregion
        
        #region Parameter DefaultStorageClass
        /// <summary>
        /// <para>
        /// <para>The default storage class for objects put into an Amazon S3 bucket by the S3 File
        /// Gateway. The default value is <code>S3_STANDARD</code>. Optional.</para><para>Valid Values: <code>S3_STANDARD</code> | <code>S3_INTELLIGENT_TIERING</code> | <code>S3_STANDARD_IA</code>
        /// | <code>S3_ONEZONE_IA</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String DefaultStorageClass { get; set; }
        #endregion
        
        #region Parameter NFSFileShareDefaults_DirectoryMode
        /// <summary>
        /// <para>
        /// <para>The Unix directory mode in the form "nnnn". For example, <code>0666</code> represents
        /// the default access mode for all directories inside the file share. The default value
        /// is <code>0777</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NFSFileShareDefaults_DirectoryMode { get; set; }
        #endregion
        
        #region Parameter NFSFileShareDefaults_FileMode
        /// <summary>
        /// <para>
        /// <para>The Unix file mode in the form "nnnn". For example, <code>0666</code> represents the
        /// default file mode inside the file share. The default value is <code>0666</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NFSFileShareDefaults_FileMode { get; set; }
        #endregion
        
        #region Parameter FileShareARN
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the file share to be updated.</para>
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
        public System.String FileShareARN { get; set; }
        #endregion
        
        #region Parameter FileShareName
        /// <summary>
        /// <para>
        /// <para>The name of the file share. Optional.</para><note><para><code>FileShareName</code> must be set if an S3 prefix name is set in <code>LocationARN</code>,
        /// or if an access point or access point alias is used.</para></note>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String FileShareName { get; set; }
        #endregion
        
        #region Parameter NFSFileShareDefaults_GroupId
        /// <summary>
        /// <para>
        /// <para>The default group ID for the file share (unless the files have another group ID specified).
        /// The default value is <code>nfsnobody</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int64? NFSFileShareDefaults_GroupId { get; set; }
        #endregion
        
        #region Parameter GuessMIMETypeEnabled
        /// <summary>
        /// <para>
        /// <para>A value that enables guessing of the MIME type for uploaded objects based on file
        /// extensions. Set this value to <code>true</code> to enable MIME type guessing, otherwise
        /// set to <code>false</code>. The default value is <code>true</code>.</para><para>Valid Values: <code>true</code> | <code>false</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? GuessMIMETypeEnabled { get; set; }
        #endregion
        
        #region Parameter KMSEncrypted
        /// <summary>
        /// <para>
        /// <para>Set to <code>true</code> to use Amazon S3 server-side encryption with your own KMS
        /// key, or <code>false</code> to use a key managed by Amazon S3. Optional.</para><para>Valid Values: <code>true</code> | <code>false</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? KMSEncrypted { get; set; }
        #endregion
        
        #region Parameter KMSKey
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of a symmetric customer master key (CMK) used for Amazon
        /// S3 server-side encryption. Storage Gateway does not support asymmetric CMKs. This
        /// value can only be set when <code>KMSEncrypted</code> is <code>true</code>. Optional.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String KMSKey { get; set; }
        #endregion
        
        #region Parameter NotificationPolicy
        /// <summary>
        /// <para>
        /// <para>The notification policy of the file share. <code>SettlingTimeInSeconds</code> controls
        /// the number of seconds to wait after the last point in time a client wrote to a file
        /// before generating an <code>ObjectUploaded</code> notification. Because clients can
        /// make many small writes to files, it's best to set this parameter for as long as possible
        /// to avoid generating multiple notifications for the same file in a small time period.</para><note><para><code>SettlingTimeInSeconds</code> has no effect on the timing of the object uploading
        /// to Amazon S3, only the timing of the notification.</para></note><para>The following example sets <code>NotificationPolicy</code> on with <code>SettlingTimeInSeconds</code>
        /// set to 60.</para><para><code>{\"Upload\": {\"SettlingTimeInSeconds\": 60}}</code></para><para>The following example sets <code>NotificationPolicy</code> off.</para><para><code>{}</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NotificationPolicy { get; set; }
        #endregion
        
        #region Parameter ObjectACL
        /// <summary>
        /// <para>
        /// <para>A value that sets the access control list (ACL) permission for objects in the S3 bucket
        /// that a S3 File Gateway puts objects into. The default value is <code>private</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.StorageGateway.ObjectACL")]
        public Amazon.StorageGateway.ObjectACL ObjectACL { get; set; }
        #endregion
        
        #region Parameter NFSFileShareDefaults_OwnerId
        /// <summary>
        /// <para>
        /// <para>The default owner ID for files in the file share (unless the files have another owner
        /// ID specified). The default value is <code>nfsnobody</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int64? NFSFileShareDefaults_OwnerId { get; set; }
        #endregion
        
        #region Parameter ReadOnly
        /// <summary>
        /// <para>
        /// <para>A value that sets the write status of a file share. Set this value to <code>true</code>
        /// to set the write status to read-only, otherwise set to <code>false</code>.</para><para>Valid Values: <code>true</code> | <code>false</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? ReadOnly { get; set; }
        #endregion
        
        #region Parameter RequesterPay
        /// <summary>
        /// <para>
        /// <para>A value that sets who pays the cost of the request and the cost associated with data
        /// download from the S3 bucket. If this value is set to <code>true</code>, the requester
        /// pays the costs; otherwise, the S3 bucket owner pays. However, the S3 bucket owner
        /// always pays the cost of storing data.</para><note><para><code>RequesterPays</code> is a configuration for the S3 bucket that backs the file
        /// share, so make sure that the configuration on the file share is the same as the S3
        /// bucket configuration.</para></note><para>Valid Values: <code>true</code> | <code>false</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("RequesterPays")]
        public System.Boolean? RequesterPay { get; set; }
        #endregion
        
        #region Parameter Squash
        /// <summary>
        /// <para>
        /// <para>The user mapped to anonymous user.</para><para>Valid values are the following:</para><ul><li><para><code>RootSquash</code>: Only root is mapped to anonymous user.</para></li><li><para><code>NoSquash</code>: No one is mapped to anonymous user.</para></li><li><para><code>AllSquash</code>: Everyone is mapped to anonymous user.</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Squash { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'FileShareARN'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.StorageGateway.Model.UpdateNFSFileShareResponse).
        /// Specifying the name of a property of type Amazon.StorageGateway.Model.UpdateNFSFileShareResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "FileShareARN";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the FileShareARN parameter.
        /// The -PassThru parameter is deprecated, use -Select '^FileShareARN' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^FileShareARN' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.FileShareARN), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-SGNFSFileShare (UpdateNFSFileShare)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.StorageGateway.Model.UpdateNFSFileShareResponse, UpdateSGNFSFileShareCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.FileShareARN;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.AuditDestinationARN = this.AuditDestinationARN;
            context.CacheAttributes_CacheStaleTimeoutInSecond = this.CacheAttributes_CacheStaleTimeoutInSecond;
            if (this.ClientList != null)
            {
                context.ClientList = new List<System.String>(this.ClientList);
            }
            context.DefaultStorageClass = this.DefaultStorageClass;
            context.FileShareARN = this.FileShareARN;
            #if MODULAR
            if (this.FileShareARN == null && ParameterWasBound(nameof(this.FileShareARN)))
            {
                WriteWarning("You are passing $null as a value for parameter FileShareARN which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.FileShareName = this.FileShareName;
            context.GuessMIMETypeEnabled = this.GuessMIMETypeEnabled;
            context.KMSEncrypted = this.KMSEncrypted;
            context.KMSKey = this.KMSKey;
            context.NFSFileShareDefaults_DirectoryMode = this.NFSFileShareDefaults_DirectoryMode;
            context.NFSFileShareDefaults_FileMode = this.NFSFileShareDefaults_FileMode;
            context.NFSFileShareDefaults_GroupId = this.NFSFileShareDefaults_GroupId;
            context.NFSFileShareDefaults_OwnerId = this.NFSFileShareDefaults_OwnerId;
            context.NotificationPolicy = this.NotificationPolicy;
            context.ObjectACL = this.ObjectACL;
            context.ReadOnly = this.ReadOnly;
            context.RequesterPay = this.RequesterPay;
            context.Squash = this.Squash;
            
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
            var request = new Amazon.StorageGateway.Model.UpdateNFSFileShareRequest();
            
            if (cmdletContext.AuditDestinationARN != null)
            {
                request.AuditDestinationARN = cmdletContext.AuditDestinationARN;
            }
            
             // populate CacheAttributes
            var requestCacheAttributesIsNull = true;
            request.CacheAttributes = new Amazon.StorageGateway.Model.CacheAttributes();
            System.Int32? requestCacheAttributes_cacheAttributes_CacheStaleTimeoutInSecond = null;
            if (cmdletContext.CacheAttributes_CacheStaleTimeoutInSecond != null)
            {
                requestCacheAttributes_cacheAttributes_CacheStaleTimeoutInSecond = cmdletContext.CacheAttributes_CacheStaleTimeoutInSecond.Value;
            }
            if (requestCacheAttributes_cacheAttributes_CacheStaleTimeoutInSecond != null)
            {
                request.CacheAttributes.CacheStaleTimeoutInSeconds = requestCacheAttributes_cacheAttributes_CacheStaleTimeoutInSecond.Value;
                requestCacheAttributesIsNull = false;
            }
             // determine if request.CacheAttributes should be set to null
            if (requestCacheAttributesIsNull)
            {
                request.CacheAttributes = null;
            }
            if (cmdletContext.ClientList != null)
            {
                request.ClientList = cmdletContext.ClientList;
            }
            if (cmdletContext.DefaultStorageClass != null)
            {
                request.DefaultStorageClass = cmdletContext.DefaultStorageClass;
            }
            if (cmdletContext.FileShareARN != null)
            {
                request.FileShareARN = cmdletContext.FileShareARN;
            }
            if (cmdletContext.FileShareName != null)
            {
                request.FileShareName = cmdletContext.FileShareName;
            }
            if (cmdletContext.GuessMIMETypeEnabled != null)
            {
                request.GuessMIMETypeEnabled = cmdletContext.GuessMIMETypeEnabled.Value;
            }
            if (cmdletContext.KMSEncrypted != null)
            {
                request.KMSEncrypted = cmdletContext.KMSEncrypted.Value;
            }
            if (cmdletContext.KMSKey != null)
            {
                request.KMSKey = cmdletContext.KMSKey;
            }
            
             // populate NFSFileShareDefaults
            var requestNFSFileShareDefaultsIsNull = true;
            request.NFSFileShareDefaults = new Amazon.StorageGateway.Model.NFSFileShareDefaults();
            System.String requestNFSFileShareDefaults_nFSFileShareDefaults_DirectoryMode = null;
            if (cmdletContext.NFSFileShareDefaults_DirectoryMode != null)
            {
                requestNFSFileShareDefaults_nFSFileShareDefaults_DirectoryMode = cmdletContext.NFSFileShareDefaults_DirectoryMode;
            }
            if (requestNFSFileShareDefaults_nFSFileShareDefaults_DirectoryMode != null)
            {
                request.NFSFileShareDefaults.DirectoryMode = requestNFSFileShareDefaults_nFSFileShareDefaults_DirectoryMode;
                requestNFSFileShareDefaultsIsNull = false;
            }
            System.String requestNFSFileShareDefaults_nFSFileShareDefaults_FileMode = null;
            if (cmdletContext.NFSFileShareDefaults_FileMode != null)
            {
                requestNFSFileShareDefaults_nFSFileShareDefaults_FileMode = cmdletContext.NFSFileShareDefaults_FileMode;
            }
            if (requestNFSFileShareDefaults_nFSFileShareDefaults_FileMode != null)
            {
                request.NFSFileShareDefaults.FileMode = requestNFSFileShareDefaults_nFSFileShareDefaults_FileMode;
                requestNFSFileShareDefaultsIsNull = false;
            }
            System.Int64? requestNFSFileShareDefaults_nFSFileShareDefaults_GroupId = null;
            if (cmdletContext.NFSFileShareDefaults_GroupId != null)
            {
                requestNFSFileShareDefaults_nFSFileShareDefaults_GroupId = cmdletContext.NFSFileShareDefaults_GroupId.Value;
            }
            if (requestNFSFileShareDefaults_nFSFileShareDefaults_GroupId != null)
            {
                request.NFSFileShareDefaults.GroupId = requestNFSFileShareDefaults_nFSFileShareDefaults_GroupId.Value;
                requestNFSFileShareDefaultsIsNull = false;
            }
            System.Int64? requestNFSFileShareDefaults_nFSFileShareDefaults_OwnerId = null;
            if (cmdletContext.NFSFileShareDefaults_OwnerId != null)
            {
                requestNFSFileShareDefaults_nFSFileShareDefaults_OwnerId = cmdletContext.NFSFileShareDefaults_OwnerId.Value;
            }
            if (requestNFSFileShareDefaults_nFSFileShareDefaults_OwnerId != null)
            {
                request.NFSFileShareDefaults.OwnerId = requestNFSFileShareDefaults_nFSFileShareDefaults_OwnerId.Value;
                requestNFSFileShareDefaultsIsNull = false;
            }
             // determine if request.NFSFileShareDefaults should be set to null
            if (requestNFSFileShareDefaultsIsNull)
            {
                request.NFSFileShareDefaults = null;
            }
            if (cmdletContext.NotificationPolicy != null)
            {
                request.NotificationPolicy = cmdletContext.NotificationPolicy;
            }
            if (cmdletContext.ObjectACL != null)
            {
                request.ObjectACL = cmdletContext.ObjectACL;
            }
            if (cmdletContext.ReadOnly != null)
            {
                request.ReadOnly = cmdletContext.ReadOnly.Value;
            }
            if (cmdletContext.RequesterPay != null)
            {
                request.RequesterPays = cmdletContext.RequesterPay.Value;
            }
            if (cmdletContext.Squash != null)
            {
                request.Squash = cmdletContext.Squash;
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
        
        private Amazon.StorageGateway.Model.UpdateNFSFileShareResponse CallAWSServiceOperation(IAmazonStorageGateway client, Amazon.StorageGateway.Model.UpdateNFSFileShareRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Storage Gateway", "UpdateNFSFileShare");
            try
            {
                #if DESKTOP
                return client.UpdateNFSFileShare(request);
                #elif CORECLR
                return client.UpdateNFSFileShareAsync(request).GetAwaiter().GetResult();
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
            public System.String AuditDestinationARN { get; set; }
            public System.Int32? CacheAttributes_CacheStaleTimeoutInSecond { get; set; }
            public List<System.String> ClientList { get; set; }
            public System.String DefaultStorageClass { get; set; }
            public System.String FileShareARN { get; set; }
            public System.String FileShareName { get; set; }
            public System.Boolean? GuessMIMETypeEnabled { get; set; }
            public System.Boolean? KMSEncrypted { get; set; }
            public System.String KMSKey { get; set; }
            public System.String NFSFileShareDefaults_DirectoryMode { get; set; }
            public System.String NFSFileShareDefaults_FileMode { get; set; }
            public System.Int64? NFSFileShareDefaults_GroupId { get; set; }
            public System.Int64? NFSFileShareDefaults_OwnerId { get; set; }
            public System.String NotificationPolicy { get; set; }
            public Amazon.StorageGateway.ObjectACL ObjectACL { get; set; }
            public System.Boolean? ReadOnly { get; set; }
            public System.Boolean? RequesterPay { get; set; }
            public System.String Squash { get; set; }
            public System.Func<Amazon.StorageGateway.Model.UpdateNFSFileShareResponse, UpdateSGNFSFileShareCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.FileShareARN;
        }
        
    }
}
