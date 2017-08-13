CREATE PROC ContactViewAllOrSearch
@SearchText VARCHAR(50)
AS BEGIN
SELECT * FROM Contact WHERE @SearchText = '' OR Name LIKE '%' + @SearchText + '%'

END



CREATE PROC ContactDeleteById
@ContactID int
AS BEGIN
DELETE FROM Contact WHERE ContactID = @ContactID
END