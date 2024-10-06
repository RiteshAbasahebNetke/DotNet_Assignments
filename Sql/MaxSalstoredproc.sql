create proc GetMaxSal(@dname varchar(100))
as 
begin 
select max(salary) from emptbl where
deptid=(select deptid from DeptTbl where DeptName=@dname)
end