CREATE TABLE [dbo].[Tara] (
    [ID]        INT            IDENTITY (1, 1) NOT NULL,
    [Nume]      NVARCHAR (MAX) NOT NULL,
    [Continent] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Tara] PRIMARY KEY CLUSTERED ([ID] ASC)
);

