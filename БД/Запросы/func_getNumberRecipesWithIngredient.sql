/*Вернуть количество рецептов с заданным ингредиентом*/
use RecipesDB
go
alter function getNumberRecipesWithIngredient(@ingredient varchar(50))
	returns int 
		begin
			declare @number int
				select @number = count(*)
				from recipes_ingredients, catalog_ingredients
				where catalog_ingredients.ingredient = @ingredient
					and catalog_ingredients.ingredient_id = recipes_ingredients.ingredient_id
			return @number
		end

