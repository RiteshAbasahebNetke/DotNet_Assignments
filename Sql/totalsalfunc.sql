create function GetTotalSal(@dname varchar(40))
returns decimal(18,2)
as 
begin 
declare @total decimal(10,2)
select @total=sum(salary) from emptbl where 
deptid in (select deptid from DeptTbl 
where deptname=@dname)
return @total
end