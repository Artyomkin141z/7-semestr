use CopyCenter
go
create function GetBranchAddresses()
	returns table
	as
		return
		(
		select address as [Адрес], name as [Название]
		from Branch
		)