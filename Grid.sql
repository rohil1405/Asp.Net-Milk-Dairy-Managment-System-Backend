CREATE TABLE email1
(
  id smallint Primary Key,
  email varchar(50)
)

DECLARE @count smallint = 0

WHILE @count<100
BEGIN
  INSERT INTO email1 VALUES(@count,CONCAT('user',FLOOR(RAND()*1000),'@outlook.com'))
  SET @count=@count+1
END


select * from email1 order by email desc;
SELECT *FROM email1
SELECT * FROM email1 ORDER BY id ASC, email desc;
SELECT *FROM email1 WHERE email LIKE 'us___2 ;

