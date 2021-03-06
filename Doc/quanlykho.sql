USE [QuanLyKho]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 10/30/2019 10:36:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[UnitID] [nvarchar](20) NOT NULL,
	[UnitName] [nvarchar](50) NULL,
	[Priority] [int] NOT NULL,
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
INSERT [dbo].[Unit] ([UnitID], [UnitName], [Priority], [Description], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'cai', N'Cái', 1, NULL, NULL, CAST(0x0000A15800000000 AS DateTime), N'aa', CAST(0x0000A6EE00000000 AS DateTime), N'admin')
INSERT [dbo].[Unit] ([UnitID], [UnitName], [Priority], [Description], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'hop', N'Hộp', 3, NULL, NULL, CAST(0x0000A70E00000000 AS DateTime), N'33', CAST(0x0000A17600000000 AS DateTime), N'11')
INSERT [dbo].[Unit] ([UnitID], [UnitName], [Priority], [Description], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'ly', N'Ly', 3, NULL, NULL, CAST(0x0000A70E00000000 AS DateTime), N'33', CAST(0x0000A17600000000 AS DateTime), N'11')
INSERT [dbo].[Unit] ([UnitID], [UnitName], [Priority], [Description], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'thung', N'Thùng', 2, NULL, NULL, CAST(0x0000A15800000000 AS DateTime), N'aa', CAST(0x0000A6EE00000000 AS DateTime), N'admin')
/****** Object:  Table [dbo].[Store]    Script Date: 10/30/2019 10:36:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Store](
	[StoreID] [int] NOT NULL,
	[StoreName] [nvarchar](200) NULL,
	[CompanyName] [nvarchar](250) NULL,
	[MST] [nvarchar](50) NULL,
	[Address] [nvarchar](150) NULL,
	[Email] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NULL,
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
INSERT [dbo].[Store] ([StoreID], [StoreName], [CompanyName], [MST], [Address], [Email], [Mobile], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (1, N'KHO CU CHI', N'Cong ty TNHH Nam Anh', NULL, N'57 Ap Giua Cu chi', NULL, NULL, NULL, CAST(0x00009FCB00000000 AS DateTime), N'admin', CAST(0x0000A2A600000000 AS DateTime), N'â')
/****** Object:  Table [dbo].[Provider]    Script Date: 10/30/2019 10:36:35 ******/
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
INSERT [dbo].[Provider] ([ProviderID], [ProviderName], [Address], [Mobile], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'1', N'Kem Bình Dương - Bình Dung', NULL, NULL, NULL, CAST(0x0000A6EE00000000 AS DateTime), N'ABC', CAST(0x0000A2C500000000 AS DateTime), N'aaa')
/****** Object:  Table [dbo].[Promotion]    Script Date: 10/30/2019 10:36:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Promotion](
	[PromotionID] [int] NOT NULL,
	[InOutKBN] [int] NOT NULL,
	[ProductID] [nvarchar](20) NOT NULL,
	[UnitID] [nvarchar](20) NOT NULL,
	[QuantityOfferUnit] [nvarchar](20) NOT NULL,
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
	[InOutKBN] ASC,
	[ProductID] ASC,
	[UnitID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductUnit]    Script Date: 10/30/2019 10:36:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductUnit](
	[ProductID] [nvarchar](20) NOT NULL,
	[UnitID1] [nvarchar](20) NOT NULL,
	[UnitIDMin] [nvarchar](20) NOT NULL,
	[Quantity] [decimal](18, 0) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[CreateUser] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[UpdateUser] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ProductUnit] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC,
	[UnitID1] ASC,
	[UnitIDMin] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KCD', N'cai', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200C53DFD AS DateTime), N'Admin', CAST(0x0000A7A70147E255 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KCD', N'thung', N'cai', CAST(160 AS Decimal(18, 0)), CAST(0x0000A7A200C58A9C AS DateTime), N'Admin', CAST(0x0000A7A70147F9E5 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KDD', N'cai', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200C2C736 AS DateTime), N'Admin', CAST(0x0000A7A200C2C736 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KDD', N'thung', N'cai', CAST(150 AS Decimal(18, 0)), CAST(0x0000A7A200C2ED74 AS DateTime), N'Admin', CAST(0x0000A7A200C2ED74 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KDX', N'cai', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200C26E3A AS DateTime), N'Admin', CAST(0x0000A7A200C26E3A AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KDX', N'thung', N'cai', CAST(150 AS Decimal(18, 0)), CAST(0x0000A7A200C2AA00 AS DateTime), N'Admin', CAST(0x0000A7A200C2AA00 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KHQC', N'cai', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200C41F4C AS DateTime), N'Admin', CAST(0x0000A7A200C41F4C AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KHQC', N'thung', N'cai', CAST(160 AS Decimal(18, 0)), CAST(0x0000A7A200C45C65 AS DateTime), N'Admin', CAST(0x0000A7A200C45C65 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KHQD', N'cai', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200C3E21B AS DateTime), N'Admin', CAST(0x0000A7A200C3E21B AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KHQD', N'thung', N'cai', CAST(160 AS Decimal(18, 0)), CAST(0x0000A7A200C406F9 AS DateTime), N'Admin', CAST(0x0000A7A200C406F9 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KHQT', N'cai', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200C3AB7A AS DateTime), N'Admin', CAST(0x0000A7A200C3AB7A AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KHQT', N'thung', N'cai', CAST(160 AS Decimal(18, 0)), CAST(0x0000A7A200C3C89C AS DateTime), N'Admin', CAST(0x0000A7A200C3C89C AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KHQV', N'cai', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200C346B1 AS DateTime), N'Admin', CAST(0x0000A7A200C346B1 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KHQV', N'thung', N'cai', CAST(160 AS Decimal(18, 0)), CAST(0x0000A7A200C379DD AS DateTime), N'Admin', CAST(0x0000A7A200C379DD AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KK', N'cai', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200C69F1C AS DateTime), N'Admin', CAST(0x0000A7A200C69F1C AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KSG', N'cai', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200C17D1E AS DateTime), N'Admin', CAST(0x0000A7A200C17D1E AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KSG', N'thung', N'cai', CAST(140 AS Decimal(18, 0)), CAST(0x0000A7A200C1C22D AS DateTime), N'Admin', CAST(0x0000A7A200C1C22D AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KSGL', N'cai', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200C1EF7E AS DateTime), N'Admin', CAST(0x0000A7A200C1EF7E AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KSGL', N'thung', N'cai', CAST(140 AS Decimal(18, 0)), CAST(0x0000A7A200C224E6 AS DateTime), N'Admin', CAST(0x0000A7A200C224E6 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'LHD01', N'ly', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200B12DC3 AS DateTime), N'Admin', CAST(0x0000A7A200B12DC3 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'LHD01', N'thung', N'cai', CAST(55 AS Decimal(18, 0)), CAST(0x0000A7A200B170A1 AS DateTime), N'Admin', CAST(0x0000A7A200B170A1 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'LNH01', N'ly', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200B1C715 AS DateTime), N'Admin', CAST(0x0000A7A200B616D1 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'LNH01', N'thung', N'cai', CAST(66 AS Decimal(18, 0)), CAST(0x0000A7A200B20319 AS DateTime), N'Admin', CAST(0x0000A7A200B8011D AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'LVN', N'ly', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200B8B142 AS DateTime), N'Admin', CAST(0x0000A7A200B8B142 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'LVN', N'thung', N'cai', CAST(72 AS Decimal(18, 0)), CAST(0x0000A7A200B8F41E AS DateTime), N'Admin', CAST(0x0000A7A200B8F41E AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OHD', N'cai', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200BA630A AS DateTime), N'Admin', CAST(0x0000A7A200BA630A AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OHD', N'thung', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200BA827A AS DateTime), N'Admin', CAST(0x0000A7B3014B9CCA AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OHS', N'cai', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200BA1C1E AS DateTime), N'Admin', CAST(0x0000A7A200BA1C1E AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OHS', N'thung', N'cai', CAST(25 AS Decimal(18, 0)), CAST(0x0000A7A200BA4AC4 AS DateTime), N'Admin', CAST(0x0000A7A200BA4AC4 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OQB', N'cai', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200BB822D AS DateTime), N'Admin', CAST(0x0000A7A200BB822D AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OQB', N'thung', N'cai', CAST(55 AS Decimal(18, 0)), CAST(0x0000A7A200BBC019 AS DateTime), N'Admin', CAST(0x0000A7A200BBC019 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OQN', N'cai', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200BCEFE5 AS DateTime), N'Admin', CAST(0x0000A7A200BD3F3B AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OQN', N'thung', N'cai', CAST(70 AS Decimal(18, 0)), CAST(0x0000A7A200BDEE8E AS DateTime), N'Admin', CAST(0x0000A7A200BDEE8E AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OQNV', N'cai', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200BD8CB6 AS DateTime), N'Admin', CAST(0x0000A7A200BD8CB6 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OQNV', N'thung', N'cai', CAST(70 AS Decimal(18, 0)), CAST(0x0000A7A200BDC8B6 AS DateTime), N'Admin', CAST(0x0000A7A200BDC8B6 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OTD', N'cai', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200BBD997 AS DateTime), N'Admin', CAST(0x0000A7A200BBD997 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OTD', N'thung', N'cai', CAST(55 AS Decimal(18, 0)), CAST(0x0000A7A200BC0E86 AS DateTime), N'Admin', CAST(0x0000A7A200BC0E86 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OTK', N'cai', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200BC9DB2 AS DateTime), N'Admin', CAST(0x0000A7A200BC9DB2 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OTK', N'thung', N'cai', CAST(55 AS Decimal(18, 0)), CAST(0x0000A7A200BCB7C6 AS DateTime), N'Admin', CAST(0x0000A7A200BCB7C6 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OTS', N'cai', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200BAF0D1 AS DateTime), N'Admin', CAST(0x0000A7A200BAF0D1 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OTS', N'thung', N'cai', CAST(55 AS Decimal(18, 0)), CAST(0x0000A7A200BB4D9B AS DateTime), N'Admin', CAST(0x0000A7A200BB4D9B AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'SC', N'cai', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7B40100BBFF AS DateTime), N'Admin', CAST(0x0000A7B40100BBFF AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'SC', N'thung', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7B40112EF33 AS DateTime), N'Admin', CAST(0x0000A7B40112EF33 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'TTC', N'hop', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200BFE0D3 AS DateTime), N'Admin', CAST(0x0000AAF600A44EBC AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'TTC', N'thung', N'cai', CAST(18 AS Decimal(18, 0)), CAST(0x0000A7A200C00A1F AS DateTime), N'Admin', CAST(0x0000A7A200C00A1F AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'TTDX', N'hop', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200C0A864 AS DateTime), N'Admin', CAST(0x0000A7A200C0A864 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'TTDX', N'thung', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200C0C723 AS DateTime), N'Admin', CAST(0x0000A7A200C0C723 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'TTK', N'hop', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200C0E7DE AS DateTime), N'Admin', CAST(0x0000A7A200C0E7DE AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'TTK', N'thung', N'cai', CAST(18 AS Decimal(18, 0)), CAST(0x0000A7A200C11926 AS DateTime), N'Admin', CAST(0x0000A7A200C11926 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'TTM', N'hop', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200BF74A2 AS DateTime), N'Admin', CAST(0x0000A7A200BF74A2 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'TTM', N'thung', N'cai', CAST(18 AS Decimal(18, 0)), CAST(0x0000A7A200BFBAD3 AS DateTime), N'Admin', CAST(0x0000A7A200BFBAD3 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'TTS', N'hop', N'cai', CAST(1 AS Decimal(18, 0)), CAST(0x0000A7A200BE6D24 AS DateTime), N'Admin', CAST(0x0000A7A200BE6D24 AS DateTime), N'Admin')
INSERT [dbo].[ProductUnit] ([ProductID], [UnitID1], [UnitIDMin], [Quantity], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'TTS', N'thung', N'cai', CAST(18 AS Decimal(18, 0)), CAST(0x0000A7A200BED162 AS DateTime), N'Admin', CAST(0x0000A7A200BED162 AS DateTime), N'Admin')
/****** Object:  Table [dbo].[ProductType]    Script Date: 10/30/2019 10:36:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductType](
	[ProductTypeID] [nvarchar](20) NOT NULL,
	[ProductTypeName] [nvarchar](250) NULL,
	[TaxPercent] [int] NULL,
	[CreateDate] [datetime] NOT NULL,
	[CreateUser] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[UpdateUser] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ProductType] PRIMARY KEY CLUSTERED 
(
	[ProductTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ProductType] ([ProductTypeID], [ProductTypeName], [TaxPercent], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'1', N'Kem', 5, CAST(0x00009FCB00000000 AS DateTime), N'abc', CAST(0x0000BAE700000000 AS DateTime), N'11')
/****** Object:  Table [dbo].[Product]    Script Date: 10/30/2019 10:36:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [nvarchar](20) NOT NULL,
	[ProductName] [nvarchar](100) NULL,
	[UnitID] [nvarchar](20) NULL,
	[UnitName] [nvarchar](50) NULL,
	[ProductType] [nvarchar](50) NULL,
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
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KCD', N'Kem Cam Deo', N'cai', N'Cái', N'1', N'1', N'Kem Bình Dương - Bình Dung', 1000.0000, NULL, NULL, 2000.0000, NULL, NULL, NULL, CAST(0x0000A7A200C53DFB AS DateTime), N'Admin', CAST(0x0000A7A70147E1E6 AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KDD', N'Kem Dẻo Đậu Đỏ', N'cai', N'Cái', N'1', N'1', N'Kem Bình Dương - Bình Dung', 1600.0000, NULL, NULL, 5500.0000, NULL, NULL, NULL, CAST(0x0000A7A200C2C734 AS DateTime), N'Admin', CAST(0x0000A7A200C2C734 AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KDX', N'Kem Dẻo Đậu Xanh', N'cai', N'Cái', N'1', N'1', N'Kem Bình Dương - Bình Dung', 1600.0000, NULL, NULL, 5500.0000, NULL, NULL, NULL, CAST(0x0000A7A200C26E37 AS DateTime), N'Admin', CAST(0x0000A7A200C26E37 AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KHQC', N'Kem Hoa Quả Cốm', N'cai', N'Cái', N'1', N'1', N'Kem Bình Dương - Bình Dung', 1000.0000, NULL, NULL, 2500.0000, NULL, NULL, NULL, CAST(0x0000A7A200C41F49 AS DateTime), N'Admin', CAST(0x0000A7A200C41F49 AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KHQD', N'Kem Hoa Quả Dâu', N'cai', N'Cái', N'1', N'1', N'Kem Bình Dương - Bình Dung', 1000.0000, NULL, NULL, 2500.0000, NULL, NULL, NULL, CAST(0x0000A7A200C3E218 AS DateTime), N'Admin', CAST(0x0000A7A200C3E218 AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KHQT', N'Kem Hoa Quả Tím', N'cai', N'Cái', N'1', N'1', N'Kem Bình Dương - Bình Dung', 1000.0000, NULL, NULL, 2500.0000, NULL, NULL, NULL, CAST(0x0000A7A200C3AB77 AS DateTime), N'Admin', CAST(0x0000A7A200C3AB77 AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KHQV', N'Kem Hoa Quả Vàng ', N'cai', N'Cái', N'1', N'1', N'Kem Bình Dương - Bình Dung', 1000.0000, NULL, NULL, 2500.0000, NULL, NULL, NULL, CAST(0x0000A7A200C346AE AS DateTime), N'Admin', CAST(0x0000A7A200C346AE AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KK', N'Kem Ký', N'cai', N'Cái', N'1', N'1', N'Kem Bình Dương - Bình Dung', 20000.0000, NULL, NULL, 40000.0000, NULL, NULL, NULL, CAST(0x0000A7A200C69F1A AS DateTime), N'Admin', CAST(0x0000A7A200C69F1A AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KSG', N'Kem Socola Giòn New', N'cai', N'Cái', N'1', N'1', N'Kem Bình Dương - Bình Dung', 2500.0000, NULL, NULL, 8000.0000, NULL, NULL, NULL, CAST(0x0000A7A200C17D1B AS DateTime), N'Admin', CAST(0x0000A7A200C17D1B AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KSGL', N'Kem Socola Giòn Lạc', N'cai', N'Cái', N'1', N'1', N'Kem Bình Dương - Bình Dung', 2500.0000, NULL, NULL, 5000.0000, NULL, NULL, NULL, CAST(0x0000A7A200C1EF7B AS DateTime), N'Admin', CAST(0x0000A7A200C1EF7B AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'LHD01', N'Ly Hoàng Đế', N'ly', N'Ly', N'1', N'1', N'Kem Bình Dương - Bình Dung', 3600.0000, NULL, NULL, 7200.0000, NULL, NULL, NULL, CAST(0x0000A7A200B12DBC AS DateTime), N'Admin', CAST(0x0000A7A200B12DBC AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'LNH01', N'Ly Nữ Hoàng ', N'ly', N'Ly', N'1', N'1', N'Kem Bình Dương - Bình Dung', 2600.0000, NULL, NULL, 5000.0000, NULL, NULL, NULL, CAST(0x0000A7A200B1C712 AS DateTime), N'Admin', CAST(0x0000A7A200B616C3 AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'LVN', N'Ly Vàng Nho ', N'ly', N'Ly', N'1', N'1', N'Kem Bình Dương - Bình Dung', 2100.0000, NULL, NULL, 4000.0000, NULL, NULL, NULL, CAST(0x0000A7A200B8B140 AS DateTime), N'Admin', CAST(0x0000A7A200B8B140 AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OHD', N'Ốc Hoa Dâu', N'cai', N'Cái', N'1', N'1', N'Kem Bình Dương - Bình Dung', 2700.0000, NULL, NULL, 7000.0000, NULL, NULL, NULL, CAST(0x0000A7A200BA6308 AS DateTime), N'Admin', CAST(0x0000A7A200BA6308 AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OHS', N'Ốc Hoa Socola ', N'cai', N'Cái', N'1', N'1', N'Kem Bình Dương - Bình Dung', 2700.0000, NULL, NULL, 7000.0000, NULL, NULL, NULL, CAST(0x0000A7A200BA1C1C AS DateTime), N'Admin', CAST(0x0000A7A200BA1C1C AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OQB', N'Ốc Quế Bạc', N'cai', N'Cái', N'1', N'1', N'Kem Bình Dương - Bình Dung', 1700.0000, NULL, NULL, 4000.0000, NULL, NULL, NULL, CAST(0x0000A7A200BB822B AS DateTime), N'Admin', CAST(0x0000A7A200BB822B AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OQN', N'Ốc Quế Nhỏ Khoai Môn', N'cai', N'Cái', N'1', N'1', N'Kem Bình Dương - Bình Dung', 1000.0000, NULL, NULL, 3000.0000, NULL, NULL, NULL, CAST(0x0000A7A200BCEFE3 AS DateTime), N'Admin', CAST(0x0000A7A200BD3F33 AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OQNV', N'Ốc Quế Nhỏ Vàng', N'cai', N'Cái', N'1', N'1', N'Kem Bình Dương - Bình Dung', 1000.0000, NULL, NULL, 3000.0000, NULL, NULL, NULL, CAST(0x0000A7A200BD8CB3 AS DateTime), N'Admin', CAST(0x0000A7A200BD8CB3 AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OTD', N'Ốc To Dâu', N'cai', N'Cái', N'1', N'1', N'Kem Bình Dương - Bình Dung', 1400.0000, NULL, NULL, 4000.0000, NULL, NULL, NULL, CAST(0x0000A7A200BBD995 AS DateTime), N'Admin', CAST(0x0000A7A200BBD995 AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OTK', N'Ốc To Khoai Môn', N'cai', N'Cái', N'1', N'1', N'Kem Bình Dương - Bình Dung', 1400.0000, NULL, NULL, 4000.0000, NULL, NULL, NULL, CAST(0x0000A7A200BC9DAE AS DateTime), N'Admin', CAST(0x0000A7A200BC9DAE AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'OTS', N'Ốc To SoCoLa', N'cai', N'Cái', N'1', N'1', N'Kem Bình Dương - Bình Dung', 1400.0000, NULL, NULL, 4000.0000, NULL, NULL, NULL, CAST(0x0000A7A200BAF0CF AS DateTime), N'Admin', CAST(0x0000A7A200BAF0CF AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'SC', N'Sữa Chua', N'cai', N'Cái', N'1', N'1', N'Kem Bình Dương - Bình Dung', 1200.0000, NULL, NULL, 2200.0000, NULL, NULL, NULL, CAST(0x0000A7B40100BBE3 AS DateTime), N'Admin', CAST(0x0000A7B40100BBE3 AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'TTC', N'Tràng Tiền Cốm', N'hop', N'Hộp', N'1', N'1', N'Kem Bình Dương - Bình Dung', 17500.0000, NULL, NULL, 40000.0000, NULL, NULL, NULL, CAST(0x0000A7A200BFE0CF AS DateTime), N'Admin', CAST(0x0000AAF600A44EAF AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'TTDX', N'Tràng Tiền Đậu Xanh', N'hop', N'Hộp', N'1', N'1', N'Kem Bình Dương - Bình Dung', 17500.0000, NULL, NULL, 39000.0000, NULL, NULL, NULL, CAST(0x0000A7A200C0A862 AS DateTime), N'Admin', CAST(0x0000A7A200C0A862 AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'TTK', N'Tràng Tiền Kacao', N'hop', N'Hộp', N'1', N'1', N'Kem Bình Dương - Bình Dung', 17500.0000, NULL, NULL, 39000.0000, NULL, NULL, NULL, CAST(0x0000A7A200C0E7DB AS DateTime), N'Admin', CAST(0x0000A7A200C0E7DB AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'TTM', N'Tràng Tiền Mít', N'hop', N'Hộp', N'1', N'1', N'Kem Bình Dương - Bình Dung', 17500.0000, NULL, NULL, 39000.0000, NULL, NULL, NULL, CAST(0x0000A7A200BF74A0 AS DateTime), N'Admin', CAST(0x0000A7A200BF74A0 AS DateTime), N'Admin')
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitID], [UnitName], [ProductType], [ProviderID], [ProviderName], [BuyPriceCurrent], [BuyPricePrevious], [BuyPriceAverage], [SellPrice], [ExportBuy], [ExportOffer], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'TTS', N'Tràng Tiền Sữa Dừa', N'hop', N'Hộp', N'1', N'1', N'Kem Bình Dương - Bình Dung', 17500.0000, NULL, NULL, 39000.0000, NULL, NULL, NULL, CAST(0x0000A7A200BE6D21 AS DateTime), N'Admin', CAST(0x0000A7A200BE6D21 AS DateTime), N'Admin')
/****** Object:  Table [dbo].[Invoice]    Script Date: 10/30/2019 10:36:35 ******/
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
	[EmployeeName] [nvarchar](150) NULL,
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
/****** Object:  Table [dbo].[InventoryHistory]    Script Date: 10/30/2019 10:36:35 ******/
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
	[QuantityOfferUnit] [nvarchar](20) NULL,
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
/****** Object:  Table [dbo].[Inventory]    Script Date: 10/30/2019 10:36:35 ******/
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
/****** Object:  Table [dbo].[Employee]    Script Date: 10/30/2019 10:36:35 ******/
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
INSERT [dbo].[Employee] ([EmployeeID], [FirstName], [LastName], [FullName], [BirthDay], [StartWorkDate], [IDNo], [Mobile], [Address], [Email], [PositionName], [ManagerID], [BasicSalary], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'NV01', N'NGUYỄN THANH', N'PHƯƠNG', N'NGUYỄN THANH PHƯƠNG', CAST(0x0000A7850149022C AS DateTime), CAST(0x0000A7850149022C AS DateTime), N'', N'0938475095', N'', N'', NULL, N'', NULL, NULL, CAST(0x0000A7A701495473 AS DateTime), N'Admin', CAST(0x0000A7A701495473 AS DateTime), N'Admin')
INSERT [dbo].[Employee] ([EmployeeID], [FirstName], [LastName], [FullName], [BirthDay], [StartWorkDate], [IDNo], [Mobile], [Address], [Email], [PositionName], [ManagerID], [BasicSalary], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'NV02', N'NGUYỄN XUÂN ', N'BA', N'NGUYỄN XUÂN BA', CAST(0x0000A7850149022C AS DateTime), CAST(0x0000A7850149022C AS DateTime), N'', N'0902797378', N'', N'', NULL, N'', NULL, NULL, CAST(0x0000A7B4011D8B51 AS DateTime), N'Admin', CAST(0x0000A7B4011DBA2B AS DateTime), N'Admin')
INSERT [dbo].[Employee] ([EmployeeID], [FirstName], [LastName], [FullName], [BirthDay], [StartWorkDate], [IDNo], [Mobile], [Address], [Email], [PositionName], [ManagerID], [BasicSalary], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'NV03', N'ĐỖ VĂN ', N'NAM', N'ĐỖ VĂN NAM', CAST(0x0000A7850149022C AS DateTime), CAST(0x0000A7850149022C AS DateTime), N'', N'0985169207', N'', N'', NULL, N'', NULL, NULL, CAST(0x0000A7B4011DEF1B AS DateTime), N'Admin', CAST(0x0000A7B4011DEF1B AS DateTime), N'Admin')
/****** Object:  Table [dbo].[Customer]    Script Date: 10/30/2019 10:36:35 ******/
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
	[MST] [nvarchar](50) NULL,
	[PrefixBillNo] [nvarchar](50) NULL,
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
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Address], [Mobile], [Email], [Note], [CompanyName], [MST], [PrefixBillNo], [IsDebt], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KH00001', N'Nha Hang Khanh Hoi', N'1212', N'0000000788', N'', N'dkjfd', N'', NULL, N'KHOI', NULL, NULL, CAST(0x0000A79D00A407D9 AS DateTime), N'Admin', CAST(0x0000A79D00A407D9 AS DateTime), N'Admin')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Address], [Mobile], [Email], [Note], [CompanyName], [MST], [PrefixBillNo], [IsDebt], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KH00002', N'Đinh Thanh Tuấn', N'340/17G Lê Văn Quới, Bình Tân', N'0937787178', N'', N'', N'Thái Dương', NULL, N'01', NULL, NULL, CAST(0x0000A7B200C5B329 AS DateTime), N'Admin', CAST(0x0000A7B200C5B329 AS DateTime), N'Admin')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Address], [Mobile], [Email], [Note], [CompanyName], [MST], [PrefixBillNo], [IsDebt], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KH00003', N'Nguyễn Văn Luân', N'450/28 Dương Bá Trạc,Q8,TP HCM', N'0988886135', N'', N'', N'', NULL, N'02', NULL, NULL, CAST(0x0000A7B200C67F28 AS DateTime), N'Admin', CAST(0x0000A7B200C67F28 AS DateTime), N'Admin')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Address], [Mobile], [Email], [Note], [CompanyName], [MST], [PrefixBillNo], [IsDebt], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KH00004', N'Tùng Q7', N'NPP Quận 7', N'0133032911', N'', N'', N'', NULL, N'03', NULL, NULL, CAST(0x0000A7B200C6F389 AS DateTime), N'Admin', CAST(0x0000A7B200C7198F AS DateTime), N'Admin')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Address], [Mobile], [Email], [Note], [CompanyName], [MST], [PrefixBillNo], [IsDebt], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KH00005', N'Nguyễn Minh Trưởng', N'60/6 Mỹ Hòa Tân Xuân, Hóc Môn', N'0909261282', N'', N'', N'', NULL, N'04', NULL, NULL, CAST(0x0000A7B200C7CFBC AS DateTime), N'Admin', CAST(0x0000A7B200C7CFBC AS DateTime), N'Admin')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Address], [Mobile], [Email], [Note], [CompanyName], [MST], [PrefixBillNo], [IsDebt], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KH00006', N' Nữ Hoàng Quân NPP M&N', N'21/10 Hồng Lạc,P10, Tân Bình,Tp HCM', N'0402979584', N'', N'', N'Npp M&N', NULL, N'05', NULL, NULL, CAST(0x0000A7B200C925E3 AS DateTime), N'Admin', CAST(0x0000A7B300A6BD57 AS DateTime), N'Admin')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Address], [Mobile], [Email], [Note], [CompanyName], [MST], [PrefixBillNo], [IsDebt], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KH00007', N'NPP Hoàng (Củ Chi )', N'Củ Chi', N'0402979583', N'', N'', N'', NULL, N'06', NULL, NULL, CAST(0x0000A7B200C9C67A AS DateTime), N'Admin', CAST(0x0000A7B200C9C67A AS DateTime), N'Admin')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Address], [Mobile], [Email], [Note], [CompanyName], [MST], [PrefixBillNo], [IsDebt], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KH00008', N'Huỳnh Khánh Hùng', N'101,KP5, Tân Chánh Hiệp, Q12,Tp HCM', N'0908005346', N'', N'', N'', NULL, N'07', NULL, NULL, CAST(0x0000A7B200CA86BE AS DateTime), N'Admin', CAST(0x0000A7B200CA86BE AS DateTime), N'Admin')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Address], [Mobile], [Email], [Note], [CompanyName], [MST], [PrefixBillNo], [IsDebt], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KH00009', N'Nguyễn Thanh Phương', N'30/4A KP2, Trung Mỹ Tây, Q12,Tp, HCM', N'0938475094', N'', N'', N'', NULL, N'08', NULL, NULL, CAST(0x0000A7B200CB2E50 AS DateTime), N'Admin', CAST(0x0000A7B200CB2E50 AS DateTime), N'Admin')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Address], [Mobile], [Email], [Note], [CompanyName], [MST], [PrefixBillNo], [IsDebt], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KH00010', N'Đỗ Văn Nam', N'C8,KDCK82,Tô Ký, Q12, Tp HCM', N'0938858372', N'', N'', N'', NULL, N'09', NULL, NULL, CAST(0x0000A7B200CBB072 AS DateTime), N'Admin', CAST(0x0000A7B200CBB072 AS DateTime), N'Admin')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Address], [Mobile], [Email], [Note], [CompanyName], [MST], [PrefixBillNo], [IsDebt], [IsDeleted], [CreateDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'KH00011', N'Vũ Văn Hiếu', N'Lê Đức thọ , P13, Gò Vấp', N'0985580441', N'', N'khách hàng khó tính', N'', NULL, N'HIEU', NULL, NULL, CAST(0x0000AAF600A4EEFD AS DateTime), N'Admin', CAST(0x0000AAF600A4EEFD AS DateTime), N'Admin')
