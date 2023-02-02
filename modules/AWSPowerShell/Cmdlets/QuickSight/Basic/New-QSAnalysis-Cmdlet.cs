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
using Amazon.QuickSight;
using Amazon.QuickSight.Model;

namespace Amazon.PowerShell.Cmdlets.QS
{
    /// <summary>
    /// Creates an analysis in Amazon QuickSight. Analyses can be created either from a template
    /// or from an <code>AnalysisDefinition</code>.
    /// </summary>
    [Cmdlet("New", "QSAnalysis", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.QuickSight.Model.CreateAnalysisResponse")]
    [AWSCmdlet("Calls the Amazon QuickSight CreateAnalysis API operation.", Operation = new[] {"CreateAnalysis"}, SelectReturnType = typeof(Amazon.QuickSight.Model.CreateAnalysisResponse))]
    [AWSCmdletOutput("Amazon.QuickSight.Model.CreateAnalysisResponse",
        "This cmdlet returns an Amazon.QuickSight.Model.CreateAnalysisResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewQSAnalysisCmdlet : AmazonQuickSightClientCmdlet, IExecutor
    {
        
        #region Parameter AnalysisId
        /// <summary>
        /// <para>
        /// <para>The ID for the analysis that you're creating. This ID displays in the URL of the analysis.</para>
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
        public System.String AnalysisId { get; set; }
        #endregion
        
        #region Parameter SourceTemplate_Arn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the source template of an analysis.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SourceEntity_SourceTemplate_Arn")]
        public System.String SourceTemplate_Arn { get; set; }
        #endregion
        
        #region Parameter AwsAccountId
        /// <summary>
        /// <para>
        /// <para>The ID of the Amazon Web Services account where you are creating an analysis.</para>
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
        public System.String AwsAccountId { get; set; }
        #endregion
        
        #region Parameter PaperMargin_Bottom
        /// <summary>
        /// <para>
        /// <para>Define the bottom spacing.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin_Bottom")]
        public System.String PaperMargin_Bottom { get; set; }
        #endregion
        
        #region Parameter Definition_CalculatedField
        /// <summary>
        /// <para>
        /// <para>An array of calculated field definitions for the analysis.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Definition_CalculatedFields")]
        public Amazon.QuickSight.Model.CalculatedField[] Definition_CalculatedField { get; set; }
        #endregion
        
        #region Parameter Definition_ColumnConfiguration
        /// <summary>
        /// <para>
        /// <para> An array of analysis-level column configurations. Column configurations can be used
        /// to set default formatting for a column to be used throughout an analysis. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Definition_ColumnConfigurations")]
        public Amazon.QuickSight.Model.ColumnConfiguration[] Definition_ColumnConfiguration { get; set; }
        #endregion
        
        #region Parameter Definition_DataSetIdentifierDeclaration
        /// <summary>
        /// <para>
        /// <para>An array of dataset identifier declarations. This mapping allows the usage of dataset
        /// identifiers instead of dataset ARNs throughout analysis sub-structures.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Definition_DataSetIdentifierDeclarations")]
        public Amazon.QuickSight.Model.DataSetIdentifierDeclaration[] Definition_DataSetIdentifierDeclaration { get; set; }
        #endregion
        
        #region Parameter SourceTemplate_DataSetReference
        /// <summary>
        /// <para>
        /// <para>The dataset references of the source template of an analysis.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SourceEntity_SourceTemplate_DataSetReferences")]
        public Amazon.QuickSight.Model.DataSetReference[] SourceTemplate_DataSetReference { get; set; }
        #endregion
        
        #region Parameter Parameters_DateTimeParameter
        /// <summary>
        /// <para>
        /// <para>The parameters that have a data type of date-time.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Parameters_DateTimeParameters")]
        public Amazon.QuickSight.Model.DateTimeParameter[] Parameters_DateTimeParameter { get; set; }
        #endregion
        
        #region Parameter Parameters_DecimalParameter
        /// <summary>
        /// <para>
        /// <para>The parameters that have a data type of decimal.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Parameters_DecimalParameters")]
        public Amazon.QuickSight.Model.DecimalParameter[] Parameters_DecimalParameter { get; set; }
        #endregion
        
        #region Parameter Definition_FilterGroup
        /// <summary>
        /// <para>
        /// <para>Filter definitions for an analysis.</para><para>For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/adding-a-filter.html">Filtering
        /// Data in Amazon QuickSight</a> in the <i>Amazon QuickSight User Guide</i>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Definition_FilterGroups")]
        public Amazon.QuickSight.Model.FilterGroup[] Definition_FilterGroup { get; set; }
        #endregion
        
        #region Parameter Parameters_IntegerParameter
        /// <summary>
        /// <para>
        /// <para>The parameters that have a data type of integer.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Parameters_IntegerParameters")]
        public Amazon.QuickSight.Model.IntegerParameter[] Parameters_IntegerParameter { get; set; }
        #endregion
        
        #region Parameter PaperMargin_Left
        /// <summary>
        /// <para>
        /// <para>Define the left spacing.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin_Left")]
        public System.String PaperMargin_Left { get; set; }
        #endregion
        
        #region Parameter Name
        /// <summary>
        /// <para>
        /// <para>A descriptive name for the analysis that you're creating. This name displays for the
        /// analysis in the Amazon QuickSight console. </para>
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
        
        #region Parameter Definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptions_OptimizedViewPortWidth
        /// <summary>
        /// <para>
        /// <para>The width that the view port will be optimized for when the layout renders.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ScreenCanvasSizeOptions_OptimizedViewPortWidth")]
        public System.String Definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptions_OptimizedViewPortWidth { get; set; }
        #endregion
        
        #region Parameter Definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions_OptimizedViewPortWidth
        /// <summary>
        /// <para>
        /// <para>The width that the view port will be optimized for when the layout renders.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions_OptimizedViewPortWidth { get; set; }
        #endregion
        
        #region Parameter PaperCanvasSizeOptions_PaperOrientation
        /// <summary>
        /// <para>
        /// <para>The paper orientation that is used to define canvas dimensions. Choose one of the
        /// following options:</para><ul><li><para>PORTRAIT</para></li><li><para>LANDSCAPE</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperOrientation")]
        [AWSConstantClassSource("Amazon.QuickSight.PaperOrientation")]
        public Amazon.QuickSight.PaperOrientation PaperCanvasSizeOptions_PaperOrientation { get; set; }
        #endregion
        
        #region Parameter PaperCanvasSizeOptions_PaperSize
        /// <summary>
        /// <para>
        /// <para>The paper size that is used to define canvas dimensions.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperSize")]
        [AWSConstantClassSource("Amazon.QuickSight.PaperSize")]
        public Amazon.QuickSight.PaperSize PaperCanvasSizeOptions_PaperSize { get; set; }
        #endregion
        
        #region Parameter Definition_ParameterDeclaration
        /// <summary>
        /// <para>
        /// <para>An array of parameter declarations for an analysis.</para><para>Parameters are named variables that can transfer a value for use by an action or an
        /// object.</para><para>For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/parameters-in-quicksight.html">Parameters
        /// in Amazon QuickSight</a> in the <i>Amazon QuickSight User Guide</i>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Definition_ParameterDeclarations")]
        public Amazon.QuickSight.Model.ParameterDeclaration[] Definition_ParameterDeclaration { get; set; }
        #endregion
        
        #region Parameter Permission
        /// <summary>
        /// <para>
        /// <para>A structure that describes the principals and the resource-level permissions on an
        /// analysis. You can use the <code>Permissions</code> structure to grant permissions
        /// by providing a list of Identity and Access Management (IAM) action information for
        /// each principal listed by Amazon Resource Name (ARN). </para><para>To specify no permissions, omit <code>Permissions</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Permissions")]
        public Amazon.QuickSight.Model.ResourcePermission[] Permission { get; set; }
        #endregion
        
        #region Parameter ScreenCanvasSizeOptions_ResizeOption
        /// <summary>
        /// <para>
        /// <para>This value determines the layout behavior when the viewport is resized.</para><ul><li><para><code>FIXED</code>: A fixed width will be used when optimizing the layout. In the
        /// Amazon QuickSight console, this option is called <code>Classic</code>.</para></li><li><para><code>RESPONSIVE</code>: The width of the canvas will be responsive and optimized
        /// to the view port. In the Amazon QuickSight console, this option is called <code>Tiled</code>.</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions_ResizeOption")]
        [AWSConstantClassSource("Amazon.QuickSight.ResizeOption")]
        public Amazon.QuickSight.ResizeOption ScreenCanvasSizeOptions_ResizeOption { get; set; }
        #endregion
        
        #region Parameter PaperMargin_Right
        /// <summary>
        /// <para>
        /// <para>Define the right spacing.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin_Right")]
        public System.String PaperMargin_Right { get; set; }
        #endregion
        
        #region Parameter DefaultNewSheetConfiguration_SheetContentType
        /// <summary>
        /// <para>
        /// <para>The option that determines the sheet content type.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Definition_AnalysisDefaults_DefaultNewSheetConfiguration_SheetContentType")]
        [AWSConstantClassSource("Amazon.QuickSight.SheetContentType")]
        public Amazon.QuickSight.SheetContentType DefaultNewSheetConfiguration_SheetContentType { get; set; }
        #endregion
        
        #region Parameter Definition_Sheet
        /// <summary>
        /// <para>
        /// <para>An array of sheet definitions for an analysis. Each <code>SheetDefinition</code> provides
        /// detailed information about a sheet within this analysis.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Definition_Sheets")]
        public Amazon.QuickSight.Model.SheetDefinition[] Definition_Sheet { get; set; }
        #endregion
        
        #region Parameter Parameters_StringParameter
        /// <summary>
        /// <para>
        /// <para>The parameters that have a data type of string.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Parameters_StringParameters")]
        public Amazon.QuickSight.Model.StringParameter[] Parameters_StringParameter { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>Contains a map of the key-value pairs for the resource tag or tags assigned to the
        /// analysis.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.QuickSight.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter ThemeArn
        /// <summary>
        /// <para>
        /// <para>The ARN for the theme to apply to the analysis that you're creating. To see the theme
        /// in the Amazon QuickSight console, make sure that you have access to it.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ThemeArn { get; set; }
        #endregion
        
        #region Parameter PaperMargin_Top
        /// <summary>
        /// <para>
        /// <para>Define the top spacing.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin_Top")]
        public System.String PaperMargin_Top { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.QuickSight.Model.CreateAnalysisResponse).
        /// Specifying the name of a property of type Amazon.QuickSight.Model.CreateAnalysisResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the AnalysisId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^AnalysisId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^AnalysisId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.AnalysisId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-QSAnalysis (CreateAnalysis)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.QuickSight.Model.CreateAnalysisResponse, NewQSAnalysisCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.AnalysisId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.AnalysisId = this.AnalysisId;
            #if MODULAR
            if (this.AnalysisId == null && ParameterWasBound(nameof(this.AnalysisId)))
            {
                WriteWarning("You are passing $null as a value for parameter AnalysisId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.AwsAccountId = this.AwsAccountId;
            #if MODULAR
            if (this.AwsAccountId == null && ParameterWasBound(nameof(this.AwsAccountId)))
            {
                WriteWarning("You are passing $null as a value for parameter AwsAccountId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptions_OptimizedViewPortWidth = this.Definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptions_OptimizedViewPortWidth;
            context.Definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions_OptimizedViewPortWidth = this.Definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions_OptimizedViewPortWidth;
            context.ScreenCanvasSizeOptions_ResizeOption = this.ScreenCanvasSizeOptions_ResizeOption;
            context.PaperMargin_Bottom = this.PaperMargin_Bottom;
            context.PaperMargin_Left = this.PaperMargin_Left;
            context.PaperMargin_Right = this.PaperMargin_Right;
            context.PaperMargin_Top = this.PaperMargin_Top;
            context.PaperCanvasSizeOptions_PaperOrientation = this.PaperCanvasSizeOptions_PaperOrientation;
            context.PaperCanvasSizeOptions_PaperSize = this.PaperCanvasSizeOptions_PaperSize;
            context.DefaultNewSheetConfiguration_SheetContentType = this.DefaultNewSheetConfiguration_SheetContentType;
            if (this.Definition_CalculatedField != null)
            {
                context.Definition_CalculatedField = new List<Amazon.QuickSight.Model.CalculatedField>(this.Definition_CalculatedField);
            }
            if (this.Definition_ColumnConfiguration != null)
            {
                context.Definition_ColumnConfiguration = new List<Amazon.QuickSight.Model.ColumnConfiguration>(this.Definition_ColumnConfiguration);
            }
            if (this.Definition_DataSetIdentifierDeclaration != null)
            {
                context.Definition_DataSetIdentifierDeclaration = new List<Amazon.QuickSight.Model.DataSetIdentifierDeclaration>(this.Definition_DataSetIdentifierDeclaration);
            }
            if (this.Definition_FilterGroup != null)
            {
                context.Definition_FilterGroup = new List<Amazon.QuickSight.Model.FilterGroup>(this.Definition_FilterGroup);
            }
            if (this.Definition_ParameterDeclaration != null)
            {
                context.Definition_ParameterDeclaration = new List<Amazon.QuickSight.Model.ParameterDeclaration>(this.Definition_ParameterDeclaration);
            }
            if (this.Definition_Sheet != null)
            {
                context.Definition_Sheet = new List<Amazon.QuickSight.Model.SheetDefinition>(this.Definition_Sheet);
            }
            context.Name = this.Name;
            #if MODULAR
            if (this.Name == null && ParameterWasBound(nameof(this.Name)))
            {
                WriteWarning("You are passing $null as a value for parameter Name which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.Parameters_DateTimeParameter != null)
            {
                context.Parameters_DateTimeParameter = new List<Amazon.QuickSight.Model.DateTimeParameter>(this.Parameters_DateTimeParameter);
            }
            if (this.Parameters_DecimalParameter != null)
            {
                context.Parameters_DecimalParameter = new List<Amazon.QuickSight.Model.DecimalParameter>(this.Parameters_DecimalParameter);
            }
            if (this.Parameters_IntegerParameter != null)
            {
                context.Parameters_IntegerParameter = new List<Amazon.QuickSight.Model.IntegerParameter>(this.Parameters_IntegerParameter);
            }
            if (this.Parameters_StringParameter != null)
            {
                context.Parameters_StringParameter = new List<Amazon.QuickSight.Model.StringParameter>(this.Parameters_StringParameter);
            }
            if (this.Permission != null)
            {
                context.Permission = new List<Amazon.QuickSight.Model.ResourcePermission>(this.Permission);
            }
            context.SourceTemplate_Arn = this.SourceTemplate_Arn;
            if (this.SourceTemplate_DataSetReference != null)
            {
                context.SourceTemplate_DataSetReference = new List<Amazon.QuickSight.Model.DataSetReference>(this.SourceTemplate_DataSetReference);
            }
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.QuickSight.Model.Tag>(this.Tag);
            }
            context.ThemeArn = this.ThemeArn;
            
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
            var request = new Amazon.QuickSight.Model.CreateAnalysisRequest();
            
            if (cmdletContext.AnalysisId != null)
            {
                request.AnalysisId = cmdletContext.AnalysisId;
            }
            if (cmdletContext.AwsAccountId != null)
            {
                request.AwsAccountId = cmdletContext.AwsAccountId;
            }
            
             // populate Definition
            var requestDefinitionIsNull = true;
            request.Definition = new Amazon.QuickSight.Model.AnalysisDefinition();
            List<Amazon.QuickSight.Model.CalculatedField> requestDefinition_definition_CalculatedField = null;
            if (cmdletContext.Definition_CalculatedField != null)
            {
                requestDefinition_definition_CalculatedField = cmdletContext.Definition_CalculatedField;
            }
            if (requestDefinition_definition_CalculatedField != null)
            {
                request.Definition.CalculatedFields = requestDefinition_definition_CalculatedField;
                requestDefinitionIsNull = false;
            }
            List<Amazon.QuickSight.Model.ColumnConfiguration> requestDefinition_definition_ColumnConfiguration = null;
            if (cmdletContext.Definition_ColumnConfiguration != null)
            {
                requestDefinition_definition_ColumnConfiguration = cmdletContext.Definition_ColumnConfiguration;
            }
            if (requestDefinition_definition_ColumnConfiguration != null)
            {
                request.Definition.ColumnConfigurations = requestDefinition_definition_ColumnConfiguration;
                requestDefinitionIsNull = false;
            }
            List<Amazon.QuickSight.Model.DataSetIdentifierDeclaration> requestDefinition_definition_DataSetIdentifierDeclaration = null;
            if (cmdletContext.Definition_DataSetIdentifierDeclaration != null)
            {
                requestDefinition_definition_DataSetIdentifierDeclaration = cmdletContext.Definition_DataSetIdentifierDeclaration;
            }
            if (requestDefinition_definition_DataSetIdentifierDeclaration != null)
            {
                request.Definition.DataSetIdentifierDeclarations = requestDefinition_definition_DataSetIdentifierDeclaration;
                requestDefinitionIsNull = false;
            }
            List<Amazon.QuickSight.Model.FilterGroup> requestDefinition_definition_FilterGroup = null;
            if (cmdletContext.Definition_FilterGroup != null)
            {
                requestDefinition_definition_FilterGroup = cmdletContext.Definition_FilterGroup;
            }
            if (requestDefinition_definition_FilterGroup != null)
            {
                request.Definition.FilterGroups = requestDefinition_definition_FilterGroup;
                requestDefinitionIsNull = false;
            }
            List<Amazon.QuickSight.Model.ParameterDeclaration> requestDefinition_definition_ParameterDeclaration = null;
            if (cmdletContext.Definition_ParameterDeclaration != null)
            {
                requestDefinition_definition_ParameterDeclaration = cmdletContext.Definition_ParameterDeclaration;
            }
            if (requestDefinition_definition_ParameterDeclaration != null)
            {
                request.Definition.ParameterDeclarations = requestDefinition_definition_ParameterDeclaration;
                requestDefinitionIsNull = false;
            }
            List<Amazon.QuickSight.Model.SheetDefinition> requestDefinition_definition_Sheet = null;
            if (cmdletContext.Definition_Sheet != null)
            {
                requestDefinition_definition_Sheet = cmdletContext.Definition_Sheet;
            }
            if (requestDefinition_definition_Sheet != null)
            {
                request.Definition.Sheets = requestDefinition_definition_Sheet;
                requestDefinitionIsNull = false;
            }
            Amazon.QuickSight.Model.AnalysisDefaults requestDefinition_definition_AnalysisDefaults = null;
            
             // populate AnalysisDefaults
            var requestDefinition_definition_AnalysisDefaultsIsNull = true;
            requestDefinition_definition_AnalysisDefaults = new Amazon.QuickSight.Model.AnalysisDefaults();
            Amazon.QuickSight.Model.DefaultNewSheetConfiguration requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration = null;
            
             // populate DefaultNewSheetConfiguration
            var requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfigurationIsNull = true;
            requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration = new Amazon.QuickSight.Model.DefaultNewSheetConfiguration();
            Amazon.QuickSight.SheetContentType requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_defaultNewSheetConfiguration_SheetContentType = null;
            if (cmdletContext.DefaultNewSheetConfiguration_SheetContentType != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_defaultNewSheetConfiguration_SheetContentType = cmdletContext.DefaultNewSheetConfiguration_SheetContentType;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_defaultNewSheetConfiguration_SheetContentType != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration.SheetContentType = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_defaultNewSheetConfiguration_SheetContentType;
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfigurationIsNull = false;
            }
            Amazon.QuickSight.Model.DefaultPaginatedLayoutConfiguration requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration = null;
            
             // populate PaginatedLayoutConfiguration
            var requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfigurationIsNull = true;
            requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration = new Amazon.QuickSight.Model.DefaultPaginatedLayoutConfiguration();
            Amazon.QuickSight.Model.DefaultSectionBasedLayoutConfiguration requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased = null;
            
             // populate SectionBased
            var requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBasedIsNull = true;
            requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased = new Amazon.QuickSight.Model.DefaultSectionBasedLayoutConfiguration();
            Amazon.QuickSight.Model.SectionBasedLayoutCanvasSizeOptions requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions = null;
            
             // populate CanvasSizeOptions
            var requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptionsIsNull = true;
            requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions = new Amazon.QuickSight.Model.SectionBasedLayoutCanvasSizeOptions();
            Amazon.QuickSight.Model.SectionBasedLayoutPaperCanvasSizeOptions requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions = null;
            
             // populate PaperCanvasSizeOptions
            var requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptionsIsNull = true;
            requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions = new Amazon.QuickSight.Model.SectionBasedLayoutPaperCanvasSizeOptions();
            Amazon.QuickSight.PaperOrientation requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_paperCanvasSizeOptions_PaperOrientation = null;
            if (cmdletContext.PaperCanvasSizeOptions_PaperOrientation != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_paperCanvasSizeOptions_PaperOrientation = cmdletContext.PaperCanvasSizeOptions_PaperOrientation;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_paperCanvasSizeOptions_PaperOrientation != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions.PaperOrientation = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_paperCanvasSizeOptions_PaperOrientation;
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptionsIsNull = false;
            }
            Amazon.QuickSight.PaperSize requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_paperCanvasSizeOptions_PaperSize = null;
            if (cmdletContext.PaperCanvasSizeOptions_PaperSize != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_paperCanvasSizeOptions_PaperSize = cmdletContext.PaperCanvasSizeOptions_PaperSize;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_paperCanvasSizeOptions_PaperSize != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions.PaperSize = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_paperCanvasSizeOptions_PaperSize;
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptionsIsNull = false;
            }
            Amazon.QuickSight.Model.Spacing requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin = null;
            
             // populate PaperMargin
            var requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMarginIsNull = true;
            requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin = new Amazon.QuickSight.Model.Spacing();
            System.String requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin_paperMargin_Bottom = null;
            if (cmdletContext.PaperMargin_Bottom != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin_paperMargin_Bottom = cmdletContext.PaperMargin_Bottom;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin_paperMargin_Bottom != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin.Bottom = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin_paperMargin_Bottom;
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMarginIsNull = false;
            }
            System.String requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin_paperMargin_Left = null;
            if (cmdletContext.PaperMargin_Left != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin_paperMargin_Left = cmdletContext.PaperMargin_Left;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin_paperMargin_Left != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin.Left = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin_paperMargin_Left;
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMarginIsNull = false;
            }
            System.String requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin_paperMargin_Right = null;
            if (cmdletContext.PaperMargin_Right != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin_paperMargin_Right = cmdletContext.PaperMargin_Right;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin_paperMargin_Right != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin.Right = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin_paperMargin_Right;
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMarginIsNull = false;
            }
            System.String requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin_paperMargin_Top = null;
            if (cmdletContext.PaperMargin_Top != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin_paperMargin_Top = cmdletContext.PaperMargin_Top;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin_paperMargin_Top != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin.Top = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin_paperMargin_Top;
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMarginIsNull = false;
            }
             // determine if requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin should be set to null
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMarginIsNull)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin = null;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions.PaperMargin = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions_PaperMargin;
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptionsIsNull = false;
            }
             // determine if requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions should be set to null
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptionsIsNull)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions = null;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions.PaperCanvasSizeOptions = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions_PaperCanvasSizeOptions;
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptionsIsNull = false;
            }
             // determine if requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions should be set to null
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptionsIsNull)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions = null;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased.CanvasSizeOptions = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased_CanvasSizeOptions;
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBasedIsNull = false;
            }
             // determine if requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased should be set to null
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBasedIsNull)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased = null;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration.SectionBased = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration_SectionBased;
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfigurationIsNull = false;
            }
             // determine if requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration should be set to null
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfigurationIsNull)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration = null;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration.PaginatedLayoutConfiguration = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_PaginatedLayoutConfiguration;
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfigurationIsNull = false;
            }
            Amazon.QuickSight.Model.DefaultInteractiveLayoutConfiguration requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration = null;
            
             // populate InteractiveLayoutConfiguration
            var requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfigurationIsNull = true;
            requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration = new Amazon.QuickSight.Model.DefaultInteractiveLayoutConfiguration();
            Amazon.QuickSight.Model.DefaultFreeFormLayoutConfiguration requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm = null;
            
             // populate FreeForm
            var requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeFormIsNull = true;
            requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm = new Amazon.QuickSight.Model.DefaultFreeFormLayoutConfiguration();
            Amazon.QuickSight.Model.FreeFormLayoutCanvasSizeOptions requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions = null;
            
             // populate CanvasSizeOptions
            var requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptionsIsNull = true;
            requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions = new Amazon.QuickSight.Model.FreeFormLayoutCanvasSizeOptions();
            Amazon.QuickSight.Model.FreeFormLayoutScreenCanvasSizeOptions requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptions = null;
            
             // populate ScreenCanvasSizeOptions
            var requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptionsIsNull = true;
            requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptions = new Amazon.QuickSight.Model.FreeFormLayoutScreenCanvasSizeOptions();
            System.String requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptions_OptimizedViewPortWidth = null;
            if (cmdletContext.Definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptions_OptimizedViewPortWidth != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptions_OptimizedViewPortWidth = cmdletContext.Definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptions_OptimizedViewPortWidth;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptions_OptimizedViewPortWidth != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptions.OptimizedViewPortWidth = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptions_OptimizedViewPortWidth;
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptionsIsNull = false;
            }
             // determine if requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptions should be set to null
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptionsIsNull)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptions = null;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptions != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions.ScreenCanvasSizeOptions = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptions;
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptionsIsNull = false;
            }
             // determine if requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions should be set to null
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptionsIsNull)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions = null;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm.CanvasSizeOptions = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions;
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeFormIsNull = false;
            }
             // determine if requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm should be set to null
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeFormIsNull)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm = null;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration.FreeForm = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm;
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfigurationIsNull = false;
            }
            Amazon.QuickSight.Model.DefaultGridLayoutConfiguration requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid = null;
            
             // populate Grid
            var requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_GridIsNull = true;
            requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid = new Amazon.QuickSight.Model.DefaultGridLayoutConfiguration();
            Amazon.QuickSight.Model.GridLayoutCanvasSizeOptions requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions = null;
            
             // populate CanvasSizeOptions
            var requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptionsIsNull = true;
            requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions = new Amazon.QuickSight.Model.GridLayoutCanvasSizeOptions();
            Amazon.QuickSight.Model.GridLayoutScreenCanvasSizeOptions requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions = null;
            
             // populate ScreenCanvasSizeOptions
            var requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptionsIsNull = true;
            requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions = new Amazon.QuickSight.Model.GridLayoutScreenCanvasSizeOptions();
            System.String requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions_OptimizedViewPortWidth = null;
            if (cmdletContext.Definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions_OptimizedViewPortWidth != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions_OptimizedViewPortWidth = cmdletContext.Definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions_OptimizedViewPortWidth;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions_OptimizedViewPortWidth != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions.OptimizedViewPortWidth = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions_OptimizedViewPortWidth;
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptionsIsNull = false;
            }
            Amazon.QuickSight.ResizeOption requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions_screenCanvasSizeOptions_ResizeOption = null;
            if (cmdletContext.ScreenCanvasSizeOptions_ResizeOption != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions_screenCanvasSizeOptions_ResizeOption = cmdletContext.ScreenCanvasSizeOptions_ResizeOption;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions_screenCanvasSizeOptions_ResizeOption != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions.ResizeOption = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions_screenCanvasSizeOptions_ResizeOption;
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptionsIsNull = false;
            }
             // determine if requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions should be set to null
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptionsIsNull)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions = null;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions.ScreenCanvasSizeOptions = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions;
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptionsIsNull = false;
            }
             // determine if requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions should be set to null
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptionsIsNull)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions = null;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid.CanvasSizeOptions = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions;
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_GridIsNull = false;
            }
             // determine if requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid should be set to null
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_GridIsNull)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid = null;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration.Grid = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid;
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfigurationIsNull = false;
            }
             // determine if requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration should be set to null
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfigurationIsNull)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration = null;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration != null)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration.InteractiveLayoutConfiguration = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration_definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration;
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfigurationIsNull = false;
            }
             // determine if requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration should be set to null
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfigurationIsNull)
            {
                requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration = null;
            }
            if (requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration != null)
            {
                requestDefinition_definition_AnalysisDefaults.DefaultNewSheetConfiguration = requestDefinition_definition_AnalysisDefaults_definition_AnalysisDefaults_DefaultNewSheetConfiguration;
                requestDefinition_definition_AnalysisDefaultsIsNull = false;
            }
             // determine if requestDefinition_definition_AnalysisDefaults should be set to null
            if (requestDefinition_definition_AnalysisDefaultsIsNull)
            {
                requestDefinition_definition_AnalysisDefaults = null;
            }
            if (requestDefinition_definition_AnalysisDefaults != null)
            {
                request.Definition.AnalysisDefaults = requestDefinition_definition_AnalysisDefaults;
                requestDefinitionIsNull = false;
            }
             // determine if request.Definition should be set to null
            if (requestDefinitionIsNull)
            {
                request.Definition = null;
            }
            if (cmdletContext.Name != null)
            {
                request.Name = cmdletContext.Name;
            }
            
             // populate Parameters
            var requestParametersIsNull = true;
            request.Parameters = new Amazon.QuickSight.Model.Parameters();
            List<Amazon.QuickSight.Model.DateTimeParameter> requestParameters_parameters_DateTimeParameter = null;
            if (cmdletContext.Parameters_DateTimeParameter != null)
            {
                requestParameters_parameters_DateTimeParameter = cmdletContext.Parameters_DateTimeParameter;
            }
            if (requestParameters_parameters_DateTimeParameter != null)
            {
                request.Parameters.DateTimeParameters = requestParameters_parameters_DateTimeParameter;
                requestParametersIsNull = false;
            }
            List<Amazon.QuickSight.Model.DecimalParameter> requestParameters_parameters_DecimalParameter = null;
            if (cmdletContext.Parameters_DecimalParameter != null)
            {
                requestParameters_parameters_DecimalParameter = cmdletContext.Parameters_DecimalParameter;
            }
            if (requestParameters_parameters_DecimalParameter != null)
            {
                request.Parameters.DecimalParameters = requestParameters_parameters_DecimalParameter;
                requestParametersIsNull = false;
            }
            List<Amazon.QuickSight.Model.IntegerParameter> requestParameters_parameters_IntegerParameter = null;
            if (cmdletContext.Parameters_IntegerParameter != null)
            {
                requestParameters_parameters_IntegerParameter = cmdletContext.Parameters_IntegerParameter;
            }
            if (requestParameters_parameters_IntegerParameter != null)
            {
                request.Parameters.IntegerParameters = requestParameters_parameters_IntegerParameter;
                requestParametersIsNull = false;
            }
            List<Amazon.QuickSight.Model.StringParameter> requestParameters_parameters_StringParameter = null;
            if (cmdletContext.Parameters_StringParameter != null)
            {
                requestParameters_parameters_StringParameter = cmdletContext.Parameters_StringParameter;
            }
            if (requestParameters_parameters_StringParameter != null)
            {
                request.Parameters.StringParameters = requestParameters_parameters_StringParameter;
                requestParametersIsNull = false;
            }
             // determine if request.Parameters should be set to null
            if (requestParametersIsNull)
            {
                request.Parameters = null;
            }
            if (cmdletContext.Permission != null)
            {
                request.Permissions = cmdletContext.Permission;
            }
            
             // populate SourceEntity
            var requestSourceEntityIsNull = true;
            request.SourceEntity = new Amazon.QuickSight.Model.AnalysisSourceEntity();
            Amazon.QuickSight.Model.AnalysisSourceTemplate requestSourceEntity_sourceEntity_SourceTemplate = null;
            
             // populate SourceTemplate
            var requestSourceEntity_sourceEntity_SourceTemplateIsNull = true;
            requestSourceEntity_sourceEntity_SourceTemplate = new Amazon.QuickSight.Model.AnalysisSourceTemplate();
            System.String requestSourceEntity_sourceEntity_SourceTemplate_sourceTemplate_Arn = null;
            if (cmdletContext.SourceTemplate_Arn != null)
            {
                requestSourceEntity_sourceEntity_SourceTemplate_sourceTemplate_Arn = cmdletContext.SourceTemplate_Arn;
            }
            if (requestSourceEntity_sourceEntity_SourceTemplate_sourceTemplate_Arn != null)
            {
                requestSourceEntity_sourceEntity_SourceTemplate.Arn = requestSourceEntity_sourceEntity_SourceTemplate_sourceTemplate_Arn;
                requestSourceEntity_sourceEntity_SourceTemplateIsNull = false;
            }
            List<Amazon.QuickSight.Model.DataSetReference> requestSourceEntity_sourceEntity_SourceTemplate_sourceTemplate_DataSetReference = null;
            if (cmdletContext.SourceTemplate_DataSetReference != null)
            {
                requestSourceEntity_sourceEntity_SourceTemplate_sourceTemplate_DataSetReference = cmdletContext.SourceTemplate_DataSetReference;
            }
            if (requestSourceEntity_sourceEntity_SourceTemplate_sourceTemplate_DataSetReference != null)
            {
                requestSourceEntity_sourceEntity_SourceTemplate.DataSetReferences = requestSourceEntity_sourceEntity_SourceTemplate_sourceTemplate_DataSetReference;
                requestSourceEntity_sourceEntity_SourceTemplateIsNull = false;
            }
             // determine if requestSourceEntity_sourceEntity_SourceTemplate should be set to null
            if (requestSourceEntity_sourceEntity_SourceTemplateIsNull)
            {
                requestSourceEntity_sourceEntity_SourceTemplate = null;
            }
            if (requestSourceEntity_sourceEntity_SourceTemplate != null)
            {
                request.SourceEntity.SourceTemplate = requestSourceEntity_sourceEntity_SourceTemplate;
                requestSourceEntityIsNull = false;
            }
             // determine if request.SourceEntity should be set to null
            if (requestSourceEntityIsNull)
            {
                request.SourceEntity = null;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            if (cmdletContext.ThemeArn != null)
            {
                request.ThemeArn = cmdletContext.ThemeArn;
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
        
        private Amazon.QuickSight.Model.CreateAnalysisResponse CallAWSServiceOperation(IAmazonQuickSight client, Amazon.QuickSight.Model.CreateAnalysisRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon QuickSight", "CreateAnalysis");
            try
            {
                #if DESKTOP
                return client.CreateAnalysis(request);
                #elif CORECLR
                return client.CreateAnalysisAsync(request).GetAwaiter().GetResult();
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
            public System.String AnalysisId { get; set; }
            public System.String AwsAccountId { get; set; }
            public System.String Definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_FreeForm_CanvasSizeOptions_ScreenCanvasSizeOptions_OptimizedViewPortWidth { get; set; }
            public System.String Definition_AnalysisDefaults_DefaultNewSheetConfiguration_InteractiveLayoutConfiguration_Grid_CanvasSizeOptions_ScreenCanvasSizeOptions_OptimizedViewPortWidth { get; set; }
            public Amazon.QuickSight.ResizeOption ScreenCanvasSizeOptions_ResizeOption { get; set; }
            public System.String PaperMargin_Bottom { get; set; }
            public System.String PaperMargin_Left { get; set; }
            public System.String PaperMargin_Right { get; set; }
            public System.String PaperMargin_Top { get; set; }
            public Amazon.QuickSight.PaperOrientation PaperCanvasSizeOptions_PaperOrientation { get; set; }
            public Amazon.QuickSight.PaperSize PaperCanvasSizeOptions_PaperSize { get; set; }
            public Amazon.QuickSight.SheetContentType DefaultNewSheetConfiguration_SheetContentType { get; set; }
            public List<Amazon.QuickSight.Model.CalculatedField> Definition_CalculatedField { get; set; }
            public List<Amazon.QuickSight.Model.ColumnConfiguration> Definition_ColumnConfiguration { get; set; }
            public List<Amazon.QuickSight.Model.DataSetIdentifierDeclaration> Definition_DataSetIdentifierDeclaration { get; set; }
            public List<Amazon.QuickSight.Model.FilterGroup> Definition_FilterGroup { get; set; }
            public List<Amazon.QuickSight.Model.ParameterDeclaration> Definition_ParameterDeclaration { get; set; }
            public List<Amazon.QuickSight.Model.SheetDefinition> Definition_Sheet { get; set; }
            public System.String Name { get; set; }
            public List<Amazon.QuickSight.Model.DateTimeParameter> Parameters_DateTimeParameter { get; set; }
            public List<Amazon.QuickSight.Model.DecimalParameter> Parameters_DecimalParameter { get; set; }
            public List<Amazon.QuickSight.Model.IntegerParameter> Parameters_IntegerParameter { get; set; }
            public List<Amazon.QuickSight.Model.StringParameter> Parameters_StringParameter { get; set; }
            public List<Amazon.QuickSight.Model.ResourcePermission> Permission { get; set; }
            public System.String SourceTemplate_Arn { get; set; }
            public List<Amazon.QuickSight.Model.DataSetReference> SourceTemplate_DataSetReference { get; set; }
            public List<Amazon.QuickSight.Model.Tag> Tag { get; set; }
            public System.String ThemeArn { get; set; }
            public System.Func<Amazon.QuickSight.Model.CreateAnalysisResponse, NewQSAnalysisCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
