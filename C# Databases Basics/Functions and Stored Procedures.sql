--1.	Employees with Salary Above 35000
--Create stored procedure usp_GetEmployeesSalaryAbove35000 that returns all employees’ first and last names for whose salary is above 35000. 
CREATE PROC usp_GetEmployeesSalaryAbove35000
AS
SELECT FirstName [First Name], LastName [Last Name]
	FROM Employees
	WHERE Salary > 35000

GO
--2.	Employees with Salary Above Number
--Create stored procedure usp_GetEmployeesSalaryAboveNumber that accept a number (of type DECIMAL(18,4)) as parameter and returns all employees’ first and last names whose salary is above or equal to the given number. 
CREATE PROC usp_GetEmployeesSalaryAboveNumber @Salary DECIMAL(18,4)
AS
SELECT FirstName [First Name], LastName [Last Name]
	FROM Employees
	WHERE Salary >= @Salary
GO

--3.	Town Names Starting With
--Write a stored procedure usp_GetTownsStartingWith that accept string as parameter and returns all town names starting with that string. 
CREATE OR ALTER PROC usp_GetTownsStartingWith @StartString VARCHAR(50)
AS
SELECT Name
	FROM Towns
	WHERE Name LIKE @StartString + '%'
GO

--4.	Employees from Town
--Write a stored procedure usp_GetEmployeesFromTown that accepts town name as parameter and return the employees’ first and last name that live in the given town.
CREATE PROC usp_GetEmployeesFromTown @Town VARCHAR(50)
AS
SELECT e.FirstName, e.LastName
	FROM Employees e
	JOIN Addresses a ON a.AddressID = e.AddressID
	JOIN Towns t ON t.TownID = a.TownID
	WHERE t.Name = @Town
GO

--5.	Salary Level Function
--Write a function ufn_GetSalaryLevel(@salary DECIMAL(18,4)) that receives salary of an employee and returns the level of the salary.
--•	If salary is < 30000 return "Low"
--•	If salary is between 30000 and 50000 (inclusive) return "Average"
--•	If salary is > 50000 return "High"
CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4))
RETURNS VARCHAR(7)
AS
BEGIN
	RETURN
		CASE
			WHEN @salary < 30000 THEN 'Low'
			WHEN @salary <= 50000 THEN 'Average'
			ELSE 'High'
		END
END
GO
--6.	Employees by Salary Level
--Write a stored procedure usp_EmployeesBySalaryLevel that receive as parameter level of salary (low, average or high) and print the names of all employees that have given level of salary. You should use the function - "dbo.ufn_GetSalaryLevel(@Salary) ", which was part of the previous task, inside your "CREATE PROCEDURE …" query.
CREATE PROC usp_EmployeesBySalaryLevel(@level VARCHAR(7))
AS
SELECT FirstName, LastName
	FROM Employees
	WHERE dbo.ufn_GetSalaryLevel(Salary) = @level
GO
--7.	Define Function
--Define a function ufn_IsWordComprised(@setOfLetters, @word) that returns true or false depending on that if the word is a comprised of the given set of letters. 
CREATE FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(50) ,@word VARCHAR(50))
RETURNS BIT
AS BEGIN
DECLARE @index INT = 1;
	WHILE @index <= LEN(@word)
		BEGIN
		IF @setOfLetters NOT LIKE '%' + SUBSTRING(@word, @index, 1) + '%'
		RETURN 0
		SET @index += 1
		END
	RETURN 1
END

GO
--8.	* Delete Employees and Departments
--Write a procedure with the name usp_DeleteEmployeesFromDepartment (@departmentId INT) which deletes all Employees from a given department. Delete these departments from the Departments table too. Finally SELECT the number of employees from the given department. If the delete statements are correct the select query should return 0.
CREATE PROC usp_DeleteEmployeesFromDepartment (@departmentId INT)
AS

DECLARE @empIDsToBeDeleted TABLE
(
Id int
)

INSERT INTO @empIDsToBeDeleted
SELECT e.EmployeeID
FROM Employees AS e
WHERE e.DepartmentID = @departmentId

ALTER TABLE Departments
ALTER COLUMN ManagerID int NULL

DELETE FROM EmployeesProjects
WHERE EmployeeID IN (SELECT Id FROM @empIDsToBeDeleted)

