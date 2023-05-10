create procedure spPrizes_GetByTournament
@TournamentId int
as
select * from Prizes inner join TournamentPrizes on Prizes.id = TournamentPrizes.PrizeId
where TournamentPrizes.TournamentId = @TournamentId;