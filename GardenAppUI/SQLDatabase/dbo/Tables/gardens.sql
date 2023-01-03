CREATE TABLE [dbo].[gardens] (
    [garden_id]                 INT           IDENTITY (1, 1) NOT NULL,
    [user_id]                   INT           NOT NULL,
    [gardenName]                VARCHAR (255) NOT NULL,
    [gardenLocationDescription] VARCHAR (255) NOT NULL,
    [isOutside]                 BIT           NOT NULL,
    [isGreenhouse]              BIT           NOT NULL,
    [gardenSunlightHours]       INT           NOT NULL,
    [isRaisedGarden]            BIT           NOT NULL,
    [isPotted]                  BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([garden_id] ASC),
    FOREIGN KEY ([user_id]) REFERENCES [dbo].[users] ([user_id])
);



