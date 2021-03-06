CREATE PROC ContactAddOrEdit
@ContactID int,
@Name varchar(50),
@Mobile varchar(50),
@Address varchar(250)
AS
BEGIN
IF(@ContactID = 0)
BEGIN
	INSERT INTO Contact
	(Name, Mobile, Address)
	VALUES
	(
	@Name,
	@Mobile,
	@Address
	)
END
ELSE
BEGIN
	UPDATE Contact
	SET
	Name = @Name,
	Mobile = @Mobile,
	Address = @Address 
	WHERE ContactID = @ContactID
END
END