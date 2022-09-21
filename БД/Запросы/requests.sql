use RecipesDB

/*Получить все ингредиенты*/
select * from catalog_ingredients

/*Получить все категории*/
select * from catalog_category

/*Получить список пользователей*/
select * from users

/*Получить список рецептов пользователя*/
select users.user_name, recipes.recipes_title 
from user_recipes, users, recipes
where users.user_id = 1
and user_recipes.recipes_id = recipes.recipes_id

/*Получить все рецепты*/
select * from recipes

/*Получить шаги приготвления рецепта*/
select recipes.recipes_title, recipes_steps.recipes_step, recipes_steps.recipes_content
from recipes, recipes_steps
where recipes_steps.recipes_id = 1 and recipes.recipes_id = 1

/*Получить ингредиенты рецепта*/
select recipes.recipes_title, catalog_ingredients.ingredient
from recipes, recipes_ingredients, catalog_ingredients
where recipes_ingredients.recipes_id = 2 
and recipes.recipes_id = 2
and recipes_ingredients.ingredient_id = catalog_ingredients.ingredient_id

/*Получить категории рецепта*/
select recipes.recipes_title, catalog_category.category
from recipes, catalog_category, recipes_categories
where recipes_categories.recipes_id = 1
and recipes.recipes_id = 1
and recipes_categories.category_id = catalog_category.category_id

/*Получить энергетическую ценность рецепта*/
select * from recipes_energy_value
where recipes_energy_value.recipes_id = 1

/*Получить совет к рецепту*/
select recipes.recipes_title, recipes_advice.advice
from recipes_advice, recipes
where recipes.recipes_id = 1
and recipes_advice.recipes_id = 1

/*Получить все подборки*/
select * from selections

/*Получить подборки пользователя*/
select users.user_name, selections.selection_title
from users, selections, user_selections_bookmarks
where users.user_id = 1
and user_selections_bookmarks.user_id = 1
and selections.selection_id = user_selections_bookmarks.selection_id

/*Получить подборку*/
select selections.selection_title, recipes.recipes_title
from selections, selections_recipes, recipes
where selections_recipes.selection_id = 1
and selections_recipes.recipes_id = recipes.recipes_id