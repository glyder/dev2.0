
CREATE PROCEDURE[dbo].[UserSessions_Insert] 
	@UserID int,
	@SessionAttribute varchar(max)
AS
BEGIN 
	INSERT INTO [dbo].[tblUserSessions] 
				([UserID],[SessionAttribute])
		 VALUES (@UserID, @SessionAttribute)
END
