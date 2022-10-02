/*
---1
Получить перечень и общее число пунктов приема заказов 
на печать по филиалам, по киоскам приема заказов, 
в целом по фотоцентру
*/
/*1)Все киоски и их количество*/
use CopyCenter
select * from Kiosk
select count(*) as [Количество] from Kiosk
/*2)Киоски определенного филиала и их количество*/
use CC2
declare @branchID int	/* id */
set @branchID = 2		/* филиала */
select *
from Kiosk
join Branch on Kiosk.branch_id = Branch.Branch_id
where Branch.Branch_id = @branchID
select count(*) as "Количество киосков" from Kiosk join Branch on Kiosk.branch_id = Branch.Branch_id where Branch.Branch_id = @branchID
/*3)Все филиалы и их количество*/
use CC2
select * from Branch
select count(*) as "Количество филиалов" from Branch

/*
---2
Получить перечень и общее число заказов на фотоработы по филиалам, 
киоскам приема заказов, в целом по фотоцентру, поступивших в 
течение некоторого периода времени
*/
/*1)Заказы на печать всего офиса в определенный период*/
use CopyCenter
declare @date1 date, @date2 date
set @date1 = '4.08.2021'
set @date2 = '18.08.2023'
select * from ClientPrintOrder
where ClientPrintOrder.date between @date1 and @date2
select count(*) from ClientPrintOrder where ClientPrintOrder.date between @date1 and @date2
/*2)Заказы на печать копкретного филиала в период времени*/
use CopyCenter
declare @2date1 date, @2date2 date, @branch int
set @2date1 = '4.08.2021'
set @2date2 = '18.08.2023'
set @branch = 1
select * from ClientPrintOrder
join BranchPrintOrders on BranchPrintOrders.printOrder_id = ClientPrintOrder.printOrder_id
where BranchPrintOrders.branch_id = @branch
and ClientPrintOrder.date between @2date1 and @2date2
select count(*) as [Количество] from ClientPrintOrder join BranchPrintOrders on BranchPrintOrders.printOrder_id = ClientPrintOrder.printOrder_id where BranchPrintOrders.branch_id = @branch and ClientPrintOrder.date between @2date1 and @2date2
/*3)Заказы на печать копкретного киоска в период времени*/
use CopyCenter
declare @3date1 date, @3date2 date, @kiosk int
set @3date1 = '4.08.2021'
set @3date2 = '18.08.2023'
set @kiosk = 1
select * from ClientPrintOrder
join KioskPrintOrders on KioskPrintOrders.printOrder_id = ClientPrintOrder.printOrder_id
where KioskPrintOrders.kiosk_id = @kiosk
and ClientPrintOrder.date between @3date1 and @3date2
select count(*) as [Количество] from ClientPrintOrder join KioskPrintOrders on KioskPrintOrders.printOrder_id = ClientPrintOrder.printOrder_id where KioskPrintOrders.kiosk_id = @kiosk and ClientPrintOrder.date between @3date1 and @3date2

/*
--3
Получить перечень и общее число заказов (отдельно простых и срочных) 
на отдельные виды заказа по указанному филиалу, киоску приема заказов, 
поступивших в течение некоторого периода времени
*/
/*1)Заказы на конкретную печать филиалов*/
use CopyCenter
select * from ClientPrintOrder
join BranchPrintOrders on BranchPrintOrders.printOrder_id = ClientPrintOrder.printOrder_id
where BranchPrintOrders.branch_id = 1 /*ID филиала*/
and ClientPrintOrder.date between '4.08.2021' and '18.08.2023'
and ClientPrintOrder.service_id = 4 /*ID печати*/
and ClientPrintOrder.urgency = 0/*Срочность*/
/*2)Заказы на конкретную печать киосков*/
use CopyCenter
select * from ClientPrintOrder
join KioskPrintOrders on KioskPrintOrders.printOrder_id = KioskPrintOrders.printOrder_id
where KioskPrintOrders.kiosk_id = 1 /*ID киоска*/
and ClientPrintOrder.date between '4.08.2021' and '18.08.2023'
and ClientPrintOrder.service_id = 4 /*ID печати*/
and ClientPrintOrder.urgency = 0/*Срочность*/

