--1./14. Create Table Logs
--Create a table – Logs (LogId, AccountId, OldSum, NewSum). Add a trigger to the Accounts table that enters a new entry into the Logs table every time the sum on an account changes. Submit only the query that creates the trigger.


CREATE TABLE Logs
(
	LogId INT PRIMARY KEY IDENTITY,
	AccountId INT REFERENCES Accounts(Id),
	OldSum MONEY,
	NewSum MONEY
)
GO

CREATE TRIGGER tr_LogOnChangeSum
ON Accounts FOR UPDATE
AS
	INSERT INTO Logs(AccountId, OldSum, NewSum)
		SELECT i.Id, d.Balance, i.Balance 
			FROM inserted i
		JOIN deleted d ON d.Id = i.Id
		WHERE d.Balance != i.Balance
GO

--2./15.	Create Table Emails
--Create another table – NotificationEmails(Id, Recipient, Subject, Body). Add a trigger to logs table and create new email whenever new record is inserted in logs table. The following data is required to be filled for each email:
--•	Recipient – AccountId
--•	Subject – "Balance change for account: {AccountId}"
--•	Body - "On {date} your balance was changed from {old} to {new}."


CREATE TABLE NotificationEmails
(
	Id INT PRIMARY KEY IDENTITY,
	Recipient INT REFERENCES Accounts(Id),
	Subject VARCHAR(50),
	Body VARCHAR(200)
)
GO

CREATE TRIGGER tr_CreateNotificationEmails ON Logs
FOR INSERT
AS
	INSERT INTO NotificationEmails(Recipient, Subject, Body)
		SELECT	AccountId, 
				CONCAT('Balance change for account: ', AccountId),
				CONCAT('On ', CONVERT(VARCHAR, GETDATE(), 0), ' your balance was changed from ', OldSum, ' to ', NewSum, '.')
				FROM inserted

GO

--3./16.	Deposit Money
--Add stored procedure usp_DepositMoney (AccountId, MoneyAmount) that deposits money to an existing account. Make sure to guarantee valid positive MoneyAmount with precision up to fourth sign after decimal point. The procedure should produce exact results working with the specified precision.

CREATE PROCEDURE usp_DepositMoney(@AccountId INT, @MoneyAmount MONEY)
AS
	IF @MoneyAmount > 0
	BEGIN
	UPDATE Accounts
	SET Balance += @MoneyAmount
	WHERE Id = @AccountId
	END
	ELSE
	THROW 50001, 'Invalid MoneyAmount', 1

GO

--4./17.	Withdraw Money
--Add stored procedure usp_WithdrawMoney (AccountId, MoneyAmount) that withdraws money from an existing account. Make sure to guarantee valid positive MoneyAmount with precision up to fourth sign after decimal point. The procedure should produce exact results working with the specified precision.

CREATE PROC usp_WithdrawMoney (@AccountId INT, @MoneyAmount MONEY)
AS
DECLARE @CurrentBalance MONEY = (SELECT Balance FROM Accounts WHERE Id = @AccountId)
	IF @MoneyAmount > 0 AND @CurrentBalance >= @MoneyAmount
	BEGIN
	UPDATE Accounts
	SET Balance -= @MoneyAmount
	WHERE Id = @AccountId
	END

GO

--5./18.	Money Transfer
--Write stored procedure usp_TransferMoney(SenderId, ReceiverId, Amount) that transfers money from one account to another. Make sure to guarantee valid positive MoneyAmount with precision up to fourth sign after decimal point. Make sure that the whole procedure passes without errors and if error occurs make no change in the database. You can use both: "usp_DepositMoney", "usp_WithdrawMoney" (look at previous two problems about those procedures). 

CREATE PROC usp_TransferMoney(@SenderId INT, @ReceiverId INT, @Amount MONEY)
AS
IF @Amount > 0
BEGIN
EXEC usp_WithdrawMoney @SenderId, @Amount
EXEC usp_DepositMoney @ReceiverId, @Amount
END

GO

--6./19.	Trigger
--1. Users should not be allowed to buy items with higher level than their level. Create a trigger that restricts that. The trigger should prevent inserting items that are above specified level while allowing all others to be inserted.
--2. Add bonus cash of 50000 to users: baleremuda, loosenoise, inguinalself, buildingdeltoid, monoxidecos in the game "Bali".
--3. There are two groups of items that you must buy for the above users. The first are items with id between 251 and 299 including. Second group are items with id between 501 and 539 including.
--Take off cash from each user for the bought items.
--4. Select all users in the current game ("Bali") with their items. Display username, game name, cash and item name. Sort the result by username alphabetically, then by item name alphabetically. 




