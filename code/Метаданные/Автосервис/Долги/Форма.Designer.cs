using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace Авто.Метаданные.Автосервис

{
    
    public partial class ДолгиФорма:NsgSoft.Forms.NsgReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ДолгиФорма));
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn1 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn2 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn3 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn4 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn5 = new NsgSoft.Forms.NsgIGridColumn();
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.vmoИтоги = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.vmoИтоги_Контрагент = new Авто.Метаданные.Автосервис.Контрагенты.ColumnDescriptor();
            this.vmoИтоги_НачОст = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.vmoИтоги_Приход = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.vmoИтоги_Расход = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.vmoИтоги_КонОст = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.nsgButton1 = new NsgSoft.Design.NsgButton();
            this.nsgPeriodPicker1 = new NsgSoft.Forms.NsgPeriodPicker();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoИтоги)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCreateReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateReport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreateReport.DisabledImageKey = "disabled_nsgdatadocument";
            this.btnCreateReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreateReport.ImageKey = "nsgdatadocument";
            this.btnCreateReport.Location = new System.Drawing.Point(0, 0);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(112, 28);
            this.btnCreateReport.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.btnCreateReport.TabIndex = 0;
            this.btnCreateReport.Text = "Сформировать";
            this.btnCreateReport.TextPosition = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelButtonReportForm
            // 
            this.panelButtonReportForm.AllowDrop = true;
            this.panelButtonReportForm.Controls.Add(this.formSettingsButton);
            this.panelButtonReportForm.Controls.Add(this.printButton);
            this.panelButtonReportForm.Controls.Add(this.btnCreateReport);
            this.panelButtonReportForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 523);
            this.panelButtonReportForm.Name = "panelButtonReportForm";
            this.panelButtonReportForm.Size = new System.Drawing.Size(1064, 28);
            this.panelButtonReportForm.TabIndex = 0;
            // 
            // printButton
            // 
            this.printButton.AutoSize = true;
            this.printButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.printButton.ButtonEnabled = true;
            this.printButton.ButtonImage = ((System.Drawing.Image)(resources.GetObject("printButton.ButtonImage")));
            this.printButton.ButtonText = "Печать";
            this.printButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.printButton.ImageKey = "Print";
            this.printButton.Location = new System.Drawing.Point(1044, 0);
            this.printButton.Name = "printButton";
            this.printButton.ShowImage = false;
            this.printButton.ShowText = false;
            this.printButton.Size = new System.Drawing.Size(20, 28);
            this.printButton.TabIndex = 1;
            // 
            // formSettingsButton
            // 
            this.formSettingsButton.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.formSettingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.formSettingsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.formSettingsButton.DisabledImageKey = "disabled_Settings";
            this.formSettingsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.formSettingsButton.ImageKey = "Settings";
            this.formSettingsButton.ImagePosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.formSettingsButton.Location = new System.Drawing.Point(112, 0);
            this.formSettingsButton.Name = "formSettingsButton";
            this.formSettingsButton.Size = new System.Drawing.Size(28, 28);
            this.formSettingsButton.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.formSettingsButton.TabIndex = 2;
            this.formSettingsButton.TextPosition = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nsgVisualMultipleObject
            // 
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.nsgVisualMultipleObject.MetaDataName = "";
            this.nsgVisualMultipleObject.FullName = "";
            // 
            // nsgIGrid1
            // 
            this.nsgIGrid1.Action = NsgSoft.DataObjects.FormShowMode.None;
            this.nsgIGrid1.AllowSaveColParamsToXML = true;
            this.nsgIGrid1.AllowSaveColPositionToXML = true;
            this.nsgIGrid1.AllowSaveColWidthToXML = true;
            this.nsgIGrid1.AllowSaveSettingsToXML = true;
            this.nsgIGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgIGrid1.AutoResizeCols = true;
            nsgIGridColumn1.AllowFilter = true;
            nsgIGridColumn1.AllowGroupSelect = false;
            nsgIGridColumn1.AllowResize = true;
            nsgIGridColumn1.AutoResize = true;
            nsgIGridColumn1.Caption = "";
            nsgIGridColumn1.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn1.DateFormat = null;
            nsgIGridColumn1.Name = "Контрагент";
            nsgIGridColumn1.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn1.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn1.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn1.UseAsHeaderImage = false;
            nsgIGridColumn1.Width = 100;
            nsgIGridColumn2.AllowFilter = true;
            nsgIGridColumn2.AllowGroupSelect = false;
            nsgIGridColumn2.AllowResize = true;
            nsgIGridColumn2.AutoResize = true;
            nsgIGridColumn2.Caption = "";
            nsgIGridColumn2.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn2.DateFormat = null;
            nsgIGridColumn2.Name = "НачОст";
            nsgIGridColumn2.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn2.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn2.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn2.UseAsHeaderImage = false;
            nsgIGridColumn2.Width = 100;
            nsgIGridColumn3.AllowFilter = true;
            nsgIGridColumn3.AllowGroupSelect = false;
            nsgIGridColumn3.AllowResize = true;
            nsgIGridColumn3.AutoResize = true;
            nsgIGridColumn3.Caption = "";
            nsgIGridColumn3.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn3.DateFormat = null;
            nsgIGridColumn3.Name = "Приход";
            nsgIGridColumn3.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn3.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn3.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn3.UseAsHeaderImage = false;
            nsgIGridColumn3.Width = 100;
            nsgIGridColumn4.AllowFilter = true;
            nsgIGridColumn4.AllowGroupSelect = false;
            nsgIGridColumn4.AllowResize = true;
            nsgIGridColumn4.AutoResize = true;
            nsgIGridColumn4.Caption = "";
            nsgIGridColumn4.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn4.DateFormat = null;
            nsgIGridColumn4.Name = "Расход";
            nsgIGridColumn4.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn4.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn4.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn4.UseAsHeaderImage = false;
            nsgIGridColumn4.Width = 100;
            nsgIGridColumn5.AllowFilter = true;
            nsgIGridColumn5.AllowGroupSelect = false;
            nsgIGridColumn5.AllowResize = true;
            nsgIGridColumn5.AutoResize = true;
            nsgIGridColumn5.Caption = "";
            nsgIGridColumn5.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn5.DateFormat = null;
            nsgIGridColumn5.Name = "КонОст";
            nsgIGridColumn5.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn5.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn5.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn5.UseAsHeaderImage = false;
            nsgIGridColumn5.Width = 100;
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn1);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn2);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn3);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn4);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn5);
            this.nsgIGrid1.Filter = false;
            this.nsgIGrid1.FrozenColumns = 0;
            this.nsgIGrid1.Grouping = true;
            this.nsgIGrid1.Hierarhy = true;
            this.nsgIGrid1.ImageList = null;
            this.nsgIGrid1.IsCanMultiSelect = false;
            this.nsgIGrid1.IsCanSingleSelect = false;
            this.nsgIGrid1.LineHeight = 20;
            this.nsgIGrid1.Location = new System.Drawing.Point(16, 12);
            this.nsgIGrid1.MarkReadOnly = false;
            this.nsgIGrid1.MasterObject = null;
            this.nsgIGrid1.Name = "NsgIGrid";
            this.nsgIGrid1.PageSelector = false;
            this.nsgIGrid1.ReadOnly = false;
            this.nsgIGrid1.RowChangeInterval = 200;
            this.nsgIGrid1.RowHeaderImageList = null;
            this.nsgIGrid1.RowMode = false;
            this.nsgIGrid1.ScrollWidth = 0;
            this.nsgIGrid1.SelectedRow = -1;
            this.nsgIGrid1.ShowHeader = true;
            this.nsgIGrid1.ShowLineImages = true;
            this.nsgIGrid1.ShowLineNumbers = false;
            this.nsgIGrid1.ShowPanel = true;
            this.nsgIGrid1.ShowTotals = false;
            this.nsgIGrid1.ShowTree = false;
            this.nsgIGrid1.Size = new System.Drawing.Size(1036, 311);
            this.nsgIGrid1.SourceObject = this.vmoИтоги;
            this.nsgIGrid1.TabIndex = 9;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            // 
            // vmoИтоги
            // 
            this.vmoИтоги.Columns.Collection.Add(this.vmoИтоги_Контрагент);
            this.vmoИтоги.Columns.Collection.Add(this.vmoИтоги_НачОст);
            this.vmoИтоги.Columns.Collection.Add(this.vmoИтоги_Приход);
            this.vmoИтоги.Columns.Collection.Add(this.vmoИтоги_Расход);
            this.vmoИтоги.Columns.Collection.Add(this.vmoИтоги_КонОст);
            this.vmoИтоги.IsActive = true;
            this.vmoИтоги.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoИтоги.MetaDataName = "";
            this.vmoИтоги.FullName = "";
            // 
            // vmoИтоги_Контрагент
            // 
            this.vmoИтоги_Контрагент.Caption = "Контрагент";
            this.vmoИтоги_Контрагент.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoИтоги_Контрагент.Name = "Контрагент";
            this.vmoИтоги_Контрагент.NSGType = typeof(Авто.Метаданные.Автосервис.Контрагенты);
            this.vmoИтоги_Контрагент.PropertyType = typeof(Авто.Метаданные.Автосервис.Контрагенты);
            this.vmoИтоги_Контрагент.SearchCondition.OwnerComponent = this.vmoИтоги_Контрагент;
            this.vmoИтоги_Контрагент.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoИтоги_НачОст
            // 
            this.vmoИтоги_НачОст.CalcTotal = false;
            this.vmoИтоги_НачОст.Caption = "НачОст";
            this.vmoИтоги_НачОст.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoИтоги_НачОст.Name = "НачОст";
            this.vmoИтоги_НачОст.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.vmoИтоги_НачОст.PropertyType = typeof(decimal);
            this.vmoИтоги_НачОст.SearchCondition.OwnerComponent = this.vmoИтоги_НачОст;
            this.vmoИтоги_НачОст.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoИтоги_Приход
            // 
            this.vmoИтоги_Приход.CalcTotal = false;
            this.vmoИтоги_Приход.Caption = "Приход";
            this.vmoИтоги_Приход.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoИтоги_Приход.Name = "Приход";
            this.vmoИтоги_Приход.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.vmoИтоги_Приход.PropertyType = typeof(decimal);
            this.vmoИтоги_Приход.SearchCondition.OwnerComponent = this.vmoИтоги_Приход;
            this.vmoИтоги_Приход.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoИтоги_Расход
            // 
            this.vmoИтоги_Расход.CalcTotal = false;
            this.vmoИтоги_Расход.Caption = "Расход";
            this.vmoИтоги_Расход.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoИтоги_Расход.Name = "Расход";
            this.vmoИтоги_Расход.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.vmoИтоги_Расход.PropertyType = typeof(decimal);
            this.vmoИтоги_Расход.SearchCondition.OwnerComponent = this.vmoИтоги_Расход;
            this.vmoИтоги_Расход.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoИтоги_КонОст
            // 
            this.vmoИтоги_КонОст.CalcTotal = false;
            this.vmoИтоги_КонОст.Caption = "КонОст";
            this.vmoИтоги_КонОст.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoИтоги_КонОст.Name = "КонОст";
            this.vmoИтоги_КонОст.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.vmoИтоги_КонОст.PropertyType = typeof(decimal);
            this.vmoИтоги_КонОст.SearchCondition.OwnerComponent = this.vmoИтоги_КонОст;
            this.vmoИтоги_КонОст.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgButton1
            // 
            this.nsgButton1.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgButton1.Location = new System.Drawing.Point(27, 373);
            this.nsgButton1.Name = "NsgButton";
            this.nsgButton1.Size = new System.Drawing.Size(85, 34);
            this.nsgButton1.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nsgButton1.TabIndex = 10;
            this.nsgButton1.Text = "nsgButton1";
            this.nsgButton1.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nsgButton1.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nsgButton1_AsyncClick);
            // 
            // nsgPeriodPicker1
            // 
            this.nsgPeriodPicker1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.nsgPeriodPicker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgPeriodPicker1.Location = new System.Drawing.Point(260, 373);
            this.nsgPeriodPicker1.MinimumSize = new System.Drawing.Size(2, 4);
            this.nsgPeriodPicker1.Name = "NsgPeriodPicker";
            this.nsgPeriodPicker1.Size = new System.Drawing.Size(191, 27);
            this.nsgPeriodPicker1.TabIndex = 11;
            // 
            // ДолгиФорма
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BlockShowReport = false;
            this.ClientSize = new System.Drawing.Size(1064, 571);
            this.Controls.Add(this.nsgPeriodPicker1);
            this.Controls.Add(this.nsgButton1);
            this.Controls.Add(this.nsgIGrid1);
            this.Controls.Add(this.panelButtonReportForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(15, -18);
            this.MainReport = null;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NsgReportForm";
            this.SelectedObject = null;
            this.TabText = "NsgMultipleObjectBaseForm";
            this.Text = "NsgReportForm";
            this.Controls.SetChildIndex(this.panelButtonReportForm, 0);
            this.Controls.SetChildIndex(this.nsgIGrid1, 0);
            this.Controls.SetChildIndex(this.nsgButton1, 0);
            this.Controls.SetChildIndex(this.nsgPeriodPicker1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).EndInit();
            this.panelButtonReportForm.ResumeLayout(false);
            this.panelButtonReportForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoИтоги)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected NsgSoft.Design.NsgButton nsgButton1;
        protected Контрагенты.ColumnDescriptor vmoИтоги_Контрагент;
        protected NsgPeriodPicker nsgPeriodPicker1;
        private NsgIGrid nsgIGrid1;
        protected NsgColumnDescriptor.Decimal vmoИтоги_НачОст;
        protected NsgColumnDescriptor.Decimal vmoИтоги_Приход;
        private NsgColumnDescriptor.Decimal vmoИтоги_Расход;
        private NsgColumnDescriptor.Decimal vmoИтоги_КонОст;
        private NsgVisualMultipleObject vmoИтоги;
    }
}