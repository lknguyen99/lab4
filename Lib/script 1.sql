USE [QLK]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 08/09/2016 17:21:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[UnitID] [nvarchar](20) NOT NULL,
	[UnitName] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
	[IsDeleted] [bit] NULL,
	[CreateDate] [datetime] NOT NULL,
	[CreateUser] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[UpdateUser] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED 
(
	[UnitID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Store]    Script Date: 08/09/2016 17:21:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Store](
	[StoreID] [int] NOT NULL,
	[StoreName] [nvarchar](200) NULL,
	[Address] [nvarchar](150) NULL,
	[IsDeleted] [bit] NULL,
	[CreateDate] [datetime] NOT NULL,
	[CreateUser] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[UpdateUser] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Store] PRIMARY KEY CLUSTERED 
(
	[StoreID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provider]    Script Date: 08/09/2016 17:21:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provider](
	[ProviderID] [nvarchar](20) NOT NULL,
	[ProviderName] [nvarchar](50) NULL,
	[Address] [nvarchar](250) NULL,
	[Mobile] [nvarchar](250) NULL,
	[IsDeleted] [bit] NULL,
	[CreateDate] [datetime] NOT NULL,
	[CreateUser] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[UpdateUser] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Provider] PRIMARY KEY CLUSTERED 
(
	[ProviderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Promotion]    Script Date: 08/09/2016 17:21:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Promotion](
	[PromotionID] [int] NOT NULL,
	[InOutKBN] [int] NOT NULL,
	[ProductID] [nvarchar](20) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[QuantityBuy] [int] NULL,
	[QuantityOffer] [int] NULL,
	[IsDeleted] [bit] NULL,
	[CreateUser] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[UpdateUser] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Promotion_1] PRIMARY KEY CLUSTERED 
(
	[PromotionID] ASC,
	[InOutKBN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 08/09/2016 17:21:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [nvarchar](20) NOT NULL,
	[ProductName] [nvarchar](100) NULL,
	[UnitID] [nvarchar](20) NULL,
	[UnitName] [nvarchar](50) NULL,
	[ProviderID] [nvarchar](20) NULL,
	[ProviderName] [nvarchar](50) NULL,
	[BuyPriceCurrent] [money] NULL,
	[BuyPricePrevious] [money] NULL,
	[BuyPriceAverage] [money] NULL,
	[SellPrice] [money] NULL,
	[ExportBuy] [int] NULL,
	[ExportOffer] [int] NULL,
	[IsDeleted] [bit] NULL,
	[CreateDate] [datetime] NOT NULL,
	[CreateUser] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[UpdateUser] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 08/09/2016 17:21:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[InvoiceNo] [nvarchar](20) NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[DeliveryDate] [datetime] NOT NULL,
	[InOutKbn] [int] NULL,
	[StoreID] [int] NOT NULL,
	[Amount] [money] NULL,
	[Discount] [float] NULL,
	[TotalAmount] [money] NULL,
	[CustomerID] [nvarchar](20) NULL,
	[CustomerName] [nvarchar](50) NULL,
	[EmployeeID] [nvarchar](20) NULL,
	[Note] [nvarchar](250) NULL,
	[IsDeleted] [bit] NULL,
	[CreateDate] [datetime] NOT NULL,
	[CreateUser] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[UpdateUser] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[InvoiceNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InventoryHistory]    Script Date: 08/09/2016 17:21:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InventoryHistory](
	[InvoiceNo] [nvarchar](20) NOT NULL,
	[StoreID] [int] NOT NULL,
	[InventoryID] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[DeliveryDate] [datetime] NOT NULL,
	[ProductID] [nvarchar](20) NOT NULL,
	[ProductName] [nvarchar](100) NULL,
	[InOutKBN] [int] NOT NULL,
	[UnitID] [nvarchar](20) NULL,
	[UnitName] [nvarchar](50) NULL,
	[Quantity] [decimal](18, 0) NULL,
	[QuantityOffer] [decimal](18, 0) NULL,
	[BuyPrice] [money] NULL,
	[SellPrice] [money] NULL,
	[AmountBuy] [money] NULL,
	[AmountSell] [money] NULL,
	[IsDeleted] [bit] NULL,
	[CreateDate] [datetime] NOT NULL,
	[CreateUser] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[UpdateUser] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_InventoryHistory_1] PRIMARY KEY CLUSTERED 
(
	[InvoiceNo] ASC,
	[InventoryID] ASC,
	[StoreID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 08/09/2016 17:21:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[ID] [int] NOT NULL,
	[StoreID] [int] NOT NULL,
	[DeliveryDate] [datetime] NOT NULL,
	[ProductID] [nvarchar](20) NOT NULL,
	[ProductName] [nvarchar](100) NULL,
	[UnitID] [nvarchar](20) NULL,
	[BuyPrice] [money] NULL,
	[SellPrice] [money] NULL,
	[Quantity] [decimal](18, 0) NULL,
	[QuantityOrder] [decimal](18, 0) NULL,
	[IsDeleted] [bit] NULL,
	[CreateDate] [datetime] NOT NULL,
	[CreateUser] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[UpdateUser] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Inventory_2] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[StoreID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 08/09/2016 17:21:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [nvarchar](20) NOT NULL,
	[FirstName] [nvarchar](20) NULL,
	[LastName] [nvarchar](20) NULL,
	[FullName] [nvarchar](150) NULL,
	[BirthDay] [datetime] NULL,
	[StartWorkDate] [datetime] NULL,
	[IDNo] [nvarchar](20) NULL,
	[Mobile] [nvarchar](20) NULL,
	[Address] [nvarchar](200) NULL,
	[Email] [nvarchar](50) NULL,
	[PositionName] [nvarchar](50) NULL,
	[ManagerID] [nvarchar](20) NULL,
	[BasicSalary] [money] NULL,
	[IsDeleted] [bit] NULL,
	[CreateDate] [datetime] NOT NULL,
	[CreateUser] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[UpdateUser] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 08/09/2016 17:21:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [nvarchar](20) NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[Address] [nvarchar](250) NULL,
	[Mobile] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NULL,
	[Note] [nvarchar](250) NULL,
	[CompanyName] [nvarchar](50) NULL,
	[IsDebt] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[CreateDate] [datetime] NOT NULL,
	[CreateUser] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[UpdateUser] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
