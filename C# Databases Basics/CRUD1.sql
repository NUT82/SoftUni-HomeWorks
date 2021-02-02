CREATE DATABASE Minions

USE Minions

CREATE TABLE Minions
(
  Id INT PRIMARY KEY,
  [Name] VARCHAR(30),
  Age INT
)

CREATE TABLE Towns
(
	Id INT PRIMARY KEY,
	[Name] VARCHAR(50)
)

ALTER TABLE Minions
ADD TownId INT

ALTER TABLE Minions
ADD FOREIGN KEY(TownId) REFERENCES Towns(Id)

INSERT INTO Towns VALUES
	(1, 'Sofia'),
	(2, 'Plovdiv'),
	(3, 'Varna');


INSERT INTO Minions VALUES
(1, 'Kevin', 22, 1),
(2, 'Bob', 15, 3),
(3, 'Steward', NULL, 2);

DELETE FROM Minions

DROP TABLE Minions

DROP TABLE Towns

CREATE TABLE People
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(200) NOT NULL,
	Picture VARCHAR(200),
	Height FLOAT(2),
	[Weight] FLOAT(2),
	Gender BIT NOT NULL,
	Birthday DATE NOT NULL,
	Biography VARCHAR(MAX)
);

INSERT INTO People VALUES
('Pesho', 'c://myDocuments/pesho.jpg', 1.65, 85, 1, '09-04-2000', 'Super pich'),
('Gosho', 'c://myDocuments/gosho.jpg', 1.75, 85, 1, '09-04-2000', 'Super pich'),
('Svetlio', 'c://myDocuments/svetlio.jpg', 1.85, 105, 1, '09-04-1982', 'Super pich'),
('Emo', 'c://myDocuments/emo.jpg', 1.38, 28, 1, '01-22-2012', 'Super pichaga'),
('Vesi', 'c://myDocuments/vesi.jpg', 1.60, 58, 0, '02-14-1987', 'Super macka');

CREATE TABLE Users
(
Id INT IDENTITY,
Username VARCHAR(30) NOT NULL,
[Password] VARCHAR(26) NOT NULL,
ProfilePicture VARCHAR(100),
LastLoginTime DATETIME DEFAULT CURRENT_TIMESTAMP,
IsDeleted BIT NOT NULL,
CONSTRAINT PK_Users PRIMARY KEY (Id, Username)
)

INSERT INTO Users VALUES
('sppetrov', 'parola', 'c://desctop/user.jpg', '01-25-2021 12:16', 0),
('sppetrov1', 'parola2', 'c://desctop/user2.jpg', '01-25-2021 12:16', 0),
('sppetrov2', 'parola3', 'c://desctop/user3.jpg', '01-25-2021 12:16', 0),
('sppetrov3', 'parola4', 'c://desctop/user4.jpg', '01-25-2021 12:16', 0),
('sppetrov4', 'parola5', 'c://desctop/user5.jpg', '01-25-2021 12:16', 0);


ALTER TABLE Users
ADD CONSTRAINT PK_Users PRIMARY KEY (Id, Username)

INSERT INTO Users VALUES
('sppetrov', 'parolataaa', 'c://desctop/user.jpg','', 0);

ALTER TABLE Users
ADD CONSTRAINT LENGHT_Password_Check CHECK (LEN(Password) > 5);

ALTER TABLE Users
ADD DEFAULT CURRENT_TIMESTAMP FOR LastLoginTime


INSERT INTO Users ([Username], [Password], IsDeleted) VALUES
('sppetrov', 'parola', 0);

ALTER TABLE Users
ADD PRIMARY KEY (Id);

ALTER TABLE Users
ADD CONSTRAINT Length_Username CHECK (LEN(Username) > 3);

CREATE DATABASE Movies

USE Movies

CREATE TABLE Directors
(
Id INT PRIMARY KEY IDENTITY,
DirectorName VARCHAR(50) NOT NULL,
Notes VARCHAR(MAX)
)

CREATE TABLE Genres
(
Id INT PRIMARY KEY IDENTITY,
GenreName VARCHAR(50) NOT NULL,
Notes VARCHAR(MAX)
)

CREATE TABLE Categories
(
Id INT PRIMARY KEY IDENTITY,
CategoryName VARCHAR(50) NOT NULL,
Notes VARCHAR(MAX)
)

CREATE TABLE Movies
(
Id INT PRIMARY KEY IDENTITY,
Title VARCHAR(150) NOT NULL,
DirectorId INT NOT NULL,
CopyrightYear INT NOT NULL,
[Length] TIME NOT NULL,
GenreId INT NOT NULL,
CategoryId INT NOT NULL,
Rating FLOAT(2) NOT NULL,
Notes VARCHAR(MAX)
)

INSERT INTO Directors (DirectorName) VALUES
('Stivan King'),
('Az'),
('Leam Niaseon'),
('Jason Statam'),
('Harisan Ford');

INSERT INTO Genres (GenreName) VALUES
('Horor'),
('Funny'),
('Parody'),
('Drama'),
('Documental');

