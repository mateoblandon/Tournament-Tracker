CREATE PROCEDURE [dbo].[spTeam_GetByTournament]
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;
	select * from Teams inner join TournamentEntries on Teams.id = TournamentEntries.TeamId
where TournamentEntries.TournamentId = @TournamentId;
END
GO