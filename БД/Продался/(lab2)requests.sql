/*
---1
�������� �������� � ����� ����� ������� ������ ������� 
�� ������ �� ��������, �� ������� ������ �������, 
� ����� �� ����������
*/
/*1)��� ������ � �� ����������*/
use CopyCenter
select * from Kiosk
select count(*) as [����������] from Kiosk
/*2)������ ������������� ������� � �� ����������*/
use CC2
declare @branchID int	/* id */
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
/*1)������ �� ������ ����� ����� � ������������ ������*/
use CopyCenter
declare @date1 date, @date2 date
set @date1 = '4.08.2021'
set @date2 = '18.08.2023'
select * from ClientPrintOrder
where ClientPrintOrder.date between @date1 and @date2
select count(*) from ClientPrintOrder where ClientPrintOrder.date between @date1 and @date2
/*2)������ �� ������ ����������� ������� � ������ �������*/
use CopyCenter
declare @2date1 date, @2date2 date, @branch int
set @2date1 = '4.08.2021'
set @2date2 = '18.08.2023'
set @branch = 1
select * from ClientPrintOrder
join BranchPrintOrders on BranchPrintOrders.printOrder_id = ClientPrintOrder.printOrder_id
where BranchPrintOrders.branch_id = @branch
and ClientPrintOrder.date between @2date1 and @2date2
select count(*) as [����������] from ClientPrintOrder join BranchPrintOrders on BranchPrintOrders.printOrder_id = ClientPrintOrder.printOrder_id where BranchPrintOrders.branch_id = @branch and ClientPrintOrder.date between @2date1 and @2date2
/*3)������ �� ������ ����������� ������ � ������ �������*/
use CopyCenter
declare @3date1 date, @3date2 date, @kiosk int
set @3date1 = '4.08.2021'
set @3date2 = '18.08.2023'
set @kiosk = 1
select * from ClientPrintOrder
join KioskPrintOrders on KioskPrintOrders.printOrder_id = ClientPrintOrder.printOrder_id
where KioskPrintOrders.kiosk_id = @kiosk
and ClientPrintOrder.date between @3date1 and @3date2
select count(*) as [����������] from ClientPrintOrder join KioskPrintOrders on KioskPrintOrders.printOrder_id = ClientPrintOrder.printOrder_id where KioskPrintOrders.kiosk_id = @kiosk and ClientPrintOrder.date between @3date1 and @3date2

/*
--3
�������� �������� � ����� ����� ������� (�������� ������� � �������) 
�� ��������� ���� ������ �� ���������� �������, ������ ������ �������, 
����������� � ������� ���������� ������� �������
*/
/*1)������ �� ���������� ������ ��������*/
use CopyCenter
select * from ClientPrintOrder
join BranchPrintOrders on BranchPrintOrders.printOrder_id = ClientPrintOrder.printOrder_id
where BranchPrintOrders.branch_id = 1 /*ID �������*/
and ClientPrintOrder.date between '4.08.2021' and '18.08.2023'
and ClientPrintOrder.service_id = 4 /*ID ������*/
and ClientPrintOrder.urgency = 0/*���������*/
/*2)������ �� ���������� ������ �������*/
use CopyCenter
select * from ClientPrintOrder
join KioskPrintOrders on KioskPrintOrders.printOrder_id = KioskPrintOrders.printOrder_id
where KioskPrintOrders.kiosk_id = 1 /*ID ������*/
and ClientPrintOrder.date between '4.08.2021' and '18.08.2023'
and ClientPrintOrder.service_id = 4 /*ID ������*/
and ClientPrintOrder.urgency = 0/*���������*/

