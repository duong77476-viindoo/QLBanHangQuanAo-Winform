create database TaiKhoan
go
use TaiKhoan

create table Tai_Khoan
(
	taikhoan varchar(50) primary key,
	matkhau varchar(50),
	quyen int,
	trangthai int
);

insert into Tai_Khoan values('Duong','123456',null,null)