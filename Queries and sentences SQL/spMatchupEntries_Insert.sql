CREATE PROCEDURE [dbo].[spMatchupEntries_Insert]
	@MatchupId int,
	@ParentMatchupId int,
	@teamCompetingId int,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;
	insert into [dbo].[MatchupEntries] (MatchupId, ParentMatchupId, TeamCompetingId) values (@MatchupId, @ParentMatchupId, @teamCompetingId);
	select @id = SCOPE_IDENTITY();
END
GO
