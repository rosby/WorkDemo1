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
    
    public partial class ПродажиОтчетФорма

    {
        public ПродажиОтчетФорма()
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
            VmoKontr();
            VmoDoc();

        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }


        void VmoKontr() 
        {
            var контр = ПродажиРегистр.Новый();
            контр.New();

            NsgCompare cmp = nsgObjectFilter1.Compare;

            var table = контр.GetCirculate(nsgPeriodPicker1.Period.Begin, nsgPeriodPicker1.Period.End, cmp,
                NsgSoft.Common.NsgRegisterResult.Credit,
                new string[] { Остатки.Names.Номенклатура, Остатки.Names.Владелец });

            vmoКонтрагент.Data.BeginUpdateData();
            vmoКонтрагент.Data.MemoryTable.Clear();

            foreach (var строка in table.Rows) 
            {
                var row = vmoКонтрагент.Data.MemoryTable.NewRow();
                row[vmoКонтр_Контр].Value = (строка[ПродажиРегистр.Names.Владелец].ToReferent() as РасходнаяНакладная).Контрагенты;
                row[vmoКонтр_Количество].Value = строка[ПродажиРегистр.Names.Количество].ToCredit();
                row[vmoКонтр_Сумма].Value = строка[ПродажиРегистр.Names.ЦенаПродажи].ToCredit();
                row[vmoКонтр_Рентаб].Value = строка[ПродажиРегистр.Names.Рентабельность].ToCredit();
                row[vmoКонтр_Прибыль].Value = строка[ПродажиРегистр.Names.Прибыль].ToCredit();
                row[vmoКонтр_Себес].Value = (строка[ПродажиРегистр.Names.ЦенаПродажи].ToCredit() - строка[ПродажиРегистр.Names.Прибыль].ToCredit());
                row.Post();
            }
            vmoКонтрагент.Data.UpdateDataAsync(this);

        }

        void VmoDoc() 
        {
            var док = ПродажиРегистр.Новый();
            док.New();

            NsgCompare cmp = nsgObjectFilter1.Compare;

            var table = док.GetCirculate(nsgPeriodPicker1.Period.Begin, nsgPeriodPicker1.Period.End, cmp,
                NsgSoft.Common.NsgRegisterResult.Credit,
                new string[] { Остатки.Names.Номенклатура, Остатки.Names.Владелец });

            vmoДок.Data.BeginUpdateData();
            vmoДок.Data.MemoryTable.Clear();

            foreach (var строка in table.Rows)
            {
                var row = vmoДок.Data.MemoryTable.NewRow();
                row[vmoДок_Контр].Value = (строка[ПродажиРегистр.Names.Владелец].ToReferent() as РасходнаяНакладная).Контрагенты;
                row[vmoДок_Номенкл].Value = строка[ПродажиРегистр.Names.Номенклатура].ToReferent() as Номенклатура;
                row[vmoДок_Количество].Value = строка[ПродажиРегистр.Names.Количество].ToCredit();
                row[vmoДок_Сумма].Value = строка[ПродажиРегистр.Names.ЦенаПродажи].ToCredit();
                row[vmoДок_Рентабел].Value = строка[ПродажиРегистр.Names.Рентабельность].ToCredit();
                row[vmoДок_Прибыль].Value = строка[ПродажиРегистр.Names.Прибыль].ToCredit();
                row[vmoДок_Себес].Value = (строка[ПродажиРегистр.Names.ЦенаПродажи].ToCredit() - строка[ПродажиРегистр.Names.Прибыль].ToCredit());
                row.Post();
            }
            vmoДок.Data.UpdateDataAsync(this);
        }

	}
    


}