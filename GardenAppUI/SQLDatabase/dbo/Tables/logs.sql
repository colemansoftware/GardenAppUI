CREATE TABLE [dbo].[logs] (
    [log_id]                INT  IDENTITY (1, 1) NOT NULL,
    [plant_id]              INT  NOT NULL,
    [date]                  DATE NOT NULL,
    [watering_completed]    BIT  NOT NULL,
    [fertilizing_completed] BIT  NOT NULL,
    PRIMARY KEY CLUSTERED ([log_id] ASC),
    FOREIGN KEY ([plant_id]) REFERENCES [dbo].[Plants] ([plant_id])
);

