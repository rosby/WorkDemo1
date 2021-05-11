using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace Авто.Метаданные.Автосервис

{
    
    public partial class ПродажиОтчетФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ПродажиОтчетФорма));
            NsgSoft.Forms.NsgGridColumn nsgGridColumn1 = new NsgSoft.Forms.NsgGridColumn();
            this.nsgObjectFilter1 = new NsgSoft.Forms.NsgIGridView.NsgObjectFilter();
            this.vmoФильтр = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.vmoФильтр_Контр = new Авто.Метаданные.Автосервис.Контрагенты.ColumnDescriptor();
            this.vmoКонтрагент = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.vmoКонтр_Контр = new Авто.Метаданные.Автосервис.Контрагенты.ColumnDescriptor();
            this.vmoКонтр_Количество = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.vmoКонтр_Прибыль = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.vmoКонтр_Рентаб = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.vmoКонтр_Сумма = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.vmoКонтр_Себес = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.vmoДок = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.vmoДок_Контр = new Авто.Метаданные.Автосервис.Контрагенты.ColumnDescriptor();
            this.vmoДок_Номенкл = new NsgSoft.Forms.NsgColumnDescriptor.UntypedMultipleObject();
            this.vmoДок_Количество = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.vmoДок_Рентабел = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.vmoДок_Прибыль = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.vmoДок_Сумма = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.vmoДок_Себес = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.nsgGroupsList1 = new NsgSoft.ReportBuilder.NsgGroupsList();
            this.nsgReport1 = new NsgSoft.ReportBuilder.NsgReport(this.components);
            this.данныеКонтрагент = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.stiReportDataSource1 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("данныеКонтрагент", this.данныеКонтрагент);
            this.данныеДок = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.stiReportDataSource2 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("данныеДок", this.данныеДок);
            this.nsgPeriodPicker1 = new NsgSoft.Forms.NsgPeriodPicker();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoКонтрагент)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДок)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgGroupsList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеКонтрагент)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеДок)).BeginInit();
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
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 474);
            this.panelButtonReportForm.Name = "panelButtonReportForm";
            this.panelButtonReportForm.Size = new System.Drawing.Size(1202, 28);
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
            this.printButton.Location = new System.Drawing.Point(1182, 0);
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
            nsgGridColumn1.Caption = "";
            nsgGridColumn1.ChangedProperties = new string[] {
        "Visible"};
            nsgGridColumn1.Name = "Контрагент";
            nsgGridColumn1.Root = this.nsgObjectFilter1.Columns.Collection;
            this.nsgObjectFilter1.Columns.Collection.Add(nsgGridColumn1);
            this.nsgObjectFilter1.FilterTypeCaption = "Тип Фильтра";
            this.nsgObjectFilter1.Grouping = false;
            this.nsgObjectFilter1.IsModify = true;
            this.nsgObjectFilter1.LineHeight = 20;
            this.nsgObjectFilter1.Location = new System.Drawing.Point(21, 12);
            this.nsgObjectFilter1.LockAdditionalColumns = false;
            this.nsgObjectFilter1.LockUpdateColumnsFromSourceObject = false;
            this.nsgObjectFilter1.Name = "NsgObjectFilter";
            this.nsgObjectFilter1.ReadOnly = false;
            this.nsgObjectFilter1.Regime = NsgSoft.Forms.NsgIGridView.NsgObjectFilter.Regimes.Filter;
            this.nsgObjectFilter1.RekvisitCaption = "Имя Фильтра";
            this.nsgObjectFilter1.SaveSettings = true;
            this.nsgObjectFilter1.Size = new System.Drawing.Size(338, 418);
            this.nsgObjectFilter1.SourceObject = this.vmoФильтр;
            this.nsgObjectFilter1.TabIndex = 0;
            this.nsgObjectFilter1.ValueCaption = "Фильтр";
            // 
            // vmoФильтр
            // 
            this.vmoФильтр.Columns.Collection.Add(this.vmoФильтр_Контр);
            this.vmoФильтр.IsActive = true;
            this.vmoФильтр.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoФильтр.MetaDataName = "";
            this.vmoФильтр.FullName = "";
            // 
            // vmoФильтр_Контр
            // 
            this.vmoФильтр_Контр.Caption = "Контрагент";
            this.vmoФильтр_Контр.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoФильтр_Контр.Name = "Контрагент";
            this.vmoФильтр_Контр.NSGType = typeof(Авто.Метаданные.Автосервис.Контрагенты);
            this.vmoФильтр_Контр.PropertyType = typeof(Авто.Метаданные.Автосервис.Контрагенты);
            this.vmoФильтр_Контр.SearchCondition.OwnerComponent = this.vmoФильтр_Контр;
            this.vmoФильтр_Контр.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoКонтрагент
            // 
            this.vmoКонтрагент.Columns.Collection.Add(this.vmoКонтр_Контр);
            this.vmoКонтрагент.Columns.Collection.Add(this.vmoКонтр_Количество);
            this.vmoКонтрагент.Columns.Collection.Add(this.vmoКонтр_Прибыль);
            this.vmoКонтрагент.Columns.Collection.Add(this.vmoКонтр_Рентаб);
            this.vmoКонтрагент.Columns.Collection.Add(this.vmoКонтр_Сумма);
            this.vmoКонтрагент.Columns.Collection.Add(this.vmoКонтр_Себес);
            this.vmoКонтрагент.IsActive = true;
            this.vmoКонтрагент.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoКонтрагент.MetaDataName = "";
            this.vmoКонтрагент.FullName = "";
            // 
            // vmoКонтр_Контр
            // 
            this.vmoКонтр_Контр.Caption = "Контрагент";
            this.vmoКонтр_Контр.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoКонтр_Контр.Name = "Контрагент";
            this.vmoКонтр_Контр.NSGType = typeof(Авто.Метаданные.Автосервис.Контрагенты);
            this.vmoКонтр_Контр.PropertyType = typeof(Авто.Метаданные.Автосервис.Контрагенты);
            this.vmoКонтр_Контр.SearchCondition.OwnerComponent = this.vmoКонтр_Контр;
            this.vmoКонтр_Контр.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoКонтр_Количество
            // 
            this.vmoКонтр_Количество.CalcTotal = false;
            this.vmoКонтр_Количество.Caption = "Количество";
            this.vmoКонтр_Количество.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoКонтр_Количество.Name = "Количество";
            this.vmoКонтр_Количество.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.vmoКонтр_Количество.PropertyType = typeof(decimal);
            this.vmoКонтр_Количество.SearchCondition.OwnerComponent = this.vmoКонтр_Количество;
            this.vmoКонтр_Количество.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoКонтр_Прибыль
            // 
            this.vmoКонтр_Прибыль.CalcTotal = false;
            this.vmoКонтр_Прибыль.Caption = "Прибыль";
            this.vmoКонтр_Прибыль.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoКонтр_Прибыль.Name = "Прибыль";
            this.vmoКонтр_Прибыль.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.vmoКонтр_Прибыль.PropertyType = typeof(decimal);
            this.vmoКонтр_Прибыль.SearchCondition.OwnerComponent = this.vmoКонтр_Прибыль;
            this.vmoКонтр_Прибыль.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoКонтр_Рентаб
            // 
            this.vmoКонтр_Рентаб.CalcTotal = false;
            this.vmoКонтр_Рентаб.Caption = "Рентабельность";
            this.vmoКонтр_Рентаб.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoКонтр_Рентаб.Name = "Рентабельность";
            this.vmoКонтр_Рентаб.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.vmoКонтр_Рентаб.PropertyType = typeof(decimal);
            this.vmoКонтр_Рентаб.SearchCondition.OwnerComponent = this.vmoКонтр_Рентаб;
            this.vmoКонтр_Рентаб.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoКонтр_Сумма
            // 
            this.vmoКонтр_Сумма.CalcTotal = false;
            this.vmoКонтр_Сумма.Caption = "Сумма";
            this.vmoКонтр_Сумма.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoКонтр_Сумма.Name = "Сумма";
            this.vmoКонтр_Сумма.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.vmoКонтр_Сумма.PropertyType = typeof(decimal);
            this.vmoКонтр_Сумма.SearchCondition.OwnerComponent = this.vmoКонтр_Сумма;
            this.vmoКонтр_Сумма.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoКонтр_Себес
            // 
            this.vmoКонтр_Себес.CalcTotal = false;
            this.vmoКонтр_Себес.Caption = "Себестоимость";
            this.vmoКонтр_Себес.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoКонтр_Себес.Name = "Себестоимость";
            this.vmoКонтр_Себес.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.vmoКонтр_Себес.PropertyType = typeof(decimal);
            this.vmoКонтр_Себес.SearchCondition.OwnerComponent = this.vmoКонтр_Себес;
            this.vmoКонтр_Себес.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoДок
            // 
            this.vmoДок.Columns.Collection.Add(this.vmoДок_Контр);
            this.vmoДок.Columns.Collection.Add(this.vmoДок_Номенкл);
            this.vmoДок.Columns.Collection.Add(this.vmoДок_Количество);
            this.vmoДок.Columns.Collection.Add(this.vmoДок_Рентабел);
            this.vmoДок.Columns.Collection.Add(this.vmoДок_Прибыль);
            this.vmoДок.Columns.Collection.Add(this.vmoДок_Сумма);
            this.vmoДок.Columns.Collection.Add(this.vmoДок_Себес);
            this.vmoДок.IsActive = true;
            this.vmoДок.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoДок.MetaDataName = "";
            this.vmoДок.FullName = "";
            // 
            // vmoДок_Контр
            // 
            this.vmoДок_Контр.Caption = "Контрагент";
            this.vmoДок_Контр.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoДок_Контр.Name = "Контрагент";
            this.vmoДок_Контр.NSGType = typeof(Авто.Метаданные.Автосервис.Контрагенты);
            this.vmoДок_Контр.PropertyType = typeof(Авто.Метаданные.Автосервис.Контрагенты);
            this.vmoДок_Контр.SearchCondition.OwnerComponent = this.vmoДок_Контр;
            this.vmoДок_Контр.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoДок_Номенкл
            // 
            this.vmoДок_Номенкл.Caption = "Номенклатура";
            this.vmoДок_Номенкл.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoДок_Номенкл.Name = "Номенклатура";
            this.vmoДок_Номенкл.NSGType = typeof(NsgSoft.DataObjects.NsgDataUntypedReference);
            this.vmoДок_Номенкл.PropertyType = typeof(NsgSoft.DataObjects.NsgDataUntypedReference);
            this.vmoДок_Номенкл.ReferentFilter = new NsgSoft.DataObjects.NsgObjectsFilter(((NsgSoft.DataObjects.NsgFiltration)(NsgSoft.DataObjects.NsgFiltration.List)), new string[0]);
            this.vmoДок_Номенкл.SearchCondition.OwnerComponent = this.vmoДок_Номенкл;
            this.vmoДок_Номенкл.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoДок_Количество
            // 
            this.vmoДок_Количество.CalcTotal = false;
            this.vmoДок_Количество.Caption = "Количество ";
            this.vmoДок_Количество.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoДок_Количество.Name = "Количество ";
            this.vmoДок_Количество.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.vmoДок_Количество.PropertyType = typeof(decimal);
            this.vmoДок_Количество.SearchCondition.OwnerComponent = this.vmoДок_Количество;
            this.vmoДок_Количество.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoДок_Рентабел
            // 
            this.vmoДок_Рентабел.CalcTotal = false;
            this.vmoДок_Рентабел.Caption = "Рентабельность";
            this.vmoДок_Рентабел.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoДок_Рентабел.Name = "Рентабельность";
            this.vmoДок_Рентабел.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.vmoДок_Рентабел.PropertyType = typeof(decimal);
            this.vmoДок_Рентабел.SearchCondition.OwnerComponent = this.vmoДок_Рентабел;
            this.vmoДок_Рентабел.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoДок_Прибыль
            // 
            this.vmoДок_Прибыль.CalcTotal = false;
            this.vmoДок_Прибыль.Caption = "Прибыль";
            this.vmoДок_Прибыль.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoДок_Прибыль.Name = "Прибыль";
            this.vmoДок_Прибыль.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.vmoДок_Прибыль.PropertyType = typeof(decimal);
            this.vmoДок_Прибыль.SearchCondition.OwnerComponent = this.vmoДок_Прибыль;
            this.vmoДок_Прибыль.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoДок_Сумма
            // 
            this.vmoДок_Сумма.CalcTotal = false;
            this.vmoДок_Сумма.Caption = "Сумма";
            this.vmoДок_Сумма.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoДок_Сумма.Name = "Сумма";
            this.vmoДок_Сумма.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.vmoДок_Сумма.PropertyType = typeof(decimal);
            this.vmoДок_Сумма.SearchCondition.OwnerComponent = this.vmoДок_Сумма;
            this.vmoДок_Сумма.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoДок_Себес
            // 
            this.vmoДок_Себес.CalcTotal = false;
            this.vmoДок_Себес.Caption = "Себестоимость";
            this.vmoДок_Себес.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoДок_Себес.Name = "Себестоимость";
            this.vmoДок_Себес.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.vmoДок_Себес.PropertyType = typeof(decimal);
            this.vmoДок_Себес.SearchCondition.OwnerComponent = this.vmoДок_Себес;
            this.vmoДок_Себес.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgGroupsList1
            // 
            this.nsgGroupsList1.AllowDrop = true;
            this.nsgGroupsList1.BackColor = System.Drawing.SystemColors.Control;
            this.nsgGroupsList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgGroupsList1.DisableComponents = ((System.Collections.Generic.List<string>)(resources.GetObject("nsgGroupsList1.DisableComponents")));
            this.nsgGroupsList1.Location = new System.Drawing.Point(390, 12);
            this.nsgGroupsList1.MinimumSize = new System.Drawing.Size(290, 150);
            this.nsgGroupsList1.Name = "NsgGroupsList";
            this.nsgGroupsList1.NsgRemoveMasterComponent = true;
            this.nsgGroupsList1.SetReport = this.nsgReport1;
            this.nsgGroupsList1.SetTitle = "title";
            this.nsgGroupsList1.Size = new System.Drawing.Size(373, 418);
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
            this.nsgReport1.ReportGuid = "476a88b77093442ea6195f34d5b24b11";
            this.nsgReport1.ReportLoaded = true;
            this.nsgReport1.ReportName = "Отчет";
            this.nsgReport1.ReportSource = resources.GetString("nsgReport1.ReportSource");
            this.nsgReport1.ReportUnit = NsgSoft.ReportBuilder.StiReportUnitType.Centimeters;
            this.nsgReport1.ScriptLanguage = NsgSoft.ReportBuilder.StiReportLanguageType.CSharp;
            this.nsgReport1.ShowBookmarksPanel = false;
            // 
            // данныеКонтрагент
            // 
            this.данныеКонтрагент.MasterComponent = this.vmoКонтрагент;
            this.данныеКонтрагент.Name = "данныеКонтрагент";
            // 
            // stiReportDataSource1
            // 
            this.stiReportDataSource1.Item = this.данныеКонтрагент;
            this.stiReportDataSource1.Name = "данныеКонтрагент";
            // 
            // данныеДок
            // 
            this.данныеДок.MasterComponent = this.vmoДок;
            this.данныеДок.Name = "данныеДок";
            // 
            // stiReportDataSource2
            // 
            this.stiReportDataSource2.Item = this.данныеДок;
            this.stiReportDataSource2.Name = "данныеДок";
            // 
            // nsgPeriodPicker1
            // 
            this.nsgPeriodPicker1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.nsgPeriodPicker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgPeriodPicker1.Location = new System.Drawing.Point(847, 194);
            this.nsgPeriodPicker1.MinimumSize = new System.Drawing.Size(2, 4);
            this.nsgPeriodPicker1.Name = "NsgPeriodPicker";
            this.nsgPeriodPicker1.Size = new System.Drawing.Size(191, 27);
            this.nsgPeriodPicker1.TabIndex = 9;
            // 
            // ПродажиОтчетФорма
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BlockShowReport = false;
            this.ClientSize = new System.Drawing.Size(1202, 522);
            this.Controls.Add(this.nsgPeriodPicker1);
            this.Controls.Add(this.nsgGroupsList1);
            this.Controls.Add(this.nsgObjectFilter1);
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
            this.Controls.SetChildIndex(this.nsgObjectFilter1, 0);
            this.Controls.SetChildIndex(this.nsgGroupsList1, 0);
            this.Controls.SetChildIndex(this.nsgPeriodPicker1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).EndInit();
            this.panelButtonReportForm.ResumeLayout(false);
            this.panelButtonReportForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoКонтрагент)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДок)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgGroupsList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеКонтрагент)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеДок)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected Контрагенты.ColumnDescriptor vmoКонтр_Контр;
        protected NsgColumnDescriptor.Decimal vmoКонтр_Количество;
        protected NsgColumnDescriptor.Decimal vmoКонтр_Прибыль;
        protected NsgColumnDescriptor.Decimal vmoКонтр_Рентаб;
        protected NsgColumnDescriptor.Decimal vmoКонтр_Сумма;
        protected NsgColumnDescriptor.Decimal vmoКонтр_Себес;
        protected Контрагенты.ColumnDescriptor vmoДок_Контр;
        protected NsgColumnDescriptor.UntypedMultipleObject vmoДок_Номенкл;
        protected NsgColumnDescriptor.Decimal vmoДок_Количество;
        protected NsgColumnDescriptor.Decimal vmoДок_Рентабел;
        protected NsgColumnDescriptor.Decimal vmoДок_Прибыль;
        protected NsgColumnDescriptor.Decimal vmoДок_Сумма;
        protected NsgColumnDescriptor.Decimal vmoДок_Себес;
        private NsgSoft.Forms.NsgIGridView.NsgObjectFilter nsgObjectFilter1;
        protected Контрагенты.ColumnDescriptor vmoФильтр_Контр;
        protected NsgPeriodPicker nsgPeriodPicker1;
        protected NsgSoft.ReportBuilder.NsgReportDataSource данныеКонтрагент;
        private NsgVisualMultipleObject vmoФильтр;
        protected NsgSoft.ReportBuilder.NsgReportDataSource данныеДок;
        protected NsgSoft.ReportBuilder.NsgGroupsList nsgGroupsList1;
        protected NsgSoft.ReportBuilder.NsgReport nsgReport1;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource1;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource2;
        private NsgVisualMultipleObject vmoКонтрагент;
        private NsgVisualMultipleObject vmoДок;
    }
}