/*
---4
�������� ����� ������� � ������� (�������� ������� � �������) �� 
��������� ���� ������ �� ���������� �������, ������ ������ �������, 
����������� � ������� ���������� ������� �������
*/
/*1)������*/
use CopyCenter
select sum(ClientPrintOrder.number * Service.price) as [�������] from ClientPrintOrder
join Service on Service.service_id = ClientPrintOrder.service_id
join BranchPrintOrders on BranchPrintOrders.printOrder_id = ClientPrintOrder.printOrder_id
where ClientPrintOrder.service_id = 4/*ID ������*/
and BranchPrintOrders.branch_id = 1/*ID �������*/
and ClientPrintOrder.date between '4.08.2021' and '18.08.2023'
and ClientPrintOrder.urgency = 0/*���������*/
/*2)�����*/
use CopyCenter
select sum(ClientPrintOrder.number * Service.price) as [�������] from ClientPrintOrder
join Service on Service.service_id = ClientPrintOrder.service_id
join KioskPrintOrders on KioskPrintOrders.printOrder_id = ClientPrintOrder.printOrder_id
where ClientPrintOrder.service_id = 4/*ID ������*/
and KioskPrintOrders.kiosk_id = 3/*ID ������*/
and ClientPrintOrder.date between '4.08.2021' and '18.08.2023'
and ClientPrintOrder.urgency = 0/*���������*/

/*
---5
�������� ���������� ������������� ������� � ������ ������� 
� ������� ������� �� ���������� �������, ������ ������ �������, 
���������� � ����� �� ��������� ������ �������
*/
/*1) ������*/
use CopyCenter
select count(*) as [���������� ������� �������] from BranchPrintOrders
join ClientPrintOrder on ClientPrintOrder.printOrder_id = BranchPrintOrders.printOrder_id
where completed = 1/*������������� ������*/
and date between '4.08.2021' and '18.08.2023'
and branch_id = 1/*������*/
/*2) �����*/
use CopyCenter
select count(*) as [���������� ������� �������] from KioskPrintOrders
join ClientPrintOrder on ClientPrintOrder.printOrder_id = KioskPrintOrders.printOrder_id
where completed = 1/*������������� ������*/
and date between '4.08.2021' and '18.08.2023'
and kiosk_id = 1/*������*/
/*3) �����*/
use CopyCenter
select a.[���������� ������� �������] + b.[���������� ������� �������] as [�����]
from
(
select count(*) as [���������� ������� �������] from BranchPrintOrders
join ClientPrintOrder on ClientPrintOrder.printOrder_id = BranchPrintOrders.printOrder_id
where completed = 1/*������������� ������*/
and date between '4.08.2021' and '18.08.2023'
) as a,
(
select count(*) as [���������� ������� �������] from KioskPrintOrders
join ClientPrintOrder on ClientPrintOrder.printOrder_id = KioskPrintOrders.printOrder_id
where completed = 1/*������������� ������*/
and date between '4.08.2021' and '18.08.2023'
)as b

/*
---6
�������� �������� ����������� � ����� �� ����������, ����������� 
��������� ����� �������.
*/
use CopyCenter
select * from Provider
join ProviderProducts on Provider.provider_id = ProviderProducts.provider_id
where product_id = 3/*������������ �������*/
/*���*/
use CopyCenter
select * from Provider
/*
---7
�������� ������ �������� � ����� �� ����������, �������� ���������� 
�������, ������� ������, ��������� ������ ������������� ������
*/
/*1) ��� �������*/
use CopyCenter
select * from Clients
where have_discount_card = 0 /*���� �� ������*/
/*2) ��� ������� ��������� ����� ��� ������*/
use CopyCenter
select * from Clients
join ClientOrder on ClientOrder.client_id = Clients.client_id
where have_discount_card = 0 /*���� �� ������*/
and number > 2 /*����� ������*/
/*3)������� �������*/
use CopyCenter
select branch_id, client_name, have_discount_card from BranchOrders
join ClientOrder on ClientOrder.order_id = BranchOrders.order_id
join Clients on Clients.client_id = ClientOrder.client_id
where branch_id = 1 /*������*/
/*4)������� ������*/
use CopyCenter
select kiosk_id, client_name, have_discount_card from KioskOrders
join ClientOrder on ClientOrder.order_id = KioskOrders.order_id
join Clients on Clients.client_id = ClientOrder.client_id
where kiosk_id = 1 /*�����*/

