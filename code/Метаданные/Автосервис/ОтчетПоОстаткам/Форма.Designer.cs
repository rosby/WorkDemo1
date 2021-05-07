using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace Авто.Метаданные.Автосервис

{
    
    public partial class ОтчетПоОстаткамФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ОтчетПоОстаткамФорма));
            NsgSoft.Forms.NsgGridColumn nsgGridColumn2 = new NsgSoft.Forms.NsgGridColumn();
            this.nsgObjectFilter1 = new NsgSoft.Forms.NsgIGridView.NsgObjectFilter();
            this.vmoФильтр = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Фильтр_Номенклатура = new Авто.Метаданные.Автосервис.Номенклатура.ColumnDescriptor();
            this.vmoИтоги = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Итоги_Номенклатура = new Авто.Метаданные.Автосервис.Номенклатура.ColumnDescriptor();
            this.Итоги_СуммаПриход = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Итоги_КоличествоПриход = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Итоги_СуммаРасход = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Итоги_СуммаКонОст = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Итоги_СуммаНачОст = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Итоги_КоличествоРасход = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Итоги_КоличествоНачОст = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Итоги_КоличествоКонОст = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.nsgPeriodPicker1 = new NsgSoft.Forms.NsgPeriodPicker();
            this.nsgGroupsList1 = new NsgSoft.ReportBuilder.NsgGroupsList();
            this.nsgReport1 = new NsgSoft.ReportBuilder.NsgReport(this.components);
            this.данныеИтоги = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.stiReportDataSource1 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("данныеИтоги", this.данныеИтоги);
            this.данныеИтогиДок = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.vmoИтогиДок = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.ИтогиДок_СуммаПриход = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ИтогиДок_СуммаРасход = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ИтогиДок_Номенклатура = new Авто.Метаданные.Автосервис.Номенклатура.ColumnDescriptor();
            this.ИтогиДок_Документ = new NsgSoft.Forms.NsgColumnDescriptor.UntypedMultipleObject();
            this.ИтогиДок_КоличествоПриход = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ИтогиДок_КоличествоРасход = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.stiReportDataSource2 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("данныеИтогиДок", this.данныеИтогиДок);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoИтоги)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgGroupsList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеИтоги)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеИтогиДок)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoИтогиДок)).BeginInit();
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
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 337);
            this.panelButtonReportForm.Name = "panelButtonReportForm";
            this.panelButtonReportForm.Size = new System.Drawing.Size(1214, 28);
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
            this.printButton.Location = new System.Drawing.Point(1194, 0);
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
            this.nsgVisualMultipleObject.MetaDataName = "";
            this.nsgVisualMultipleObject.FullName = "";
            // 
            // nsgObjectFilter1
            // 
            this.nsgObjectFilter1.AllowDrop = true;
            this.nsgObjectFilter1.AutoSetCompare = true;
            this.nsgObjectFilter1.BackColor = System.Drawing.SystemColors.Control;
            nsgGridColumn2.Caption = "";
            nsgGridColumn2.ChangedProperties = new string[] {
        "Visible"};
            nsgGridColumn2.ImportedFromVMO = false;
            nsgGridColumn2.Name = "Номенклатура";
            nsgGridColumn2.Root = this.nsgObjectFilter1.Columns.Collection;
            this.nsgObjectFilter1.Columns.Collection.Add(nsgGridColumn2);
            this.nsgObjectFilter1.FilterTypeCaption = "Тип Фильтра";
            this.nsgObjectFilter1.Grouping = false;
            this.nsgObjectFilter1.IsModify = true;
            this.nsgObjectFilter1.LineHeight = 20;
            this.nsgObjectFilter1.Location = new System.Drawing.Point(817, 28);
            this.nsgObjectFilter1.LockAdditionalColumns = false;
            this.nsgObjectFilter1.LockUpdateColumnsFromSourceObject = false;
            this.nsgObjectFilter1.Name = "NsgObjectFilter";
            this.nsgObjectFilter1.ReadOnly = false;
            this.nsgObjectFilter1.Regime = NsgSoft.Forms.NsgIGridView.NsgObjectFilter.Regimes.Filter;
            this.nsgObjectFilter1.RekvisitCaption = "Имя Фильтра";
            this.nsgObjectFilter1.SaveSettings = true;
            this.nsgObjectFilter1.Size = new System.Drawing.Size(367, 232);
            this.nsgObjectFilter1.SourceObject = this.vmoФильтр;
            this.nsgObjectFilter1.TabIndex = 0;
            this.nsgObjectFilter1.ValueCaption = "Фильтр";
            // 
            // vmoФильтр
            // 
            this.vmoФильтр.Columns.Collection.Add(this.Фильтр_Номенклатура);
            this.vmoФильтр.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoФильтр.MetaDataName = "";
            this.vmoФильтр.FullName = "";
            // 
            // Фильтр_Номенклатура
            // 
            this.Фильтр_Номенклатура.Caption = "Номенклатура";
            this.Фильтр_Номенклатура.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Фильтр_Номенклатура.Name = "Номенклатура";
            this.Фильтр_Номенклатура.NSGType = typeof(Авто.Метаданные.Автосервис.Номенклатура);
            this.Фильтр_Номенклатура.PropertyType = typeof(Авто.Метаданные.Автосервис.Номенклатура);
            this.Фильтр_Номенклатура.SearchCondition.OwnerComponent = this.Фильтр_Номенклатура;
            this.Фильтр_Номенклатура.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoИтоги
            // 
            this.vmoИтоги.Columns.Collection.Add(this.Итоги_Номенклатура);
            this.vmoИтоги.Columns.Collection.Add(this.Итоги_СуммаПриход);
            this.vmoИтоги.Columns.Collection.Add(this.Итоги_КоличествоПриход);
            this.vmoИтоги.Columns.Collection.Add(this.Итоги_СуммаРасход);
            this.vmoИтоги.Columns.Collection.Add(this.Итоги_СуммаКонОст);
            this.vmoИтоги.Columns.Collection.Add(this.Итоги_СуммаНачОст);
            this.vmoИтоги.Columns.Collection.Add(this.Итоги_КоличествоРасход);
            this.vmoИтоги.Columns.Collection.Add(this.Итоги_КоличествоНачОст);
            this.vmoИтоги.Columns.Collection.Add(this.Итоги_КоличествоКонОст);
            this.vmoИтоги.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoИтоги.MetaDataName = "";
            this.vmoИтоги.FullName = "";
            // 
            // Итоги_Номенклатура
            // 
            this.Итоги_Номенклатура.Caption = "Номенклатура";
            this.Итоги_Номенклатура.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Итоги_Номенклатура.Name = "Номенклатура";
            this.Итоги_Номенклатура.NSGType = typeof(Авто.Метаданные.Автосервис.Номенклатура);
            this.Итоги_Номенклатура.PropertyType = typeof(Авто.Метаданные.Автосервис.Номенклатура);
            this.Итоги_Номенклатура.SearchCondition.OwnerComponent = this.Итоги_Номенклатура;
            this.Итоги_Номенклатура.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Итоги_СуммаПриход
            // 
            this.Итоги_СуммаПриход.CalcTotal = false;
            this.Итоги_СуммаПриход.Caption = "СуммаПриход";
            this.Итоги_СуммаПриход.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Итоги_СуммаПриход.Name = "СуммаПриход";
            this.Итоги_СуммаПриход.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Итоги_СуммаПриход.PropertyType = typeof(decimal);
            this.Итоги_СуммаПриход.SearchCondition.OwnerComponent = this.Итоги_СуммаПриход;
            this.Итоги_СуммаПриход.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Итоги_КоличествоПриход
            // 
            this.Итоги_КоличествоПриход.CalcTotal = false;
            this.Итоги_КоличествоПриход.Caption = "КоличествоПриход";
            this.Итоги_КоличествоПриход.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Итоги_КоличествоПриход.Name = "КоличествоПриход";
            this.Итоги_КоличествоПриход.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Итоги_КоличествоПриход.PropertyType = typeof(decimal);
            this.Итоги_КоличествоПриход.SearchCondition.OwnerComponent = this.Итоги_КоличествоПриход;
            this.Итоги_КоличествоПриход.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Итоги_СуммаРасход
            // 
            this.Итоги_СуммаРасход.CalcTotal = false;
            this.Итоги_СуммаРасход.Caption = "СуммаРасход";
            this.Итоги_СуммаРасход.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Итоги_СуммаРасход.Name = "СуммаРасход";
            this.Итоги_СуммаРасход.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Итоги_СуммаРасход.PropertyType = typeof(decimal);
            this.Итоги_СуммаРасход.SearchCondition.OwnerComponent = this.Итоги_СуммаРасход;
            this.Итоги_СуммаРасход.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Итоги_СуммаКонОст
            // 
            this.Итоги_СуммаКонОст.CalcTotal = false;
            this.Итоги_СуммаКонОст.Caption = "СуммаКонОст";
            this.Итоги_СуммаКонОст.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Итоги_СуммаКонОст.Name = "СуммаКонОст";
            this.Итоги_СуммаКонОст.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Итоги_СуммаКонОст.PropertyType = typeof(decimal);
            this.Итоги_СуммаКонОст.SearchCondition.OwnerComponent = this.Итоги_СуммаКонОст;
            this.Итоги_СуммаКонОст.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Итоги_СуммаНачОст
            // 
            this.Итоги_СуммаНачОст.CalcTotal = false;
            this.Итоги_СуммаНачОст.Caption = "СуммаНачОст";
            this.Итоги_СуммаНачОст.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Итоги_СуммаНачОст.Name = "СуммаНачОст";
            this.Итоги_СуммаНачОст.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Итоги_СуммаНачОст.PropertyType = typeof(decimal);
            this.Итоги_СуммаНачОст.SearchCondition.OwnerComponent = this.Итоги_СуммаНачОст;
            this.Итоги_СуммаНачОст.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Итоги_КоличествоРасход
            // 
            this.Итоги_КоличествоРасход.CalcTotal = false;
            this.Итоги_КоличествоРасход.Caption = "КоличествоРасход";
            this.Итоги_КоличествоРасход.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Итоги_КоличествоРасход.Name = "КоличествоРасход";
            this.Итоги_КоличествоРасход.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Итоги_КоличествоРасход.PropertyType = typeof(decimal);
            this.Итоги_КоличествоРасход.SearchCondition.OwnerComponent = this.Итоги_КоличествоРасход;
            this.Итоги_КоличествоРасход.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Итоги_КоличествоНачОст
            // 
            this.Итоги_КоличествоНачОст.CalcTotal = false;
            this.Итоги_КоличествоНачОст.Caption = "КоличествоНачОст";
            this.Итоги_КоличествоНачОст.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Итоги_КоличествоНачОст.Name = "КоличествоНачОст";
            this.Итоги_КоличествоНачОст.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Итоги_КоличествоНачОст.PropertyType = typeof(decimal);
            this.Итоги_КоличествоНачОст.SearchCondition.OwnerComponent = this.Итоги_КоличествоНачОст;
            this.Итоги_КоличествоНачОст.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Итоги_КоличествоКонОст
            // 
            this.Итоги_КоличествоКонОст.CalcTotal = false;
            this.Итоги_КоличествоКонОст.Caption = "КоличетствоКонОст";
            this.Итоги_КоличествоКонОст.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Итоги_КоличествоКонОст.Name = "КоличетствоКонОст";
            this.Итоги_КоличествоКонОст.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Итоги_КоличествоКонОст.PropertyType = typeof(decimal);
            this.Итоги_КоличествоКонОст.SearchCondition.OwnerComponent = this.Итоги_КоличествоКонОст;
            this.Итоги_КоличествоКонОст.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgPeriodPicker1
            // 
            this.nsgPeriodPicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nsgPeriodPicker1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.nsgPeriodPicker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgPeriodPicker1.Location = new System.Drawing.Point(148, 44);
            this.nsgPeriodPicker1.MinimumSize = new System.Drawing.Size(2, 4);
            this.nsgPeriodPicker1.Name = "NsgPeriodPicker";
            this.nsgPeriodPicker1.Size = new System.Drawing.Size(192, 27);
            this.nsgPeriodPicker1.TabIndex = 10;
            // 
            // nsgGroupsList1
            // 
            this.nsgGroupsList1.AllowDrop = true;
            this.nsgGroupsList1.BackColor = System.Drawing.SystemColors.Control;
            this.nsgGroupsList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgGroupsList1.DisableComponents = ((System.Collections.Generic.List<string>)(resources.GetObject("nsgGroupsList1.DisableComponents")));
            this.nsgGroupsList1.Location = new System.Drawing.Point(401, 28);
            this.nsgGroupsList1.MinimumSize = new System.Drawing.Size(290, 150);
            this.nsgGroupsList1.Name = "NsgGroupsList";
            this.nsgGroupsList1.NsgRemoveMasterComponent = true;
            this.nsgGroupsList1.SetReport = this.nsgReport1;
            this.nsgGroupsList1.SetTitle = "title";
            this.nsgGroupsList1.Size = new System.Drawing.Size(377, 232);
            this.nsgGroupsList1.TabIndex = 0;
            // 
            // nsgReport1
            // 
            this.nsgReport1.CurrentProgressValue = 0;
            this.nsgReport1.HighlightedComponent = null;
            this.nsgReport1.IsSyncMode = true;
            this.nsgReport1.MaxProgressValue = 100;
            this.nsgReport1.OwnerForm = null;
            this.nsgReport1.ProgressEventType = NsgSoft.DataObjects.NsgThread.ProgressEventsType.Asynchronous;
            this.nsgReport1.ProgressObject = null;
            this.nsgReport1.ProgressProcentage = 0;
            this.nsgReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "NsgSoft.ReportControls.Dll",
        "NsgSoft.ReportBase.Dll",
        "NsgSoft.ReportBuilder.Dll",
        "NsgSoft.Common.Dll",
        "NsgSoft.Database.Dll",
        "NsgSoft.DataObjects.Dll",
        "NsgSoft.Design.Dll",
        "NsgSoft.Forms.Dll",
        "NsgSoft.FormsComponents.dll",
        "NsgSoft.Tools.dll",
        "NsgSoft.CityGuide.Dll"};
            this.nsgReport1.ReportAlias = "Отчет";
            this.nsgReport1.ReportDataSources.Add(this.stiReportDataSource1);
            this.nsgReport1.ReportDataSources.Add(this.stiReportDataSource2);
            this.nsgReport1.ReportGuid = "4a7a57840d764cbfacbc988d697c2c04";
            this.nsgReport1.ReportLoaded = true;
            this.nsgReport1.ReportName = "Отчет";
            this.nsgReport1.ReportSource = resources.GetString("nsgReport1.ReportSource");
            this.nsgReport1.ReportUnit = NsgSoft.ReportBuilder.StiReportUnitType.Centimeters;
            this.nsgReport1.ScriptLanguage = NsgSoft.ReportBuilder.StiReportLanguageType.CSharp;
            this.nsgReport1.ShowBookmarksPanel = false;
            // 
            // данныеИтоги
            // 
            this.данныеИтоги.MasterComponent = this.vmoИтоги;
            this.данныеИтоги.Name = "ДанныеИтоги";
            // 
            // stiReportDataSource1
            // 
            this.stiReportDataSource1.Item = this.данныеИтоги;
            this.stiReportDataSource1.Name = "данныеИтоги";
            // 
            // данныеИтогиДок
            // 
            this.данныеИтогиДок.MasterComponent = this.vmoИтогиДок;
            this.данныеИтогиДок.Name = "данныеИтогиДок";
            // 
            // vmoИтогиДок
            // 
            this.vmoИтогиДок.Columns.Collection.Add(this.ИтогиДок_СуммаПриход);
            this.vmoИтогиДок.Columns.Collection.Add(this.ИтогиДок_СуммаРасход);
            this.vmoИтогиДок.Columns.Collection.Add(this.ИтогиДок_Номенклатура);
            this.vmoИтогиДок.Columns.Collection.Add(this.ИтогиДок_Документ);
            this.vmoИтогиДок.Columns.Collection.Add(this.ИтогиДок_КоличествоПриход);
            this.vmoИтогиДок.Columns.Collection.Add(this.ИтогиДок_КоличествоРасход);
            this.vmoИтогиДок.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoИтогиДок.MetaDataName = "";
            this.vmoИтогиДок.FullName = "";
            // 
            // ИтогиДок_СуммаПриход
            // 
            this.ИтогиДок_СуммаПриход.CalcTotal = false;
            this.ИтогиДок_СуммаПриход.Caption = "СуммаПриход";
            this.ИтогиДок_СуммаПриход.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ИтогиДок_СуммаПриход.Name = "СуммаПриход";
            this.ИтогиДок_СуммаПриход.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ИтогиДок_СуммаПриход.PropertyType = typeof(decimal);
            this.ИтогиДок_СуммаПриход.SearchCondition.OwnerComponent = this.ИтогиДок_СуммаПриход;
            this.ИтогиДок_СуммаПриход.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ИтогиДок_СуммаРасход
            // 
            this.ИтогиДок_СуммаРасход.CalcTotal = false;
            this.ИтогиДок_СуммаРасход.Caption = "СуммаРасход";
            this.ИтогиДок_СуммаРасход.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ИтогиДок_СуммаРасход.Name = "СуммаРасход";
            this.ИтогиДок_СуммаРасход.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ИтогиДок_СуммаРасход.PropertyType = typeof(decimal);
            this.ИтогиДок_СуммаРасход.SearchCondition.OwnerComponent = this.ИтогиДок_СуммаРасход;
            this.ИтогиДок_СуммаРасход.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ИтогиДок_Номенклатура
            // 
            this.ИтогиДок_Номенклатура.Caption = "Номенклатура";
            this.ИтогиДок_Номенклатура.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ИтогиДок_Номенклатура.Name = "Номенклатура";
            this.ИтогиДок_Номенклатура.NSGType = typeof(Авто.Метаданные.Автосервис.Номенклатура);
            this.ИтогиДок_Номенклатура.PropertyType = typeof(Авто.Метаданные.Автосервис.Номенклатура);
            this.ИтогиДок_Номенклатура.SearchCondition.OwnerComponent = this.ИтогиДок_Номенклатура;
            this.ИтогиДок_Номенклатура.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ИтогиДок_Документ
            // 
            this.ИтогиДок_Документ.Caption = "Документ";
            this.ИтогиДок_Документ.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ИтогиДок_Документ.Name = "Документ";
            this.ИтогиДок_Документ.NSGType = typeof(NsgSoft.DataObjects.NsgDataUntypedReference);
            this.ИтогиДок_Документ.PropertyType = typeof(NsgSoft.DataObjects.NsgDataUntypedReference);
            this.ИтогиДок_Документ.ReferentFilter = new NsgSoft.DataObjects.NsgObjectsFilter(((NsgSoft.DataObjects.NsgFiltration)(NsgSoft.DataObjects.NsgFiltration.List)), new string[0]);
            this.ИтогиДок_Документ.SearchCondition.OwnerComponent = this.ИтогиДок_Документ;
            this.ИтогиДок_Документ.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ИтогиДок_КоличествоПриход
            // 
            this.ИтогиДок_КоличествоПриход.Caption = "КоличествоПриход";
            this.ИтогиДок_КоличествоПриход.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ИтогиДок_КоличествоПриход.Name = "КоличествоПриход";
            this.ИтогиДок_КоличествоПриход.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ИтогиДок_КоличествоПриход.PropertyType = typeof(string);
            this.ИтогиДок_КоличествоПриход.SearchCondition.OwnerComponent = this.ИтогиДок_КоличествоПриход;
            this.ИтогиДок_КоличествоПриход.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ИтогиДок_КоличествоРасход
            // 
            this.ИтогиДок_КоличествоРасход.Caption = "КоличествоРасход";
            this.ИтогиДок_КоличествоРасход.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ИтогиДок_КоличествоРасход.Name = "КоличествоРасход";
            this.ИтогиДок_КоличествоРасход.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ИтогиДок_КоличествоРасход.PropertyType = typeof(string);
            this.ИтогиДок_КоличествоРасход.SearchCondition.OwnerComponent = this.ИтогиДок_КоличествоРасход;
            this.ИтогиДок_КоличествоРасход.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // stiReportDataSource2
            // 
            this.stiReportDataSource2.Item = this.данныеИтогиДок;
            this.stiReportDataSource2.Name = "данныеИтогиДок";
            // 
            // ОтчетПоОстаткамФорма
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BlockShowReport = false;
            this.ClientSize = new System.Drawing.Size(1214, 385);
            this.Controls.Add(this.nsgObjectFilter1);
            this.Controls.Add(this.nsgGroupsList1);
            this.Controls.Add(this.nsgPeriodPicker1);
            this.Controls.Add(this.panelButtonReportForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.MainReport = null;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NsgReportForm";
            this.SelectedObject = null;
            this.TabText = "NsgMultipleObjectBaseForm";
            this.Text = "NsgReportForm";
            this.Controls.SetChildIndex(this.panelButtonReportForm, 0);
            this.Controls.SetChildIndex(this.nsgPeriodPicker1, 0);
            this.Controls.SetChildIndex(this.nsgGroupsList1, 0);
            this.Controls.SetChildIndex(this.nsgObjectFilter1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).EndInit();
            this.panelButtonReportForm.ResumeLayout(false);
            this.panelButtonReportForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoИтоги)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgGroupsList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеИтоги)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеИтогиДок)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoИтогиДок)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected NsgPeriodPicker nsgPeriodPicker1;
        private NsgSoft.Forms.NsgIGridView.NsgObjectFilter nsgObjectFilter1;
        protected Номенклатура.ColumnDescriptor Итоги_Номенклатура;
        protected NsgColumnDescriptor.Decimal Итоги_СуммаПриход;
        protected NsgColumnDescriptor.Decimal Итоги_КоличествоПриход;
        protected Номенклатура.ColumnDescriptor Фильтр_Номенклатура;
        protected NsgColumnDescriptor.Decimal Итоги_СуммаРасход;
        protected NsgColumnDescriptor.Decimal Итоги_СуммаКонОст;
        protected NsgColumnDescriptor.Decimal Итоги_СуммаНачОст;
        protected NsgColumnDescriptor.Decimal Итоги_КоличествоРасход;
        protected NsgColumnDescriptor.Decimal Итоги_КоличествоНачОст;
        protected NsgColumnDescriptor.Decimal Итоги_КоличествоКонОст;
        protected NsgSoft.ReportBuilder.NsgGroupsList nsgGroupsList1;
        protected NsgSoft.ReportBuilder.NsgReportDataSource данныеИтоги;
        private NsgSoft.ReportBuilder.NsgReport nsgReport1;
        protected NsgColumnDescriptor.Decimal ИтогиДок_СуммаПриход;
        protected NsgColumnDescriptor.Decimal ИтогиДок_СуммаРасход;
        protected Номенклатура.ColumnDescriptor ИтогиДок_Номенклатура;
        protected NsgColumnDescriptor.UntypedMultipleObject ИтогиДок_Документ;
        protected NsgColumnDescriptor.String ИтогиДок_КоличествоПриход;
        protected NsgColumnDescriptor.String ИтогиДок_КоличествоРасход;
        protected NsgSoft.ReportBuilder.NsgReportDataSource данныеИтогиДок;
        protected NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource2;
        private NsgVisualMultipleObject vmoИтогиДок;
        private NsgVisualMultipleObject vmoИтоги;
        private NsgVisualMultipleObject vmoФильтр;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource1;
    }
}