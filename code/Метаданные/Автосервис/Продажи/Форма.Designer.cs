using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace Авто.Метаданные.Автосервис

{
    
    public partial class ПродажиФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ПродажиФорма));
            this.vmoКонтрагент = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.vmoКонтр_Номенк = new Авто.Метаданные.Автосервис.Номенклатура.ColumnDescriptor();
            this.vmoКонтр_Количест = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.vmoКонтр_Сумма = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.vmoКонтр_Прибыль = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.vmoКонтр_Рент = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.vmoНоменклатура = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.nsgObjectFilter1 = new NsgSoft.Forms.NsgIGridView.NsgObjectFilter();
            this.nsgPeriodPicker1 = new NsgSoft.Forms.NsgPeriodPicker();
            this.ДанныеКонтрагент = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.nsgReport1 = new NsgSoft.ReportBuilder.NsgReport(this.components);
            this.stiReportDataSource1 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("ДанныеКонтрагент", this.ДанныеКонтрагент);
            this.vmoКонтр_Контр = new Авто.Метаданные.Автосервис.РасходнаяНакладная.ColumnDescriptor();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoКонтрагент)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoНоменклатура)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ДанныеКонтрагент)).BeginInit();
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
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 457);
            this.panelButtonReportForm.Name = "panelButtonReportForm";
            this.panelButtonReportForm.Size = new System.Drawing.Size(1132, 28);
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
            this.printButton.Location = new System.Drawing.Point(1112, 0);
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
            // vmoКонтрагент
            // 
            this.vmoКонтрагент.Columns.Collection.Add(this.vmoКонтр_Контр);
            this.vmoКонтрагент.Columns.Collection.Add(this.vmoКонтр_Номенк);
            this.vmoКонтрагент.Columns.Collection.Add(this.vmoКонтр_Количест);
            this.vmoКонтрагент.Columns.Collection.Add(this.vmoКонтр_Сумма);
            this.vmoКонтрагент.Columns.Collection.Add(this.vmoКонтр_Прибыль);
            this.vmoКонтрагент.Columns.Collection.Add(this.vmoКонтр_Рент);
            this.vmoКонтрагент.IsActive = true;
            this.vmoКонтрагент.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoКонтрагент.MetaDataName = "";
            this.vmoКонтрагент.FullName = "";
            // 
            // vmoКонтр_Номенк
            // 
            this.vmoКонтр_Номенк.Caption = "Номенклатура";
            this.vmoКонтр_Номенк.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoКонтр_Номенк.Name = "Номенклатура";
            this.vmoКонтр_Номенк.NSGType = typeof(Авто.Метаданные.Автосервис.Номенклатура);
            this.vmoКонтр_Номенк.PropertyType = typeof(Авто.Метаданные.Автосервис.Номенклатура);
            this.vmoКонтр_Номенк.SearchCondition.OwnerComponent = this.vmoКонтр_Номенк;
            this.vmoКонтр_Номенк.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoКонтр_Количест
            // 
            this.vmoКонтр_Количест.CalcTotal = false;
            this.vmoКонтр_Количест.Caption = "Количество ";
            this.vmoКонтр_Количест.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoКонтр_Количест.Name = "Количество ";
            this.vmoКонтр_Количест.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.vmoКонтр_Количест.PropertyType = typeof(decimal);
            this.vmoКонтр_Количест.SearchCondition.OwnerComponent = this.vmoКонтр_Количест;
            this.vmoКонтр_Количест.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // vmoКонтр_Рент
            // 
            this.vmoКонтр_Рент.CalcTotal = false;
            this.vmoКонтр_Рент.Caption = "Рентабельность";
            this.vmoКонтр_Рент.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoКонтр_Рент.Name = "Рентабельность";
            this.vmoКонтр_Рент.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.vmoКонтр_Рент.PropertyType = typeof(decimal);
            this.vmoКонтр_Рент.SearchCondition.OwnerComponent = this.vmoКонтр_Рент;
            this.vmoКонтр_Рент.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoНоменклатура
            // 
            this.vmoНоменклатура.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoНоменклатура.MetaDataName = "";
            this.vmoНоменклатура.FullName = "";
            // 
            // nsgObjectFilter1
            // 
            this.nsgObjectFilter1.AllowDrop = true;
            this.nsgObjectFilter1.AutoSetCompare = true;
            this.nsgObjectFilter1.BackColor = System.Drawing.SystemColors.Control;
            this.nsgObjectFilter1.FilterTypeCaption = "Тип Фильтра";
            this.nsgObjectFilter1.Grouping = false;
            this.nsgObjectFilter1.IsModify = true;
            this.nsgObjectFilter1.LineHeight = 20;
            this.nsgObjectFilter1.Location = new System.Drawing.Point(26, 26);
            this.nsgObjectFilter1.LockAdditionalColumns = false;
            this.nsgObjectFilter1.LockUpdateColumnsFromSourceObject = false;
            this.nsgObjectFilter1.Name = "NsgObjectFilter";
            this.nsgObjectFilter1.ReadOnly = false;
            this.nsgObjectFilter1.Regime = NsgSoft.Forms.NsgIGridView.NsgObjectFilter.Regimes.Filter;
            this.nsgObjectFilter1.RekvisitCaption = "Имя Фильтра";
            this.nsgObjectFilter1.SaveSettings = true;
            this.nsgObjectFilter1.Size = new System.Drawing.Size(301, 219);
            this.nsgObjectFilter1.SourceObject = this.vmoКонтрагент;
            this.nsgObjectFilter1.TabIndex = 0;
            this.nsgObjectFilter1.ValueCaption = "Фильтр";
            // 
            // nsgPeriodPicker1
            // 
            this.nsgPeriodPicker1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.nsgPeriodPicker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgPeriodPicker1.Location = new System.Drawing.Point(428, 164);
            this.nsgPeriodPicker1.MinimumSize = new System.Drawing.Size(2, 4);
            this.nsgPeriodPicker1.Name = "NsgPeriodPicker";
            this.nsgPeriodPicker1.Size = new System.Drawing.Size(191, 27);
            this.nsgPeriodPicker1.TabIndex = 9;
            // 
            // ДанныеКонтрагент
            // 
            this.ДанныеКонтрагент.MasterComponent = this.vmoКонтрагент;
            this.ДанныеКонтрагент.Name = "ДанныеКонтрагент";
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
            this.nsgReport1.ReportGuid = "6ed5b5478f384f19b430e6db43741fe2";
            this.nsgReport1.ReportLoaded = true;
            this.nsgReport1.ReportName = "Отчет";
            this.nsgReport1.ReportSource = resources.GetString("nsgReport1.ReportSource");
            this.nsgReport1.ReportUnit = NsgSoft.ReportBuilder.StiReportUnitType.Centimeters;
            this.nsgReport1.ScriptLanguage = NsgSoft.ReportBuilder.StiReportLanguageType.CSharp;
            this.nsgReport1.ShowBookmarksPanel = false;
            // 
            // stiReportDataSource1
            // 
            this.stiReportDataSource1.Item = this.ДанныеКонтрагент;
            this.stiReportDataSource1.Name = "ДанныеКонтрагент";
            // 
            // vmoКонтр_Контр
            // 
            this.vmoКонтр_Контр.Caption = "Контрагент";
            this.vmoКонтр_Контр.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoКонтр_Контр.Name = "Контрагент";
            this.vmoКонтр_Контр.NSGType = typeof(Авто.Метаданные.Автосервис.РасходнаяНакладная);
            this.vmoКонтр_Контр.PropertyType = typeof(Авто.Метаданные.Автосервис.РасходнаяНакладная);
            this.vmoКонтр_Контр.SearchCondition.OwnerComponent = this.vmoКонтр_Контр;
            this.vmoКонтр_Контр.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ПродажиФорма
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BlockShowReport = false;
            this.ClientSize = new System.Drawing.Size(1132, 505);
            this.Controls.Add(this.nsgPeriodPicker1);
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
            this.Controls.SetChildIndex(this.nsgPeriodPicker1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).EndInit();
            this.panelButtonReportForm.ResumeLayout(false);
            this.panelButtonReportForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoКонтрагент)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoНоменклатура)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ДанныеКонтрагент)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected NsgVisualMultipleObject vmoНоменклатура;
        private NsgSoft.Forms.NsgIGridView.NsgObjectFilter nsgObjectFilter1;
        protected NsgPeriodPicker nsgPeriodPicker1;
        protected Номенклатура.ColumnDescriptor vmoКонтр_Номенк;
        protected NsgColumnDescriptor.Decimal vmoКонтр_Количест;
        protected NsgColumnDescriptor.Decimal vmoКонтр_Сумма;
        protected NsgColumnDescriptor.Decimal vmoКонтр_Прибыль;
        protected NsgColumnDescriptor.Decimal vmoКонтр_Рент;
        protected NsgSoft.ReportBuilder.NsgReportDataSource ДанныеКонтрагент;
        private NsgSoft.ReportBuilder.NsgReport nsgReport1;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource1;
        private NsgVisualMultipleObject vmoКонтрагент;
        protected РасходнаяНакладная.ColumnDescriptor vmoКонтр_Контр;
    }
}