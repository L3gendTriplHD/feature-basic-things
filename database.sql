CREATE DATABASE BasicThingsDB;
GO

USE BasicThingsDB;
GO

CREATE TABLE Animals (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Age INT
);

CREATE TABLE Cars (
    Id INT PRIMARY KEY IDENTITY,
    Brand NVARCHAR(100),
    Year INT
);


CREATE TABLE Persons (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Job NVARCHAR(100)
);


CREATE TABLE Books (
    Id INT PRIMARY KEY IDENTITY,
    Title NVARCHAR(100),
    Author NVARCHAR(100)
);
GO

USE BasicThingsDB;
GO

INSERT INTO Animals (Name, Age) VALUES ('Dog', 3), ('Cat', 5);
INSERT INTO Cars (Brand, Year) VALUES ('Toyota', 2020), ('BMW', 2022);
INSERT INTO Persons (Name, Job) VALUES ('John', 'Developer'), ('Anna', 'Designer');
INSERT INTO Books (Title, Author) VALUES ('1984', 'Orwell'), ('Dune', 'Herbert');
GO

SELECT * FROM Animals;
SELECT * FROM Cars;
SELECT * FROM Persons;
SELECT * FROM Books;
GO

UPDATE Animals SET Age = 4 WHERE Name = 'Dog';
UPDATE Cars SET Year = 2021 WHERE Brand = 'Toyota';
UPDATE Persons SET Job = 'Manager' WHERE Name = 'John';
UPDATE Books SET Author = 'George Orwell' WHERE Title = '1984';
GO

DELETE FROM Animals WHERE Name = 'Cat';
DELETE FROM Cars WHERE Brand = 'BMW';
DELETE FROM Persons WHERE Name = 'Anna';
DELETE FROM Books WHERE Title = 'Dune';
GO