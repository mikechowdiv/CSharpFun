

EXEC GetEmployeeDetails 1

CREATE PROCEDURE GetEmployeeDetails
	@businessEntityId int
AS 

SET NOCOUNT ON


SELECT * FROM HumanResources.Employee E
	JOIN Person.Person P ON E.BusinessEntityID = P.BusinessEntityID AND P.PersonType = 'EM'
	JOIN HumanResources.EmployeeDepartmentHistory EH ON E.BusinessEntityID = EH.BusinessEntityID
	JOIN HumanResources.Department D ON D.DepartmentID = EH.DepartmentID
WHERE 
	E.BusinessEntityID = @businessEntityId