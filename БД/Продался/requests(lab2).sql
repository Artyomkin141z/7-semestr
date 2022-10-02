/*
---1
ѕолучить перечень и общее число пунктов приема заказов 
на печать по филиалам, по киоскам приема заказов, 
в целом по фотоцентру
*/
/*1)¬се киоски и их количество*/
use CC2
select *
from Kiosk
select count(*) as " оличество киосков" from Kiosk
/*2) иоски определенного филиала и их количество*/
use CC2
declare @branchID int	/* id а*/
set @branchID = 2		/* филиала */
select *
from Kiosk
join Branch on Kiosk.branch_id = Branch.Branch_id
where Branch.Branch_id = @branchID
select count(*) as " оличество киосков" from Kiosk join Branch on Kiosk.branch_id = Branch.Branch_id where Branch.Branch_id = @branchID
/*3)¬се филиалы и их количество*/
use CC2
select * from Branch
select count(*) as " оличество филиалов" from Branch

/*
---2
ѕолучить перечень и общее число заказов на фотоработы по филиалам, 
киоскам приема заказов, в целом по фотоцентру, поступивших в 
течение некоторого периода времени
*/
/*1)«аказы всего офиса в определенный период*/
use CC2
declare @date1 date, @date2 date
set @date1 = '13.08.2022'
set @date2 = '18.08.2022'
select * from ServiceOrder
join Service on Service.service_id = ServiceOrder.service_id

select count(*) as [ оличество заказов] from ServiceOrder join Service on Service.service_id = ServiceOrder.service_id where ServiceOrder.date between @date1 and @date2
/*2)«аказы отдельного филиала и их количество в определенный период*/
use CC2
declare @1date1 date, @1date2 date, @1branchID int
set @1date1 = '13.08.2022'
set @1date2 = '18.08.2022'
set @1branchID = 1
select * from ServiceOrder
join BranchOrder on ServiceOrder.service_order_id = BranchOrder.service_order_id
where ServiceOrder.date between @1date1 and @1date2
and BranchOrder.branch_id = @1branchID
select count(*) as [ оличество заказов] from ServiceOrder join BranchOrder on ServiceOrder.service_order_id = BranchOrder.service_order_id where ServiceOrder.date between @1date1 and @1date2 and BranchOrder.branch_id = @1branchID
/*3)«аказы отдельного киоска и их количество в определенный период*/
use CC2
declare @2date1 date, @2date2 date, @2kioskID int
set @2date1 = '13.08.2022'
set @2date2 = '18.08.2022'
set @2kioskID = 1
select * from ServiceOrder
join KiosOrder on ServiceOrder.service_order_id = KiosOrder.service_order_id
where ServiceOrder.date between @2date1 and @2date2
and KiosOrder.branch_id = @2kioskID
select count(*) as [ оличество заказов] from ServiceOrder join KiosOrder on ServiceOrder.service_order_id = KiosOrder.service_order_id where ServiceOrder.date between @2date1 and @2date2 and KiosOrder.branch_id = @2kioskID
/*
---3
ѕолучить перечень и общее число заказов (отдельно простых и срочных) 
на отдельные виды заказа по указанному филиалу, киоску приема заказов, 
поступивших в течение некоторого периода времени
*/

