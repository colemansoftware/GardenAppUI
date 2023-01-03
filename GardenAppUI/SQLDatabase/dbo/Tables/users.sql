CREATE TABLE [dbo].[users] (
    [user_id]     INT           IDENTITY (1, 1) NOT NULL,
    [username]    VARCHAR (255) NOT NULL,
    [password]    VARCHAR (255) NOT NULL,
    [email]       VARCHAR (50)  NOT NULL,
    [phoneNumber] VARCHAR (10)  NOT NULL,
    PRIMARY KEY CLUSTERED ([user_id] ASC)
);



