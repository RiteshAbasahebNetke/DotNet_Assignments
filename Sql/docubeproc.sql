Create proc doCube(@n int)
as
begin 
  declare @r int 
  set @r=@n*@n*@n
  print 'Cube is:'+ convert(varchar,@r)
end
