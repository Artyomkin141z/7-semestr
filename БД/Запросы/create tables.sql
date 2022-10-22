/*create database RecipesDB*/

use RecipesDB
/*������� ������������*/
create table catalog_ingredients
(
ingredient_id int primary key identity,
ingredient varchar(50)
)
/*������� ���������*/
create table catalog_category
(
category_id int primary key identity,
category varchar(50)
)

/*������������*/
create table users
(
user_id int primary key identity,
user_name varchar(15),
user_surname varchar(20),
user_login varchar(50) not null,
user_password varchar(50) not null,
user_imgURL char(300),
user_redistrDate datetimeoffset 
)

/*�������*/
create table recipes
(
recipes_id int primary key identity,
recipes_title varchar(100),
recipes_content text,
recipes_numbers_servings int,
recipes_time int,
recipes_titleImgURL char(300) 
)
ALTER TABLE recipes ADD recipes_imgURL CHAR (300)
/*���� �� �������������*/
create table recipes_steps
(
recipes_id int foreign key references recipes(recipes_id),
recipes_step int,
recipes_content char(1500),
recipes_imgURL char(300)
)
alter table recipes_steps add id_recipes_steps int primary key identity


/*�����������*/
create table recipes_ingredients
(
recipes_id int foreign key references recipes(recipes_id),
ingredient_id int foreign key references catalog_ingredients(ingredient_id)
)
alter table recipes_ingredients add id_recipes_ingredients int primary key identity

/*����� � �������*/
create table recipes_feedback
(
recipes_id int foreign key references recipes(recipes_id),
commentator_id int foreign key references users(user_id),
recipes_points int default 0,
comment char(500),
comment_time datetimeoffset 
)
alter table recipes_feedback add id_recipes_feedback int primary key identity

/*�������������� ��������*/
create table recipes_energy_value
(
recipes_id int foreign key references recipes(recipes_id),
recipes_calories int,
recipes_proteins int,
recipes_fats int,
recipes_carbohydrates int
)
alter table recipes_energy_value add id_recipes_energy_value int primary key identity
/*���������*/
create table recipes_categories
(
recipes_id int foreign key references recipes(recipes_id),
category_id int foreign key references catalog_category(category_id)
)
alter table recipes_categories add id_recipes_categories int primary key identity
/*����� � �������*/
create table recipes_advice
(
recipes_id int foreign key references recipes(recipes_id),
advice text
)
alter table recipes_advice add id_recipes_advice int primary key identity

/*������
create table articles
(
article_id int primary key identity,
user_id int foreign key references users(user_id),
content text
)*/
/*������ � ������
create table articles_feedback
(
article_id int foreign key references articles(article_id),
commentator_id int foreign key references users(user_id),
articles_points int default 0,
comment char(500)
)*/

/*�������� � ���������*/
create table selections
(
selection_id int primary key identity,
selection_title char(100),
content text,
selection_createDate datetimeoffset 
)
/*������� � ��������*/
create table selections_recipes
(
selection_id int foreign key references selections(selection_id),
recipes_id int foreign key references recipes(recipes_id),
content text
)
alter table selections_recipes add id_selections_recipes int primary key identity
/*����� � ��������
create table selections_feedback
(
selection_id int foreign key references selections(selection_id),
commentator_id int foreign key references users(user_id),
selections_points int default 0,
comment char(500)
)*/

/*��������� �������*/
create table user_recipes
(
recipes_id int foreign key references recipes(recipes_id),
user_id int foreign key references users(user_id),
recipes_dateCreate datetimeoffset
)
alter table user_recipes add id_user_recipes int primary key identity
/*����������
create table user_subscribers
(
user_id int foreign key references users(user_id),
subscriber_id int foreign key references users(user_id)
)*/
/*��������
create table user_subscriptions
(
user_id int foreign key references users(user_id),
subscriptions_id int foreign key references users(user_id)
)*/
/*����� � ������������
create table user_feedback
(
user_id int foreign key references users(user_id),
commentator_id int foreign key references users(user_id),
user_points int default 0,
comment char(500)
)*/
/*�������� � ���������*/
create table user_recipe_bookmarks
(
user_id int foreign key references users(user_id),
recipes_id int foreign key references recipes(recipes_id),
bookmarks_createDate datetimeoffset
)
alter table user_recipe_bookmarks add id_user_recipe_bookmarks int primary key identity
/*�������� �� ��������
create table user_articles_bookmarks
(
user_id int foreign key references users(user_id),
article_id int foreign key references articles(article_id)
)*/
/*�������� � ����������*/
create table user_selections_bookmarks
(
user_id int foreign key references users(user_id),
selection_id int foreign key references selections(selection_id),
bookmarks_createDate datetimeoffset
)
alter table user_selections_bookmarks add id_user_selections_bookmarks int primary key identity

/*����� �������� �������*/
create table recipes_likes
(
recipes_likes_id int primary key identity,
recipes_id int foreign key references recipes(recipes_id),
user_id int foreign key references users(user_id),
isLike bit,
like_time datetimeoffset
)
