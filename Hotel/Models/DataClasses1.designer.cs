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

namespace Hotel.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLyKhachSan")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertHoaDon(HoaDon instance);
    partial void UpdateHoaDon(HoaDon instance);
    partial void DeleteHoaDon(HoaDon instance);
    partial void InsertPhong(Phong instance);
    partial void UpdatePhong(Phong instance);
    partial void DeletePhong(Phong instance);
    partial void InsertKhachHang(KhachHang instance);
    partial void UpdateKhachHang(KhachHang instance);
    partial void DeleteKhachHang(KhachHang instance);
    partial void InsertLoaiPhong(LoaiPhong instance);
    partial void UpdateLoaiPhong(LoaiPhong instance);
    partial void DeleteLoaiPhong(LoaiPhong instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QuanLyKhachSanConnectionString2"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<HoaDon> HoaDons
		{
			get
			{
				return this.GetTable<HoaDon>();
			}
		}
		
		public System.Data.Linq.Table<Phong> Phongs
		{
			get
			{
				return this.GetTable<Phong>();
			}
		}
		
		public System.Data.Linq.Table<KhachHang> KhachHangs
		{
			get
			{
				return this.GetTable<KhachHang>();
			}
		}
		
		public System.Data.Linq.Table<LoaiPhong> LoaiPhongs
		{
			get
			{
				return this.GetTable<LoaiPhong>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HoaDon")]
	public partial class HoaDon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _maHD;
		
		private string _email;
		
		private string _tenPhong;
		
		private System.Nullable<System.DateTime> _ngayDat;
		
		private System.Nullable<System.DateTime> _ngayTra;
		
		private System.Nullable<decimal> _tienThanhToan;
		
		private EntityRef<Phong> _Phong;
		
		private EntityRef<KhachHang> _KhachHang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaHDChanging(string value);
    partial void OnmaHDChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OntenPhongChanging(string value);
    partial void OntenPhongChanged();
    partial void OnngayDatChanging(System.Nullable<System.DateTime> value);
    partial void OnngayDatChanged();
    partial void OnngayTraChanging(System.Nullable<System.DateTime> value);
    partial void OnngayTraChanged();
    partial void OntienThanhToanChanging(System.Nullable<decimal> value);
    partial void OntienThanhToanChanged();
    #endregion
		
		public HoaDon()
		{
			this._Phong = default(EntityRef<Phong>);
			this._KhachHang = default(EntityRef<KhachHang>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maHD", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string maHD
		{
			get
			{
				return this._maHD;
			}
			set
			{
				if ((this._maHD != value))
				{
					this.OnmaHDChanging(value);
					this.SendPropertyChanging();
					this._maHD = value;
					this.SendPropertyChanged("maHD");
					this.OnmaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					if (this._KhachHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenPhong", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string tenPhong
		{
			get
			{
				return this._tenPhong;
			}
			set
			{
				if ((this._tenPhong != value))
				{
					if (this._Phong.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OntenPhongChanging(value);
					this.SendPropertyChanging();
					this._tenPhong = value;
					this.SendPropertyChanged("tenPhong");
					this.OntenPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayDat", DbType="Date")]
		public System.Nullable<System.DateTime> ngayDat
		{
			get
			{
				return this._ngayDat;
			}
			set
			{
				if ((this._ngayDat != value))
				{
					this.OnngayDatChanging(value);
					this.SendPropertyChanging();
					this._ngayDat = value;
					this.SendPropertyChanged("ngayDat");
					this.OnngayDatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayTra", DbType="Date")]
		public System.Nullable<System.DateTime> ngayTra
		{
			get
			{
				return this._ngayTra;
			}
			set
			{
				if ((this._ngayTra != value))
				{
					this.OnngayTraChanging(value);
					this.SendPropertyChanging();
					this._ngayTra = value;
					this.SendPropertyChanged("ngayTra");
					this.OnngayTraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tienThanhToan", DbType="Money")]
		public System.Nullable<decimal> tienThanhToan
		{
			get
			{
				return this._tienThanhToan;
			}
			set
			{
				if ((this._tienThanhToan != value))
				{
					this.OntienThanhToanChanging(value);
					this.SendPropertyChanging();
					this._tienThanhToan = value;
					this.SendPropertyChanged("tienThanhToan");
					this.OntienThanhToanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Phong_HoaDon", Storage="_Phong", ThisKey="tenPhong", OtherKey="tenPhong", IsForeignKey=true)]
		public Phong Phong
		{
			get
			{
				return this._Phong.Entity;
			}
			set
			{
				Phong previousValue = this._Phong.Entity;
				if (((previousValue != value) 
							|| (this._Phong.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Phong.Entity = null;
						previousValue.HoaDons.Remove(this);
					}
					this._Phong.Entity = value;
					if ((value != null))
					{
						value.HoaDons.Add(this);
						this._tenPhong = value.tenPhong;
					}
					else
					{
						this._tenPhong = default(string);
					}
					this.SendPropertyChanged("Phong");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_HoaDon", Storage="_KhachHang", ThisKey="email", OtherKey="email", IsForeignKey=true)]
		public KhachHang KhachHang
		{
			get
			{
				return this._KhachHang.Entity;
			}
			set
			{
				KhachHang previousValue = this._KhachHang.Entity;
				if (((previousValue != value) 
							|| (this._KhachHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KhachHang.Entity = null;
						previousValue.HoaDons.Remove(this);
					}
					this._KhachHang.Entity = value;
					if ((value != null))
					{
						value.HoaDons.Add(this);
						this._email = value.email;
					}
					else
					{
						this._email = default(string);
					}
					this.SendPropertyChanged("KhachHang");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Phong")]
	public partial class Phong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _tenPhong;
		
		private string _tinhTrang;
		
		private string _maLoai;
		
		private string _hinhAnh;
		
		private System.Nullable<decimal> _giamGia;
		
		private System.Nullable<double> _danhGia;
		
		private EntitySet<HoaDon> _HoaDons;
		
		private EntityRef<LoaiPhong> _LoaiPhong;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntenPhongChanging(string value);
    partial void OntenPhongChanged();
    partial void OntinhTrangChanging(string value);
    partial void OntinhTrangChanged();
    partial void OnmaLoaiChanging(string value);
    partial void OnmaLoaiChanged();
    partial void OnhinhAnhChanging(string value);
    partial void OnhinhAnhChanged();
    partial void OngiamGiaChanging(System.Nullable<decimal> value);
    partial void OngiamGiaChanged();
    partial void OndanhGiaChanging(System.Nullable<double> value);
    partial void OndanhGiaChanged();
    #endregion
		
		public Phong()
		{
			this._HoaDons = new EntitySet<HoaDon>(new Action<HoaDon>(this.attach_HoaDons), new Action<HoaDon>(this.detach_HoaDons));
			this._LoaiPhong = default(EntityRef<LoaiPhong>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenPhong", DbType="VarChar(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string tenPhong
		{
			get
			{
				return this._tenPhong;
			}
			set
			{
				if ((this._tenPhong != value))
				{
					this.OntenPhongChanging(value);
					this.SendPropertyChanging();
					this._tenPhong = value;
					this.SendPropertyChanged("tenPhong");
					this.OntenPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tinhTrang", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string tinhTrang
		{
			get
			{
				return this._tinhTrang;
			}
			set
			{
				if ((this._tinhTrang != value))
				{
					this.OntinhTrangChanging(value);
					this.SendPropertyChanging();
					this._tinhTrang = value;
					this.SendPropertyChanged("tinhTrang");
					this.OntinhTrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maLoai", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string maLoai
		{
			get
			{
				return this._maLoai;
			}
			set
			{
				if ((this._maLoai != value))
				{
					if (this._LoaiPhong.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaLoaiChanging(value);
					this.SendPropertyChanging();
					this._maLoai = value;
					this.SendPropertyChanged("maLoai");
					this.OnmaLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hinhAnh", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string hinhAnh
		{
			get
			{
				return this._hinhAnh;
			}
			set
			{
				if ((this._hinhAnh != value))
				{
					this.OnhinhAnhChanging(value);
					this.SendPropertyChanging();
					this._hinhAnh = value;
					this.SendPropertyChanged("hinhAnh");
					this.OnhinhAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_giamGia", DbType="Money")]
		public System.Nullable<decimal> giamGia
		{
			get
			{
				return this._giamGia;
			}
			set
			{
				if ((this._giamGia != value))
				{
					this.OngiamGiaChanging(value);
					this.SendPropertyChanging();
					this._giamGia = value;
					this.SendPropertyChanged("giamGia");
					this.OngiamGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_danhGia", DbType="Float")]
		public System.Nullable<double> danhGia
		{
			get
			{
				return this._danhGia;
			}
			set
			{
				if ((this._danhGia != value))
				{
					this.OndanhGiaChanging(value);
					this.SendPropertyChanging();
					this._danhGia = value;
					this.SendPropertyChanged("danhGia");
					this.OndanhGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Phong_HoaDon", Storage="_HoaDons", ThisKey="tenPhong", OtherKey="tenPhong")]
		public EntitySet<HoaDon> HoaDons
		{
			get
			{
				return this._HoaDons;
			}
			set
			{
				this._HoaDons.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiPhong_Phong", Storage="_LoaiPhong", ThisKey="maLoai", OtherKey="maLoai", IsForeignKey=true)]
		public LoaiPhong LoaiPhong
		{
			get
			{
				return this._LoaiPhong.Entity;
			}
			set
			{
				LoaiPhong previousValue = this._LoaiPhong.Entity;
				if (((previousValue != value) 
							|| (this._LoaiPhong.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoaiPhong.Entity = null;
						previousValue.Phongs.Remove(this);
					}
					this._LoaiPhong.Entity = value;
					if ((value != null))
					{
						value.Phongs.Add(this);
						this._maLoai = value.maLoai;
					}
					else
					{
						this._maLoai = default(string);
					}
					this.SendPropertyChanged("LoaiPhong");
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
		
		private void attach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.Phong = this;
		}
		
		private void detach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.Phong = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhachHang")]
	public partial class KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _email;
		
		private string _tenKH;
		
		private string _gioiTinh;
		
		private string _pass;
		
		private EntitySet<HoaDon> _HoaDons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OntenKHChanging(string value);
    partial void OntenKHChanged();
    partial void OngioiTinhChanging(string value);
    partial void OngioiTinhChanged();
    partial void OnpassChanging(string value);
    partial void OnpassChanged();
    #endregion
		
		public KhachHang()
		{
			this._HoaDons = new EntitySet<HoaDon>(new Action<HoaDon>(this.attach_HoaDons), new Action<HoaDon>(this.detach_HoaDons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenKH", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string tenKH
		{
			get
			{
				return this._tenKH;
			}
			set
			{
				if ((this._tenKH != value))
				{
					this.OntenKHChanging(value);
					this.SendPropertyChanging();
					this._tenKH = value;
					this.SendPropertyChanged("tenKH");
					this.OntenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gioiTinh", DbType="NVarChar(100)")]
		public string gioiTinh
		{
			get
			{
				return this._gioiTinh;
			}
			set
			{
				if ((this._gioiTinh != value))
				{
					this.OngioiTinhChanging(value);
					this.SendPropertyChanging();
					this._gioiTinh = value;
					this.SendPropertyChanged("gioiTinh");
					this.OngioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pass", DbType="NVarChar(10)")]
		public string pass
		{
			get
			{
				return this._pass;
			}
			set
			{
				if ((this._pass != value))
				{
					this.OnpassChanging(value);
					this.SendPropertyChanging();
					this._pass = value;
					this.SendPropertyChanged("pass");
					this.OnpassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_HoaDon", Storage="_HoaDons", ThisKey="email", OtherKey="email")]
		public EntitySet<HoaDon> HoaDons
		{
			get
			{
				return this._HoaDons;
			}
			set
			{
				this._HoaDons.Assign(value);
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
		
		private void attach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = this;
		}
		
		private void detach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoaiPhong")]
	public partial class LoaiPhong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _maLoai;
		
		private string _tenLP;
		
		private System.Nullable<decimal> _giaPhong;
		
		private EntitySet<Phong> _Phongs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaLoaiChanging(string value);
    partial void OnmaLoaiChanged();
    partial void OntenLPChanging(string value);
    partial void OntenLPChanged();
    partial void OngiaPhongChanging(System.Nullable<decimal> value);
    partial void OngiaPhongChanged();
    #endregion
		
		public LoaiPhong()
		{
			this._Phongs = new EntitySet<Phong>(new Action<Phong>(this.attach_Phongs), new Action<Phong>(this.detach_Phongs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maLoai", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string maLoai
		{
			get
			{
				return this._maLoai;
			}
			set
			{
				if ((this._maLoai != value))
				{
					this.OnmaLoaiChanging(value);
					this.SendPropertyChanging();
					this._maLoai = value;
					this.SendPropertyChanged("maLoai");
					this.OnmaLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenLP", DbType="NVarChar(100)")]
		public string tenLP
		{
			get
			{
				return this._tenLP;
			}
			set
			{
				if ((this._tenLP != value))
				{
					this.OntenLPChanging(value);
					this.SendPropertyChanging();
					this._tenLP = value;
					this.SendPropertyChanged("tenLP");
					this.OntenLPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_giaPhong", DbType="Money")]
		public System.Nullable<decimal> giaPhong
		{
			get
			{
				return this._giaPhong;
			}
			set
			{
				if ((this._giaPhong != value))
				{
					this.OngiaPhongChanging(value);
					this.SendPropertyChanging();
					this._giaPhong = value;
					this.SendPropertyChanged("giaPhong");
					this.OngiaPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiPhong_Phong", Storage="_Phongs", ThisKey="maLoai", OtherKey="maLoai")]
		public EntitySet<Phong> Phongs
		{
			get
			{
				return this._Phongs;
			}
			set
			{
				this._Phongs.Assign(value);
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
		
		private void attach_Phongs(Phong entity)
		{
			this.SendPropertyChanging();
			entity.LoaiPhong = this;
		}
		
		private void detach_Phongs(Phong entity)
		{
			this.SendPropertyChanging();
			entity.LoaiPhong = null;
		}
	}
}
#pragma warning restore 1591
