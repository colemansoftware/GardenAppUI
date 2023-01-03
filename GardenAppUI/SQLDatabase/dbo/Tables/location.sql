CREATE TABLE [dbo].[location] (
    [location_id] INT           IDENTITY (1, 1) NOT NULL,
    [user_id]     INT           NOT NULL,
    [address]     VARCHAR (255) NOT NULL,
    [city]        VARCHAR (50)  NOT NULL,
    [state]       VARCHAR (50)  NOT NULL,
    FOREIGN KEY ([user_id]) REFERENCES [dbo].[users] ([user_id])
);

