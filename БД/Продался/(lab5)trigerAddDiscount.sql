use CopyCenter
go
create trigger Discount_INSERT
on Discount for insert
as
begin
	if exists (select i.client_id from Discount i)
		begin
			ROLLBACK TRAN
			print '� ����� ������� ��� ���� ���������� �����'
		end
end
