USE [CodeFirstDb]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 6/21/2024 3:53:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [bigint] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](max) NULL,
	[EmailId] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[MobileNo] [nvarchar](max) NULL,
	[CreditLimit] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_dbo.Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [EmailId], [Address], [MobileNo], [CreditLimit]) VALUES (1, N'Ajay', N'ajay@hotmail.com', N'Akurdi', N'7852335112', CAST(6000.00 AS Decimal(18, 2)))
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [EmailId], [Address], [MobileNo], [CreditLimit]) VALUES (2, N'Sunil', N'sunil@outlook.com', N'Nigdi', N'9621330455', CAST(10000.00 AS Decimal(18, 2)))
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [EmailId], [Address], [MobileNo], [CreditLimit]) VALUES (3, N'Manoj', N'manoj@gmail..com', N'Nigdi', N'7852123664', CAST(12000.00 AS Decimal(18, 2)))
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [EmailId], [Address], [MobileNo], [CreditLimit]) VALUES (4, N'Onkar', N'onkar@hotmail.com', N'Akurdi', N'8974421123', CAST(10000.00 AS Decimal(18, 2)))
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [EmailId], [Address], [MobileNo], [CreditLimit]) VALUES (5, N'Raj', N'raj@outlook.com', N'Pimpri', N'7485963201', CAST(9500.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
