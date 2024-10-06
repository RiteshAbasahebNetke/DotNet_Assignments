begin
declare @i int 
set @i=0
while @i<10
begin
 print 'Value of i is:'+convert(varchar,@i)
 set @i =@i +1
end
end