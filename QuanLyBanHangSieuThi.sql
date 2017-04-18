create database QuanLyBanHangSieuThi
go

use QuanLyBanHangSieuThi
go

 -- table tblDangNhap(
--TaiKhoan char(100),
--MatKhau varchar(100),
--primary key (TaiKhoan)
--)

--create table tblHangHoa(
--MaHangHoa int,
--TenHangHoa Nvarchar(100),
--SoLuongTrongKho int,
--primary key (MaHangHoa)
--)

create table Employy(
id int IDENTITY PRIMARY KEY,
name Nvarchar(100),
phone int,
address Nvarchar(100),
)

create table Customer(
id int IDENTITY PRIMARY KEY,
name Nvarchar(100),
phone int,
address Nvarchar(100),
)

--create table tblHoaDon(
--MaHoaDon int,
--MaNhanVien int,
--MaKhachHang int,
--NgayBanHang date,
--primary key (MaHoaDon),
--foreign key(MaNhanVien) references tblNhanVien(MaNhanVien),
--foreign key(MaKhachHang) references tblKhachHang(MaKhachHang)
--)

--create table tblHoaDon_HangHoa(
--MaHoaDon int,
--MaHangHoa int,
--SoLuongHangHoaBan int,
--GiaHoaDon int,
--primary key (MaHoaDon,MaHangHoa),
--foreign key(MaHoaDon) references tblHoaDon(MaHoaDon),
--foreign key(MaHangHoa) references tblHangHoa(MaHangHoa) 
--)