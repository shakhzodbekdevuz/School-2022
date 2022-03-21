CREATE TABLE [dbo].[Student] (
    [stId]      INT          NOT NULL IDENTITY,
    [stName]    VARCHAR (50) NOT NULL,
    [stSurname] VARCHAR (50) NOT NULL,
    [stGender]  VARCHAR (50) NOT NULL,
    [stDay]     VARCHAR (50) NOT NULL,
    [stPhone]   VARCHAR (50) NOT NULL,
    [stVaqti]   VARCHAR (50) NOT NULL,
    [stSubject] VARCHAR (50) NOT NULL,
    [stregistr] DATE         NOT NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([stId] ASC)
);

