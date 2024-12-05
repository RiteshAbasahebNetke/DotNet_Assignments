Create table Emp(EmpID bigint primary key,EmpName varchar(30),Address varchar(30),
Salary decimal(30,2), DeptID bigint references Dept(DeptID))

insert into Emp values(1,'Rajesh','Nigdi',34000,1)

insert into Emp values(2,'Sham','Akurdi',45000,3)

insert into Emp values(3,'Raj','Pimpri',23000,2)

insert into Emp values(4,'Nilesh','Chinchwad',6000,4)

insert into Emp values(5,'Rosy','Khradi',34000,2)

insert into Emp(EmpID,EmpName,Address,Salary,DeptID)values(6,'Smita','Hadapsar',56000,1)

insert into Emp values(7,'Raviraj','Wagholi',34000,4)

insert into Emp values(8,'Shruti','Baner',45000,3)

select top 2 * from Emp

select * from Emp where Salary>50000

select * from Emp where EmpName like 'S%'

select * from Emp where Salary>40000 and Salary<=60000

select * from Emp where EmpName in('Akurdi','Baner','Pimpri')

select Address, sum(Salary) from Emp group by Address

select * from Emp where DeptID=(select DeptID from Dept where DeptName='Akurdi')

select * from Emp where DeptID in (select DeptID from Dept where DeptName in('Pimpri','Baner'))

select * from Emp