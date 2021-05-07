using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace Авто.Метаданные.Автосервис
{
    
    public partial class ПриходнаНакладная
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
            рег.Контрагенты = Контрагент;
            рег.Сумма = СуммаИтого;
            рег.ВидДвижения = Сервис.ВидыДвижений.Приход;
            рег.AddMovement();
            рег.Post();
            Test();
            return true;

        }

        void Test()
        {
            
            
            var array = Таблица.Rows;
            var остатки = Остатки.Новый(this);
            остатки.New();

            foreach (var строка in array)
            {
                остатки.Номенклатура = строка.Номенклатура;
                остатки.Количество = строка.Количество;
                остатки.Сумма = строка.Сумма;
                остатки.ВидДвижения = Сервис.ВидыДвижений.Приход;
                остатки.AddMovement();
            }
            остатки.Post();




        }
    }

}
