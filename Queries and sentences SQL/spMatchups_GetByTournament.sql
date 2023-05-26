CREATE PROCEDURE [dbo].[spMatchups_GetByTournament] 
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * from Matchups
	where Matchups.TournamentId = @TournamentId;
END
GO