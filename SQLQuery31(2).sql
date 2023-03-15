CREATE TABLE ClientMaster
(
  ClientKeyId INT PRIMARY KEY IDENTITY,
  ClientId VARCHAR(500),
  ClientSecret VARCHAR(500),
  ClientName VARCHAR(100),
  CreatedOn DateTime
)

 INSERT INTO ClientMaster(ClientId, ClientSecret, ClientName, CreatedOn) 
 VALUES(NEWID(), NEWID(), 'My Client1', GETDATE())
 INSERT INTO ClientMaster(ClientId, ClientSecret, ClientName, CreatedOn) 
 VALUES(NEWID(), NEWID(), 'My Client2', GETDATE())
 INSERT INTO ClientMaster(ClientId, ClientSecret, ClientName, CreatedOn) 
 VALUES(NEWID(), NEWID(), 'My Client3', GETDATE())

 select * from ClientMaster;