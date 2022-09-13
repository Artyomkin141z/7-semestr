create database RecipesDB;

create table users
(
user_id int primary key identity,
user_name varchar(15),
user_surname varchar(20),
user_login varchar(50) not null,
user_password varchar(50) not null
)
create table recipes
(
recipes_id int primary key identity,
recipes_title varchar(100)
)
create table user_recipes
(
recipes_id int foreign key references recipes(recipes_id),
user_id int foreign key references users(user_id),
)
create table recipes_steps
(
recipes_id int foreign key references recipes(recipes_id),
recipes_step int,
recipes_content char(500)
)
create table recipes_ingredients
(
recipes_id int foreign key references recipes(recipes_id),
recipes_ingredient varchar(20)
)
create table recipes_feedback
(
recipes_id int foreign key references recipes(recipes_id),
user_id int foreign key references users(user_id),
recipes_points int default 10,
comment char(500)
)
create table user_subscribers
(
user_id int foreign key references users(user_id),
subscriber_id int foreign key references users(user_id)
)
create table user_subscriptions
(
user_id int foreign key references users(user_id),
subscriptions_id int foreign key references users(user_id)
)
create table user_feedback
(
user_id int foreign key references users(user_id),

)