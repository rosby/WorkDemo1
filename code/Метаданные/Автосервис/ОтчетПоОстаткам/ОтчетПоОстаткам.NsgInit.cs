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

namespace Авто.Метаданные.Автосервис
{
    
    [NsgTypeName("NsgReportObject", Guid = "57088a41-162a-4262-9f7c-6a721c8df113")]
    public partial class ОтчетПоОстаткам : NsgSoft.DataObjects.NsgReportObject
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgReportObject
        




        #endregion // Данные NsgSoft.DataObjects.NsgReportObject

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgReportObject
        




        #endregion // Конструкторы NsgSoft.DataObjects.NsgReportObject

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected ОтчетПоОстаткам()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected ОтчетПоОстаткам(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static ОтчетПоОстаткам Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("57088a41-162a-4262-9f7c-6a721c8df113"));
            if (obj == null)
                obj = new ОтчетПоОстаткам();
            return obj as ОтчетПоОстаткам;
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
			#region начало инициализации NsgSoft.DataObjects.NsgReportObject
			




			#endregion //начало инициализации NsgSoft.DataObjects.NsgReportObject
			
			#region создание System.Guid Идентификатор
			{  
                NsgDataGuid Идентификатор = null;
				if (ObjectList.Contains("Идентификатор"))
                    Идентификатор = ObjectList["Идентификатор"] as NsgDataGuid;
                else
                    Идентификатор = new NsgDataGuid();
	//NsgDataGuid
	Идентификатор.IsLoadedFromDll = true;
	Идентификатор.StringFormat = "";
	Идентификатор.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Идентификатор.IncludeInPredefined = false;
	Идентификатор.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Идентификатор.Required = false;
	Идентификатор.EmptyValue = "";
	Идентификатор.NullAllow = false;
	Идентификатор.IndexType = NsgSoft.Database.NsgRekvisitIndexType.UniqueControl;
	Идентификатор.FieldName = "_ID";
	Идентификатор.SaveInDatabase = false;
	Идентификатор.InformMetaDataOnValueChanged = false;
	Идентификатор.Visible = true;
	Идентификатор.Name = "Идентификатор";
	Идентификатор.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Идентификатор.Description = "Идентификатор";
	Идентификатор.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Идентификатор.GroupName = "";
	Идентификатор.Guid = NsgService.StringToGuid("eeff3572-9b47-4ab4-a91b-83a2c2552cbf");
	
				if (!ObjectList.Contains("Идентификатор"))
                    ObjectList.Add(Идентификатор);
			}
			#endregion //создание System.Guid Идентификатор
			
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
	Автоинкремент.SaveInDatabase = false;
	Автоинкремент.InformMetaDataOnValueChanged = false;
	Автоинкремент.Visible = true;
	Автоинкремент.Name = "Автоинкремент";
	Автоинкремент.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Автоинкремент.Description = "Автоинкремент";
	Автоинкремент.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Hidden;
	Автоинкремент.GroupName = "";
	Автоинкремент.Guid = NsgService.StringToGuid("d7a17797-a590-46f9-88e1-f2c842cf06cb");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание Авто.Метаданные.Автосервис.ОтчетПоОстаткамФорма Форма
			{  
                NsgDataForm Форма = null;
				if (ObjectList.Contains("Форма"))
                    Форма = ObjectList["Форма"] as NsgDataForm;
                else
                    Форма = new NsgDataForm();
	//NsgDataForm
	Форма.IsLoadedFromDll = true;
	Форма.FormClassName = "Авто.Метаданные.Автосервис.ОтчетПоОстаткамФорма";
	Форма.SaveInDatabase = false;
	Форма.StringFormat = "";
	Форма.SubType = NsgSoft.Common.NsgRekvisitSubType.ElementForm;
	Форма.IncludeInPredefined = false;
	Форма.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Форма.Required = false;
	Форма.EmptyValue = "";
	Форма.NullAllow = false;
	Форма.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Форма.FieldName = "Forma";
	Форма.InformMetaDataOnValueChanged = false;
	Форма.Visible = true;
	Форма.Name = "Форма";
	Форма.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Форма.Description = "Форма";
	Форма.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Форма.GroupName = "";
	Форма.Guid = NsgService.StringToGuid("edcc5c13-cd28-45f4-ac49-3af933f6f2f5");
	
				if (!ObjectList.Contains("Форма"))
                    ObjectList.Add(Форма);
			}
			#endregion //создание Авто.Метаданные.Автосервис.ОтчетПоОстаткамФорма Форма
			
