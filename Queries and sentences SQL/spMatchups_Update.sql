CREATE PROCEDURE [dbo].[spMatchups_Update]
	@id int,
	@WinnerId int
AS
BEGIN
	SET NOCOUNT ON;
	update Matchups
	set WinnerId = @WinnerId
	where id = @id;
END
GO