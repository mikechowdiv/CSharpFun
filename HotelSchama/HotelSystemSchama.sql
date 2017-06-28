/*Overwrite existing database if any*/

USE master
GO

IF EXISTS (SELECT * FROM sys.databases WHERE name = 'HotelSystem')
	DROP DATABASE HotelSystem
CREATE DATABASE HotelSystem

USE HotelSystem
GO

/*Room Information*/

CREATE TABLE RoomType(
	RoomTypeID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Name VARCHAR(30) NOT NULL, /*e.g. Single, King...etc */
	[Description] VARCHAR(180)
)

CREATE TABLE Room(
	RoomID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	RoomTypeID INT FOREIGN KEY REFERENCES RoomType(RoomTypeID) NOT NULL,
	RoomNumber INT NOT NULL,
	FloorNumber INT NOT NULL,
	OccupancyLimit INT /*nullable, since not always ncessary to specify */
)

CREATE TABLE Amenity(
	AmenityID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Name VARCHAR(30) NOT NULL, /*e.g. Fridge, spa, etc */
	[Description] VARCHAR(180)
)

CREATE TABLE RoomAmenity(
	RoomID INT FOREIGN KEY REFERENCES Room(RoomID) NOT NULL,
	AmenityID INT FOREIGN KEY REFERENCES Amenity(AmenityID) NOT NULL,
	PRIMARY KEY(RoomID, AmenityID)
)

/*Reservation Information*/

CREATE TABLE Customer(
	CustomerID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	FirstName NVARCHAR(70) NOT NULL,
	LastName NVARCHAR(70) NOT NULL,
	Phone VARCHAR(20) NOT NULL,
	Email VARCHAR(320) NOT NULL
)

CREATE TABLE Guest(
	GuestID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	FirstName NVARCHAR(70) NOT NULL,
	LastName NVARCHAR(70) NOT NULL,
	Age TINYINT NOT NULL
)

CREATE TABLE Promotion(
	PromotionID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Name] VARCHAR(30),
	[Description] VARCHAR(180),
	StartDate DATE NOT NULL,
	EndDate DATE,
	PercentOFF DECIMAL(4,2) DEFAULT 0,
	FlatOFF DECIMAL(6,2) DEFAULT 0
)

CREATE TABLE Reservation(
	ReservationID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	CustomerID INT FOREIGN KEY REFERENCES Customer(CustomerID) NOT NULL,
	PromotionID INT FOREIGN KEY REFERENCES Promotion(PromotionID),
	StartDate DATE NOT NULL,
	EndDate DATE NOT NULL
)

CREATE TABLE GuestReservation(
	GuestID INT FOREIGN KEY REFERENCES Guest(GuestID) NOT NULL,
	ReservationID INT FOREIGN KEY REFERENCES Reservation(ReservationID) NOT NULL,
	PRIMARY KEY(GuestID, ReservationID)
)

CREATE TABLE RoomReservation(
	RoomID INT FOREIGN KEY REFERENCES Room(RoomID) NOT NULL,
	ReservationID INT FOREIGN KEY REFERENCES Reservation(ReservationID) NOT NULL
)

/* Rates */

CREATE TABLE RoomRate(
	RoomRateID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Description] VARCHAR(180), /*e.g.  Winter rate.*/
	RoomTypeID INT FOREIGN KEY REFERENCES RoomType(RoomTypeID),
	Rate DECIMAL(6,2) NOT NULL,
	StartDate DATE NOT NULL,
	EndDate DATE
)

CREATE TABLE AddOn(
	AddOnID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Name VARCHAR(30) NOT NULL, /*Room service, movie rental, etc. */
	[Description] VARCHAR(180)
)

CREATE TABLE ReservationAddOn(
	ReservationAddOnId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	ReservationId INT FOREIGN KEY REFERENCES Reservation(ReservationID) NOT NULL,
	AddOnId INT FOREIGN KEY REFERENCES AddOn(AddOnID) NOT NULL,
	RoomID INT FOREIGN KEY REFERENCES Room(RoomID) NOT NULL,
	[Description] VARCHAR(180),
	StartDate DATE NOT NULL,
	EndDate DATE NOT NULL
)

CREATE TABLE AddOnRate(
	AddOnRateID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Description] VARCHAR(180),
	AddOnID INT FOREIGN KEY REFERENCES AddOn(AddOnID),
	Rate DECIMAL(6,2) NOT NULL,
	StartDate DATE NOT NULL,
	EndDate DATE
)

/*Billing */

CREATE TABLE Invoice(
	InvoiceID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	CustomerID INT FOREIGN KEY REFERENCES Customer(CustomerID) NOT NULL,
	ReservationID INT FOREIGN KEY REFERENCES Reservation(ReservationID) NOT NULL,
	Subtotal DECIMAL(8,2) NOT NULL,
	Taxes DECIMAL(6,2) NOT NULL,
	Total DECIMAL(8,2) NOT NULL
)

CREATE TABLE InvoiceDetail(
	InvoiceDetailID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	InvoiceID INT FOREIGN KEY REFERENCES Invoice(InvoiceID) NOT NULL,
	[Name] VARCHAR(30) NOT NULL,
	[Description] VARCHAR(180),
	Rate DECIMAL (6,2) NOT NULL,
	Units INT DEFAULT 1,
	Total DECIMAL(8,2) NOT NULL,
)



