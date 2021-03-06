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

namespace MarkingImage_PhieuKiemDinh
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PhieuKiemDinh")]
	public partial class DataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttbl_Batch(tbl_Batch instance);
    partial void Updatetbl_Batch(tbl_Batch instance);
    partial void Deletetbl_Batch(tbl_Batch instance);
    partial void Inserttbl_Point_Hide(tbl_Point_Hide instance);
    partial void Updatetbl_Point_Hide(tbl_Point_Hide instance);
    partial void Deletetbl_Point_Hide(tbl_Point_Hide instance);
    #endregion
		
		public DataDataContext() : 
				base(global::MarkingImage_PhieuKiemDinh.Properties.Settings.Default.PhieuKiemDinhConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_Batch> tbl_Batches
		{
			get
			{
				return this.GetTable<tbl_Batch>();
			}
		}
		
		public System.Data.Linq.Table<tbl_Point_Hide> tbl_Point_Hides
		{
			get
			{
				return this.GetTable<tbl_Point_Hide>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetToaDo")]
		public ISingleResult<GetToaDoResult> GetToaDo([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(255)")] string fBatchName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fBatchName);
			return ((ISingleResult<GetToaDoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Xoa_drawhide")]
		public int Xoa_drawhide([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string fBatchName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fBatchName);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Luu_drawhide")]
		public int Luu_drawhide([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string fBatchName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="STT", DbType="Int")] System.Nullable<int> sTT, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> x1, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> y1, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> x2, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> y2)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fBatchName, sTT, x1, y1, x2, y2);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetBatch_ToaDo")]
		public ISingleResult<GetBatch_ToaDoResult> GetBatch_ToaDo()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetBatch_ToaDoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetBatchCheckExists")]
		public ISingleResult<GetBatchCheckExistsResult> GetBatchCheckExists([global::System.Data.Linq.Mapping.ParameterAttribute(Name="BatchName", DbType="NVarChar(255)")] string batchName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), batchName);
			return ((ISingleResult<GetBatchCheckExistsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertBatch")]
		public int InsertBatch([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(255)")] string fBatchName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserTaoBatch", DbType="NVarChar(255)")] string userTaoBatch, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(255)")] string fPathPicture, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SoLuongHinh", DbType="NVarChar(255)")] string soLuongHinh, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ChiaUser", DbType="Int")] System.Nullable<int> chiaUser)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fBatchName, userTaoBatch, fPathPicture, soLuongHinh, chiaUser);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertImage")]
		public int InsertImage([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(255)")] string fBatchName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdImage", DbType="NVarChar(255)")] string idImage, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ChiaUsser", DbType="Int")] System.Nullable<int> chiaUsser)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fBatchName, idImage, chiaUsser);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Batch")]
	public partial class tbl_Batch : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _fBatchName;
		
		private string _UserTaoBatch;
		
		private string _SoLuongHinh;
		
		private System.Nullable<System.DateTime> _NgayTaoBatch;
		
		private string _fPathPicture;
		
		private System.Nullable<bool> _ChiaUser;
		
		private System.Nullable<bool> _CongKhaiBatch;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnfBatchNameChanging(string value);
    partial void OnfBatchNameChanged();
    partial void OnUserTaoBatchChanging(string value);
    partial void OnUserTaoBatchChanged();
    partial void OnSoLuongHinhChanging(string value);
    partial void OnSoLuongHinhChanged();
    partial void OnNgayTaoBatchChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayTaoBatchChanged();
    partial void OnfPathPictureChanging(string value);
    partial void OnfPathPictureChanged();
    partial void OnChiaUserChanging(System.Nullable<bool> value);
    partial void OnChiaUserChanged();
    partial void OnCongKhaiBatchChanging(System.Nullable<bool> value);
    partial void OnCongKhaiBatchChanged();
    #endregion
		
		public tbl_Batch()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fBatchName", DbType="NVarChar(255) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string fBatchName
		{
			get
			{
				return this._fBatchName;
			}
			set
			{
				if ((this._fBatchName != value))
				{
					this.OnfBatchNameChanging(value);
					this.SendPropertyChanging();
					this._fBatchName = value;
					this.SendPropertyChanged("fBatchName");
					this.OnfBatchNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserTaoBatch", DbType="NVarChar(255)")]
		public string UserTaoBatch
		{
			get
			{
				return this._UserTaoBatch;
			}
			set
			{
				if ((this._UserTaoBatch != value))
				{
					this.OnUserTaoBatchChanging(value);
					this.SendPropertyChanging();
					this._UserTaoBatch = value;
					this.SendPropertyChanged("UserTaoBatch");
					this.OnUserTaoBatchChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuongHinh", DbType="NVarChar(255)")]
		public string SoLuongHinh
		{
			get
			{
				return this._SoLuongHinh;
			}
			set
			{
				if ((this._SoLuongHinh != value))
				{
					this.OnSoLuongHinhChanging(value);
					this.SendPropertyChanging();
					this._SoLuongHinh = value;
					this.SendPropertyChanged("SoLuongHinh");
					this.OnSoLuongHinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayTaoBatch", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayTaoBatch
		{
			get
			{
				return this._NgayTaoBatch;
			}
			set
			{
				if ((this._NgayTaoBatch != value))
				{
					this.OnNgayTaoBatchChanging(value);
					this.SendPropertyChanging();
					this._NgayTaoBatch = value;
					this.SendPropertyChanged("NgayTaoBatch");
					this.OnNgayTaoBatchChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fPathPicture", DbType="NVarChar(255)")]
		public string fPathPicture
		{
			get
			{
				return this._fPathPicture;
			}
			set
			{
				if ((this._fPathPicture != value))
				{
					this.OnfPathPictureChanging(value);
					this.SendPropertyChanging();
					this._fPathPicture = value;
					this.SendPropertyChanged("fPathPicture");
					this.OnfPathPictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChiaUser", DbType="Bit")]
		public System.Nullable<bool> ChiaUser
		{
			get
			{
				return this._ChiaUser;
			}
			set
			{
				if ((this._ChiaUser != value))
				{
					this.OnChiaUserChanging(value);
					this.SendPropertyChanging();
					this._ChiaUser = value;
					this.SendPropertyChanged("ChiaUser");
					this.OnChiaUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CongKhaiBatch", DbType="Bit")]
		public System.Nullable<bool> CongKhaiBatch
		{
			get
			{
				return this._CongKhaiBatch;
			}
			set
			{
				if ((this._CongKhaiBatch != value))
				{
					this.OnCongKhaiBatchChanging(value);
					this.SendPropertyChanging();
					this._CongKhaiBatch = value;
					this.SendPropertyChanged("CongKhaiBatch");
					this.OnCongKhaiBatchChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Point_Hide")]
	public partial class tbl_Point_Hide : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _fBatchName;
		
		private int _STT;
		
		private System.Nullable<int> _x1;
		
		private System.Nullable<int> _y1;
		
		private System.Nullable<int> _x2;
		
		private System.Nullable<int> _y2;
		
		private System.Nullable<System.DateTime> _DateCreate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnfBatchNameChanging(string value);
    partial void OnfBatchNameChanged();
    partial void OnSTTChanging(int value);
    partial void OnSTTChanged();
    partial void Onx1Changing(System.Nullable<int> value);
    partial void Onx1Changed();
    partial void Ony1Changing(System.Nullable<int> value);
    partial void Ony1Changed();
    partial void Onx2Changing(System.Nullable<int> value);
    partial void Onx2Changed();
    partial void Ony2Changing(System.Nullable<int> value);
    partial void Ony2Changed();
    partial void OnDateCreateChanging(System.Nullable<System.DateTime> value);
    partial void OnDateCreateChanged();
    #endregion
		
		public tbl_Point_Hide()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fBatchName", DbType="NVarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string fBatchName
		{
			get
			{
				return this._fBatchName;
			}
			set
			{
				if ((this._fBatchName != value))
				{
					this.OnfBatchNameChanging(value);
					this.SendPropertyChanging();
					this._fBatchName = value;
					this.SendPropertyChanged("fBatchName");
					this.OnfBatchNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STT", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int STT
		{
			get
			{
				return this._STT;
			}
			set
			{
				if ((this._STT != value))
				{
					this.OnSTTChanging(value);
					this.SendPropertyChanging();
					this._STT = value;
					this.SendPropertyChanged("STT");
					this.OnSTTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_x1", DbType="Int")]
		public System.Nullable<int> x1
		{
			get
			{
				return this._x1;
			}
			set
			{
				if ((this._x1 != value))
				{
					this.Onx1Changing(value);
					this.SendPropertyChanging();
					this._x1 = value;
					this.SendPropertyChanged("x1");
					this.Onx1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_y1", DbType="Int")]
		public System.Nullable<int> y1
		{
			get
			{
				return this._y1;
			}
			set
			{
				if ((this._y1 != value))
				{
					this.Ony1Changing(value);
					this.SendPropertyChanging();
					this._y1 = value;
					this.SendPropertyChanged("y1");
					this.Ony1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_x2", DbType="Int")]
		public System.Nullable<int> x2
		{
			get
			{
				return this._x2;
			}
			set
			{
				if ((this._x2 != value))
				{
					this.Onx2Changing(value);
					this.SendPropertyChanging();
					this._x2 = value;
					this.SendPropertyChanged("x2");
					this.Onx2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_y2", DbType="Int")]
		public System.Nullable<int> y2
		{
			get
			{
				return this._y2;
			}
			set
			{
				if ((this._y2 != value))
				{
					this.Ony2Changing(value);
					this.SendPropertyChanging();
					this._y2 = value;
					this.SendPropertyChanged("y2");
					this.Ony2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateCreate", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateCreate
		{
			get
			{
				return this._DateCreate;
			}
			set
			{
				if ((this._DateCreate != value))
				{
					this.OnDateCreateChanging(value);
					this.SendPropertyChanging();
					this._DateCreate = value;
					this.SendPropertyChanged("DateCreate");
					this.OnDateCreateChanged();
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
	
	public partial class GetToaDoResult
	{
		
		private System.Nullable<int> _x1;
		
		private System.Nullable<int> _y1;
		
		private System.Nullable<int> _x2;
		
		private System.Nullable<int> _y2;
		
		public GetToaDoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_x1", DbType="Int")]
		public System.Nullable<int> x1
		{
			get
			{
				return this._x1;
			}
			set
			{
				if ((this._x1 != value))
				{
					this._x1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_y1", DbType="Int")]
		public System.Nullable<int> y1
		{
			get
			{
				return this._y1;
			}
			set
			{
				if ((this._y1 != value))
				{
					this._y1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_x2", DbType="Int")]
		public System.Nullable<int> x2
		{
			get
			{
				return this._x2;
			}
			set
			{
				if ((this._x2 != value))
				{
					this._x2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_y2", DbType="Int")]
		public System.Nullable<int> y2
		{
			get
			{
				return this._y2;
			}
			set
			{
				if ((this._y2 != value))
				{
					this._y2 = value;
				}
			}
		}
	}
	
	public partial class GetBatch_ToaDoResult
	{
		
		private string _fBatchName;
		
		public GetBatch_ToaDoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fBatchName", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string fBatchName
		{
			get
			{
				return this._fBatchName;
			}
			set
			{
				if ((this._fBatchName != value))
				{
					this._fBatchName = value;
				}
			}
		}
	}
	
	public partial class GetBatchCheckExistsResult
	{
		
		private string _fBatchName;
		
		public GetBatchCheckExistsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fBatchName", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string fBatchName
		{
			get
			{
				return this._fBatchName;
			}
			set
			{
				if ((this._fBatchName != value))
				{
					this._fBatchName = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
