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
            рег.ВидДвижения = Сервис.ВидыДвижений.Приход;
            рег.AddMovement();
            рег.Post();

            return true;

        }
    }

}
