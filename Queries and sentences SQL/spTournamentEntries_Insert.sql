CREATE PROCEDURE [dbo].[spTournamentEntries_Insert]
	@TournamentId int, @TeamId int, @id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;
	insert into TournamentEntries (TournamentId, TeamId) values (@TournamentId, @TeamId);
	select @id = SCOPE_IDENTITY();
END
GO