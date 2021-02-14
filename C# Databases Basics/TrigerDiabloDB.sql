USE Diablo
SELECT u.Username, g.Name, ug.Cash, i.Name, u.Id FROM UsersGames ug
JOIN Games g ON g.Id = ug.GameId
JOIN Users u ON u.Id = ug.UserId
JOIN UserGameItems ugi ON ugi.UserGameId = ug.Id
JOIN Items i ON i.Id = ugi.ItemId
WHERE g.Name = 'Bali'
ORDER BY u.Username, i.Name

SELECT * FROM Users

SELECT * FROM UserGameItems
WHERE UserGameId IN (SELECT UserId FROM UsersGames
WHERE GameId = 212)

SELECT * FROM UsersGames
WHERE UserId = 61 AND GameId = 212

UPDATE UsersGames
SET Cash += 50000
	FROM UsersGames ug
	JOIN Games g ON g.Id = ug.GameId
	WHERE g.Name = 'Bali'

GO

CREATE OR ALTER PROC usp_BuyItemForUser (@Item INT, @User NVARCHAR(50), @GameName NVARCHAR(50) = 'Bali')
AS
DECLARE @UsersGamesId INT = (SELECT Id FROM UsersGames
	WHERE	UserId = (SELECT Id FROM Users WHERE Username = @User) AND
			GameId = (SELECT Id FROM Games WHERE Name = @GameName))
BEGIN TRY
INSERT INTO UserGameItems(ItemId, UserGameId)
	VALUES(@Item, @UsersGamesId)
END TRY
BEGIN CATCH
RETURN
END CATCH

GO

CREATE OR ALTER TRIGGER tr_AllowedToBye ON UserGameItems
INSTEAD OF INSERT
AS
DECLARE @RequiredLevel INT = (SELECT MinLevel FROM Items
	WHERE Id = (SELECT ItemId FROM inserted));
DECLARE @UserLevel INT = (SELECT Level FROM UsersGames
	WHERE Id = (SELECT UserGameId FROM inserted));
DECLARE @Price INT = (SELECT Price FROM Items
	WHERE Id = (SELECT ItemId FROM inserted));
DECLARE @Cash MONEY = (SELECT Cash FROM UsersGames WHERE Id = (SELECT UserGameId FROM inserted));

IF @RequiredLevel <= @UserLevel AND @Cash >= @Price
	BEGIN
	INSERT INTO UserGameItems(ItemId, UserGameId)
	VALUES((SELECT ItemId FROM inserted), (SELECT UserGameId FROM inserted))
	UPDATE UsersGames
	SET Cash -= @Price
	WHERE Id = (SELECT UserGameId FROM inserted)
	END

GO
DECLARE @itemId INT = 451;
WHILE (@itemId <= 480)
	BEGIN
	EXEC usp_BuyItemForUser @itemId,'swingbark', 'Toronto';
	SET @itemId += 1;
	END
GO
DECLARE @itemId INT = 501;
WHILE (@itemId <= 539)
	BEGIN
	EXEC usp_BuyItemForUser @itemId,'buildingdeltoid';
	SET @itemId += 1;
	END
GO