INSERT INTO Categories (CategoryName) VALUES
('Children'),
('Adult only'),
('18+'),
('Animation'),
('Documental');

INSERT INTO Movies VALUES
('To2', 6, 1990, '1:44', 1, 2, 8.5, Null),
('To3', 1, 2020, '1:30', 1, 2, 8.1, Null),
('To4', 5, 1991, '1:49', 1, 2, 8.5, Null),
('To5', 4, 2000, '1:34', 1, 2, 9, Null),
('To6', 3, 1990, '1:54', 1, 2, 8, Null);

ALTER TABLE Movies
ADD FOREIGN KEY (DirectorId) REFERENCES Directors(Id),
FOREIGN KEY (CategoryId) REFERENCES Categories(Id),
FOREIGN KEY (GenreId) REFERENCES Genres(Id)

CREATE DATABASE Hotel

USE Hotel

CREATE TABLE Categories
(
Id INT PRIMARY KEY IDENTITY,
CategoryName VARCHAR(30) NOT NULL,
DailyRate FLOAT(2),
WeeklyRate FLOAT(2),
MountlyRate FLOAT(2),
WeekendRate FLOAT(2)
)

CREATE TABLE Cars
(
Id INT PRIMARY KEY IDENTITY,
PlateNumber VARCHAR(10) NOT NULL,
Manifacturer VARCHAR(30) NOT NULL,
Model VARCHAR(30) NOT NULL,
CarYear DATE,
CategoryId INT NOT NULL,
Doors TINYINT,
Picture VARCHAR(150),
Condition VARCHAR(150),
Available BIT NOT NULL
)

CREATE TABLE Employees
(
Id INT PRIMARY KEY IDENTITY,
FirstName VARCHAR(20) NOT NULL,
LastName VARCHAR(20) NOT NULL,
Title VARCHAR(10),
Notes VARCHAR(MAX)
)

CREATE TABLE Customers
(
Id INT PRIMARY KEY IDENTITY,
AccountNumber VARCHAR(10) NOT NULL,
FirstName VARCHAR(20) NOT NULL,
LastName VARCHAR(20) NOT NULL,
PhoneNumber VARCHAR(50) NOT NULL,
EmergencyName VARCHAR(30),
EmergencyNumber VARCHAR(30),
Notes VARCHAR(MAX)
)

CREATE TABLE RentalOrders
(
Id INT PRIMARY KEY IDENTITY,
EmloyeeId INT NOT NULL,
CustomerId INT NOT NULL,
CarId INT NOT NULL,
TankLevel FLOAT(2) NOT NULL,
KilometrageStart INT NOT NULL,
KilometrageEnd INT NOT NULL,
TotalKilometrage INT NOT NULL,
StartDate DATE NOT NULL,
EndDate Date,
TotalDays TINYINT,
RateApplied FLOAT(2),
TaxRate FLOAT(2),
OrderStatus BIT NOT NULL,
Notes VARCHAR(MAX)
)

INSERT INTO Categories (CategoryName) VALUES
('First Category'),
('Second Category'),
('Third Category');

INSERT INTO Cars (PlateNumber, Manifacturer, Model, CategoryId, Available) VALUES
('P3901KB', 'Mazda', 'F3', 1, 0),
('P1818BB', 'Audi', 'A3', 2, 0),
('P1111KB', 'Opel', 'Zafira', 3, 1);

INSERT INTO Employees (FirstName, LastName) VALUES
('Svetoslav', 'Petrov'),
('Emilian', 'Petrov'),
('Veselka', 'Petrova');

INSERT INTO Customers (AccountNumber, FirstName, LastName, PhoneNumber) VALUES
('A750888', 'Svetlio', 'Petrov', '0898600911'),
('A750000', 'Vesi', 'Petrova', '0888888888'),
('A743867', 'Emo', 'Petrov', '0888979797');

INSERT INTO RentalOrders (EmloyeeId, CustomerId, CarId, TankLevel, KilometrageStart, KilometrageEnd, TotalKilometrage, StartDate, OrderStatus) VALUES
(1, 1, 1, 0.5, 120000, 120980, 999999, '01-20-2021', 1),
(1, 2, 3, 0.9, 120000, 120980, 999999, '01-25-2021', 0),
(1, 3, 2, 1, 120000, 120980, 999999, '09-20-2021', 1);

ALTER TABLE RentalOrders ADD
FOREIGN KEY (EmloyeeId) REFERENCES Employees(Id),
FOREIGN KEY (CustomerId) REFERENCES Customers(Id),
FOREIGN KEY (CarId) REFERENCES Cars(Id);

ALTER TABLE RentalOrders
sp_rename 'RentalOrders.EmloyeeId', 'EmployeeId', 'COLUMN';

CREATE TABLE RoomStatus
(
Id INT PRIMARY KEY IDENTITY,
RoomStatus VARCHAR(30) NOT NULL,
Notes VARCHAR(MAX)
)

CREATE TABLE RoomTypes
(
Id INT PRIMARY KEY IDENTITY,
RoomTypes VARCHAR(30) NOT NULL,
Notes VARCHAR(MAX)
)