/*
---8
�������� ����� ������� �� ���������� ������� � ����� �� ����������, 
�� ���������� �������, ��������� � ������� ���������� ������� �������
*/
/*1) ������� �� �������*/
use CopyCenter
select sum(number * price) as [�������]
from BranchOrders
join ClientOrder on ClientOrder.order_id = BranchOrders.order_id
join Service on ClientOrder.service_id = Service.service_id
where branch_id = 1
and date between '4.08.2021' and '18.08.2023'
/*2) ������� �� ������*/
use CopyCenter
select sum(number * price) as [�������]
from KioskOrders
join ClientOrder on ClientOrder.order_id = KioskOrders.order_id
join Service on ClientOrder.service_id = Service.service_id
where kiosk_id = 1
and date between '4.08.2021' and '18.08.2023'
/*3) ����� �������*/
use CopyCenter
declare @83date1 date, @83date2 date
set @83date1 = '4.08.2021'
set @83date2 = '18.08.2023'
select a.������� + b.������� as [����� �������]
from (
select sum(number * price) as [�������]
from BranchOrders
join ClientOrder on ClientOrder.order_id = BranchOrders.order_id
join Service on ClientOrder.service_id = Service.service_id
where date between @83date1 and @83date2
) as a,
(
select sum(number * price) as [�������]
from KioskOrders
join ClientOrder on ClientOrder.order_id = KioskOrders.order_id
join Service on ClientOrder.service_id = Service.service_id
where date between @83date1 and @83date2
) as b

/*
---9
�������� �������� ������� � ����, �� ������������, ������� ���������� 
���������� ������� � ����� �� ����������, � ��������� �������.
*/
/*1) �� ����� ������*/
select top 1 product, sum(number) as [�������]  from ClientOrder
join Service on ClientOrder.service_id = Service.service_id
join Products on Products.product_id = Service.product_id
group by product
order by [�������] desc
/*2) �� �������*/
select top 1 product, sum(number) as [�������] from BranchOrders
join ClientOrder on ClientOrder.order_id = BranchOrders.order_id
join Service on Service.service_id = ClientOrder.service_id
join Products on Products.product_id = Service.product_id
where branch_id = 1 /*������*/
group by product
order by [�������] desc
/*3) ���������� ������*/
select product, provider_name from Products
join ProviderProducts on Products.product_id = ProviderProducts.product_id
join Provider on Provider.provider_id = ProviderProducts.provider_id

/*
---10
�������� �������� ������������� ������� � ������ �� ���������� � ����� 
�� ����������, �� ���������� �������, ��������� � ������� ���������� 
������� �������.
*/
/*1) �� ����� ������*/
select product, sum(number) as [�������]  from ClientOrder
join Service on ClientOrder.service_id = Service.service_id
join Products on Products.product_id = Service.product_id
where date between '4.08.2021' and '18.08.2023'
group by product
order by [�������] desc
/*2) �� �������*/
select product, sum(number) as [�������] from BranchOrders
join ClientOrder on ClientOrder.order_id = BranchOrders.order_id
join Service on Service.service_id = ClientOrder.service_id
join Products on Products.product_id = Service.product_id
where branch_id = 3 /*������*/
and date between '4.08.2021' and '18.08.2023'
group by product
order by [�������] desc
/*
---11
�������� �������� ������� ���� ���������� � ����� � ���������� �������
*/
/*1) ������� ����� ��������*/
select job_title, address, name from VacanciesBranch
join Branch on Branch.Branch_id = VacanciesBranch.branch_id
/*2) ������� ����� �������*/
select job_title, address, name from VacanciesKiosk
join Kiosk on Kiosk.kiosk_id = VacanciesKiosk.kiosk_id
/*3) ������� ����� �������� ������*/
select job_title, address, name from VacanciesOffice
join Office on Office.Office_id = VacanciesOffice.Office_id