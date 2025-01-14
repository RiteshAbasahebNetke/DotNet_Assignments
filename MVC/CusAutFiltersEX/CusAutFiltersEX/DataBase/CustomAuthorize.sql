USE [CustomAuthorize]
GO
/****** Object:  Table [dbo].[ProductTbl]    Script Date: 6/20/2024 3:20:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTbl](
	[ProductID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[MfgName] [varchar](50) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_ProductTbl] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTbl]    Script Date: 6/20/2024 3:20:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTbl](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[EmailID] [nvarchar](50) NOT NULL,
	[MobileNo] [varchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_UserTbl] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ProductTbl] ON 

INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [MfgName], [Price]) VALUES (5, N'DeskTop', N'Dell', CAST(22300 AS Decimal(18, 0)))
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [MfgName], [Price]) VALUES (6, N'Mouse', N'HP', CAST(650 AS Decimal(18, 0)))
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [MfgName], [Price]) VALUES (7, N'HardDisk', N'HUL', CAST(5600 AS Decimal(18, 0)))
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [MfgName], [Price]) VALUES (8, N'KeyBoard', N'Dell', CAST(1600 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[ProductTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[UserTbl] ON 

INSERT [dbo].[UserTbl] ([ID], [FirstName], [LastName], [Address], [EmailID], [MobileNo], [Password]) VALUES (5, N'Ravi', N'Verma', N'Chikhali', N'ravi@gmail.com', N'8564136516', N'abc')
INSERT [dbo].[UserTbl] ([ID], [FirstName], [LastName], [Address], [EmailID], [MobileNo], [Password]) VALUES (6, N'Suresh', N'Sharma', N'Akurdi', N'suresh@outlook.com', N'9874562013', N'pqr')
INSERT [dbo].[UserTbl] ([ID], [FirstName], [LastName], [Address], [EmailID], [MobileNo], [Password]) VALUES (7, N'Sachin', N'Sharma', N'Pune', N'sachin@hotmail.com', N'7896412301', N'mno')
INSERT [dbo].[UserTbl] ([ID], [FirstName], [LastName], [Address], [EmailID], [MobileNo], [Password]) VALUES (8, N'Rajesh', N'Sharma', N'Pimpri', N'rajesh@hotmail.com', N'96032140587', N'mno')
SET IDENTITY_INSERT [dbo].[UserTbl] OFF
GO
