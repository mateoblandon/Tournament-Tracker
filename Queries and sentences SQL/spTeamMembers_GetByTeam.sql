CREATE PROCEDURE [dbo].[spTeamMembers_GetByTeam]
	@TeamId int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT People.* from TeamMembers inner join People on TeamMembers.PersonId = People.id
	where TeamMembers.TeamId = @TeamId;
END
GO