			#region создание _SystemTables.АвтосервисОтчетПоОстаткамТаблица Таблица
			{  
                NsgDataTableReference Таблица = null;
				if (ObjectList.Contains("Таблица"))
                    Таблица = ObjectList["Таблица"] as NsgDataTableReference;
                else
                    Таблица = new NsgDataTableReference();
	//NsgDataTableReference
	Таблица.IsLoadedFromDll = true;
	Таблица.Name = "Таблица";
	Таблица.SaveInDatabase = false;
	Таблица.ReferentGroup = "_SystemTables";
	Таблица.ReferentName = "АвтосервисОтчетПоОстаткамТаблица";
	Таблица.OwnerName = "";
	Таблица.AllowEmptyOwner = false;
	Таблица.StringFormat = "";
	Таблица.SubType = NsgSoft.Common.NsgRekvisitSubType.Tables;
	Таблица.IncludeInPredefined = false;
	Таблица.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Таблица.Required = false;
	Таблица.EmptyValue = "";
	Таблица.NullAllow = false;
	Таблица.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Таблица.FieldName = "Tablica";
	Таблица.InformMetaDataOnValueChanged = false;
	Таблица.Visible = true;
	Таблица.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Таблица.Description = "Таблица";
	Таблица.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Таблица.GroupName = "";
	Таблица.Guid = NsgService.StringToGuid("a460ac2a-d8bc-46b2-9afa-bf0d1e2dedc1");
	
				if (!ObjectList.Contains("Таблица"))
                    ObjectList.Add(Таблица);
			}
			#endregion //создание _SystemTables.АвтосервисОтчетПоОстаткамТаблица Таблица
			

			#region заполнение полей класса
				//NsgReportObject
	IsLoadedFromDll = true;
	Name = "ОтчетПоОстаткам";
	Visible = true;
	Guid = NsgService.StringToGuid("57088a41-162a-4262-9f7c-6a721c8df113");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "Ав_report_OtchetPoOstatkam";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "ОтчетПоОстаткам";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Автосервис";
	
			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgReportObject
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgReportObject

			#region необходимые операции после создания реквизитов и заполнения полей
			// внести в кэш полей
            initFieldsCash();
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

        #endregion // Инициализация

        #region Имена
        public new partial class Names// :NsgSoft.DataObjects.NsgReportObject.Names
        {
            
            /// <summary>
            /// Идентификатор
            /// </summary>
            public static String Идентификатор
            {
                get
                {
                    return "Идентификатор";
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
            /// Форма
            /// </summary>
            public static String Форма
            {
                get
                {
                    return "Форма";
                }
            }
            
            /// <summary>
            /// Таблица
            /// </summary>
            public static String Таблица
            {
                get
                {
                    return "Таблица";
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
                    descriptor.Name = "ОтчетПоОстаткам";
                    descriptor.GroupName = "Автосервис";
                }
                return descriptor;
            }
            set
            {
            }
        }


        public static string GetFullName()
        {
            return "Автосервис.ОтчетПоОстаткам";
        }

        
        /// <summary>
        /// Идентификатор
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataGuid")]
        
        public System.Guid Идентификатор
        {
            get
            {
				 NsgDataGuid __Идентификатор = ObjectList["Идентификатор"] as NsgDataGuid;
                 return (System.Guid)__Идентификатор.Value;
            }
            set
            {
                NsgDataGuid __Идентификатор = ObjectList["Идентификатор"] as NsgDataGuid;
                __Идентификатор.Value = value;
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
        /// Таблица
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.АвтосервисОтчетПоОстаткамТаблица Таблица
        {
            get
            {
				 NsgDataTableReference __Таблица = ObjectList["Таблица"] as NsgDataTableReference;
                 return (_SystemTables.АвтосервисОтчетПоОстаткамТаблица)__Таблица.Referent;
            }
            set
            {
                NsgDataTableReference __Таблица = ObjectList["Таблица"] as NsgDataTableReference;
                __Таблица.Referent = value;
            }
        }
        

        
        /// <summary>
        /// Форма
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataForm")]
        
        public INsgObjectForm Форма
        {
            get
            {
                INsgObjectForm res = null;
                if (ObjectList["Форма"].SubType == NsgRekvisitSubType.ListForm)
                   res = NsgSettings.MainForm.GetObjectListForm(this,"Форма");
                else
                   res = NsgSettings.MainForm.GetObjectForm(this,"Форма");
                return res;
           }
        }
        
        #region Свойства NsgSoft.DataObjects.NsgReportObject
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgReportObject

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgReportObject
        




        #endregion // Методы NsgSoft.DataObjects.NsgReportObject

        #region Методы NsgMultipleObject
        private ОтчетПоОстаткам[] convertArray(NsgMultipleObject[] array)
        {
            ОтчетПоОстаткам[] res = new ОтчетПоОстаткам[array.Length];
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
        public new virtual ОтчетПоОстаткам[] FindAll(NsgCompare compare)
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
        public new virtual ОтчетПоОстаткам[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual ОтчетПоОстаткам[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual ОтчетПоОстаткам[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new ОтчетПоОстаткам(this as NsgObject);
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
                base.NSGType = typeof(ОтчетПоОстаткам);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new ОтчетПоОстаткам Value
            {
                get
                {
                    return (ОтчетПоОстаткам)base.Value;
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
                    return "s_NsgReportObject";
                }
            }
        }

    }

}
