begin 
declare @sal decimal(10,2)
select @sal=salary from emptbl where EmpID=20012
if @sal % 2=0
begin
 print 'Salary is EVen!'
end
else
begin 
 print 'Salary is Odd!'
end
end