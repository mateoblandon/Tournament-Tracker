create procedure [dbo].[spTournaments_GetAll]
as
select * from  Tournaments
where Active = 1;