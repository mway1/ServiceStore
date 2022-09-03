CREATE TABLE [dbo].[Service] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (100) NOT NULL,
    [Description] TEXT          NOT NULL,
    [TypeId]      INT           NOT NULL,
    [Price]       DECIMAL (18)  NOT NULL,
    [isDeleted]   BIT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([TypeId]) REFERENCES [dbo].[TypeOfService] ([Id])
);

