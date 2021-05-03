using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NsgSoft.DataObjects;
using NsgSoft.Forms;





namespace Авто.Метаданные.Автосервис
{
    
    public partial class ДолгиФорма

    {
        public ДолгиФорма()
        {
            InitializeComponent();
		}

		#region #Comments_Data# NsgSoft.Forms.NsgReportForm
		
		#endregion //#Comments_Data# NsgSoft.Forms.NsgReportForm

		#region #Comments_Constructors# NsgSoft.Forms.NsgReportForm
		
		#endregion //#Comments_Constructors# NsgSoft.Forms.NsgReportForm

		#region #Comments_Methods# NsgSoft.Forms.NsgReportForm
		
        protected override void OnBeforeCreateReport(NsgBackgroundWorker nsgBackgroundReporter)
        {
            base.OnBeforeCreateReport(nsgBackgroundReporter);
        }

        protected override void OnCreateReport(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.DoWorkEventArgs e)
        {
            base.OnCreateReport(nsgBackgroundReporter, e);
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }

        #endregion //#Comments_Methods# NsgSoft.Forms.NsgReportForm

        #region #Comments_Properties# NsgSoft.Forms.NsgReportForm

        #endregion //#Comments_Properties# NsgSoft.Forms.NsgReportForm

        private void nsgButton1_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var рег = Взаиморасчеты.Новый();
            рег.New();

            NsgCompare cmp = null;
            
            var table = рег.GetCirculate(nsgPeriodPicker1.Period.Begin, nsgPeriodPicker1.Period.End, cmp);

            vmoИтоги.Data.BeginUpdateData();
            vmoИтоги.Data.MemoryTable.Clear();
            foreach (var строка in table.Rows)
            {
                var ка = строка[Взаиморасчеты.Names.Контрагенты].ToReferent() as Контрагенты;
                var начОстаок = строка[Взаиморасчеты.Names.Сумма].ToBegin();
                var Приход = строка[Взаиморасчеты.Names.Сумма].ToCredit();
                var Расход = строка[Взаиморасчеты.Names.Сумма].ToDebit();
                var конОстаток = строка[Взаиморасчеты.Names.Сумма].ToEnd();

                var row = vmoИтоги.Data.MemoryTable.NewRow();
                row[vmoИтоги_Контрагент].Value = ка;
                row[vmoИтоги_НачОст].Value = начОстаок;
                row[vmoИтоги_Приход].Value = Приход;
                row[vmoИтоги_Расход].Value = Расход;
                row[vmoИтоги_КонОст].Value = конОстаток;
                row.Post();
            }
           
            vmoИтоги.Data.UpdateDataAsync(this);
        }
    }
    


}