CREATE TABLE BedTypes
(
Id INT PRIMARY KEY IDENTITY,
BedTypes VARCHAR(30) NOT NULL,
Notes VARCHAR(MAX)
)

CREATE TABLE Rooms
(
Id INT PRIMARY KEY IDENTITY,
RoomNumber VARCHAR(10) NOT NULL,
RoomType INT NOT NULL,
BedType INT NOT NULL,
Rate Float(2),
RoomStatus INT NOT NULL,
Notes VARCHAR(MAX)
)

CREATE TABLE Payments
(
Id INT PRIMARY KEY IDENTITY,
EmployeeId INT NOT NULL,
PaymentDate DATE,
AccountNumber INT NOT NULL,
FirstDateOccupied DATE,
LastDateOccupied DATE,
TotalDays TINYINT,
AmountCharged Float(2),
TaxRate Float(2),
TaxAmount Float(2),
PaymentTotal Float(2),
Notes VARCHAR(MAX)
)

CREATE TABLE Occupancies
(
Id INT PRIMARY KEY IDENTITY,
EmployeeId INT NOT NULL,
DateOccupied DATE,
AccountNumber INT NOT NULL,
RoomNumber INT NOT NULL,
RateAplied FLOAT(2),
PhoneCharge Float(2),
Notes VARCHAR(MAX)
)

INSERT INTO RoomStatus(RoomStatus) VALUES
('Free'),
('Not Free'),
('Cleaning');

INSERT INTO RoomTypes(RoomTypes) VALUES
('Single'),
('Double'),
('Apartment');

INSERT INTO BedTypes(BedTypes) VALUES
('Single'),
('Double'),
('Kid bed');

INSERT INTO Rooms (RoomNumber, RoomType, BedType, RoomStatus) VALUES
('101A', 1, 1, 1),
('101B', 1, 2, 1),
('605C', 2, 1, 1);

INSERT INTO Payments (EmployeeId,AccountNumber) VALUES
(1, 1),
(2, 1),
(3, 2);

INSERT INTO Occupancies (EmployeeId, AccountNumber, RoomNumber) VALUES
(1, 1, 1),
(1, 2, 3),
(1, 3, 2);

CREATE DATABASE SoftUni

USE SoftUni

CREATE TABLE Towns
(
Id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(30) NOT NULL
)

CREATE TABLE Addresses
(
Id INT PRIMARY KEY IDENTITY,
AddressText VARCHAR(60) NOT NULL,
TownId INT NOT NULL
)

CREATE TABLE Departments
(
Id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(30) NOT NULL
)

CREATE TABLE Employees
(
Id INT PRIMARY KEY IDENTITY,
FirstName VARCHAR(20) NOT NULL,
MiddleName VARCHAR(20),
LastName VARCHAR(20) NOT NULL,
JobTitle VARCHAR(20),
DepartmentId INT NOT NULL,
HireDate DATE NOT NULL,
Salary FLOAT(2) NOT NULL,
AddressId INT NOT NULL
)

ALTER TABLE Addresses
ADD FOREIGN KEY (TownId) REFERENCES Towns(Id)

ALTER TABLE Employees ADD
FOREIGN KEY (DepartmentId) REFERENCES Departments(Id),
FOREIGN KEY (AddressId) REFERENCES Addresses(Id)

BACKUP DATABASE SoftUni TO DISK = 'SoftUni.bak'

INSERT INTO Towns VALUES
('Sofia'),
('Plovdiv'),
('Varna'),
('Burgas');

INSERT INTO Addresses VALUES
('Borisova 97', 1),
('Papa Gosho 3', 2),
('Minka 44', 3),
('Borisova 97', 1),
('Mutkurova 11', 4);

--•	Departments: Engineering, Sales, Marketing, Software Development, Quality Assurance

INSERT INTO Departments VALUES
('Engineering'),
('Sales'),
('Marketing'),
('Software Development'),
('Quality Assurance');




INSERT INTO Employees (FirstName, MiddleName, LastName, JobTitle, DepartmentId, HireDate, Salary, AddressId)
VALUES ('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '02-01-2013', 3500.00, 1),
('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, '03-02-2004', 4000.00, 2),
('Maria', 'Petrova', 'Ivanova', 'Intern', 5, '08-28-2016', 525.25, 1),
('Georgi', 'Teziev', 'Ivanov', 'CEO', 2, '12-09-2007', 3000.00, 3),
('Peter', 'Pan', 'Pan', 'Intern', 3, '08-28-2016', 599.88, 3);

SELECT Name FROM Towns ORDER BY (Name)

SELECT Name FROM Departments ORDER BY (Name)

SELECT FirstName, LastName, JobTitle, Salary FROM Employees ORDER BY (Salary) DESC

UPDATE Employees SET Salary *= 1.1;

SELECT Salary FROM Employees

USE Hotel

SELECT * FROM Payments

UPDATE Payments SET TaxRate *= 0.97;

SELECT TaxRate FROM Payments

SELECT * FROM Occupancies

DELETE FROM Occupancies