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
    
    public partial class ПриходнаНакладнаяФормаЭлемента

    {
        public ПриходнаНакладнаяФормаЭлемента()
        {
            InitializeComponent();
		}

        #region #Comments_Data# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Data# NsgSoft.Forms.NsgMultipleObjectElementForm

        #region #Comments_Constructors# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Constructors# NsgSoft.Forms.NsgMultipleObjectElementForm

        #region #Comments_Methods# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Methods# NsgSoft.Forms.NsgMultipleObjectElementForm

        #region #Comments_Properties# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Properties# NsgSoft.Forms.NsgMultipleObjectElementForm

        private void nsgIGrid1_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == Номенклатура.Name) 
            {
                Цена.Value = Номенклатура.Value.Цена;
            }
            if (e.ColumnName == Количество.Name)
            {
                Сумма.Value = Цена.Value * Количество.Value;
            }
            if (e.ColumnName == Сумма.Name)
            {
                Цена.Value = Сумма.Value / Количество.Value;
            }
        }
    }
    


}