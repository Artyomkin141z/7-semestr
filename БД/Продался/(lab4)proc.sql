use CopyCenter
go
create procedure addClientOrder
	@clientID int,
	@serviceID int,
	@number int
as
begin
	declare @isAdd int;
	select @isAdd = count(*)
		from Clients
		where Clients.client_id = @clientID
	if (@isAdd = 0)
		begin
			insert Clients values (2, '����� ����������', 0)
			declare @id int
			SELECT @id = @@IDENTITY
			insert ClientOrder values (@id, @serviceID, @number, getdate())
			print '������� ����� ������ ����������'
		end
	else
		begin
			insert ClientOrder values (@clientID, @serviceID, @number, getdate())
			print '���������� ������� �����' 
		end
end
