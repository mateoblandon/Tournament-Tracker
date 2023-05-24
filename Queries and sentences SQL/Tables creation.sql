CREATE TABLE Prizes (
    id int IDENTITY(1,1) NOT NULL,
    PlaceNumber int NOT NULL,
    PlaceName nvarchar(50) NOT NULL,
	PrizeAmount	 money NOT NULL,
	PrizePercentage float NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE People (
    id int IDENTITY(1,1) NOT NULL,
    FirstName nvarchar(100) NOT NULL,
    LastName nvarchar(100) NOT NULL,
	EmailAddress nvarchar(200) NOT NULL,
	CellphoneNumber nvarchar(50) NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE Teams (
    id int IDENTITY(1,1) NOT NULL,
    TeamName nvarchar(100) NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE TeamMembers (
    id int IDENTITY(1,1) NOT NULL,
    TeamId int NOT NULL,
	PersonId int NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE Matchups (
    id int IDENTITY(1,1) NOT NULL,
	TournamentId int NOT NULL,
    WinnerId int NULL,
	MatchupRound int NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (TournamentId) REFERENCES [dbo].[Tournaments] (id),
	FOREIGN KEY (WinnerId) REFERENCES [dbo].[Teams] (id)
);

CREATE TABLE MatchupEntries(
    id int IDENTITY(1,1) NOT NULL,
    MatchupId int NOT NULL,
	ParentMatchupId int NULL,
	TeamCompetingId int NULL,
	Score float NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (MatchupId) REFERENCES [dbo].[Matchups] (id),
	FOREIGN KEY (ParentMatchupId) REFERENCES [dbo].[Matchups] (id),
	FOREIGN KEY (TeamCompetingId) REFERENCES [dbo].[Teams] (id)
);

CREATE TABLE TournamentPrizes (
    id int IDENTITY(1,1) NOT NULL,
    TournamentId int NOT NULL,
	PrizeId int NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE TournamentEntries (
    id int IDENTITY(1,1) NOT NULL,
    TournamentId int NOT NULL,
	TeamId int NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE Tournaments (
    id int IDENTITY(1,1) NOT NULL,
    TournamentName nvarchar(100) NOT NULL,
	EntryFee money NOT NULL,
	PRIMARY KEY (id)
);
