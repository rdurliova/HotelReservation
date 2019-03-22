/*
create database Reservation;
go

use reservation ;
go

--Създаване на таблица с име Countries
create table Countries(
Id int primary key identity, --колона Id тип цяло число, ключово поле, автоматично се увеличава при добавяне на нов запис
Name varchar(50) unique -- колона Name, тип текст с дължина 50, уникални стойности
);
go
--Създаване на таблица Towns
create table Towns(
Id int primary key identity,
Name varchar(50),
CountryId int not null,
constraint fk_towns_countries  --ограничение с име fk_towns_countries
foreign key (CountryId)   --външен ключ колона от текуща таблица CountryId
references Countries (Id) --връзка към таблица Countries, колона Id
);
go

create table Types(
Id int primary key identity,
Type varchar(20) unique);
go

create table Rooms(
Id int primary key identity,
TypeId int not null,
constraint fk_room_types
foreign key (TypeId)
references Types (Id)
);
go

create table HotelBase(
Id int primary key,
IsFree bit
constraint fk_hotelBase_rooms
foreign key(Id)
references Rooms (Id)
);
go

create table Clients(
Id int primary key identity,
FirstName varchar(50),
LastName varchar(50),
EGN varchar(10),
Age int check(Age>=0 and Age<=120),--колона Age, цяло число, проверява дали стойностите са между 0 и 120
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
constraint fk_reservation_hotelBase
foreign key (IdRoom)
references HotelBase(Id));
go

--Добавяне на записи в таблица Countries
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
--Добавяне на записи в таблица
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
*/

