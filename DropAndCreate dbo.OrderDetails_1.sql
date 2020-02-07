USE [Shop]
GO

/****** Object: Table [dbo].[OrderDetails] Script Date: 2020-02-03 10:42:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[OrderDetails];


GO
CREATE TABLE [dbo].[OrderDetails] (
    [OrderDetailsId]      INT             IDENTITY (1, 1) NOT NULL,
   
    [ProductId]           INT             NOT NULL,
    [Amount]              INT             NOT NULL,
    [Price]               DECIMAL (18, 2) NOT NULL,
    [ordersOrderId]       INT             NULL,
    [ShoppingCartItemsId] INT             NOT NULL
);


