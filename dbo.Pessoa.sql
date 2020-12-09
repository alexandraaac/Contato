CREATE TABLE [dbo].[Pessoa] (
    [ContatoID] INT        IDENTITY (1, 1) NOT NULL,
    [Nome]      NCHAR (10) NOT NULL,
    CONSTRAINT [PK_Pessoa] PRIMARY KEY CLUSTERED ([ContatoID])
);