UPDATE Employees
SET ManagerID = NULL
WHERE ManagerID IN (SELECT Id FROM @empIDsToBeDeleted)

UPDATE Departments
SET ManagerID = NULL
WHERE ManagerID IN (SELECT Id FROM @empIDsToBeDeleted)

DELETE FROM Employees
WHERE EmployeeID IN (SELECT Id FROM @empIDsToBeDeleted)

DELETE FROM Departments
WHERE DepartmentID = @departmentId 

SELECT COUNT(*) AS [Employees Count] FROM Employees AS e
JOIN Departments AS d
ON d.DepartmentID = e.DepartmentID
WHERE e.DepartmentID = @departmentId

GO
--9.	Find Full Name
--You are given a database schema with tables AccountHolders(Id (PK), FirstName, LastName, SSN) and Accounts(Id (PK), AccountHolderId (FK), Balance).  Write a stored procedure usp_GetHoldersFullName that selects the full names of all people. 
USE Bank

CREATE PROC usp_GetHoldersFullName
AS
SELECT FirstName + ' ' + LastName AS [Full Name]
	FROM AccountHolders

GO
--10.	People with Balance Higher Than
--Your task is to create a stored procedure usp_GetHoldersWithBalanceHigherThan that accepts a number as a parameter and returns all people who have more money in total of all their accounts than the supplied number. Order them by first name, then by last name
CREATE PROC usp_GetHoldersWithBalanceHigherThan @balance MONEY
AS
SELECT FirstName, LastName
	FROM
		(SELECT AccountHolderId, SUM(Balance) sum
		FROM Accounts a
		GROUP BY a.AccountHolderId) t
	JOIN AccountHolders ah ON ah.Id = t.AccountHolderId
	WHERE sum > @balance
	ORDER BY FirstName, LastName

GO
--11. Future Value Function
--Your task is to create a function ufn_CalculateFutureValue that accepts as parameters – sum (decimal), yearly interest rate (float) and number of years(int). It should calculate and return the future value of the initial sum rounded to the fourth digit after the decimal delimiter. Using the following formula:
--FV=I×(〖(1+R)〗^T)
--	I – Initial sum
--	R – Yearly interest rate
--	T – Number of years
CREATE FUNCTION ufn_CalculateFutureValue (@sum DECIMAL(18,4), @yearlyInterestRate FLOAT, @years INT)
RETURNS DECIMAL(18,4)
AS BEGIN
RETURN @sum * POWER(1 + @yearlyInterestRate, @years)
END

GO
--12.	Calculating Interest
--Your task is to create a stored procedure usp_CalculateFutureValueForAccount that uses the function from the previous problem to give an interest to a person's account for 5 years, along with information about his/her account id, first name, last name and current balance as it is shown in the example below. It should take the AccountId and the interest rate as parameters. Again you are provided with “dbo.ufn_CalculateFutureValue” function which was part of the previous task.
CREATE PROC usp_CalculateFutureValueForAccount @accountId INT, @yearlyInterestRate FLOAT
AS
SELECT	a.Id AS [Account Id], ah.FirstName, ah.LastName, a.Balance,
		dbo.ufn_CalculateFutureValue(a.Balance, @yearlyInterestRate, 5) AS [Balance in 5 years]
	FROM Accounts a
	JOIN AccountHolders ah ON ah.Id = a.AccountHolderId
	WHERE a.Id = @accountId

GO
--13.	*Scalar Function: Cash in User Games Odd Rows
--Create a function ufn_CashInUsersGames that sums the cash of odd rows. Rows must be ordered by cash in descending order. The function should take a game name as a parameter and return the result as table. Submit only your function in.
--Execute the function over the following game names, ordered exactly like: "Love in a mist".
CREATE FUNCTION ufn_CashInUsersGames(@gameName NVARCHAR(50))
RETURNS TABLE
AS RETURN
SELECT SUM(t.Cash) AS SumCash
	FROM
		(SELECT g.Name, ug.Cash, ROW_NUMBER() OVER (ORDER BY Cash DESC) AS row
			FROM UsersGames ug
		JOIN Games g ON g.Id = ug.GameId
		WHERE g.Name = @gameName) t
	WHERE row % 2 != 0