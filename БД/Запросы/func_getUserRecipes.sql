/*������� ������� ������������*/
use RecipesDB
go
alter function getUserRecipes(@id int)
	returns table
	as
		return
		(
		select '���' = users.user_name + ' ' + users.user_surname, recipes.recipes_title as '�������'
		from users, recipes, user_recipes
		where users.user_id = @id
			and user_recipes.user_id = @id
			and user_recipes.recipes_id = recipes.recipes_id
		)