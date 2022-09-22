use RecipesDB
go
create procedure addUser
	@name varchar(15),
	@surname varchar(20),
	@login varchar(50),
	@password varchar(50)
as
begin
	declare @isAdd int;
	select @isAdd = count(*)
		from users
		where users.user_login = @login
	if (@isAdd > 0)
		select 'error';	
	else
		insert users values(@name, @surname, @login, @password)
		select 'done'
end