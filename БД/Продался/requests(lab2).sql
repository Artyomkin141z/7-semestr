/*
---1
�������� �������� � ����� ����� ������� ������ ������� 
�� ������ �� ��������, �� ������� ������ �������, 
� ����� �� ����������
*/
/*1)��� ������ � �� ����������*/
use CC2
select *
from Kiosk
select count(*) as "���������� �������" from Kiosk
/*2)������ ������������� ������� � �� ����������*/
use CC2
declare @branchID int	/* id �*/
set @branchID = 2		/* ������� */
select *
from Kiosk
join Branch on Kiosk.branch_id = Branch.Branch_id
where Branch.Branch_id = @branchID
select count(*) as "���������� �������" from Kiosk join Branch on Kiosk.branch_id = Branch.Branch_id where Branch.Branch_id = @branchID
/*3)��� ������� � �� ����������*/
use CC2
select * from Branch
select count(*) as "���������� ��������" from Branch

/*
---2
�������� �������� � ����� ����� ������� �� ���������� �� ��������, 
������� ������ �������, � ����� �� ����������, ����������� � 
������� ���������� ������� �������
*/
/*1)������ ����� ����� � ������������ ������*/
use CC2
declare @date1 date, @date2 date
set @date1 = '13.08.2022'
set @date2 = '18.08.2022'
select * from ServiceOrder
join Service on Service.service_id = ServiceOrder.service_id

select count(*) as [���������� �������] from ServiceOrder join Service on Service.service_id = ServiceOrder.service_id where ServiceOrder.date between @date1 and @date2
/*2)������ ���������� ������� � �� ���������� � ������������ ������*/
use CC2
declare @1date1 date, @1date2 date, @1branchID int
set @1date1 = '13.08.2022'
set @1date2 = '18.08.2022'
set @1branchID = 1
select * from ServiceOrder
join BranchOrder on ServiceOrder.service_order_id = BranchOrder.service_order_id
where ServiceOrder.date between @1date1 and @1date2
and BranchOrder.branch_id = @1branchID
select count(*) as [���������� �������] from ServiceOrder join BranchOrder on ServiceOrder.service_order_id = BranchOrder.service_order_id where ServiceOrder.date between @1date1 and @1date2 and BranchOrder.branch_id = @1branchID
/*3)������ ���������� ������ � �� ���������� � ������������ ������*/
use CC2
declare @2date1 date, @2date2 date, @2kioskID int
set @2date1 = '13.08.2022'
set @2date2 = '18.08.2022'
set @2kioskID = 1
select * from ServiceOrder
join KiosOrder on ServiceOrder.service_order_id = KiosOrder.service_order_id
where ServiceOrder.date between @2date1 and @2date2
and KiosOrder.branch_id = @2kioskID
select count(*) as [���������� �������] from ServiceOrder join KiosOrder on ServiceOrder.service_order_id = KiosOrder.service_order_id where ServiceOrder.date between @2date1 and @2date2 and KiosOrder.branch_id = @2kioskID
/*
---3
�������� �������� � ����� ����� ������� (�������� ������� � �������) 
�� ��������� ���� ������ �� ���������� �������, ������ ������ �������, 
����������� � ������� ���������� ������� �������
*/

