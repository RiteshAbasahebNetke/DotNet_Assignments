--create table Customer(CustomerID bigint,CustomerName varchar(50), 
--Address Varchar(max),EmailID varchar(100),MobileNo varchar(10),
--CreditLimit decimal(10,2))

insert into Customer values(1,'Ganesh','Nigdi Pune','Ganesh@gmail.com',
'1234567890',12000)

insert into Customer values(2,'Sunil','Akurdi Pune','Sunil@hotmail.com',
'5675756756',15000)

insert into Customer values(3,'Akash','Chichwad Pune','Akash@hotmail.com',
'6678686868',18000)
insert into Customer values(4,'Manish','Akurdi Pune','Manish@gmail.com',
'686786867',20000)

insert into Customer values(4,'Sudhir','Akurdi Pune','Manish@gmail.com',
'686786867',26000)
insert into Customer values(5,'Sumit','Akurdi Pune','Manish@gmail.com',
'6867868699',29000)


insert into customer(CustomerID,CustomerName,MobileNo,CreditLimit)
values(5,'Ajit','5675756',45000)

select * from Customer

select customername,creditlimit from customer

select * from customer where creditlimit>18000
select * from customer where creditlimit>=18000 and creditlimit<=20000
select * from customer where creditlimit between 18000 and 20000
select * from customer where customerid=5

select * from customer where customername like 's%'
select * from customer where customername like '_u%'
select * from customer where customername like '%s_'

select * from Customer where customerid=2 or customerid=4 or customerid=5
select * from customer where customerid in(2,4,5)
select * from customer where customerid not in (2,4,5)






