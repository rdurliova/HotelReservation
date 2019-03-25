/*
create database NewHotelReservation;
go
use NewHotelReservation;
go

--��������� �� ������� � ��� Countries
create table Countries(
Id int primary key identity, --������ Id ��� ���� �����, ������� ����, ����������� �� ��������� ��� �������� �� ��� �����
Name varchar(50) unique -- ������ Name, ��� ����� � ������� 50, �������� ���������
);
go
--��������� �� ������� Towns
create table Towns(
Id int primary key identity,
Name varchar(50),
CountryId int not null,
constraint fk_towns_countries  --����������� � ��� fk_towns_countries
foreign key (CountryId)   --������ ���� ������ �� ������ ������� CountryId
references Countries (Id) --������ ��� ������� Countries, ������ Id
);
go

create table RoomTypes(
Id int primary key identity,
Type varchar(20) unique,
Price decimal);
go

create table Rooms(
Id int primary key identity,
RoomNumebr varchar(3) unique,
TypeId int not null,
isFree bit,
constraint fk_room_types
foreign key (TypeId)
references RoomTypes (Id)
);
go

create table Clients(
Id int primary key identity,
FirstName varchar(50),
LastName varchar(50),
EGN varchar(10),
Age int check(Age>=0 and Age<=120),--������ Age, ���� �����, ��������� ���� ����������� �� ����� 0 � 120
TownID int,
Gsm varchar(30),
Email varchar(30),
constraint fk_minions_towns
foreign key (TownID)
references Towns(Id)
);
go

create table Reservation(
Id int primary key identity,
IdClient int,
IdRoom int,
DataStart date,
DataFinish date,
Payment decimal,
PaymentType varchar(20),
constraint fk_reservation_clients
foreign key (IdClient)
references Clients(Id),
constraint fk_reservation_rooms
foreign key (IdRoom)
references Rooms(Id));
go

insert into RoomTypes(Type,Price)  values
('Single',30),
('Double',50),
('Apartment',100);

--�������� �� ������ � ������� Countries
insert into Countries(name) values 
('Bulgaria'),
('Poland'),
('Italy'),
('France'),
('Turkey'),
('England'),
('USA'),
('Russia'),
('Greece'),
('Cyprus'),
('Romania'),
('Serbia'),
('Germany'),
('Austria'),
('Tanzania'),
('Spain'),
('Ethiopia'),
('Finland'),
('Fiji'),
('Falkland Islands'),
('Micronesia'),
('Faroe Islands');
go
--�������� �� ������ � �������
insert into Towns (Name, CountryId) values
('Pleven', 1),
('Sofia',1),
('Plovdiv',1),
('Ruse',1),
('Velingrad',1),
('Pazardzhik',1),
('Burgas',1),
('Varna',1),
('Devin',1),
('Vidin',1),
('Turin',3),
('Rome',3),
('Milan',3),
('Venice',3),
('Berlin',13),
('Munich',13),
('Frankfurt',13),
('Salzburg',13),
('Drezden',13),
('Bremen',13),
('Dortmund',13),
('Chikago',7),
('Washington',7),
('Los Angeles',7),
('Las Vegas',7),
('Paris',4),
('Nice',4),
('Lyon',4),
('Toulouse',4),
('Strasbourg',4),
('Birmingham',6),
('Manchester',6),
('Ashford',6),
('Barnsley',6),
('Oxford',6),
('Cambridge',6),
('Nottingham',6),
('Reading',6),
('London',6);
go

insert into Rooms(RoomNumebr,TypeId,isFree) values
(101,2,1),
(102,1,1),
(103,1,1),
(104,2,1),
(105,2,1),
(106,1,1);
*/
insert into Clients (FirstName,LastName, EGN, TownID, Age, Gsm, Email) values
('Ivan', 'Georgiev', 1234567898,1,45,0887980981,'ivang'),
('Mariya','Sokolova',1212121212,4,33,0986754321,'mariyaS'),
('Valentina','Dospatska',3434353434,7,19,0888888888,'valqqq'),
('Reshide', 'Durleva',0111111111,5,50,0777777777,'reshii'),
('Mihail','Mihailov',0233333333,12,68,0654123455,'misho01'),
('Aishe','Alkeeva',0412121212,2,22,0798120989,'aisheto01');