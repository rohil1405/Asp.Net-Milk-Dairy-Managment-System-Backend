CREATE TABLE Persons (
    ID int NOT NULL PRIMARY KEY,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255),
    Age int
);
INSERT INTO Persons(ID,LastName, FirstName,Age)
VALUES('56', 'Hetanshi', 'Patel', '22')
INSERT INTO Persons(ID,LASTNAME,FIRSTNAME,AGE)
VALUES('14','AALISHA','DESAI', '20')
INSERT INTO PERSONS(ID,LASTNAME,FIRSTNAME,AGE)
VALUES('88','RIYA','SHAH', '20')
INSERT INTO PERSONS(ID,LASTNAME,FIRSTNAME,AGE)
VALUES('90','SAKSHI','SHAH', '20')
INSERT INTO PERSONS(ID,LASTNAME,FIRSTNAME,AGE)
VALUES('66','SIDDHI','PATEL', '20')
INSERT INTO PERSONS(ID,LASTNAME,FIRSTNAME,AGE)
VALUES('27','JEEL','JOSHI', '20')
INSERT INTO PERSONS(ID,LASTNAME,FIRSTNAME,AGE)
VALUES('29','MITTAL','JADEJA', '20')

SELECT * FROM Persons
