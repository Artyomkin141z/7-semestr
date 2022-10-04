use CopyCenter
go
create function GetBranchRevenue
	(@branchID int, @date1 date, @date2 date)
returns numeric(10,2)
	begin
		declare @revenue numeric(10, 2)
		select @revenue = sum(number * price)
		from BranchOrders
		join ClientOrder on ClientOrder.order_id = BranchOrders.order_id
		join Service on ClientOrder.service_id = Service.service_id
		where branch_id = 1
			and date between @date1 and @date2
		return @revenue
	end