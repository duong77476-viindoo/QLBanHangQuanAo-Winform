create database Imagetest
go
use Imagetest
create table Image_Test
(
	id int primary key,
	Img varbinary(max)
);

insert into Image_Test values(1,'C:\Users\Dai Duong\Desktop\Dữ liệu\Lập Trình Windows\Bài tập lớn LTWin\Vay.jpg')

select * from Image_Test
drop table Image_Test
