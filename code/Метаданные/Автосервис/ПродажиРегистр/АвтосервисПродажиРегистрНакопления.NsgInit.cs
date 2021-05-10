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
    
    [NsgTypeName("NsgDataTable", Guid = "2b219a90-8c91-4547-a460-c59d3a1f81d4")]
    public partial class АвтосервисПродажиРегистрНакопления : NsgSoft.DataObjects.NsgDataTable
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
        protected АвтосервисПродажиРегистрНакопления()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected АвтосервисПродажиРегистрНакопления(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static АвтосервисПродажиРегистрНакопления Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("2b219a90-8c91-4547-a460-c59d3a1f81d4"));
            if (obj == null)
                obj = new АвтосервисПродажиРегистрНакопления();
            return obj as АвтосервисПродажиРегистрНакопления;
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
			
			#region создание System.Decimal ЦенаПродажи
			{  
                NsgDataFloat ЦенаПродажи = null;
				if (ObjectList.Contains("ЦенаПродажи"))
                    ЦенаПродажи = ObjectList["ЦенаПродажи"] as NsgDataFloat;
                else
                    ЦенаПродажи = new NsgDataFloat();
	//NsgDataFloat
	ЦенаПродажи.IsLoadedFromDll = true;
	ЦенаПродажи.Precision = 2;
	ЦенаПродажи.HideZero = true;
	ЦенаПродажи.DefaultValue = 0M;
	ЦенаПродажи.MinValue = -100000000000000000M;
	ЦенаПродажи.MaxValue = 100000000000000000M;
	ЦенаПродажи.UseCalculator = true;
	ЦенаПродажи.StringFormat = "";
	ЦенаПродажи.SubType = NsgSoft.Common.NsgRekvisitSubType.Resource;
	ЦенаПродажи.IncludeInPredefined = false;
	ЦенаПродажи.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ЦенаПродажи.Required = false;
	ЦенаПродажи.EmptyValue = "";
	ЦенаПродажи.NullAllow = false;
	ЦенаПродажи.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ЦенаПродажи.FieldName = "CenaProdazhi";
	ЦенаПродажи.InformMetaDataOnValueChanged = false;
	ЦенаПродажи.Visible = true;
	ЦенаПродажи.Name = "ЦенаПродажи";
	ЦенаПродажи.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЦенаПродажи.Description = "Цена продажи";
	ЦенаПродажи.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ЦенаПродажи.GroupName = "";
	ЦенаПродажи.Guid = NsgService.StringToGuid("05da435f-cda1-4567-a825-d4b655860cf7");
	
				if (!ObjectList.Contains("ЦенаПродажи"))
                    ObjectList.Add(ЦенаПродажи);
			}
			#endregion //создание System.Decimal ЦенаПродажи
			
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
	Автоинкремент.Guid = NsgService.StringToGuid("a383260b-1556-4d5b-b476-2f3560f871ea");
	
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
	Номенклатура.Guid = NsgService.StringToGuid("946c4f1d-69c6-410f-b211-7a330091280d");
	
				if (!ObjectList.Contains("Номенклатура"))
                    ObjectList.Add(Номенклатура);
			}
			#endregion //создание Автосервис.Номенклатура Номенклатура
			
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
	Количество.Guid = NsgService.StringToGuid("6bd88652-b7ee-4a93-b9e3-0f437ec68f03");
	
				if (!ObjectList.Contains("Количество"))
                    ObjectList.Add(Количество);
			}
			#endregion //создание System.Decimal Количество
			
			#region создание System.Decimal Прибыль
			{  
                NsgDataFloat Прибыль = null;
				if (ObjectList.Contains("Прибыль"))
                    Прибыль = ObjectList["Прибыль"] as NsgDataFloat;
                else
                    Прибыль = new NsgDataFloat();
	//NsgDataFloat
	Прибыль.IsLoadedFromDll = true;
	Прибыль.Precision = 2;
	Прибыль.HideZero = true;
	Прибыль.DefaultValue = 0M;
	Прибыль.MinValue = -100000000000000000M;
	Прибыль.MaxValue = 100000000000000000M;
	Прибыль.UseCalculator = true;
	Прибыль.StringFormat = "";
	Прибыль.SubType = NsgSoft.Common.NsgRekvisitSubType.Resource;
	Прибыль.IncludeInPredefined = false;
	Прибыль.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Прибыль.Required = false;
	Прибыль.EmptyValue = "";
	Прибыль.NullAllow = false;
	Прибыль.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Прибыль.FieldName = "Pribyl";
	Прибыль.InformMetaDataOnValueChanged = false;
	Прибыль.Visible = true;
	Прибыль.Name = "Прибыль";
	Прибыль.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Прибыль.Description = "Прибыль";
	Прибыль.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Прибыль.GroupName = "";
	Прибыль.Guid = NsgService.StringToGuid("c7f4ecd2-00be-4461-a08e-85547a03243f");
	
				if (!ObjectList.Contains("Прибыль"))
                    ObjectList.Add(Прибыль);
			}
			#endregion //создание System.Decimal Прибыль
			
			#region создание System.Decimal Рентабельность
			{  
                NsgDataFloat Рентабельность = null;
				if (ObjectList.Contains("Рентабельность"))
                    Рентабельность = ObjectList["Рентабельность"] as NsgDataFloat;
                else
                    Рентабельность = new NsgDataFloat();
	//NsgDataFloat
	Рентабельность.IsLoadedFromDll = true;
	Рентабельность.Precision = 2;
	Рентабельность.HideZero = true;
	Рентабельность.DefaultValue = 0M;
	Рентабельность.MinValue = -100000000000000000M;
	Рентабельность.MaxValue = 100000000000000000M;
	Рентабельность.UseCalculator = true;
	Рентабельность.StringFormat = "";
	Рентабельность.SubType = NsgSoft.Common.NsgRekvisitSubType.Resource;
	Рентабельность.IncludeInPredefined = false;
	Рентабельность.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Рентабельность.Required = false;
	Рентабельность.EmptyValue = "";
	Рентабельность.NullAllow = false;
	Рентабельность.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Рентабельность.FieldName = "Rentabelnost";
	Рентабельность.InformMetaDataOnValueChanged = false;
	Рентабельность.Visible = true;
	Рентабельность.Name = "Рентабельность";
	Рентабельность.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Рентабельность.Description = "Рентабельность";
	Рентабельность.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Рентабельность.GroupName = "";
	Рентабельность.Guid = NsgService.StringToGuid("0fac9c8d-c7fe-41bc-9bf0-59490779acbc");
	
				if (!ObjectList.Contains("Рентабельность"))
                    ObjectList.Add(Рентабельность);
			}
			#endregion //создание System.Decimal Рентабельность
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "Автосервис.ПродажиРегистр";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 1;
	TableSubType = NsgSoft.Common.NsgTableSubType.RegisterAccumTable;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "АвтосервисПродажиРегистрНакопления";
	Visible = true;
	Guid = NsgService.StringToGuid("2b219a90-8c91-4547-a460-c59d3a1f81d4");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "Ав_tab_AvtoservisProdazh1";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Автосервис продажи регистр накопления";
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
            /// Цена продажи
            /// </summary>
            public static String ЦенаПродажи
            {
                get
                {
                    return "ЦенаПродажи";
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
            /// Прибыль
            /// </summary>
            public static String Прибыль
            {
                get
                {
                    return "Прибыль";
                }
            }
            
            /// <summary>
            /// Рентабельность
            /// </summary>
            public static String Рентабельность
            {
                get
                {
                    return "Рентабельность";
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
                    descriptor.Name = "АвтосервисПродажиРегистрНакопления";
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
            return "_SystemTables.АвтосервисПродажиРегистрНакопления";
        }

        
        /// <summary>
        /// Цена продажи
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ЦенаПродажи
        {
            get
            {
				 NsgDataFloat __ЦенаПродажи = ObjectList["ЦенаПродажи"] as NsgDataFloat;
                 return (System.Decimal)__ЦенаПродажи.Value;
            }
            set
            {
                NsgDataFloat __ЦенаПродажи = ObjectList["ЦенаПродажи"] as NsgDataFloat;
                __ЦенаПродажи.Value = value;
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
        /// Прибыль
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Прибыль
        {
            get
            {
				 NsgDataFloat __Прибыль = ObjectList["Прибыль"] as NsgDataFloat;
                 return (System.Decimal)__Прибыль.Value;
            }
            set
            {
                NsgDataFloat __Прибыль = ObjectList["Прибыль"] as NsgDataFloat;
                __Прибыль.Value = value;
            }
        }
        
        /// <summary>
        /// Рентабельность
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Рентабельность
        {
            get
            {
				 NsgDataFloat __Рентабельность = ObjectList["Рентабельность"] as NsgDataFloat;
                 return (System.Decimal)__Рентабельность.Value;
            }
            set
            {
                NsgDataFloat __Рентабельность = ObjectList["Рентабельность"] as NsgDataFloat;
                __Рентабельность.Value = value;
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
        public new АвтосервисПродажиРегистрНакопления.Строка NewRow()
        {
            return newRow(null) as АвтосервисПродажиРегистрНакопления.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new АвтосервисПродажиРегистрНакопления.Строка(this);
            return base.newRow(row) as АвтосервисПродажиРегистрНакопления.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public АвтосервисПродажиРегистрНакопления.Строка NewRow(АвтосервисПродажиРегистрНакопления.Строка inRow)
        {
            АвтосервисПродажиРегистрНакопления.Строка row = inRow.Clone as АвтосервисПродажиРегистрНакопления.Строка;
            return base.newRow(row) as АвтосервисПродажиРегистрНакопления.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new АвтосервисПродажиРегистрНакопления.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as АвтосервисПродажиРегистрНакопления.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new АвтосервисПродажиРегистрНакопления.Строка GetEtalonRow()
        {
            АвтосервисПродажиРегистрНакопления.Строка row = new АвтосервисПродажиРегистрНакопления.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private АвтосервисПродажиРегистрНакопления.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            АвтосервисПродажиРегистрНакопления.Строка[] res = new АвтосервисПродажиРегистрНакопления.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new АвтосервисПродажиРегистрНакопления.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as АвтосервисПродажиРегистрНакопления.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new АвтосервисПродажиРегистрНакопления.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new АвтосервисПродажиРегистрНакопления.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as АвтосервисПродажиРегистрНакопления.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new АвтосервисПродажиРегистрНакопления.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as АвтосервисПродажиРегистрНакопления.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new АвтосервисПродажиРегистрНакопления.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as АвтосервисПродажиРегистрНакопления.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new АвтосервисПродажиРегистрНакопления.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new АвтосервисПродажиРегистрНакопления.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new АвтосервисПродажиРегистрНакопления.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<АвтосервисПродажиРегистрНакопления> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<АвтосервисПродажиРегистрНакопления>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new АвтосервисПродажиРегистрНакопления.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new АвтосервисПродажиРегистрНакопления.Строка[] AllRows
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
        public new АвтосервисПродажиРегистрНакопления.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as АвтосервисПродажиРегистрНакопления.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private АвтосервисПродажиРегистрНакопления[] convertArray(NsgMultipleObject[] array)
        {
            АвтосервисПродажиРегистрНакопления[] res = new АвтосервисПродажиРегистрНакопления[array.Length];
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
        public new virtual АвтосервисПродажиРегистрНакопления[] FindAll(NsgCompare compare)
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
        public new virtual АвтосервисПродажиРегистрНакопления[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual АвтосервисПродажиРегистрНакопления[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual АвтосервисПродажиРегистрНакопления[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new АвтосервисПродажиРегистрНакопления(this as NsgObject);
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
                base.NSGType = typeof(АвтосервисПродажиРегистрНакопления);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new АвтосервисПродажиРегистрНакопления Value
            {
                get
                {
                    return (АвтосервисПродажиРегистрНакопления)base.Value;
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