/*
---4
Получить сумму выручки с заказов (отдельно простых и срочных) на 
отдельные виды заказа по указанному филиалу, киоску приема заказов, 
поступивших в течение некоторого периода времени
*/
/*1)Филиал*/
use CopyCenter
select sum(ClientPrintOrder.number * Service.price) as [Выручка] from ClientPrintOrder
join Service on Service.service_id = ClientPrintOrder.service_id
join BranchPrintOrders on BranchPrintOrders.printOrder_id = ClientPrintOrder.printOrder_id
where ClientPrintOrder.service_id = 4/*ID услуги*/
and BranchPrintOrders.branch_id = 1/*ID филиала*/
and ClientPrintOrder.date between '4.08.2021' and '18.08.2023'
and ClientPrintOrder.urgency = 0/*Срочность*/
/*2)Киоск*/
use CopyCenter
select sum(ClientPrintOrder.number * Service.price) as [Выручка] from ClientPrintOrder
join Service on Service.service_id = ClientPrintOrder.service_id
join KioskPrintOrders on KioskPrintOrders.printOrder_id = ClientPrintOrder.printOrder_id
where ClientPrintOrder.service_id = 4/*ID услуги*/
and KioskPrintOrders.kiosk_id = 3/*ID киоска*/
and ClientPrintOrder.date between '4.08.2021' and '18.08.2023'
and ClientPrintOrder.urgency = 0/*Срочность*/

/*
---5
Получить количество распечатанных заказов в рамках простых 
и срочных заказов по указанному филиалу, киоску приема заказов, 
копицентру в целом за некоторый период времени
*/
/*1) Филиал*/
use CopyCenter
select count(*) as [Количество готовых заказов] from BranchPrintOrders
join ClientPrintOrder on ClientPrintOrder.printOrder_id = BranchPrintOrders.printOrder_id
where completed = 1/*Завершенность заказа*/
and date between '4.08.2021' and '18.08.2023'
and branch_id = 1/*Филиал*/
/*2) Киоск*/
use CopyCenter
select count(*) as [Количество готовых заказов] from KioskPrintOrders
join ClientPrintOrder on ClientPrintOrder.printOrder_id = KioskPrintOrders.printOrder_id
where completed = 1/*Завершенность заказа*/
and date between '4.08.2021' and '18.08.2023'
and kiosk_id = 1/*Филиал*/
/*3) Всего*/
use CopyCenter
select a.[Количество готовых заказов] + b.[Количество готовых заказов] as [Всего]
from
(
select count(*) as [Количество готовых заказов] from BranchPrintOrders
join ClientPrintOrder on ClientPrintOrder.printOrder_id = BranchPrintOrders.printOrder_id
where completed = 1/*Завершенность заказа*/
and date between '4.08.2021' and '18.08.2023'
) as a,
(
select count(*) as [Количество готовых заказов] from KioskPrintOrders
join ClientPrintOrder on ClientPrintOrder.printOrder_id = KioskPrintOrders.printOrder_id
where completed = 1/*Завершенность заказа*/
and date between '4.08.2021' and '18.08.2023'
)as b

/*
---6
Получить перечень поставщиков в целом по копицентру, поставщиков 
отдельных видов товаров.
*/
use CopyCenter
select * from Provider
join ProviderProducts on Provider.provider_id = ProviderProducts.provider_id
where product_id = 3/*Поставляемый продукт*/
/*Все*/
use CopyCenter
select * from Provider
/*
---7
Получить список клиентов в целом по копицентру, клиентов указанного 
филиала, имеющих скидки, сделавших заказы определенного объема
*/
/*1) Все клиенты*/
use CopyCenter
select * from Clients
where have_discount_card = 0 /*Есть ли скидка*/
/*2) Все клиенты сделавшие заказ опр объема*/
use CopyCenter
select * from Clients
join ClientOrder on ClientOrder.client_id = Clients.client_id
where have_discount_card = 0 /*Есть ли скидка*/
and number > 2 /*Объем заказа*/
/*3)Клиенты филиала*/
use CopyCenter
select branch_id, client_name, have_discount_card from BranchOrders
join ClientOrder on ClientOrder.order_id = BranchOrders.order_id
join Clients on Clients.client_id = ClientOrder.client_id
where branch_id = 1 /*Филиал*/
/*4)Клиенты киоска*/
use CopyCenter
select kiosk_id, client_name, have_discount_card from KioskOrders
join ClientOrder on ClientOrder.order_id = KioskOrders.order_id
join Clients on Clients.client_id = ClientOrder.client_id
where kiosk_id = 1 /*Киоск*/

