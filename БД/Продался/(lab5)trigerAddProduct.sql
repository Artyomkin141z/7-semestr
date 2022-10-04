use CopyCenter
go
create trigger Products_INSERT
on Products for insert
as
begin
	if exists (select i.product from Products i)
		begin
			ROLLBACK TRAN
			print 'Этот продукт уже есть'
		end
end
