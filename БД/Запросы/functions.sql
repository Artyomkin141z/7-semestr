use RecipesDB

select dbo.getNumberRecipesWithIngredient('��������� ����') as '���������� ��������' 

select * from dbo.getUserRecipes(1)

exec dbo.addUser '����', '�����������', 'vinogradova', '1111'



