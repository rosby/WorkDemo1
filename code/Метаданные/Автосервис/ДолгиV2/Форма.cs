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
    
    public partial class ДолгиV2Форма

    {
        public ДолгиV2Форма()
        {
            InitializeComponent();
		}



        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            vmoФильтр.Data.MemoryTable.Clear();
            vmoФильтр.Data.CurrentRow = vmoФильтр.Data.MemoryTable.NewRow();
        }

        protected override void OnBeforeCreateReport(NsgBackgroundWorker nsgBackgroundReporter)
        {
            base.OnBeforeCreateReport(nsgBackgroundReporter);
        }

        protected override void OnCreateReport(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.DoWorkEventArgs e)
        {
            base.OnCreateReport(nsgBackgroundReporter, e);
            nsgButton1_AsyncClick(this, null);
            docs();
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }


        private void nsgButton1_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var рег = Взаиморасчеты.Новый();
            рег.New();

            NsgCompare cmp = nsgObjectFilter1.Compare;

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

        void docs()
        {
            var рег = Взаиморасчеты.Новый();
            рег.New();

            NsgCompare cmp = nsgObjectFilter1.Compare;

            var table = рег.GetCirculate(nsgPeriodPicker1.Period.Begin, nsgPeriodPicker1.Period.End, cmp,
                NsgSoft.Common.NsgRegisterResult.Credit | NsgSoft.Common.NsgRegisterResult.Debit,
                new string[] { Взаиморасчеты.Names.Контрагенты, Взаиморасчеты.Names.Владелец });

            vmoДок.Data.BeginUpdateData();
            vmoДок.Data.MemoryTable.Clear();
            foreach (var строка in table.Rows)
            {
                var ка = строка[Взаиморасчеты.Names.Контрагенты].ToReferent() as Контрагенты;
                var док = строка[Взаиморасчеты.Names.Владелец].ToReferent();
                var Приход = строка[Взаиморасчеты.Names.Сумма].ToCredit();
                var Расход = строка[Взаиморасчеты.Names.Сумма].ToDebit();


                var row = vmoДок.Data.MemoryTable.NewRow();
                row[док_Контрагент].Value = ка;
                row[док_Приход].Value = Приход;
                row[док_Расход].Value = Расход;
                row[док_Документ].Value = док;
                row.Post();
            }

            vmoИтоги.Data.UpdateDataAsync(this);
        }
    }
    


}