CREATE TABLE [dbo].[Lead] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [LeadId]       VARCHAR (50) NOT NULL,
    [SubStartDate] DATE         NOT NULL,
    [SubEndDate]   DATE         NOT NULL,
    [ServiceId]    INT          NOT NULL,
    [isDeleted]    BIT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([ServiceId]) REFERENCES [dbo].[Service] ([Id])
);

