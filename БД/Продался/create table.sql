/*create database CopyCenter*/

use CopyCenter
CREATE TABLE Office
(Office_id int NOT NULL IDENTITY primary key,
address nvarchar (40) NULL,
Name nvarchar (40) NULL
)
GO
INSERT Office
( address, Name)
VALUES
('�.����� ��.����������� �.2', '������� ����')
GO
select * from Office

CREATE TABLE Branch
(Branch_id int NOT NULL IDENTITY primary key,
Office_id int foreign key references dbo.Office(Office_id),
address nvarchar (40) NULL,
Name nvarchar (40) NULL
)
GO
INSERT Branch
( Office_id, address, Name)
VALUES
('1','�.����� ��.����������� �.18 �.44', '������ �1'),
('1','�.������� ��.������ �.7 �.1', '������ �2'),
('1','�.������ ��.������ �.54 �.2', '������ �3'),
('1','�.����� ��.���������� �.108 �.52', '������ �4')
GO
select * from Branch

CREATE TABLE Kiosk
(kiosk_id int NOT NULL IDENTITY primary key,
branch_id int foreign key references dbo.Branch(branch_id),
address nvarchar (40) NULL,
Name nvarchar (40) NULL
)
GO
INSERT Kiosk
( branch_id, address, Name)
VALUES
('1','�.����� ��.����������� �.44 �.18', '����� �1'),
('2','�.������� ��.������ �.11 �.7', '����� �2'),
('3','�.������ ��.������ �.25 �.54', '����� �3'),
('4','�.����� ��.���������� �.10 �.2', '����� �4'),
('1','�.����� ��.������������ �.18 �.44', '����� �5'),
('2','�.������� ��.��������� �.7 �.1', '����� �6'),
('3','�.������ ��.��������� �.54 �.2', '����� �7'),
('4','�.����� ��.������������ �.108 �.52', '����� �8'),
('1','�.����� ��.�������� �.18 �.25', '����� �9'),
('4','�.������� ��.��������� �.21 �.8', '����� �10'),
('3','�.������ ��.������������� �.4 �.12', '����� �11'),
('4','�.����� ��.������������ �.77 �.62', '����� �12')
GO
select * from Kiosk

create table Products
(
product_id int NOT NULL IDENTITY primary key,
product nvarchar (40) NULL
)
go 
insert Products values
('������'),
('�����'),
('�������'),
('������ �4 �������'),
('������ �4 ���������'),
('������ �3 �������'),
('������ �3 ���������'),
('�4 �������'),
('�4 ���������'),
('�3 �������'),
('�3 ���������')
go
select * from Products

create table Status
(
status_id int NOT NULL IDENTITY primary key,
status nvarchar (40) NULL
)
go
insert Status values
('����������'),
('�� ����������')
go
select * from Status

create table Clients
(
client_id int NOT NULL IDENTITY primary key,
status_id int foreign key references Status(status_id),
client_name nvarchar (60) NULL,
have_discount_card BIT
)
go 
insert Clients values
('1','����������� �.�.','true'),
('2','������ �.�.','false'),
('1','������ �.�.','true'),
('2','����������� �.�.','false')
go 
select * from Clients

create table Discount
(
discount_id int NOT NULL IDENTITY primary key,
client_id int foreign key references Clients(client_id),
discount TINYINT
)
go
insert Discount values
(1, 5),
(3, 7)
go
select * from Discount

create table ClientPrintOrder
(
printOrder_id int NOT NULL IDENTITY primary key,
client_id int foreign key references Clients(client_id),
service_id int foreign key references Service(service_id),
number int not null,
urgency BIT,
date DATE,
)
insert ClientPrintOrder values
(1, 4, 15, 0, '15.09.2022'),
(1, 5, 10, 1, '17.10.2022'),
(3, 4, 32, 0, '19.10.2022')
go
select * from ClientPrintOrder

create table ClientOrder 
(
order_id int NOT NULL IDENTITY primary key,
client_id int foreign key references Clients(client_id),
service_id int foreign key references Service(service_id),
number int not null,
date DATE,
)
go
insert ClientOrder values
(2, 1, 3, '5.08.2022'),
(2, 2, 1, '5.08.2022'),
(3, 3, 12, '19.10.2022')
go
select * from ClientOrder

create table Provider
(
provider_id int NOT NULL IDENTITY primary key,
provider_name nvarchar (40) NULL
)
go
insert Provider values
('��������� �1'),
('��������� �2'),
('��������� �3')
go
select * from Provider

create table ProviderProducts
(
providerProducts_id int NOT NULL IDENTITY primary key,
provider_id int foreign key references Provider(provider_id),
product_id int foreign key references Products(product_id),
price DECIMAL(18,2)
)
go
insert ProviderProducts values
(1, 1, 1),
(2, 3, 0.5),
(3, 3, 0.3)
go
select * from ProviderProducts

create table Service
(
service_id int NOT NULL IDENTITY primary key,
product_id int foreign key references Products(product_id),
price DECIMAL(18,2)
)
go
insert Service values
(1, 5),
(2, 1),
(3, 1.2),
(4, 0.65),
(5, 0.9),
(6, 1.3),
(7, 1.7)
go
select * from Service

