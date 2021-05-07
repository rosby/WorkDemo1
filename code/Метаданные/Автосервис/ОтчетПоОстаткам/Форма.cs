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
    
    public partial class ОтчетПоОстаткамФорма

    {
        public ОтчетПоОстаткамФорма()
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
            Itogi();
            ItogiDoc();
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }




        void Itogi() 
        {
            var ост = Остатки.Новый();
            ост.New();

            NsgCompare cmp = nsgObjectFilter1.Compare;

            var table = ост.GetCirculate(nsgPeriodPicker1.Period.Begin, nsgPeriodPicker1.Period.End, cmp);

            vmoИтоги.Data.BeginUpdateData();
            vmoИтоги.Data.MemoryTable.Clear();

            foreach (var строка in table.Rows) 
            {
                var row = vmoИтоги.Data.MemoryTable.NewRow();
                row[Итоги_Номенклатура].Value = строка[Остатки.Names.Номенклатура].ToReferent() as Номенклатура;
                row[Итоги_СуммаПриход].Value = строка[Остатки.Names.Сумма].ToCredit();
                row[Итоги_СуммаРасход].Value = строка[Остатки.Names.Сумма].ToDebit();
                row[Итоги_СуммаНачОст].Value = строка[Остатки.Names.Сумма].ToBegin();
                row[Итоги_СуммаКонОст].Value = строка[Остатки.Names.Сумма].ToEnd();
                row[Итоги_КоличествоПриход].Value = строка[Остатки.Names.Количество].ToCredit();
                row[Итоги_КоличествоРасход].Value = строка[Остатки.Names.Количество].ToDebit();
                row[Итоги_КоличествоНачОст].Value = строка[Остатки.Names.Количество].ToBegin();
                row[Итоги_КоличествоКонОст].Value = строка[Остатки.Names.Количество].ToEnd();
                row.Post();
            }
            vmoИтоги.Data.UpdateDataAsync(this);
            
        }

        void ItogiDoc() 
        {
            var ост = Остатки.Новый();  
            ост.New();

            NsgCompare cmp = nsgObjectFilter1.Compare;

            var table = ост.GetCirculate(nsgPeriodPicker1.Period.Begin, nsgPeriodPicker1.Period.End, cmp,
                NsgSoft.Common.NsgRegisterResult.Credit | NsgSoft.Common.NsgRegisterResult.Debit,
                new string[] { Остатки.Names.Номенклатура, Остатки.Names.Владелец });

            vmoИтогиДок.Data.BeginUpdateData();
            vmoИтогиДок.Data.MemoryTable.Clear();

            foreach (var строка in table.Rows)
            {
                var row = vmoИтогиДок.Data.MemoryTable.NewRow();
                row[ИтогиДок_Номенклатура].Value = строка[Остатки.Names.Номенклатура].ToReferent() as Номенклатура;
                row[ИтогиДок_Документ].Value = строка[Остатки.Names.Владелец].ToReferent();
                row[ИтогиДок_СуммаПриход].Value = строка[Остатки.Names.Сумма].ToCredit();
                row[ИтогиДок_СуммаРасход].Value = строка[Остатки.Names.Сумма].ToDebit();
                row[ИтогиДок_КоличествоПриход].Value = строка[Остатки.Names.Количество].ToCredit();
                row[ИтогиДок_КоличествоРасход].Value = строка[Остатки.Names.Количество].ToDebit();

                row.Post();
            }
            vmoИтогиДок.Data.UpdateDataAsync(this);
            

        }


	}
    


}