use CopyCenter
go
create function GetBranchAddresses()
	returns table
	as
		return
		(
		select address as [�����], name as [��������]
		from Branch
		)