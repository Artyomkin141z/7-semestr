use RecipesDB
go
alter trigger catalog_category_INSERT
on catalog_category for insert
as
begin
	if exists (select i.category_id from inserted i)
		begin
		ROLLBACK TRAN
		print 'Каталог уже есть'
		end
end