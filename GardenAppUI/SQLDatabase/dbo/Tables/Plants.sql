CREATE TABLE [dbo].[plants] (
    [plant_id]             INT           IDENTITY (1, 1) NOT NULL,
    [garden_id]            INT           NULL,
    [plantName]            VARCHAR (255) NOT NULL,
    [plantDescription]     VARCHAR (255) NOT NULL,
    [sunlightTime]         VARCHAR (255) NOT NULL,
    [species]              VARCHAR (255) NOT NULL,
    [watering_schedule]    VARCHAR (255) NOT NULL,
    [fertilizing_schedule] VARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([plant_id] ASC),
    FOREIGN KEY ([garden_id]) REFERENCES [dbo].[gardens] ([garden_id])
);



