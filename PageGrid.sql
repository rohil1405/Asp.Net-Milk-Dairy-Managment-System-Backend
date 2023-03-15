CREATE TABLE #email
(
  id smallint,
  email varchar(50)
)

DECLARE @count smallint = 0

WHILE @count<100
BEGIN
  INSERT INTO #email VALUES(@count,CONCAT('user',FLOOR(RAND()*1000),'@outlook.com'))
  SET @count=@count+1
END

SELECT *FROM #email