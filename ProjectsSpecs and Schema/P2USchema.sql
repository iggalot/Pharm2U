USE [KenticoInternet_DotCom_Prod]
GO
/****** Object:  Table [dbo].[P2U_CancellationReason]    Script Date: 6/10/2019 3:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[P2U_CancellationReason](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemCreatedBy] [int] NULL,
	[ItemCreatedWhen] [datetime2](7) NULL,
	[ItemModifiedBy] [int] NULL,
	[ItemModifiedWhen] [datetime2](7) NULL,
	[ItemOrder] [int] NULL,
	[ItemGUID] [uniqueidentifier] NOT NULL,
	[Reason] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_P2U_CancellationReason] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[P2U_Customer]    Script Date: 6/10/2019 3:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[P2U_Customer](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemCreatedBy] [int] NULL,
	[ItemCreatedWhen] [datetime2](7) NULL,
	[ItemModifiedBy] [int] NULL,
	[ItemModifiedWhen] [datetime2](7) NULL,
	[ItemOrder] [int] NULL,
	[ItemGUID] [uniqueidentifier] NOT NULL,
	[FirstName] [nvarchar](200) NULL,
	[LastName] [nvarchar](200) NULL,
	[ContactMethod] [nvarchar](20) NULL,
	[Phone] [nvarchar](20) NULL,
	[Email] [nvarchar](200) NULL,
	[StreetAddress] [nvarchar](500) NULL,
	[Zip] [nvarchar](20) NULL,
	[AddressType] [nvarchar](20) NULL,
 CONSTRAINT [PK_P2U_Customer] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[P2U_DeliveryArea]    Script Date: 6/10/2019 3:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[P2U_DeliveryArea](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemCreatedBy] [int] NULL,
	[ItemCreatedWhen] [datetime2](7) NULL,
	[ItemModifiedBy] [int] NULL,
	[ItemModifiedWhen] [datetime2](7) NULL,
	[ItemOrder] [int] NULL,
	[ItemGUID] [uniqueidentifier] NOT NULL,
	[Zip] [nvarchar](20) NOT NULL,
	[PharmacyID] [int] NULL,
	[DeliveryPrice] [decimal](12, 2) NULL,
 CONSTRAINT [PK_P2U_DeliveryArea] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[P2U_DeliveryCompany]    Script Date: 6/10/2019 3:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[P2U_DeliveryCompany](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemCreatedBy] [int] NULL,
	[ItemCreatedWhen] [datetime2](7) NULL,
	[ItemModifiedBy] [int] NULL,
	[ItemModifiedWhen] [datetime2](7) NULL,
	[ItemOrder] [int] NULL,
	[ItemGUID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Address] [nvarchar](400) NULL,
	[Zip] [nvarchar](20) NULL,
	[Phone] [nvarchar](20) NULL,
	[Fax] [nvarchar](20) NULL,
	[Email] [nvarchar](200) NULL,
 CONSTRAINT [PK_P2U_DeliveryCompany] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[P2U_Food]    Script Date: 6/10/2019 3:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[P2U_Food](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemCreatedBy] [int] NULL,
	[ItemCreatedWhen] [datetime2](7) NULL,
	[ItemModifiedBy] [int] NULL,
	[ItemModifiedWhen] [datetime2](7) NULL,
	[ItemOrder] [int] NULL,
	[ItemGUID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Price] [decimal](12, 2) NOT NULL,
	[Taxable] [bit] NOT NULL,
	[Type] [nvarchar](10) NULL,
 CONSTRAINT [PK_P2U_Food] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[P2U_Order]    Script Date: 6/10/2019 3:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[P2U_Order](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemCreatedBy] [int] NULL,
	[ItemCreatedWhen] [datetime2](7) NULL,
	[ItemModifiedBy] [int] NULL,
	[ItemModifiedWhen] [datetime2](7) NULL,
	[ItemOrder] [int] NULL,
	[ItemGUID] [uniqueidentifier] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[PharmacyID] [int] NULL,
	[DeliveryCompanyID] [int] NULL,
	[ProviderUsername] [nvarchar](20) NOT NULL,
	[Status] [nvarchar](100) NOT NULL,
	[DeliveryWindow] [nvarchar](200) NULL,
	[DeliveryInstructions] [nvarchar](max) NULL,
	[DeliveryCost] [decimal](12, 2) NULL,
	[FoodCost] [decimal](12, 2) NULL,
	[OTCMedCost] [decimal](12, 2) NULL,
	[PrescriptionCost] [decimal](12, 2) NULL,
	[Tax] [decimal](12, 2) NULL,
	[TotalCost] [decimal](12, 2) NULL,
	[AuthCode] [nvarchar](100) NULL,
	[TransactionKey] [nvarchar](225) NULL,
	[CardNumber] [nvarchar](10) NULL,
	[OrderInitiatedWhen] [datetime2](7) NULL,
	[NewOrderCreatedWhen] [datetime2](7) NULL,
	[ReadyForPaymentWhen] [datetime2](7) NULL,
	[ReadyForPackagingWhen] [datetime2](7) NULL,
	[ReadyForPickupWhen] [datetime2](7) NULL,
	[OutForDeliveryWhen] [datetime2](7) NULL,
	[DeliveredWhen] [datetime2](7) NULL,
	[CanceledWhen] [datetime2](7) NULL,
	[CanceledReason] [nvarchar](200) NULL,
	[ReturnedWhen] [datetime2](7) NULL,
	[ReturnedReason] [nvarchar](200) NULL,
 CONSTRAINT [PK_P2U_Order] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[P2U_OrderFood]    Script Date: 6/10/2019 3:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[P2U_OrderFood](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemCreatedBy] [int] NULL,
	[ItemCreatedWhen] [datetime2](7) NULL,
	[ItemModifiedBy] [int] NULL,
	[ItemModifiedWhen] [datetime2](7) NULL,
	[ItemOrder] [int] NULL,
	[ItemGUID] [uniqueidentifier] NOT NULL,
	[OrderID] [int] NOT NULL,
	[FoodID] [int] NOT NULL,
	[Price] [decimal](12, 2) NOT NULL,
	[Qty] [int] NOT NULL,
	[Taxable] [bit] NOT NULL,
 CONSTRAINT [PK_P2U_OrderFood] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[P2U_OrderOTCMeds]    Script Date: 6/10/2019 3:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[P2U_OrderOTCMeds](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemCreatedBy] [int] NULL,
	[ItemCreatedWhen] [datetime2](7) NULL,
	[ItemModifiedBy] [int] NULL,
	[ItemModifiedWhen] [datetime2](7) NULL,
	[ItemOrder] [int] NULL,
	[ItemGUID] [uniqueidentifier] NOT NULL,
	[OrderID] [int] NOT NULL,
	[OTCMedID] [int] NOT NULL,
	[Price] [decimal](12, 2) NOT NULL,
	[Qty] [int] NOT NULL,
	[Taxable] [bit] NOT NULL,
 CONSTRAINT [PK_P2U_OrderOTCMeds] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[P2U_OTCMedication]    Script Date: 6/10/2019 3:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[P2U_OTCMedication](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemCreatedBy] [int] NULL,
	[ItemCreatedWhen] [datetime2](7) NULL,
	[ItemModifiedBy] [int] NULL,
	[ItemModifiedWhen] [datetime2](7) NULL,
	[ItemOrder] [int] NULL,
	[ItemGUID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Price] [decimal](12, 2) NOT NULL,
	[Taxable] [bit] NOT NULL,
 CONSTRAINT [PK_P2U_OTCMedication] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[P2U_Pharmacy]    Script Date: 6/10/2019 3:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[P2U_Pharmacy](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemCreatedBy] [int] NULL,
	[ItemCreatedWhen] [datetime2](7) NULL,
	[ItemModifiedBy] [int] NULL,
	[ItemModifiedWhen] [datetime2](7) NULL,
	[ItemOrder] [int] NULL,
	[ItemGUID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Address] [nvarchar](400) NULL,
	[Phone] [nvarchar](50) NULL,
	[Zip] [nvarchar](20) NULL,
	[UseGlobalPricing] [bit] NULL,
	[GlobalDeliveryPrice] [decimal](12, 2) NULL,
	[UseMinDeliveryAmt] [bit] NULL,
	[MinDeliveryAmt] [decimal](12, 2) NULL,
	[OrderTimeout] [int] NULL,
	[PaymentTimeout] [int] NULL,
	[GLNumber] [nvarchar](100) NULL,
	[DefaultDeliveryCompany] [int] NULL,
	[TaxRate] [decimal](19, 4) NULL,
	[OrderEmailAddress] [nvarchar](200) NULL,
	[OrderEmailSubject] [nvarchar](200) NULL,
 CONSTRAINT [PK_P2U_Pharmacy] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[P2U_Provider]    Script Date: 6/10/2019 3:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[P2U_Provider](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemCreatedBy] [int] NULL,
	[ItemCreatedWhen] [datetime2](7) NULL,
	[ItemModifiedBy] [int] NULL,
	[ItemModifiedWhen] [datetime2](7) NULL,
	[ItemOrder] [int] NULL,
	[ItemGUID] [uniqueidentifier] NOT NULL,
	[ProviderID] [nvarchar](20) NULL,
	[FullName] [nvarchar](200) NULL,
	[Email] [nvarchar](200) NULL,
 CONSTRAINT [PK_P2U_Provider] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[P2U_ReturnedReason]    Script Date: 6/10/2019 3:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[P2U_ReturnedReason](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemCreatedBy] [int] NULL,
	[ItemCreatedWhen] [datetime2](7) NULL,
	[ItemModifiedBy] [int] NULL,
	[ItemModifiedWhen] [datetime2](7) NULL,
	[ItemOrder] [int] NULL,
	[ItemGUID] [uniqueidentifier] NOT NULL,
	[Reason] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_P2U_ReturnedReason] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[P2U_Statuses]    Script Date: 6/10/2019 3:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[P2U_Statuses](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemCreatedBy] [int] NULL,
	[ItemCreatedWhen] [datetime2](7) NULL,
	[ItemModifiedBy] [int] NULL,
	[ItemModifiedWhen] [datetime2](7) NULL,
	[ItemOrder] [int] NULL,
	[ItemGUID] [uniqueidentifier] NOT NULL,
	[Status] [nvarchar](200) NOT NULL,
	[ActiveStatus] [bit] NOT NULL,
	[DisplayText] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_P2U_Statuses] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[P2U_ZipCodes]    Script Date: 6/10/2019 3:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[P2U_ZipCodes](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemCreatedBy] [int] NULL,
	[ItemCreatedWhen] [datetime2](7) NULL,
	[ItemModifiedBy] [int] NULL,
	[ItemModifiedWhen] [datetime2](7) NULL,
	[ItemOrder] [int] NULL,
	[ItemGUID] [uniqueidentifier] NOT NULL,
	[Zip] [nvarchar](20) NOT NULL,
	[City] [nvarchar](100) NULL,
	[County] [nvarchar](100) NULL,
	[State] [nvarchar](2) NULL,
	[Country] [nvarchar](200) NULL,
	[Latitude] [float] NULL,
	[Longitude] [float] NULL,
 CONSTRAINT [PK_P2U_ZipCodes] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[P2U_CancellationReason] ADD  CONSTRAINT [DEFAULT_P2U_CancellationReason_ItemGUID]  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [ItemGUID]
GO
ALTER TABLE [dbo].[P2U_CancellationReason] ADD  CONSTRAINT [DEFAULT_P2U_CancellationReason_Reason]  DEFAULT (N'') FOR [Reason]
GO
ALTER TABLE [dbo].[P2U_Customer] ADD  CONSTRAINT [DEFAULT_P2U_Customer_ItemGUID]  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [ItemGUID]
GO
ALTER TABLE [dbo].[P2U_DeliveryArea] ADD  CONSTRAINT [DEFAULT_P2U_DeliveryArea_ItemGUID]  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [ItemGUID]
GO
ALTER TABLE [dbo].[P2U_DeliveryArea] ADD  CONSTRAINT [DEFAULT_P2U_DeliveryArea_Zip]  DEFAULT (N'') FOR [Zip]
GO
ALTER TABLE [dbo].[P2U_DeliveryCompany] ADD  CONSTRAINT [DEFAULT_P2U_DeliveryCompany_ItemGUID]  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [ItemGUID]
GO
ALTER TABLE [dbo].[P2U_Food] ADD  CONSTRAINT [DEFAULT_P2U_Food_ItemGUID]  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [ItemGUID]
GO
ALTER TABLE [dbo].[P2U_Food] ADD  CONSTRAINT [DEFAULT_P2U_Food_Name]  DEFAULT (N'') FOR [Name]
GO
ALTER TABLE [dbo].[P2U_Food] ADD  CONSTRAINT [DEFAULT_P2U_Food_Price]  DEFAULT ('0') FOR [Price]
GO
ALTER TABLE [dbo].[P2U_Food] ADD  CONSTRAINT [DEFAULT_P2U_Food_Taxable]  DEFAULT ((1)) FOR [Taxable]
GO
ALTER TABLE [dbo].[P2U_Order] ADD  CONSTRAINT [DEFAULT_P2U_Order_ItemGUID]  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [ItemGUID]
GO
ALTER TABLE [dbo].[P2U_Order] ADD  CONSTRAINT [DEFAULT_P2U_Order_CustomerID]  DEFAULT ((0)) FOR [CustomerID]
GO
ALTER TABLE [dbo].[P2U_Order] ADD  CONSTRAINT [DEFAULT_P2U_Order_ProviderUsername]  DEFAULT (N'') FOR [ProviderUsername]
GO
ALTER TABLE [dbo].[P2U_Order] ADD  CONSTRAINT [DEFAULT_P2U_Order_Status]  DEFAULT (N'Initiated') FOR [Status]
GO
ALTER TABLE [dbo].[P2U_OrderFood] ADD  CONSTRAINT [DEFAULT_P2U_OrderFood_ItemGUID]  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [ItemGUID]
GO
ALTER TABLE [dbo].[P2U_OrderFood] ADD  CONSTRAINT [DEFAULT_P2U_OrderFood_OrderID]  DEFAULT ((0)) FOR [OrderID]
GO
ALTER TABLE [dbo].[P2U_OrderFood] ADD  CONSTRAINT [DEFAULT_P2U_OrderFood_FoodID]  DEFAULT ((0)) FOR [FoodID]
GO
ALTER TABLE [dbo].[P2U_OrderFood] ADD  CONSTRAINT [DEFAULT_P2U_OrderFood_Price]  DEFAULT ('0') FOR [Price]
GO
ALTER TABLE [dbo].[P2U_OrderFood] ADD  CONSTRAINT [DEFAULT_P2U_OrderFood_Qty]  DEFAULT ((0)) FOR [Qty]
GO
ALTER TABLE [dbo].[P2U_OrderFood] ADD  CONSTRAINT [DEFAULT_P2U_OrderFood_Taxable]  DEFAULT ((1)) FOR [Taxable]
GO
ALTER TABLE [dbo].[P2U_OrderOTCMeds] ADD  CONSTRAINT [DEFAULT_P2U_OrderOTCMeds_ItemGUID]  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [ItemGUID]
GO
ALTER TABLE [dbo].[P2U_OrderOTCMeds] ADD  CONSTRAINT [DEFAULT_P2U_OrderOTCMeds_OrderID]  DEFAULT ((0)) FOR [OrderID]
GO
ALTER TABLE [dbo].[P2U_OrderOTCMeds] ADD  CONSTRAINT [DEFAULT_P2U_OrderOTCMeds_OTCMedID]  DEFAULT ((0)) FOR [OTCMedID]
GO
ALTER TABLE [dbo].[P2U_OrderOTCMeds] ADD  CONSTRAINT [DEFAULT_P2U_OrderOTCMeds_Price]  DEFAULT ('0') FOR [Price]
GO
ALTER TABLE [dbo].[P2U_OrderOTCMeds] ADD  CONSTRAINT [DEFAULT_P2U_OrderOTCMeds_Qty]  DEFAULT ((0)) FOR [Qty]
GO
ALTER TABLE [dbo].[P2U_OrderOTCMeds] ADD  CONSTRAINT [DEFAULT_P2U_OrderOTCMeds_Taxable]  DEFAULT ((1)) FOR [Taxable]
GO
ALTER TABLE [dbo].[P2U_OTCMedication] ADD  CONSTRAINT [DEFAULT_P2U_OTCMedication_ItemGUID]  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [ItemGUID]
GO
ALTER TABLE [dbo].[P2U_OTCMedication] ADD  CONSTRAINT [DEFAULT_P2U_OTCMedication_Name]  DEFAULT (N'') FOR [Name]
GO
ALTER TABLE [dbo].[P2U_OTCMedication] ADD  CONSTRAINT [DEFAULT_P2U_OTCMedication_Price]  DEFAULT ('0') FOR [Price]
GO
ALTER TABLE [dbo].[P2U_OTCMedication] ADD  CONSTRAINT [DEFAULT_P2U_OTCMedication_Taxable]  DEFAULT ((1)) FOR [Taxable]
GO
ALTER TABLE [dbo].[P2U_Pharmacy] ADD  CONSTRAINT [DEFAULT_P2U_Pharmacy_ItemGUID]  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [ItemGUID]
GO
ALTER TABLE [dbo].[P2U_Pharmacy] ADD  CONSTRAINT [DEFAULT_P2U_Pharmacy_Name]  DEFAULT (N'') FOR [Name]
GO
ALTER TABLE [dbo].[P2U_Pharmacy] ADD  CONSTRAINT [DEFAULT_P2U_Pharmacy_TaxRate]  DEFAULT ('0.07') FOR [TaxRate]
GO
ALTER TABLE [dbo].[P2U_Provider] ADD  CONSTRAINT [DEFAULT_P2U_Provider_ItemGUID]  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [ItemGUID]
GO
ALTER TABLE [dbo].[P2U_ReturnedReason] ADD  CONSTRAINT [DEFAULT_P2U_ReturnedReason_ItemGUID]  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [ItemGUID]
GO
ALTER TABLE [dbo].[P2U_ReturnedReason] ADD  CONSTRAINT [DEFAULT_P2U_ReturnedReason_Reason]  DEFAULT (N'') FOR [Reason]
GO
ALTER TABLE [dbo].[P2U_Statuses] ADD  CONSTRAINT [DEFAULT_P2U_Statuses_ItemGUID]  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [ItemGUID]
GO
ALTER TABLE [dbo].[P2U_Statuses] ADD  CONSTRAINT [DEFAULT_P2U_Statuses_Status]  DEFAULT (N'') FOR [Status]
GO
ALTER TABLE [dbo].[P2U_Statuses] ADD  CONSTRAINT [DEFAULT_P2U_Statuses_ActiveStatus]  DEFAULT ((1)) FOR [ActiveStatus]
GO
ALTER TABLE [dbo].[P2U_Statuses] ADD  CONSTRAINT [DEFAULT_P2U_Statuses_DisplayText]  DEFAULT (N'') FOR [DisplayText]
GO
ALTER TABLE [dbo].[P2U_ZipCodes] ADD  CONSTRAINT [DEFAULT_P2U_ZipCodes_ItemGUID]  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [ItemGUID]
GO
ALTER TABLE [dbo].[P2U_ZipCodes] ADD  CONSTRAINT [DEFAULT_P2U_ZipCodes_Zip]  DEFAULT (N'') FOR [Zip]
GO
ALTER TABLE [dbo].[P2U_ZipCodes] ADD  CONSTRAINT [DEFAULT_P2U_ZipCodes_Country]  DEFAULT (N'USA') FOR [Country]
GO
