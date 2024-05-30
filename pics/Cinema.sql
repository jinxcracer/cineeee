create database Cinema

use Cinema;

create table tbl_Cinema (
	ORDER_ID INT PRIMARY KEY,
	CUSTOMER_ID INT,
	QUANTITY INT,
	PRICE INT,
);

create table tbl_Film (
	FILM_ID INT PRIMARY KEY,
	FILM_NAME VARCHAR(50),
	FILM_PRICE INT,
	QUANTY INT,

);

create table tbl_Customer(
	CUSTOMER_ID INT PRIMARY KEY,
	ADDRESS_ID INT, 
	CUSTOMER_PHONE INT,
	CUSTOMER_EMAIL VARCHAR(50),

);

create table tbl_address(
	ADDRESS_ID INT PRIMARY KEY,
	CUSTOMER_ID INT,
	REGION VARCHAR (50),
	PROVINCE VARCHAR (50),
	MUNICIPALITY VARCHAR (50),
	BARANGAY VARCHAR (50),
	STREET VARCHAR(50),

);

select * from tbl_Cinema
select * from tbl_Customer
select * from tbl_Film
select * from tbl_address

insert into tbl_Cinema (ORDER_ID, CUSTOMER_ID, QUANTITY, PRICE) values (01,01,2,2000)
insert into tbl_Customer(CUSTOMER_ID,CUSTOMER_EMAIL, CUSTOMER_PHONE) values (01,'jolohorca@gmail.com',09123456789)
