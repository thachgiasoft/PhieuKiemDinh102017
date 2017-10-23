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

namespace PhieuKiemDinh
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DatabaseDataEntryBPO")]
	public partial class KiemDinh_EntryBPODataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttbl_Version(tbl_Version instance);
    partial void Updatetbl_Version(tbl_Version instance);
    partial void Deletetbl_Version(tbl_Version instance);
    partial void Inserttbl_TokenLogin(tbl_TokenLogin instance);
    partial void Updatetbl_TokenLogin(tbl_TokenLogin instance);
    partial void Deletetbl_TokenLogin(tbl_TokenLogin instance);
    #endregion
		
		public KiemDinh_EntryBPODataContext() : 
				base(global::PhieuKiemDinh.Properties.Settings.Default.DatabaseDataEntryBPOConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public KiemDinh_EntryBPODataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KiemDinh_EntryBPODataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KiemDinh_EntryBPODataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KiemDinh_EntryBPODataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_User> tbl_Users
		{
			get
			{
				return this.GetTable<tbl_User>();
			}
		}
		
		public System.Data.Linq.Table<tbl_Version> tbl_Versions
		{
			get
			{
				return this.GetTable<tbl_Version>();
			}
		}
		
		public System.Data.Linq.Table<tbl_TokenLogin> tbl_TokenLogins
		{
			get
			{
				return this.GetTable<tbl_TokenLogin>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateTimeFree")]
		public int UpdateTimeFree([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Token", DbType="NVarChar(255)")] string token, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> freetime)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), token, freetime);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetListUser")]
		public ISingleResult<GetListUserResult> GetListUser()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetListUserResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetListRole")]
		public ISingleResult<GetListRoleResult> GetListRole()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetListRoleResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateUsername")]
		public int UpdateUsername([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Username", DbType="NVarChar(100)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(100)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRole", DbType="NVarChar(100)")] string iDRole, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDNhanVien", DbType="NVarChar(100)")] string iDNhanVien, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GroupLevel", DbType="NVarChar(100)")] string groupLevel)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, password, iDRole, iDNhanVien, groupLevel);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertUsername")]
		public int InsertUsername([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Username", DbType="NVarChar(100)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(100)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRole", DbType="NVarChar(100)")] string iDRole, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NhanVien", DbType="NVarChar(100)")] string nhanVien, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GroupLevel", DbType="NVarChar(100)")] string groupLevel)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, password, iDRole, nhanVien, groupLevel);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteUsername")]
		public int DeleteUsername([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Username", DbType="NVarChar(100)")] string username)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.KiemTraLogin")]
		public int KiemTraLogin([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Username", DbType="NVarChar(100)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string password)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, password);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetRoLeCheckLogin")]
		public ISingleResult<GetRoLeCheckLoginResult> GetRoLeCheckLogin([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] ref string role)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, role);
			role = ((string)(result.GetParameterValue(1)));
			return ((ISingleResult<GetRoLeCheckLoginResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.updateToken")]
		public int updateToken([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(255)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(150)")] string idproject, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(255)")] string token)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, idproject, token);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertLoginTime_new")]
		public int InsertLoginTime_new([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserName", DbType="NVarChar(100)")] string userName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TimeLogin", DbType="DateTime")] System.Nullable<System.DateTime> timeLogin, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="WindowUser", DbType="NVarChar(100)")] string windowUser, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MachineName", DbType="NVarChar(100)")] string machineName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IPAddress", DbType="NVarChar(100)")] string iPAddress, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Token", DbType="NVarChar(100)")] string token, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string project)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userName, timeLogin, windowUser, machineName, iPAddress, token, project);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdatePassword")]
		public int UpdatePassword([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserName", DbType="NVarChar(255)")] string userName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PassWordOld", DbType="NVarChar(255)")] string passWordOld, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PassWordNew", DbType="NVarChar(255)")] string passWordNew)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userName, passWordOld, passWordNew);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateTimeLastRequest")]
		public int UpdateTimeLastRequest([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Token", DbType="NVarChar(255)")] string token)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), token);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateTimeLogout")]
		public int UpdateTimeLogout([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Token", DbType="NVarChar(255)")] string token)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), token);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ResetToken")]
		public int ResetToken([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(255)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(150)")] string idproject, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Token", DbType="NVarChar(255)")] string token)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, idproject, token);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_User")]
	public partial class tbl_User
	{
		
		private string _Username;
		
		private string _Password;
		
		private string _IDRole;
		
		private string _IDNhanVien;
		
		private string _Group_Level;
		
		private string _FullName;
		
		private System.Nullable<bool> _NotGoodUser;
		
		private System.Nullable<System.DateTime> _DateEdit;
		
		private bool _IsDelete;
		
		public tbl_User()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this._Username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(100)")]
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
					this._Password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDRole", DbType="NVarChar(100)")]
		public string IDRole
		{
			get
			{
				return this._IDRole;
			}
			set
			{
				if ((this._IDRole != value))
				{
					this._IDRole = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDNhanVien", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string IDNhanVien
		{
			get
			{
				return this._IDNhanVien;
			}
			set
			{
				if ((this._IDNhanVien != value))
				{
					this._IDNhanVien = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Group_Level", DbType="NVarChar(100)")]
		public string Group_Level
		{
			get
			{
				return this._Group_Level;
			}
			set
			{
				if ((this._Group_Level != value))
				{
					this._Group_Level = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="NVarChar(100)")]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this._FullName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NotGoodUser", DbType="Bit")]
		public System.Nullable<bool> NotGoodUser
		{
			get
			{
				return this._NotGoodUser;
			}
			set
			{
				if ((this._NotGoodUser != value))
				{
					this._NotGoodUser = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateEdit", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateEdit
		{
			get
			{
				return this._DateEdit;
			}
			set
			{
				if ((this._DateEdit != value))
				{
					this._DateEdit = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsDelete", DbType="Bit NOT NULL")]
		public bool IsDelete
		{
			get
			{
				return this._IsDelete;
			}
			set
			{
				if ((this._IsDelete != value))
				{
					this._IsDelete = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Version")]
	public partial class tbl_Version : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IDProject;
		
		private string _IDVersion;
		
		private int _ID_int_auto;
		
		private string _MoTaChucNangMoi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDProjectChanging(string value);
    partial void OnIDProjectChanged();
    partial void OnIDVersionChanging(string value);
    partial void OnIDVersionChanged();
    partial void OnID_int_autoChanging(int value);
    partial void OnID_int_autoChanged();
    partial void OnMoTaChucNangMoiChanging(string value);
    partial void OnMoTaChucNangMoiChanged();
    #endregion
		
		public tbl_Version()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDProject", DbType="NVarChar(150) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IDProject
		{
			get
			{
				return this._IDProject;
			}
			set
			{
				if ((this._IDProject != value))
				{
					this.OnIDProjectChanging(value);
					this.SendPropertyChanging();
					this._IDProject = value;
					this.SendPropertyChanged("IDProject");
					this.OnIDProjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDVersion", DbType="NVarChar(100)")]
		public string IDVersion
		{
			get
			{
				return this._IDVersion;
			}
			set
			{
				if ((this._IDVersion != value))
				{
					this.OnIDVersionChanging(value);
					this.SendPropertyChanging();
					this._IDVersion = value;
					this.SendPropertyChanged("IDVersion");
					this.OnIDVersionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_int_auto", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int ID_int_auto
		{
			get
			{
				return this._ID_int_auto;
			}
			set
			{
				if ((this._ID_int_auto != value))
				{
					this.OnID_int_autoChanging(value);
					this.SendPropertyChanging();
					this._ID_int_auto = value;
					this.SendPropertyChanged("ID_int_auto");
					this.OnID_int_autoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTaChucNangMoi", DbType="NVarChar(200)")]
		public string MoTaChucNangMoi
		{
			get
			{
				return this._MoTaChucNangMoi;
			}
			set
			{
				if ((this._MoTaChucNangMoi != value))
				{
					this.OnMoTaChucNangMoiChanging(value);
					this.SendPropertyChanging();
					this._MoTaChucNangMoi = value;
					this.SendPropertyChanged("MoTaChucNangMoi");
					this.OnMoTaChucNangMoiChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_TokenLogin")]
	public partial class tbl_TokenLogin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private string _UserName;
		
		private string _IDProject;
		
		private string _Token;
		
		private System.Nullable<System.DateTime> _DateLogin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnIDProjectChanging(string value);
    partial void OnIDProjectChanged();
    partial void OnTokenChanging(string value);
    partial void OnTokenChanged();
    partial void OnDateLoginChanging(System.Nullable<System.DateTime> value);
    partial void OnDateLoginChanged();
    #endregion
		
		public tbl_TokenLogin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(255)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDProject", DbType="NVarChar(150)")]
		public string IDProject
		{
			get
			{
				return this._IDProject;
			}
			set
			{
				if ((this._IDProject != value))
				{
					this.OnIDProjectChanging(value);
					this.SendPropertyChanging();
					this._IDProject = value;
					this.SendPropertyChanged("IDProject");
					this.OnIDProjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Token", DbType="NVarChar(255)")]
		public string Token
		{
			get
			{
				return this._Token;
			}
			set
			{
				if ((this._Token != value))
				{
					this.OnTokenChanging(value);
					this.SendPropertyChanging();
					this._Token = value;
					this.SendPropertyChanged("Token");
					this.OnTokenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateLogin", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateLogin
		{
			get
			{
				return this._DateLogin;
			}
			set
			{
				if ((this._DateLogin != value))
				{
					this.OnDateLoginChanging(value);
					this.SendPropertyChanging();
					this._DateLogin = value;
					this.SendPropertyChanged("DateLogin");
					this.OnDateLoginChanged();
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
	
	public partial class GetListUserResult
	{
		
		private string _Username;
		
		private string _FullName;
		
		private string _Password;
		
		private string _IDRole;
		
		private string _Group_Level;
		
		private System.Nullable<bool> _NotGoodUser;
		
		public GetListUserResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this._Username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="NVarChar(100)")]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this._FullName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(100)")]
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
					this._Password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDRole", DbType="NVarChar(100)")]
		public string IDRole
		{
			get
			{
				return this._IDRole;
			}
			set
			{
				if ((this._IDRole != value))
				{
					this._IDRole = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Group_Level", DbType="NVarChar(100)")]
		public string Group_Level
		{
			get
			{
				return this._Group_Level;
			}
			set
			{
				if ((this._Group_Level != value))
				{
					this._Group_Level = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NotGoodUser", DbType="Bit")]
		public System.Nullable<bool> NotGoodUser
		{
			get
			{
				return this._NotGoodUser;
			}
			set
			{
				if ((this._NotGoodUser != value))
				{
					this._NotGoodUser = value;
				}
			}
		}
	}
	
	public partial class GetListRoleResult
	{
		
		private string _RoleID;
		
		private string _RoleName;
		
		private string _GhiChu;
		
		public GetListRoleResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleID", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string RoleID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleName", DbType="NVarChar(100)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(100)")]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this._GhiChu = value;
				}
			}
		}
	}
	
	public partial class GetRoLeCheckLoginResult
	{
		
		private string _Column1;
		
		public GetRoLeCheckLoginResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="", Storage="_Column1", DbType="NVarChar(100)")]
		public string Column1
		{
			get
			{
				return this._Column1;
			}
			set
			{
				if ((this._Column1 != value))
				{
					this._Column1 = value;
				}
			}
		}
	}
}
#pragma warning restore 1591