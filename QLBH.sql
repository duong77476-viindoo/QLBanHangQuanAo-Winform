create database QLBanHang
go
use QLBanHang
go
create table LoaiHang
(
	maloaihang varchar(20) not null,
	tenloaihang nvarchar(50)not null,
	constraint PK_LoaiHang primary key(maloaihang)
)
create table NhaCungCap
(
	mancc varchar(20) not null,
	tenncc nvarchar(50) not null,
	tengiaodich nvarchar(50),
	diachi nvarchar(100),
	sdt varchar(15),
	fax nvarchar(15),
	email nvarchar(30),
	constraint PK_NCC primary key(mancc)
)
create table NhanVien
(
	manv varchar(20) not null,
	ho nvarchar(7) not null,
	ten nvarchar(30) not null,
	ngaysinh date,
	ngaylamviec date,
	diachi nvarchar(100),
	sdt varchar(15),
	luongcoban float,
	phucap float,
	constraint PK_Nhanvien primary key(manv)
)
create table KhachHang
(
	makh varchar(20) not null,
	tenkh nvarchar(50),
	diachi nvarchar(100),
	sdt varchar(15),
	email nvarchar(50),
	gioitinh bit,
	constraint PK_KhachHang primary key(makh)
)
create table MatHang
(
	mahang varchar(20) not null,
	tenhang nvarchar(100) not null,
	chatlieu nvarchar(50),
	mausac nvarchar(10),
	size varchar(3),
	mancc varchar(20),
	soluong int,
	dongia float,
	donvitinh nvarchar(10),
	maloaihang varchar(20),
	img image,
	constraint PK_MatHang primary key(mahang),
	constraint FK_MatHang_NhaCungCap foreign key(mancc) references NhaCungCap(mancc),
	constraint FK_MatHang_LoaiHang foreign key(maloaihang) references LoaiHang(maloaihang)
)
create table DonDatHang
(
	sohoadon varchar(10),
	makh varchar(20),
	manv varchar(20),
	ngaydathang date,
	ngaygiaohang date,
	ngaychuyenhang date,
	noigiaohang nvarchar(100),
	constraint PK_DonDatHang primary key(sohoadon),
	constraint FK_DonDatHang_KhachHang foreign key(makh) references KhachHang(makh),
	constraint FK_DonDatHang_NhanVien foreign key(manv) references NhanVien(manv)
)
create table ChiTietDatHang
(
	sohoadon varchar(10),
	mahang varchar(20),
	giaban float,
	soluong int,
	mucgiamgia nvarchar(50),
	primary key(sohoadon,mahang),
	constraint FK_ChiTietDatHang_DonDatHang foreign key(sohoadon) references DonDatHang(sohoadon),
	constraint FK_ChiTietDatHang_MatHang foreign key(mahang) references MatHang(mahang)
)

create table Tai_Khoan
(
	taikhoan varchar(50) primary key,
	matkhau varchar(50),
	quyen int,
	trangthai int
);

create table size
(
	id int identity(1,1) primary key,
	tensize nvarchar(20)
);
insert into size values('S')
insert into size values('M')
insert into size values('L')
insert into size values('XL')
insert into size values('XXL')
insert into size values('XXXL')
insert into size values('XXXXL')
insert into Tai_Khoan values('Duong','123456',null,null)

insert into LoaiHang values('LH01',N'Váy')
insert into LoaiHang values('LH02',N'Áo thun')
insert into LoaiHang values('LH03',N'Chân váy')
insert into LoaiHang values('LH04',N'Áo len')

insert into NhaCungCap values('NCC01',N'Dior','','','','','')
insert into NhaCungCap values('NCC02',N'Channel','','','','','')
insert into NhaCungCap values('NCC03',N'Việt Nam','','','','','')

insert into NhanVien values('NV01',N'Nguyễn',N'Đại Dương','2000-09-27',null,null,null,null,null)
insert into NhanVien values('NV02',N'Phạm',N'Thu Thảo','2000-10-25',null,null,null,null,null)
insert into NhanVien values('NV03',N'Đào',N'Mạnh Thái','2000-11-16',null,null,null,null,null)


drop table KhachHang
drop table DonDatHang
drop table ChiTietDatHang