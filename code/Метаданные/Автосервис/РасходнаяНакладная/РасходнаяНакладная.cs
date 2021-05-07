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
            Test();
            return true;

        }


        void Test()
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
                }
                else 
                {
                    throw new Exception($"Номенклатура: {строка.Номенклатура.Наименование} " +
                                        $"- не достаточно остатка");
                }
            }
            остатки.Post();

        }

    }

}
