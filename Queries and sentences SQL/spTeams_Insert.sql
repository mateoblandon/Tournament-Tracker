CREATE PROCEDURE [dbo].[spTeams_Insert] 
	@TeamName nvarchar(100),
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;
	insert into [dbo].[Teams] (TeamName) values (@TeamName);
	select @id = SCOPE_IDENTITY();
END
GO