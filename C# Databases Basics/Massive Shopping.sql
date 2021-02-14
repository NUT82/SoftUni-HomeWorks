
SELECT i.Name FROM UsersGames ug
JOIN Games g ON g.Id = ug.GameId
JOIN Users u ON u.Id = ug.UserId
JOIN UserGameItems ugi ON ugi.UserGameId = ug.Id
JOIN Items i ON i.Id = ugi.ItemId
WHERE u.Username = 'Stamat' AND g.Name = 'Safflower'
ORDER BY i.Name
GO
--RETURN All Id of Item from selected MinLevel
CREATE OR ALTER FUNCTION ufc_GetItemsTableForItemLevel (@ItemLevel INT)
RETURNS TABLE
AS
RETURN
SELECT Id FROM Items WHERE MinLevel IN (11,12)
GO

--create transaction
CREATE OR ALTER PROC usp_BuyItemsFromLevelForUser (@ItemLevel INT, @User NVARCHAR(50) = 'Stamat', @GameName NVARCHAR(50) = 'Safflower')
AS
BEGIN TRANSACTION
DECLARE @UsersGamesId INT = (SELECT Id FROM UsersGames
	WHERE	UserId = (SELECT Id FROM Users WHERE Username = 'Stamat') AND
			GameId = (SELECT Id FROM Games WHERE Name = 'Safflower'))
	DECLARE @Counter INT = 1;
	WHILE @Counter <= (SELECT COUNT(*) FROM (SELECT Id FROM Items WHERE MinLevel IN (11,12,19,20,21)) t)
	BEGIN
	DECLARE @CurrentItem INT = 
		(SELECT t.Id FROM
			(SELECT t1.Id,ROW_NUMBER() OVER (ORDER BY Id) row 
				FROM 
				(SELECT Id FROM Items WHERE MinLevel IN (11,12,19,20,21)) t1) t
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

EXEC usp_BuyItemsFromLevelForUser 11
EXEC usp_BuyItemsFromLevelForUser 12
EXEC usp_BuyItemsFromLevelForUser 19
EXEC usp_BuyItemsFromLevelForUser 20
EXEC usp_BuyItemsFromLevelForUser 21

SELECT i.Name FROM UsersGames ug
JOIN Games g ON g.Id = ug.GameId
JOIN Users u ON u.Id = ug.UserId
JOIN UserGameItems ugi ON ugi.UserGameId = ug.Id
JOIN Items i ON i.Id = ugi.ItemId
WHERE u.Username = 'Stamat' AND g.Name = 'Safflower'
ORDER BY i.Name