--7./20.	*Massive Shopping
--1.	User Stamat in Safflower game wants to buy some items. He likes all items from Level 11 to 12 as well as all items from Level 19 to 21. As it is a bulk operation you have to use transactions. 
--2.	A transaction is the operation of taking out the cash from the user in the current game as well as adding up the items. 
--3.	Write transactions for each level range. If anything goes wrong turn back the changes inside of the transaction.
--4.	Extract all of Stamat’s item names in the given game sorted by name alphabetically
BEGIN TRANSACTION
DECLARE @UsersGamesId INT = (SELECT Id FROM UsersGames
	WHERE	UserId = (SELECT Id FROM Users WHERE Username = 'Stamat') AND
			GameId = (SELECT Id FROM Games WHERE Name = 'Safflower'))
	DECLARE @Counter INT = 1;
	WHILE @Counter <= (SELECT COUNT(*) FROM (SELECT Id FROM Items WHERE MinLevel IN (11,12)) t)
	BEGIN
	DECLARE @CurrentItem INT = 
		(SELECT t.Id FROM
			(SELECT t1.Id,ROW_NUMBER() OVER (ORDER BY Id) row 
				FROM 
				(SELECT Id FROM Items WHERE MinLevel IN (11,12)) t1) t
					WHERE t.row = @Counter);

		BEGIN TRY
			DECLARE @RequiredLevel INT = (SELECT MinLevel FROM Items WHERE Id = @CurrentItem);
			DECLARE @UserLevel INT = (SELECT Level FROM UsersGames WHERE Id = @UsersGamesId);
			DECLARE @Price INT = (SELECT Price FROM Items WHERE Id = @CurrentItem);
			DECLARE @Cash MONEY = (SELECT Cash FROM UsersGames WHERE Id = @UsersGamesId);

		IF @RequiredLevel <= @UserLevel AND @Cash >= @Price
			BEGIN
				INSERT INTO UserGameItems(ItemId, UserGameId)
				VALUES(@CurrentItem, @UsersGamesId)

				UPDATE UsersGames
				SET Cash -= @Price
				WHERE Id = @UsersGamesId
			END
			ELSE 
			BEGIN
				ROLLBACK
				RETURN
			END
		END TRY
		BEGIN CATCH
			ROLLBACK
			RETURN
		END CATCH
	SET @Counter += 1;
	END
COMMIT

BEGIN TRANSACTION
DECLARE @UsersGamesId INT = (SELECT Id FROM UsersGames
	WHERE	UserId = (SELECT Id FROM Users WHERE Username = 'Stamat') AND
			GameId = (SELECT Id FROM Games WHERE Name = 'Safflower'))
	DECLARE @Counter INT = 1;
	WHILE @Counter <= (SELECT COUNT(*) FROM (SELECT Id FROM Items WHERE MinLevel IN (19,20,21)) t)
	BEGIN
	DECLARE @CurrentItem INT = 
		(SELECT t.Id FROM
			(SELECT t1.Id,ROW_NUMBER() OVER (ORDER BY Id) row 
				FROM 
				(SELECT Id FROM Items WHERE MinLevel IN (19,20,21)) t1) t
					WHERE t.row = @Counter);

		BEGIN TRY
			DECLARE @RequiredLevel INT = (SELECT MinLevel FROM Items WHERE Id = @CurrentItem);
			DECLARE @UserLevel INT = (SELECT Level FROM UsersGames WHERE Id = @UsersGamesId);
			DECLARE @Price INT = (SELECT Price FROM Items WHERE Id = @CurrentItem);
			DECLARE @Cash MONEY = (SELECT Cash FROM UsersGames WHERE Id = @UsersGamesId);

		IF @RequiredLevel <= @UserLevel AND @Cash >= @Price
			BEGIN
				INSERT INTO UserGameItems(ItemId, UserGameId)
				VALUES(@CurrentItem, @UsersGamesId)

				UPDATE UsersGames
				SET Cash -= @Price
				WHERE Id = @UsersGamesId
			END
			ELSE 
			BEGIN
				ROLLBACK
				RETURN
			END
		END TRY
		BEGIN CATCH
			ROLLBACK
			RETURN
		END CATCH
	SET @Counter += 1;
	END
COMMIT

GO

SELECT i.Name FROM UsersGames ug
JOIN Games g ON g.Id = ug.GameId
JOIN Users u ON u.Id = ug.UserId
JOIN UserGameItems ugi ON ugi.UserGameId = ug.Id
JOIN Items i ON i.Id = ugi.ItemId
WHERE u.Username = 'Stamat' AND g.Name = 'Safflower'
ORDER BY i.Name
GO
--8./21.	Employees with Three Projects
--Create a procedure usp_AssignProject(@emloyeeId, @projectID) that assigns projects to employee. If the employee has more than 3 project throw exception and rollback the changes. The exception message must be: "The employee has too many projects!" with Severity = 16, State = 1.
SELECT * FROM EmployeesProjects
GO

CREATE PROC usp_AssignProject(@emloyeeId INT, @projectID INT)
AS
DECLARE @CountOfProjects INT = (SELECT COUNT(*) FROM EmployeesProjects WHERE EmployeeID = @emloyeeId);
IF @CountOfProjects <= 3
	BEGIN
	INSERT INTO EmployeesProjects
	VALUES (@emloyeeId, @projectID)
	END
ELSE
THROW 50001, 'The employee has too many projects!', 1

EXEC usp_AssignProject 43,5

GO
--9./22.	Delete Employees
--Create a table Deleted_Employees(EmployeeId PK, FirstName, LastName, MiddleName, JobTitle, DepartmentId, Salary) that will hold information about fired (deleted) employees from the Employees table. Add a trigger to Employees table that inserts the corresponding information about the deleted records in Deleted_Employees.
SELECT * FROM Employees


CREATE TABLE Deleted_Employees
(
EmployeeId INT PRIMARY KEY,
FirstName VARCHAR(50) NOT NULL,
LastName VARCHAR (50) NOT NULL,
MiddleName VARCHAR (50),
JobTitle VARCHAR (50) NOT NULL,
DepartmentId INT NOT NULL,
Salary MONEY NOT NULL
) 

GO
CREATE TRIGGER OnDeletingEmploy ON Employees
FOR DELETE
AS
INSERT INTO Deleted_Employees(EmployeeId, FirstName, LastName, MiddleName, JobTitle, DepartmentId, Salary)
SELECT EmployeeID, FirstName, LastName, MiddleName, JobTitle, DepartmentID, Salary FROM deleted

GO
DELETE Employees
WHERE EmployeeID = 2

SELECT * FROM Deleted_Employees