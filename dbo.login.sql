CREATE TABLE [dbo].[login] (
    [Id]     INT          NOT NULL,
    [adname] VARCHAR (50) NOT NULL,
    [adpass] VARCHAR (50) NOT NULL,
    [image] IMAGE NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

