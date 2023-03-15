CREATE DATABASE SECURITY_DB

CREATE TABLE UserMaster
(
  UserID INT PRIMARY KEY,
  UserName VARCHAR(50),
  UserPassword VARCHAR(50),
  UserRoles VARCHAR(500),
  UserEmailID VARCHAR(100),
);
INSERT INTO UserMaster VALUES(101, 'Anurag', '123456', 'Admin', 'Anurag@g.com')
INSERT INTO UserMaster VALUES(102, 'Priyanka', 'abcdef', 'User', 'Priyanka@g.com')
INSERT INTO UserMaster VALUES(103, 'Sambit', '123pqr', 'SuperAdmin', 'Sambit@g.com')
INSERT INTO UserMaster VALUES(104, 'Pranaya', 'abc123', 'Admin, User', 'Pranaya@g.com')

select * from UserMaster