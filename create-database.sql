CREATE DATABASE KINOWY_SYSTEM_REZERWACJI;

USE KINOWY_SYSTEM_REZERWACJI;

CREATE TABLE Miejsca(
id int not null auto_increment,
rzad int not null,
numer int not null,
PRIMARY KEY(id))
ENGINE = innodb
default character set utf8 collate utf8_unicode_ci;

CREATE TABLE Uzytkownicy(
id int not null auto_increment,
nazwa_uzytkownika char(14) not null,
ukryte_haslo char(50) not null,
imie char(20) not null,
nazwisko char(30) not null,
email char(30) not null,
data_urodzenia date,
PRIMARY KEY(id))
ENGINE = innodb
default character set utf8 collate utf8_unicode_ci;

CREATE TABLE Filmy(
id int not null auto_increment,
nazwa char(30) not null,
czas_trwania int not null,
ocena float not null,
rok_premiery year,
PRIMARY KEY(id))
ENGINE = innodb
default character set utf8 collate utf8_unicode_ci;

CREATE TABLE Seanse(
id int not null auto_increment,
id_filmu int not null,
kiedy datetime,
PRIMARY KEY(id),
CONSTRAINT fk_projekcja FOREIGN KEY(id_filmu) REFERENCES Filmy(id))
ENGINE = innodb
default character set utf8 collate utf8_unicode_ci;

CREATE TABLE Rezerwacje(
id int not null auto_increment,
id_seansu int not null,
id_uzytkownika int not null,
PRIMARY KEY(id),
CONSTRAINT fk_rezerwacjauzytkownika FOREIGN KEY (id_uzytkownika) REFERENCES Uzytkownicy(id),
CONSTRAINT fk_rezerwacjawseansie FOREIGN KEY (id_seansu) REFERENCES Seanse(id))
ENGINE = innodb
default character set utf8 collate utf8_unicode_ci;
 
CREATE TABLE Miejsca_Rezerwacje(
id int not null auto_increment,
id_rezerwacji int not null,
id_miejsca int not null,
PRIMARY KEY(id),
CONSTRAINT fk_miejscewrezerwacji FOREIGN KEY (id_rezerwacji) REFERENCES Rezerwacje(id),
CONSTRAINT fk_rezerwowanemiejsce FOREIGN KEY (id_miejsca) REFERENCES Miejsca(id))
ENGINE = innodb
default character set utf8 collate utf8_unicode_ci;
