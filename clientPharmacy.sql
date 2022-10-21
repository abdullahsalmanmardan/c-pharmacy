create database pharmacyManagment


create table users
(
Uid int identity(1,1) primary key not null,
username nvarchar(100) NOT Null UNIQUE, 
password nvarchar(100) NOT Null,
email nvarchar(100)NOT Null UNIQUE,
name nvarchar(100)NOT Null,
role nvarchar(50),
)

insert into users Values('admin','123','admin@gmail.com','admin','administrator')

create table medicine
(
medid int identity(1,1) primary key not null,
medname nvarchar(100) NOT Null UNIQUE, 
medshelfno int NOT Null,
price  int NOT Null,
quantity int NOT Null,
mdate varchar(50) not null,
edate varchar(50) not null,
)


