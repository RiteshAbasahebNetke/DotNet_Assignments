SELECT TOP (1000) [EmpID]
      ,[EmpName]
      ,[address]
      ,[DeptName]
      ,[Salary]
  FROM [DB22].[dbo].[Emptbl]

  insert into EmpTbl values(1,'Sujit','Pune','Sales',45000)

  insert into EmpTbl(EmpID,EmpName,address,DeptName,Salary) values(2,'Manish','Mumbai','Purchase',30000)

  insert into EmpTbl values(3,'Rajesh','Delhi','Computer',34000)

  insert into EmpTbl(EmpID,EmpName,address,DeptName,Salary) values (3,'Ravi','Mumbai','Sales',67000)

  insert into EmpTbl values(5,'Sham','Pune','Computer',56000)

  insert into Emptbl(EmpID,EmpName,address,DeptName,Salary) values (6,'Niraj','Mumbai','Purchase',45000)

  select top 3* from Emptbl

  select EmpName,DeptName from Emptbl

  select * from Emptbl where DeptName='Sales'

  select * from EMpTBl where Salary>=60000

  select * from Emptbl where salary between 50000 and 70000

  select * from emptbl where empname like 'R%'

  select * from emptbl where empname in ('Pune','Delhi')

  select * from emptbl order by salary

  select * from emptbl  order by empname

  select * from EmpTbl