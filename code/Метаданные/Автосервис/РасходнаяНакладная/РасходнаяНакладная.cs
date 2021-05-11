using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace Авто.Метаданные.Автосервис
{

    public partial class РасходнаяНакладная
    {
        #region Данные
        #endregion //Данные

        #region Конструкторы
        #endregion //Конструкторы

        #region Свойства
        #endregion //Свойства

        protected override bool Handling()
        {
            var рег = Взаиморасчеты.Новый(this);
            рег.New();
            рег.Контрагенты = Контрагенты;
            рег.Сумма = СуммаИтого;
            рег.ВидДвижения = Сервис.ВидыДвижений.Расход;
            рег.AddMovement();
            рег.Post();
            ForRegisters();
            return true;

        }


        void ForRegisters()
        {
            var остатки = Остатки.Новый(this);
            остатки.New();
            

            foreach (var строка in Таблица.AllRows)
            {
                NsgCompare compare = new NsgCompare().Add(Остатки.Names.Номенклатура, строка.Номенклатура);
                
                var table = остатки.GetRests(ДатаДокумента, compare);
                decimal sum = 0;
                decimal count = 0;

                if (table.Count > 0)
                {
                    count = table.Rows[0][Остатки.Names.Количество].ToBegin();
                    sum = table.Rows[0][Остатки.Names.Сумма].ToBegin();
                }
                else 
                {
                    throw new Exception($"Номенклатура: {строка.Номенклатура.Наименование} " +
                                        $"- не достаточно остатка");
                }

                if (строка.Количество <= count)
                {
                    var себестоймость = sum / count;
                    остатки.Номенклатура = строка.Номенклатура;
                    остатки.Количество = строка.Количество;
                    остатки.Сумма = себестоймость * строка.Количество;
                    остатки.ВидДвижения = Сервис.ВидыДвижений.Расход;
                    остатки.AddMovement();
                    Prodagi(себестоймость, строка);
                    
                }
                else 
                {
                    throw new Exception($"Номенклатура: {строка.Номенклатура.Наименование} " +
                                        $"- не достаточно остатка");
                }
            }
            остатки.Post();
        }

        void Prodagi(decimal себестоймость, _SystemTables.АвтосервисРасходнаяНакладнаяТаблица.Строка строка) 
        {
            var продажи = ПродажиРегистр.Новый(this);
            продажи.New();
            продажи.Контрагенты = Контрагенты;
            продажи.Номенклатура = строка.Номенклатура;
            продажи.ЦенаПродажи = строка.Сумма;
            продажи.Количество = строка.Количество;
            продажи.Прибыль = строка.Сумма - (себестоймость * строка.Количество);
            продажи.Рентабельность = ((строка.Сумма - себестоймость * строка.Количество) / строка.Сумма) * 100;
            продажи.ВидДвижения = Сервис.ВидыДвижений.Приход;
            продажи.AddMovement();
            продажи.Post();
        }


    }

}