INSERT INTO RoomType (Name, [Description])
VALUES ('Single', 'One tiny bed'),
('Double', 'Two tiny beds'),
('Queen', 'Nice beds'),
('King', 'Best beds')

INSERT INTO RoomRate (RoomTypeID, Rate, StartDate, EndDate, [Description])
VALUES
(1, 50, '1/23/2017', NULL, 'Regular single rate'),
(2, 65, '1/23/2017', NULL, 'Regular double rate'),
(3, 80, '1/23/2017', '4/30/2017', 'Early bird special'),
(3, 90, '5/1/2017', NULL, 'Regular queen rate'),
(4, 90, '1/23/2017', '4/30/2017', 'Early bird special'),
(4, 100, '5/1/2017', NULL, 'Regular king rate')

INSERT INTO AddOn (Name, Description)
VALUES
('Wifi', '24-hours of connectivity'),
('Late checkout', NULL),
('Movie rental', NULL)

INSERT INTO AddOnRate (AddOnID, Rate, StartDate)
VALUES
(1, 20, '1/23/2017'),
(2, 10, '1/23/2017'),
(3,5,'1/23/2017')

INSERT INTO Amenity (Name)
VALUES
('Minifridge'), ('A/C'), ('Vault'), ('Pull-out couch')

INSERT INTO Room (RoomNumber, FloorNumber, RoomTypeID)
VALUES
		(100, 1, 1),
		(101, 1, 1),
		(102, 1, 2),
		(103, 1, 2),
		(200, 2, 3),
		(201, 2, 3),
		(202, 2, 4),
		(203, 2, 4)

INSERT INTO RoomAmenity (RoomID, AmenityID) VALUES
(1, 1), (1,2),
		(2, 1), (2,2), (2,3),
		(3, 2),
		(5, 1), (5, 3),
		(6, 1), (6, 2),
		(7, 1), (7, 2), (7, 3),
		(8, 2), (8, 3)

INSERT INTO Promotion (Name, StartDate, EndDate, PercentOFF, FlatOFF) VALUES
('Chess Tournament', '3/1/2017', '3/31/2017', 10, 0),
('Groundhog Month', '2/1/2017', '2/28/2017', 0, 20)

/* Make People */

INSERT INTO Customer(FirstName, LastName, Phone, Email)
VALUES	('ALEX', 'JONES', '123-4567', 'FAKE@EMAIL.COM'),
		('BIANCA', 'CAFFY', '123-4567', 'FAKE@EMAIL.COM'),
		('CLETUS', 'WONG', '123-4567', 'FAKE@EMAIL.COM'),
		('DARRYL', 'GOLDSMITH', '123-4567', 'FAKE@EMAIL.COM'),
		('EGBERT', 'JUN', '123-4567', 'FAKE@EMAIL.COM')

INSERT INTO GUEST(FirstName, LastName, Age)
VALUES	('ALEX', 'JONES', 25),
		('BIANCA', 'CAFFY', 33),
		('CLETUS', 'WONG', 67),
		('DARRYL', 'GOLDSMITH', 78),
		('EGBERT', 'JUN', 22),
		('ALVIN', 'WONG', 20),
		('BEATRIX', 'CAFFY', 30),
		('CAROL', 'MCCAROL', 35),
		('DAVE', 'JUN', 59),
		('ERROL', 'WHITE', 59)

/*Make reservation*/
INSERT INTO Reservation(CustomerID, PromotionID, StartDate, EndDate)
VALUES	(1, NULL, '4/1/2017', '4/8/2017'),
		(2, 1, '3/5/2017', '3/8/2017'),
		(3, 2, '2/13/2017', '2/19/2017'),
		(4, NULL, '1/23/2017', '1/24/2017'),
		(5, 1, '3/4/2017', '3/12/2017')


INSERT INTO GuestReservation(ReservationID, GuestID)
VALUES	(1, 1), (1, 3), (1, 10),
		(2, 2), (2, 7),
		(3, 3), (3, 8),
		(4, 4), (4, 9), (4,3), (4, 5),
		(5, 5)

INSERT INTO RoomReservation(ReservationID, RoomID)
VALUES	(1, 1), (1, 2),
		(2, 6),
		(3, 5),
		(4, 7), (4, 8),
		(5, 3)

INSERT INTO ReservationAddOn(ReservationID, AddOnID, RoomID, StartDate, EndDate)
VALUES	(1, 1, 1, '4/1/2017', '4/8/2017'),
		(1, 1, 2, '4/1/2017', '4/8/2017'),
		(2, 2, 7, '3/8/2017', '3/8/2017'),
		(3, 3, 8, '2/15/2017', '2/16/2017')

INSERT INTO INVOICE (ReservationID, CustomerID, Subtotal, Taxes, Total)
VALUES	(1, 1, 1000, 85, 1085),
		(2, 2, 500, 50, 550),
		(3, 3, 800, 120, 920),
		(4, 4, 1400, 150, 1550),
		(5, 5, 700, 150, 850)

INSERT INTO InvoiceDetail(InvoiceID, Name, Rate, Units, Total)
VALUES	(1, 'Arbitrary charges', 100, 10, 1000),
		(2, 'Arbitrary charges', 250, 2, 500),
		(3, 'Arbitrary charges', 160, 5, 800),
		(4, 'Arbitrary charges', 200, 7, 1400),
		(5, 'Arbitrary charges', 700, 1, 700)