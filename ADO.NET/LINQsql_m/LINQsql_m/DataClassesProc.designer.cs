﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LINQsql_m
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Northwind")]
	public partial class DataClassesProcDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    #endregion
		
		public DataClassesProcDataContext() : 
				base(global::LINQsql_m.Properties.Settings.Default.NorthwindConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesProcDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesProcDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesProcDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesProcDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.[Ten Most Expensive Products]")]
		public ISingleResult<Ten_Most_Expensive_ProductsResult> Ten_Most_Expensive_Products()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<Ten_Most_Expensive_ProductsResult>)(result.ReturnValue));
		}
	}
	
	public partial class Ten_Most_Expensive_ProductsResult
	{
		
		private string _TenMostExpensiveProducts;
		
		private System.Nullable<decimal> _UnitPrice;
		
		public Ten_Most_Expensive_ProductsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenMostExpensiveProducts", DbType="NVarChar(40) NOT NULL", CanBeNull=false)]
		public string TenMostExpensiveProducts
		{
			get
			{
				return this._TenMostExpensiveProducts;
			}
			set
			{
				if ((this._TenMostExpensiveProducts != value))
				{
					this._TenMostExpensiveProducts = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitPrice", DbType="Money")]
		public System.Nullable<decimal> UnitPrice
		{
			get
			{
				return this._UnitPrice;
			}
			set
			{
				if ((this._UnitPrice != value))
				{
					this._UnitPrice = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
