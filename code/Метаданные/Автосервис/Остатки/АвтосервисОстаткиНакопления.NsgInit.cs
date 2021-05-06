using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.IO;

using NsgSoft.DataObjects;
using NsgSoft.Design;
using NsgSoft.Database;
using NsgSoft.Common;

// ================================================================ //
// Этот файл создается автоматически, все изменения будут потеряны. //
// ================================================================ //

namespace Авто.Метаданные._SystemTables
{
    
    [NsgTypeName("NsgDataTable", Guid = "435ac49c-755f-4f46-bb41-f662252ecca6")]
    public partial class АвтосервисОстаткиНакопления : NsgSoft.DataObjects.NsgDataTable
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgDataTable
        




        #endregion // Данные NsgSoft.DataObjects.NsgDataTable

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgDataTable
        




        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataTable

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected АвтосервисОстаткиНакопления()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected АвтосервисОстаткиНакопления(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static АвтосервисОстаткиНакопления Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("435ac49c-755f-4f46-bb41-f662252ecca6"));
            if (obj == null)
                obj = new АвтосервисОстаткиНакопления();
            return obj as АвтосервисОстаткиНакопления;
        }

        /// <summary>
        /// Инициализация реквизитов объекта
        /// </summary>
        protected override void CreatePreDefinedFields()
		{
			#region необходимые операции до создания реквизитов и заполнения полей
			if (NsgSettings.Regime == NsgSoft.Common.NsgViewTypes.Load)
                base.CreatePreDefinedFields();
			#endregion //необходимые операции до создания реквизитов и заполнения полей
			#region начало инициализации NsgSoft.DataObjects.NsgDataTable
			




			#endregion //начало инициализации NsgSoft.DataObjects.NsgDataTable
			
			#region создание System.Decimal Количество
			{  
                NsgDataFloat Количество = null;
				if (ObjectList.Contains("Количество"))
                    Количество = ObjectList["Количество"] as NsgDataFloat;
                else
                    Количество = new NsgDataFloat();
	//NsgDataFloat
	Количество.IsLoadedFromDll = true;
	Количество.Precision = 2;
	Количество.HideZero = true;
	Количество.DefaultValue = 0M;
	Количество.MinValue = -100000000000000000M;
	Количество.MaxValue = 100000000000000000M;
	Количество.UseCalculator = true;
	Количество.StringFormat = "";
	Количество.SubType = NsgSoft.Common.NsgRekvisitSubType.Resource;
	Количество.IncludeInPredefined = false;
	Количество.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Количество.Required = false;
	Количество.EmptyValue = "";
	Количество.NullAllow = false;
	Количество.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Количество.FieldName = "Kolichestvo";
	Количество.InformMetaDataOnValueChanged = false;
	Количество.Visible = true;
	Количество.Name = "Количество";
	Количество.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Количество.Description = "Количество";
	Количество.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Количество.GroupName = "";
	Количество.Guid = NsgService.StringToGuid("86297c62-ed77-4e4b-b15e-8c34d61cf842");
	
				if (!ObjectList.Contains("Количество"))
                    ObjectList.Add(Количество);
			}
			#endregion //создание System.Decimal Количество
			
			#region создание System.Int64 Автоинкремент
			{  
                NsgDataInteger Автоинкремент = null;
				if (ObjectList.Contains("Автоинкремент"))
                    Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                else
                    Автоинкремент = new NsgDataInteger();
	//NsgDataInteger
	Автоинкремент.IsLoadedFromDll = true;
	Автоинкремент.DefaultValue = 0M;
	Автоинкремент.MinValue = 0M;
	Автоинкремент.MaxValue = 0M;
	Автоинкремент.UseCalculator = true;
	Автоинкремент.StringFormat = "";
	Автоинкремент.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Автоинкремент.IncludeInPredefined = false;
	Автоинкремент.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Автоинкремент.Required = false;
	Автоинкремент.EmptyValue = "";
	Автоинкремент.NullAllow = false;
	Автоинкремент.IndexType = NsgSoft.Database.NsgRekvisitIndexType.UniqueControl;
	Автоинкремент.FieldName = "_AutoInc";
	Автоинкремент.SaveInDatabase = true;
	Автоинкремент.InformMetaDataOnValueChanged = false;
	Автоинкремент.Visible = true;
	Автоинкремент.Name = "Автоинкремент";
	Автоинкремент.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Автоинкремент.Description = "Автоинкремент";
	Автоинкремент.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Hidden;
	Автоинкремент.GroupName = "";
	Автоинкремент.Guid = NsgService.StringToGuid("858af9b8-43b7-4bc6-9d6d-82aa0a7541aa");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание Автосервис.Номенклатура Номенклатура
			{  
                NsgDataTypedReference Номенклатура = null;
				if (ObjectList.Contains("Номенклатура"))
                    Номенклатура = ObjectList["Номенклатура"] as NsgDataTypedReference;
                else
                    Номенклатура = new NsgDataTypedReference();
	//NsgDataTypedReference
	Номенклатура.IsLoadedFromDll = true;
	Номенклатура.ReferentGroup = "Автосервис";
	Номенклатура.ReferentName = "Номенклатура";
	Номенклатура.SaveInDatabase = true;
	Номенклатура.OwnerName = "";
	Номенклатура.AllowEmptyOwner = false;
	Номенклатура.StringFormat = "";
	Номенклатура.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Номенклатура.IncludeInPredefined = false;
	Номенклатура.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Номенклатура.Required = false;
	Номенклатура.EmptyValue = "";
	Номенклатура.NullAllow = false;
	Номенклатура.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Номенклатура.FieldName = "Nomenklatura";
	Номенклатура.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Номенклатура.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Номенклатура.CharactericticWeight = 1;
	Номенклатура.InformMetaDataOnValueChanged = false;
	Номенклатура.Visible = true;
	Номенклатура.Name = "Номенклатура";
	Номенклатура.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Номенклатура.Description = "Номенклатура";
	Номенклатура.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Номенклатура.GroupName = "";
	Номенклатура.Guid = NsgService.StringToGuid("8969cfb4-beae-4f71-a6d6-5154bb8eecee");
	
				if (!ObjectList.Contains("Номенклатура"))
                    ObjectList.Add(Номенклатура);
			}
			#endregion //создание Автосервис.Номенклатура Номенклатура
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "Автосервис.Остатки";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 1;
	TableSubType = NsgSoft.Common.NsgTableSubType.RegisterAccumTable;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "АвтосервисОстаткиНакопления";
	Visible = true;
	Guid = NsgService.StringToGuid("435ac49c-755f-4f46-bb41-f662252ecca6");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "Ав_tab_AvtoservisOstatki1";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Автосервис остатки накопления";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "_SystemTables";
	
			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgDataTable
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgDataTable

			#region необходимые операции после создания реквизитов и заполнения полей
			// внести в кэш полей
            initFieldsCash();
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

        #endregion // Инициализация

        #region Имена
        public new partial class Names// :NsgSoft.DataObjects.NsgDataTable.Names
        {
            
            /// <summary>
            /// Количество
            /// </summary>
            public static String Количество
            {
                get
                {
                    return "Количество";
                }
            }
            
            /// <summary>
            /// Автоинкремент
            /// </summary>
            public static String Автоинкремент
            {
                get
                {
                    return "Автоинкремент";
                }
            }
            
            /// <summary>
            /// Номенклатура
            /// </summary>
            public static String Номенклатура
            {
                get
                {
                    return "Номенклатура";
                }
            }
            
        }

        #endregion // Имена

        #region Свойства
        public override NsgMultipleObjectDescriptor Descriptor
        {
            get
            {
                if (descriptor == null)
                {
                    descriptor = new NsgMultipleObjectDescriptor();
                    descriptor.Name = "АвтосервисОстаткиНакопления";
                    descriptor.GroupName = "_SystemTables";
                }
                return descriptor;
            }
            set
            {
            }
        }


        public static string GetFullName()
        {
            return "_SystemTables.АвтосервисОстаткиНакопления";
        }

        
        /// <summary>
        /// Количество
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Количество
        {
            get
            {
				 NsgDataFloat __Количество = ObjectList["Количество"] as NsgDataFloat;
                 return (System.Decimal)__Количество.Value;
            }
            set
            {
                NsgDataFloat __Количество = ObjectList["Количество"] as NsgDataFloat;
                __Количество.Value = value;
            }
        }
        
        /// <summary>
        /// Автоинкремент
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 Автоинкремент
        {
            get
            {
				 NsgDataInteger __Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                 return (System.Int64)__Автоинкремент.Value;
            }
            set
            {
                NsgDataInteger __Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                __Автоинкремент.Value = value;
            }
        }
        
        /// <summary>
        /// Номенклатура
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Автосервис.Номенклатура Номенклатура
        {
            get
            {
				 NsgDataTypedReference __Номенклатура = ObjectList["Номенклатура"] as NsgDataTypedReference;
                 return (Автосервис.Номенклатура)__Номенклатура.Referent;
            }
            set
            {
                NsgDataTypedReference __Номенклатура = ObjectList["Номенклатура"] as NsgDataTypedReference;
                __Номенклатура.Referent = value;
            }
        }
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataTable
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataTable

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataTable
        

        /// <summary>
        /// Добавить новую строку в таблицу
        /// </summary>
        public new АвтосервисОстаткиНакопления.Строка NewRow()
        {
            return newRow(null) as АвтосервисОстаткиНакопления.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new АвтосервисОстаткиНакопления.Строка(this);
            return base.newRow(row) as АвтосервисОстаткиНакопления.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public АвтосервисОстаткиНакопления.Строка NewRow(АвтосервисОстаткиНакопления.Строка inRow)
        {
            АвтосервисОстаткиНакопления.Строка row = inRow.Clone as АвтосервисОстаткиНакопления.Строка;
            return base.newRow(row) as АвтосервисОстаткиНакопления.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new АвтосервисОстаткиНакопления.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as АвтосервисОстаткиНакопления.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new АвтосервисОстаткиНакопления.Строка GetEtalonRow()
        {
            АвтосервисОстаткиНакопления.Строка row = new АвтосервисОстаткиНакопления.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private АвтосервисОстаткиНакопления.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            АвтосервисОстаткиНакопления.Строка[] res = new АвтосервисОстаткиНакопления.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new АвтосервисОстаткиНакопления.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as АвтосервисОстаткиНакопления.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new АвтосервисОстаткиНакопления.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new АвтосервисОстаткиНакопления.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as АвтосервисОстаткиНакопления.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new АвтосервисОстаткиНакопления.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as АвтосервисОстаткиНакопления.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new АвтосервисОстаткиНакопления.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as АвтосервисОстаткиНакопления.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new АвтосервисОстаткиНакопления.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new АвтосервисОстаткиНакопления.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new АвтосервисОстаткиНакопления.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<АвтосервисОстаткиНакопления> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<АвтосервисОстаткиНакопления>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new АвтосервисОстаткиНакопления.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new АвтосервисОстаткиНакопления.Строка[] AllRows
        {
            get
            {
                return convertRowsArray(base.AllRows);
            }
        }

        /// <summary>
        /// Получить строку таблицы
        /// </summary>
        /// <param name="inName">Идентификатор строки.</param>
        /// <returns>Найденные строки.</returns>
        public new АвтосервисОстаткиНакопления.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as АвтосервисОстаткиНакопления.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private АвтосервисОстаткиНакопления[] convertArray(NsgMultipleObject[] array)
        {
            АвтосервисОстаткиНакопления[] res = new АвтосервисОстаткиНакопления[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск множества результатов на полное совпадение. Перегруженные методы.
        /// <summary>
        /// Метод поиска в БД по одному и более реквизитов с ограничением количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        /// </remarks>
        /// <param name="compare">Параметры запроса.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual АвтосервисОстаткиНакопления[] FindAll(NsgCompare compare)
        {
            return convertArray(base.FindAll(compare));
        }

        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному и более реквизитов
        ///  c ограничением количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="paramAll">Параметры запроса.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual АвтосервисОстаткиНакопления[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, compare));
        }


        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному реквизиту c ограничением 
        ///  количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="inName">Имя реквизита.</param>
        /// <param name="inValue">Значение для поиска. Условие поиска - полное совпадение.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual АвтосервисОстаткиНакопления[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }


        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному реквизиту c ограничением 
        ///  количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="inName">Идентификатор реквизита.</param>
        /// <param name="inValue">Значение для поиска. Условие поиска - полное совпадение.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual АвтосервисОстаткиНакопления[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new АвтосервисОстаткиНакопления(this as NsgObject);
            }
        }

        #endregion // Методы NsgMultipleObject
        #endregion // Методы

        /// <summary>
        /// Описатель колонки источника данных
        /// </summary>
        public new class ColumnDescriptor : NsgSoft.Forms.NsgColumnDescriptor
        {
            public ColumnDescriptor()
                : base()
            {
                base.NSGType = typeof(АвтосервисОстаткиНакопления);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new АвтосервисОстаткиНакопления Value
            {
                get
                {
                    return (АвтосервисОстаткиНакопления)base.Value;
                }
                set
                {
                    base.Value = value;
                }
            }

            /// <summary>
            /// Имя иконки колонки
            /// </summary>
            public override string ImageKey
            {
                get
                {
                    return "s_NsgDataTable";
                }
            }
        }

    }

}
