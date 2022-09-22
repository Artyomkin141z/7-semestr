use RecipesDB

select dbo.getNumberRecipesWithIngredient('Пшеничная мука') as 'Количество рецептов' 

select * from dbo.getUserRecipes(1)