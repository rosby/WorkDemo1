using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using NsgSoft.Database;




namespace Авто.Метаданные.Автосервис
{
    
    public partial class ПродажиФорма

    {
        public ПродажиФорма()
        {
            InitializeComponent();
		}

		
		
        protected override void OnBeforeCreateReport(NsgBackgroundWorker nsgBackgroundReporter)
        {
            base.OnBeforeCreateReport(nsgBackgroundReporter);
        }

        protected override void OnCreateReport(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.DoWorkEventArgs e)
        {
            base.OnCreateReport(nsgBackgroundReporter, e);
            VmoFill();
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }

        void VmoFill() 
        {
            var продажи = Остатки.Новый();
            продажи.New();

            NsgCompare cmp = nsgObjectFilter1.Compare;
            

            var table = продажи.GetCirculate(nsgPeriodPicker1.Period.Begin, nsgPeriodPicker1.Period.End, cmp,
                NsgSoft.Common.NsgRegisterResult.Credit | NsgSoft.Common.NsgRegisterResult.Debit,
                new string[] { Остатки.Names.Номенклатура, Остатки.Names.Владелец });

            vmoКонтрагент.Data.BeginUpdateData();
            vmoКонтрагент.Data.MemoryTable.Clear();

            foreach (var строка in table.Rows) 
            {
                var row = vmoКонтрагент.Data.MemoryTable.NewRow();
                //row[vmoКонтр_Контр].Value = (строка[Остатки.Names.Владелец].ToReferent() as РасходнаяНакладная);
                row[vmoКонтр_Номенк].Value = строка[Остатки.Names.Номенклатура].ToReferent() as Номенклатура;
                row[vmoКонтр_Количест].Value = строка[Остатки.Names.Количество].ToDebit();
                row[vmoКонтр_Сумма].Value = строка[Остатки.Names.Сумма].ToDebit();
                row.Post();
            }
            vmoКонтрагент.Data.UpdateDataAsync(this);
            

            //var a = строка[Остатки.Names.Владелец].ToReferent() as РасходнаяНакладная;
            //var b = a.Контрагенты;
        }
	}
    


}