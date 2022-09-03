CREATE TABLE [dbo].[TypeOfService] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (100) NOT NULL,
    [isDeleted] BIT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

