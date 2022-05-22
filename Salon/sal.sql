CREATE DATABASE Salon;
USE Salon;

CREATE TABLE Kategorija (
ID int Primary Key Identity(1,1),
Ime NVARCHAR(60) NOT NULL
)
GO

CREATE TABLE Proizvodjac (
ID int Primary Key Identity(1,1),
Ime NVARCHAR(60) NOT NULL,
Opis NVARCHAR(255),

)
GO
create table Korisnik(
ID INT IDENTITY(1,1) PRIMARY KEY,
Ime NVARCHAR(20),
Prezime NVARCHAR(30),
Adresa NVARCHAR(30),
Email VARCHAR(30),
Pass VARCHAR(20),
Uloga INT
)
GO

CREATE TABLE Boja (
ID INT IDENTITY(1,1) PRIMARY KEY,
Name NVARCHAR(30) NOT NULL,

)
GO
CREATE TABLE Materijal (
ID INT IDENTITY(1,1) PRIMARY KEY,
Ime NVARCHAR(80) NOT NULL,
)
GO



create table Proizvod(
ID INT IDENTITY(1,1) PRIMARY KEY,
Ime NVARCHAR(20),
Cena INT,
Proizvodjac_id INT FOREIGN KEY REFERENCES Proizvodjac(ID),
Kategorija_id INT FOREIGN KEY REFERENCES Kategorija(ID),
Boja_id INT FOREIGN KEY REFERENCES Boja(ID),
Materijal_id INT FOREIGN KEY REFERENCES Materijal(ID)

)
GO

create table Narudzbina(
ID INT IDENTITY(1,1) PRIMARY KEY,
Proizvod_id INT FOREIGN KEY REFERENCES Proizvod(ID),
Kome_id INT FOREIGN KEY REFERENCES Korisnik(ID),
Kolicina INT,
)

create table Magacin(
ID INT IDENTITY(1,1) PRIMARY KEY,
Proizvod_id INT FOREIGN KEY REFERENCES Proizvod(ID),
kolicina INT
)

INSERT INTO Kategorija VALUES ('Sto')
INSERT INTO Kategorija VALUES ('Stolica')
INSERT INTO Kategorija VALUES ('Kauc')
INSERT INTO Kategorija VALUES ('Fotelja')

INSERT INTO Proizvodjac VALUES ('Vranjex','Prave mnogo lep namestaj')
INSERT INTO Proizvodjac VALUES ('Beogradex','Prave mnogo fin namestaj')
INSERT INTO Proizvodjac VALUES ('Krusevex','Prave mnogo kvalitetan namestaj')
INSERT INTO Proizvodjac VALUES ('Nisex','Prave mnogo udoban namestaj')

insert into Korisnik
values('Teodor','Djelic','Adr1','admin@gmail.com','admin',1),
      ('Matija','Zivanovic','Adr2','korisnik@.gmail.com','korisnik',2),
	  ('Marija','Draskovic','Adr3','korisnik1@.gmail.com','korisnik',2)
	  
insert into Boja
values('braon'),('crn'),('siv'),('bez')

insert into Materijal
values('hrast'),('iverica'),('medijapan'),('mebl stof')

insert into Magacin
values(1, 55),(2, 55),(3,40),(4,20)

insert into Proizvod VALUES
('Ana', 4800,1,1,1,1),
('Dunja', 4000,2,1,3,2),
('Mirko', 4300,3,2,2,3),
('Sandra', 2500,4,2,1,1),
('Danijela', 5000,3,1,4,4),
('Danilo', 6000,2,4,4,4)

insert into Narudzbina VAlUES
(1,2,2),
(2,3,4),
(3,2,2),
(4,3,1)