/*
---8
Получить сумму выручки от реализации товаров в целом по Копицентру, 
по указанному филиалу, проданных в течение некоторого периода времени
*/
/*1) Прибыль по филиалу*/
use CopyCenter
select sum(number * price) as [Выручка]
from BranchOrders
join ClientOrder on ClientOrder.order_id = BranchOrders.order_id
join Service on ClientOrder.service_id = Service.service_id
where branch_id = 1
and date between '4.08.2021' and '18.08.2023'
/*2) Прибыль по киоску*/
use CopyCenter
select sum(number * price) as [Выручка]
from KioskOrders
join ClientOrder on ClientOrder.order_id = KioskOrders.order_id
join Service on ClientOrder.service_id = Service.service_id
where kiosk_id = 1
and date between '4.08.2021' and '18.08.2023'
/*3) Общая прибыль*/
use CopyCenter
declare @83date1 date, @83date2 date
set @83date1 = '4.08.2021'
set @83date2 = '18.08.2023'
select a.Выручка + b.Выручка as [Общая прибыль]
from (
select sum(number * price) as [Выручка]
from BranchOrders
join ClientOrder on ClientOrder.order_id = BranchOrders.order_id
join Service on ClientOrder.service_id = Service.service_id
where date between @83date1 and @83date2
) as a,
(
select sum(number * price) as [Выручка]
from KioskOrders
join ClientOrder on ClientOrder.order_id = KioskOrders.order_id
join Service on ClientOrder.service_id = Service.service_id
where date between @83date1 and @83date2
) as b

/*
---9
Получить перечень товаров и фирм, их производящих, которые пользуются 
наибольшим спросом в целом по копицентру, в указанном филиале.
*/
/*1) По всему центру*/
select top 1 product, sum(number) as [Продано]  from ClientOrder
join Service on ClientOrder.service_id = Service.service_id
join Products on Products.product_id = Service.product_id
group by product
order by [Продано] desc
/*2) По филиалу*/
select top 1 product, sum(number) as [Продано] from BranchOrders
join ClientOrder on ClientOrder.order_id = BranchOrders.order_id
join Service on Service.service_id = ClientOrder.service_id
join Products on Products.product_id = Service.product_id
where branch_id = 1 /*Филиал*/
group by product
order by [Продано] desc
/*3) Поставщики товара*/
select product, provider_name from Products
join ProviderProducts on Products.product_id = ProviderProducts.product_id
join Provider on Provider.provider_id = ProviderProducts.provider_id

/*
---10
Получить перечень реализованных товаров и объемы их реализации в целом 
по фотоцентру, по указанному филиалу, проданных в течение некоторого 
периода времени.
*/
/*1) По всему центру*/
select product, sum(number) as [Продано]  from ClientOrder
join Service on ClientOrder.service_id = Service.service_id
join Products on Products.product_id = Service.product_id
where date between '4.08.2021' and '18.08.2023'
group by product
order by [Продано] desc
/*2) По филиалу*/
select product, sum(number) as [Продано] from BranchOrders
join ClientOrder on ClientOrder.order_id = BranchOrders.order_id
join Service on Service.service_id = ClientOrder.service_id
join Products on Products.product_id = Service.product_id
where branch_id = 3 /*Филиал*/
and date between '4.08.2021' and '18.08.2023'
group by product
order by [Продано] desc
/*
---11
Получить перечень рабочих мест копицентра в целом и указанного профиля
*/
/*1) Рабочие места филиалов*/
select job_title, address, name from VacanciesBranch
join Branch on Branch.Branch_id = VacanciesBranch.branch_id
/*2) Рабочие места киосков*/
select job_title, address, name from VacanciesKiosk
join Kiosk on Kiosk.kiosk_id = VacanciesKiosk.kiosk_id
/*3) Рабочие места главного оффиса*/
select job_title, address, name from VacanciesOffice
join Office on Office.Office_id = VacanciesOffice.Office_id