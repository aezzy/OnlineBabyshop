USE [Shop]
GO

/****** Object: Table [dbo].[Orders] Script Date: 2020-02-03 10:45:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Orders];


GO
CREATE TABLE [dbo].[Orders] (
    [OrderId]             INT             IDENTITY (1, 1) NOT NULL,
    [FirstName]           NVARCHAR (50)   NOT NULL,
    [LastName]            NVARCHAR (50)   NOT NULL,
    [AddressLine1]        NVARCHAR (100)  NOT NULL,
    [AddressLine2]        NVARCHAR (MAX)  NULL,
    [ZipCode]             NVARCHAR (10)   NOT NULL,
    [State]               NVARCHAR (10)   NULL,
    [Country]             NVARCHAR (50)   NOT NULL,
    [PhoneNumber]         NVARCHAR (25)   NOT NULL,
    [Email]               NVARCHAR (50)   NOT NULL,
    [OrderTotal]          DECIMAL (18, 2) NOT NULL,
    [OrderPlaced]         DATETIME2 (7)   NOT NULL,
    [OrderDetailsId]      INT             NOT NULL
   
);


