﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Day15.Model
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SampleDB")]
	public partial class SaleDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttbl_customer(tbl_customer instance);
    partial void Updatetbl_customer(tbl_customer instance);
    partial void Deletetbl_customer(tbl_customer instance);
    partial void Inserttbl_product(tbl_product instance);
    partial void Updatetbl_product(tbl_product instance);
    partial void Deletetbl_product(tbl_product instance);
    partial void Inserttbl_SalesInvoice(tbl_SalesInvoice instance);
    partial void Updatetbl_SalesInvoice(tbl_SalesInvoice instance);
    partial void Deletetbl_SalesInvoice(tbl_SalesInvoice instance);
    partial void Inserttbl_UOM(tbl_UOM instance);
    partial void Updatetbl_UOM(tbl_UOM instance);
    partial void Deletetbl_UOM(tbl_UOM instance);
    partial void Inserttbl_user(tbl_user instance);
    partial void Updatetbl_user(tbl_user instance);
    partial void Deletetbl_user(tbl_user instance);
    #endregion
		
		public SaleDBDataContext() : 
				base(global::Day15.Properties.Settings.Default.SampleDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SaleDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SaleDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SaleDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SaleDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_customer> tbl_customers
		{
			get
			{
				return this.GetTable<tbl_customer>();
			}
		}
		
		public System.Data.Linq.Table<tbl_user_role> tbl_user_roles
		{
			get
			{
				return this.GetTable<tbl_user_role>();
			}
		}
		
		public System.Data.Linq.Table<tbl_department> tbl_departments
		{
			get
			{
				return this.GetTable<tbl_department>();
			}
		}
		
		public System.Data.Linq.Table<tbl_product> tbl_products
		{
			get
			{
				return this.GetTable<tbl_product>();
			}
		}
		
		public System.Data.Linq.Table<tbl_project> tbl_projects
		{
			get
			{
				return this.GetTable<tbl_project>();
			}
		}
		
		public System.Data.Linq.Table<tbl_SalesInvoice> tbl_SalesInvoices
		{
			get
			{
				return this.GetTable<tbl_SalesInvoice>();
			}
		}
		
		public System.Data.Linq.Table<tbl_task> tbl_tasks
		{
			get
			{
				return this.GetTable<tbl_task>();
			}
		}
		
		public System.Data.Linq.Table<tbl_UOM> tbl_UOMs
		{
			get
			{
				return this.GetTable<tbl_UOM>();
			}
		}
		
		public System.Data.Linq.Table<tbl_user> tbl_users
		{
			get
			{
				return this.GetTable<tbl_user>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_customer")]
	public partial class tbl_customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CusID;
		
		private string _CusName;
		
		private string _CusPhone;
		
		private string _CusEmail;
		
		private System.DateTime _CreatedDate;
		
		private System.DateTime _ModifiedDate;
		
		private bool _IsActive;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCusIDChanging(string value);
    partial void OnCusIDChanged();
    partial void OnCusNameChanging(string value);
    partial void OnCusNameChanged();
    partial void OnCusPhoneChanging(string value);
    partial void OnCusPhoneChanged();
    partial void OnCusEmailChanging(string value);
    partial void OnCusEmailChanged();
    partial void OnCreatedDateChanging(System.DateTime value);
    partial void OnCreatedDateChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    partial void OnIsActiveChanging(bool value);
    partial void OnIsActiveChanged();
    #endregion
		
		public tbl_customer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CusID", DbType="Char(36) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CusID
		{
			get
			{
				return this._CusID;
			}
			set
			{
				if ((this._CusID != value))
				{
					this.OnCusIDChanging(value);
					this.SendPropertyChanging();
					this._CusID = value;
					this.SendPropertyChanged("CusID");
					this.OnCusIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CusName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string CusName
		{
			get
			{
				return this._CusName;
			}
			set
			{
				if ((this._CusName != value))
				{
					this.OnCusNameChanging(value);
					this.SendPropertyChanging();
					this._CusName = value;
					this.SendPropertyChanged("CusName");
					this.OnCusNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CusPhone", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string CusPhone
		{
			get
			{
				return this._CusPhone;
			}
			set
			{
				if ((this._CusPhone != value))
				{
					this.OnCusPhoneChanging(value);
					this.SendPropertyChanging();
					this._CusPhone = value;
					this.SendPropertyChanged("CusPhone");
					this.OnCusPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CusEmail", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string CusEmail
		{
			get
			{
				return this._CusEmail;
			}
			set
			{
				if ((this._CusEmail != value))
				{
					this.OnCusEmailChanging(value);
					this.SendPropertyChanging();
					this._CusEmail = value;
					this.SendPropertyChanged("CusEmail");
					this.OnCusEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedDate", DbType="DateTime NOT NULL")]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._CreatedDate;
			}
			set
			{
				if ((this._CreatedDate != value))
				{
					this.OnCreatedDateChanging(value);
					this.SendPropertyChanging();
					this._CreatedDate = value;
					this.SendPropertyChanged("CreatedDate");
					this.OnCreatedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedDate
		{
			get
			{
				return this._ModifiedDate;
			}
			set
			{
				if ((this._ModifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this.SendPropertyChanging();
					this._ModifiedDate = value;
					this.SendPropertyChanged("ModifiedDate");
					this.OnModifiedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit NOT NULL")]
		public bool IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this.OnIsActiveChanging(value);
					this.SendPropertyChanging();
					this._IsActive = value;
					this.SendPropertyChanged("IsActive");
					this.OnIsActiveChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_user_roles")]
	public partial class tbl_user_role
	{
		
		private int _RoleID;
		
		private string _RoleName;
		
		public tbl_user_role()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleID", DbType="Int NOT NULL")]
		public int RoleID
		{
			get
			{
				return this._RoleID;
			}
			set
			{
				if ((this._RoleID != value))
				{
					this._RoleID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string RoleName
		{
			get
			{
				return this._RoleName;
			}
			set
			{
				if ((this._RoleName != value))
				{
					this._RoleName = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_departments")]
	public partial class tbl_department
	{
		
		private int _DepartmentID;
		
		private System.Data.Linq.Binary _DepartmentName;
		
		public tbl_department()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentID", DbType="Int NOT NULL")]
		public int DepartmentID
		{
			get
			{
				return this._DepartmentID;
			}
			set
			{
				if ((this._DepartmentID != value))
				{
					this._DepartmentID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentName", DbType="VarBinary(100) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary DepartmentName
		{
			get
			{
				return this._DepartmentName;
			}
			set
			{
				if ((this._DepartmentName != value))
				{
					this._DepartmentName = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_product")]
	public partial class tbl_product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ProId;
		
		private string _ProName;
		
		private decimal _ProPrice;
		
		private string _UOMId;
		
		private System.DateTime _ExpiedDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProIdChanging(string value);
    partial void OnProIdChanged();
    partial void OnProNameChanging(string value);
    partial void OnProNameChanged();
    partial void OnProPriceChanging(decimal value);
    partial void OnProPriceChanged();
    partial void OnUOMIdChanging(string value);
    partial void OnUOMIdChanged();
    partial void OnExpiedDateChanging(System.DateTime value);
    partial void OnExpiedDateChanged();
    #endregion
		
		public tbl_product()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProId", DbType="Char(36) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ProId
		{
			get
			{
				return this._ProId;
			}
			set
			{
				if ((this._ProId != value))
				{
					this.OnProIdChanging(value);
					this.SendPropertyChanging();
					this._ProId = value;
					this.SendPropertyChanged("ProId");
					this.OnProIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ProName
		{
			get
			{
				return this._ProName;
			}
			set
			{
				if ((this._ProName != value))
				{
					this.OnProNameChanging(value);
					this.SendPropertyChanging();
					this._ProName = value;
					this.SendPropertyChanged("ProName");
					this.OnProNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProPrice", DbType="Decimal(18,0) NOT NULL")]
		public decimal ProPrice
		{
			get
			{
				return this._ProPrice;
			}
			set
			{
				if ((this._ProPrice != value))
				{
					this.OnProPriceChanging(value);
					this.SendPropertyChanging();
					this._ProPrice = value;
					this.SendPropertyChanged("ProPrice");
					this.OnProPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UOMId", DbType="Char(36) NOT NULL", CanBeNull=false)]
		public string UOMId
		{
			get
			{
				return this._UOMId;
			}
			set
			{
				if ((this._UOMId != value))
				{
					this.OnUOMIdChanging(value);
					this.SendPropertyChanging();
					this._UOMId = value;
					this.SendPropertyChanged("UOMId");
					this.OnUOMIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExpiedDate", DbType="DateTime NOT NULL")]
		public System.DateTime ExpiedDate
		{
			get
			{
				return this._ExpiedDate;
			}
			set
			{
				if ((this._ExpiedDate != value))
				{
					this.OnExpiedDateChanging(value);
					this.SendPropertyChanging();
					this._ExpiedDate = value;
					this.SendPropertyChanged("ExpiedDate");
					this.OnExpiedDateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_projects")]
	public partial class tbl_project
	{
		
		private int _ProjectID;
		
		private System.Data.Linq.Binary _ProjectName;
		
		private System.Data.Linq.Binary _DepartmentID;
		
		public tbl_project()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectID", DbType="Int NOT NULL")]
		public int ProjectID
		{
			get
			{
				return this._ProjectID;
			}
			set
			{
				if ((this._ProjectID != value))
				{
					this._ProjectID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectName", DbType="VarBinary(100) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary ProjectName
		{
			get
			{
				return this._ProjectName;
			}
			set
			{
				if ((this._ProjectName != value))
				{
					this._ProjectName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentID", DbType="VarBinary(100) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary DepartmentID
		{
			get
			{
				return this._DepartmentID;
			}
			set
			{
				if ((this._DepartmentID != value))
				{
					this._DepartmentID = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_SalesInvoice")]
	public partial class tbl_SalesInvoice : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _SalesInvoiceId;
		
		private string _CusID;
		
		private string _ProId;
		
		private int _Quantity;
		
		private string _UOMId;
		
		private string _SubTotal;
		
		private System.DateTime _CreatedDate;
		
		private System.DateTime _ModifiedDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSalesInvoiceIdChanging(string value);
    partial void OnSalesInvoiceIdChanged();
    partial void OnCusIDChanging(string value);
    partial void OnCusIDChanged();
    partial void OnProIdChanging(string value);
    partial void OnProIdChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    partial void OnUOMIdChanging(string value);
    partial void OnUOMIdChanged();
    partial void OnSubTotalChanging(string value);
    partial void OnSubTotalChanged();
    partial void OnCreatedDateChanging(System.DateTime value);
    partial void OnCreatedDateChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
		
		public tbl_SalesInvoice()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalesInvoiceId", DbType="Char(36) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string SalesInvoiceId
		{
			get
			{
				return this._SalesInvoiceId;
			}
			set
			{
				if ((this._SalesInvoiceId != value))
				{
					this.OnSalesInvoiceIdChanging(value);
					this.SendPropertyChanging();
					this._SalesInvoiceId = value;
					this.SendPropertyChanged("SalesInvoiceId");
					this.OnSalesInvoiceIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CusID", DbType="Char(36) NOT NULL", CanBeNull=false)]
		public string CusID
		{
			get
			{
				return this._CusID;
			}
			set
			{
				if ((this._CusID != value))
				{
					this.OnCusIDChanging(value);
					this.SendPropertyChanging();
					this._CusID = value;
					this.SendPropertyChanged("CusID");
					this.OnCusIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProId", DbType="Char(36) NOT NULL", CanBeNull=false)]
		public string ProId
		{
			get
			{
				return this._ProId;
			}
			set
			{
				if ((this._ProId != value))
				{
					this.OnProIdChanging(value);
					this.SendPropertyChanging();
					this._ProId = value;
					this.SendPropertyChanged("ProId");
					this.OnProIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
		public int Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UOMId", DbType="Char(36) NOT NULL", CanBeNull=false)]
		public string UOMId
		{
			get
			{
				return this._UOMId;
			}
			set
			{
				if ((this._UOMId != value))
				{
					this.OnUOMIdChanging(value);
					this.SendPropertyChanging();
					this._UOMId = value;
					this.SendPropertyChanged("UOMId");
					this.OnUOMIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubTotal", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SubTotal
		{
			get
			{
				return this._SubTotal;
			}
			set
			{
				if ((this._SubTotal != value))
				{
					this.OnSubTotalChanging(value);
					this.SendPropertyChanging();
					this._SubTotal = value;
					this.SendPropertyChanged("SubTotal");
					this.OnSubTotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedDate", DbType="DateTime NOT NULL")]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._CreatedDate;
			}
			set
			{
				if ((this._CreatedDate != value))
				{
					this.OnCreatedDateChanging(value);
					this.SendPropertyChanging();
					this._CreatedDate = value;
					this.SendPropertyChanged("CreatedDate");
					this.OnCreatedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedDate
		{
			get
			{
				return this._ModifiedDate;
			}
			set
			{
				if ((this._ModifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this.SendPropertyChanging();
					this._ModifiedDate = value;
					this.SendPropertyChanged("ModifiedDate");
					this.OnModifiedDateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_tasks")]
	public partial class tbl_task
	{
		
		private System.Nullable<int> _TaskID;
		
		private string _TaskName;
		
		private System.Nullable<int> _UserID;
		
		private System.Nullable<int> _ProjectID;
		
		public tbl_task()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskID", DbType="Int")]
		public System.Nullable<int> TaskID
		{
			get
			{
				return this._TaskID;
			}
			set
			{
				if ((this._TaskID != value))
				{
					this._TaskID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskName", DbType="VarChar(100)")]
		public string TaskName
		{
			get
			{
				return this._TaskName;
			}
			set
			{
				if ((this._TaskName != value))
				{
					this._TaskName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int")]
		public System.Nullable<int> UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this._UserID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectID", DbType="Int")]
		public System.Nullable<int> ProjectID
		{
			get
			{
				return this._ProjectID;
			}
			set
			{
				if ((this._ProjectID != value))
				{
					this._ProjectID = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_UOM")]
	public partial class tbl_UOM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UOMId;
		
		private string _Description;
		
		private string _Symbol;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUOMIdChanging(string value);
    partial void OnUOMIdChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnSymbolChanging(string value);
    partial void OnSymbolChanged();
    #endregion
		
		public tbl_UOM()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UOMId", DbType="Char(36) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UOMId
		{
			get
			{
				return this._UOMId;
			}
			set
			{
				if ((this._UOMId != value))
				{
					this.OnUOMIdChanging(value);
					this.SendPropertyChanging();
					this._UOMId = value;
					this.SendPropertyChanged("UOMId");
					this.OnUOMIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Symbol", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Symbol
		{
			get
			{
				return this._Symbol;
			}
			set
			{
				if ((this._Symbol != value))
				{
					this.OnSymbolChanging(value);
					this.SendPropertyChanging();
					this._Symbol = value;
					this.SendPropertyChanged("Symbol");
					this.OnSymbolChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_user")]
	public partial class tbl_user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserID;
		
		private string _UserName;
		
		private string _Email;
		
		private string _Password;
		
		private System.DateTime _CreatedDate;
		
		private System.Nullable<System.DateTime> _ModifiedDate;
		
		private bool _IsActive;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(string value);
    partial void OnUserIDChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnCreatedDateChanging(System.DateTime value);
    partial void OnCreatedDateChanged();
    partial void OnModifiedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnModifiedDateChanged();
    partial void OnIsActiveChanging(bool value);
    partial void OnIsActiveChanged();
    #endregion
		
		public tbl_user()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Char(36) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedDate", DbType="DateTime NOT NULL")]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._CreatedDate;
			}
			set
			{
				if ((this._CreatedDate != value))
				{
					this.OnCreatedDateChanging(value);
					this.SendPropertyChanging();
					this._CreatedDate = value;
					this.SendPropertyChanged("CreatedDate");
					this.OnCreatedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ModifiedDate
		{
			get
			{
				return this._ModifiedDate;
			}
			set
			{
				if ((this._ModifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this.SendPropertyChanging();
					this._ModifiedDate = value;
					this.SendPropertyChanged("ModifiedDate");
					this.OnModifiedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit NOT NULL")]
		public bool IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this.OnIsActiveChanging(value);
					this.SendPropertyChanging();
					this._IsActive = value;
					this.SendPropertyChanged("IsActive");
					this.OnIsActiveChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
