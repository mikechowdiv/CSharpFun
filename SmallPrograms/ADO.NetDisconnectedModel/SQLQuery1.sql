USE PSDB

CREATE TABLE Employees
(
	Empno int PRIMARY KEY,
	Ename varchar(50),
	Salary money,
	Hiredate DateTime
)

SELECT * FROM Employees