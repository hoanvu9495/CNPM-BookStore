create database Book_Store
use Book_Store
go

create table dbo_NXB(
ID_nxb int primary key,
Ten_nxb nvarchar(50),
Diachi_nxb nvarchar(MAX),
Sdt_nxb char(13),
Fax_nxb char(20)
)

create table dbo_CHUDE(
ID_chude int primary key,
Ten_chude nvarchar(50)
)

create table dbo_SACH(
ID_sach int primary key,
Ten_sach nvarchar(50),
Giaban_sach int,
Gianhap_sach int,
Mota_sach nvarchar(MAX),
ID_chude int,
ID_nxb int,
foreign key(ID_chude) references dbo_CHUDE,
foreign key(ID_nxb) references dbo_NXB,
)

create table dbo_TACGIA(
ID_tacgia int primary key,
Ten_tacgia nvarchar(50),
Diachi_tacgia nvarchar(50),
Sdt_tacgia char(13)
)

create table dbo_VIETSACH(
ID_sach int references dbo_SACH,
ID_tacgia int references dbo_TACGIA,
Ngayviet datetime,
primary key(ID_sach,ID_tacgia)
)

create table dbo_DATHANG(
ID_dh int primary key,
ID_sach int references dbo_SACH,
Soluong int,
Thanhtien int
)

create table dbo_KHACHHANG(
ID_kh int primary key,
Ten_kh nvarchar(50),
Sdt_kh char(13),
Diachi_kh nvarchar(50),
)

create table dbo_HOADON(
ID_dh int references dbo_DATHANG,
ID_kh int references dbo_KHACHHANG,
Ngaydh datetime,
Trigia int,
Ngaygiaohang datetime
)

create table dbo_PHANQUYEN(
ID_quyen int primary key,
Ten_quyen nvarchar(50)
)

create table dbo_NHANVIEN(
ID_nv int primary key,
Ten_nv nvarchar(50),
Ngaysinh_nv datetime,
Sdt_nv char(13),
Tendangnhap_nv nvarchar(20),
Matkhau_nv char(10),
ID_quyen int references dbo_PHANQUYEN
)

