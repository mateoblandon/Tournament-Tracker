CREATE PROCEDURE [dbo].[spMatchupEntries_GetByMatchup]
	@MatchupEntry int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * from MatchupEntries
	where MatchupId = @MatchupEntry
END
GO