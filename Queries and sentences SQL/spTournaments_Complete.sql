CREATE PROCEDURE [dbo].[spTournaments_Complete]
	@id int
AS
BEGIN
	SET NOCOUNT ON;
	update Tournaments set Active = 0
	where id = @id;
END
GO
