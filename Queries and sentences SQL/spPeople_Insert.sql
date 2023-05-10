CREATE PROCEDURE [dbo].[spPeople_Insert]
	@FirstName nvarchar(100),
	@LastName nvarchar(100),
	@EmailAddress nvarchar(200),
	@CellphoneNumber nvarchar(50),
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;
	insert into [dbo].[People] (FirstName, LastName, EmailAddress, CellphoneNumber) values (@FirstName, @LastName, @EmailAddress, @CellphoneNumber);
	select @id = SCOPE_IDENTITY();
END
GO