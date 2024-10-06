begin 
declare @r int 
set @r=dbo.addnum(34,45)
print 'Result is:'+ convert(varchar,@r)
end