alter table Service
add start_price int
insert Service values
(1, 5, 1),
(2, 1, 0.2),
(3, 1.2, 0.5),
(4, 0.65, 0.05),
(5, 0.9, 0.1),
(6, 1.3, 0.4),
(7, 1.7, 0.9)

create table BranchPrintOrders
(
branchPrintOrders_id int NOT NULL IDENTITY primary key,
branch_id int foreign key references dbo.Branch(branch_id),
printOrder_id int foreign key references ClientPrintOrder(printOrder_id)
)
go
insert BranchPrintOrders values
(1, 1),
(2, 2),
(3, 3)
go
select * from BranchPrintOrders

alter table BranchPrintOrders
add completed bit
insert BranchPrintOrders values
(1, 1, 1),
(2, 2, 1),
(3, 3, 1)

create table BranchOrders
(
branchOrders_id int NOT NULL IDENTITY primary key,
branch_id int foreign key references dbo.Branch(branch_id),
order_id int foreign key references ClientOrder(order_id)
)
go
insert BranchOrders values
(1, 1),
(2, 2),
(3, 3)
go
select * from BranchOrders

create table KioskPrintOrders
(
kioskPrintOrders_id int NOT NULL IDENTITY primary key,
kiosk_id int foreign key references Kiosk(kiosk_id),
printOrder_id int foreign key references ClientPrintOrder(printOrder_id)
)
go
insert KioskPrintOrders values
(1, 1),
(2, 2),
(3, 3)
go
select * from KioskPrintOrders

alter table KioskPrintOrders
add completed bit
insert KioskPrintOrders values
(1, 1, 1),
(2, 2, 1),
(3, 3, 1)

create table KioskOrders
(
kioskOrders_id int NOT NULL IDENTITY primary key,
kiosk_id int foreign key references Kiosk(kiosk_id),
order_id int foreign key references ClientOrder(order_id)
)
go
insert KioskOrders values
(1, 1),
(2, 2),
(3, 3)
go
select * from KioskOrders

create table DeliveryOrderBranch
(
deliveryOrderBranch_id int NOT NULL IDENTITY primary key,
branch_id int foreign key references dbo.Branch(branch_id),
product_id int foreign key references Products(product_id),
providerProducts_id int foreign key references ProviderProducts(providerProducts_id),
number int,
date date
)
go
insert DeliveryOrderBranch values
(1, 1, 1, 1000, '29.09.2022'),
(2, 2, 2, 1200, '30.09.2022'),
(3, 3, 3, 5000, '1.10.2022')
go
select * from DeliveryOrderBranch

create table DeliveryOrderKiosk
(
deliveryOrderKiosk_id int NOT NULL IDENTITY primary key,
kiosk_id int foreign key references Kiosk(kiosk_id),
product_id int foreign key references Products(product_id),
providerProducts_id int foreign key references ProviderProducts(providerProducts_id),
number int,
date date
)
go
insert DeliveryOrderKiosk values
(1, 1, 1, 1000, '29.09.2022'),
(2, 2, 2, 1200, '30.09.2022'),
(3, 3, 3, 5000, '1.10.2022')
go
select * from DeliveryOrderKiosk

create table BranchProductAvailability
(
branch_id int foreign key references dbo.Branch(branch_id),
product_id int foreign key references Products(product_id),
number int
)
go
insert BranchProductAvailability values
(1, 1, 1000),
(1, 2, 1200),
(1, 2, 900),
(2, 1, 100),
(2, 2, 105),
(2, 2, 908)

create table KioskProductAvailability
(
kiosk_id int foreign key references Kiosk(kiosk_id),
product_id int foreign key references Products(product_id),
number int
)
go
insert BranchProductAvailability values
(1, 1, 1000),
(1, 2, 1200),
(1, 2, 900),
(2, 1, 100),
(2, 2, 105),
(2, 2, 908)

create table VacanciesBranch
(
vacncy_id int NOT NULL IDENTITY primary key,
branch_id int foreign key references dbo.Branch(branch_id),
job_title nvarchar (40) not null,
)
go 
insert VacanciesBranch values
(1, '�������'),
(1, '�������'),
(2, '�������'),
(2, '�������'),
(3, '�������'),
(3, '�������'),
(4, '�������'),
(4, '�������')

create table VacanciesKiosk
(
vacncy_id int NOT NULL IDENTITY primary key,
kiosk_id int foreign key references Kiosk(kiosk_id),
job_title nvarchar (40) not null,
)
go 
insert VacanciesKiosk values
(1, '�������'),
(1, '�������'),
(2, '�������'),
(2, '�������'),
(3, '�������'),
(3, '�������'),
(4, '�������'),
(4, '�������')

create table VacanciesOffice
(
vacncy_id int NOT NULL IDENTITY primary key,
Office_id int foreign key references Office(Office_id),
job_title nvarchar (40) not null,
)
go 
insert VacanciesOffice values
(1, '�������'),
(1, '�������'),
(1, '��������'),
(1, '�����������')




