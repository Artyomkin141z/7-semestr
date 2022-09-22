use RecipesDB

select dbo.getNumberRecipesWithIngredient('Пшеничная мука') as 'Количество рецептов' 

select * from dbo.getUserRecipes(1)

exec dbo.addUser 'Катя', 'Виноградова', 'vinogradova', '1111'



