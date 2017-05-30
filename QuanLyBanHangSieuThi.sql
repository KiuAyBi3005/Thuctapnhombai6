create database QuanLyBanHangSieuThi
go

use QuanLyBanHangSieuThi
go

 -- table tblDangNhap(
--TaiKhoan char(100),
--MatKhau varchar(100),
--primary key (TaiKhoan)
--)

create table Goods(
id int IDENTITY PRIMARY KEY not null,
name Nvarchar(100),
price float,
amount int
)

create table Employy(
id int IDENTITY PRIMARY KEY not null,
name Nvarchar(100),
phone varchar(100),
address Nvarchar(100),
)

create table Customer(
id int IDENTITY PRIMARY KEY not null ,
name Nvarchar(100),
phone varchar(100),
address Nvarchar(100),
)

create table Bill(
id int IDENTITY PRIMARY KEY not null,
idCustomer int not null,
billingDate date,
foreign key(idCustomer) references dbo.Customer(id)
)

create table BillInfo(
id int IDENTITY PRIMARY KEY not null,
idBill int,
idGoods int,
count int not null,
foreign key(idBill) references Bill(id),
foreign key(idGoods) references Goods(id), 
)