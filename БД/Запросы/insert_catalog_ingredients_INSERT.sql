use RecipesDB
go
alter trigger catalog_ingredients_INSERT
on catalog_ingredients for insert
as
begin
	if exists (select i.ingredient_id from inserted i)
		begin
		ROLLBACK TRAN
		print 'Ингредиент уже есть'
		end
end