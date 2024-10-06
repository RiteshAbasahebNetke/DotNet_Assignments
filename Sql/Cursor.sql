begin
declare @en varchar(100)
declare @sal decimal(10,2)
declare @cur cursor
set @cur=cursor for select empname,salary from emptbl 
open @cur
fetch next from @cur into @en,@sal
while @@FETCH_STATUS=0
begin 
   print 'Emp Name:'+ @en +' Salary:'+ convert(varchar,@sal)
   fetch next from @cur into @en,@sal
end
close @cur
deallocate @cur
end
