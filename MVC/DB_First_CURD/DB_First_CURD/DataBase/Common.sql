USE [Common]
GO
/****** Object:  Table [dbo].[AreaTbl]    Script Date: 6/20/2024 3:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AreaTbl](
	[AreaId] [bigint] NOT NULL,
	[AreaName] [varchar](50) NULL,
	[CityName] [varchar](50) NULL,
	[DeptId] [bigint] NOT NULL,
 CONSTRAINT [PK_AreaTbl] PRIMARY KEY CLUSTERED 
(
	[AreaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeptTbl]    Script Date: 6/20/2024 3:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeptTbl](
	[DeptId] [bigint] NOT NULL,
	[DeptName] [varchar](50) NULL,
	[EmpId] [bigint] NOT NULL,
 CONSTRAINT [PK_DeptTbl] PRIMARY KEY CLUSTERED 
(
	[DeptId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmpTbl]    Script Date: 6/20/2024 3:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpTbl](
	[EmpId] [bigint] NOT NULL,
	[EmpName] [varchar](50) NULL,
	[EmailId] [varchar](50) NULL,
	[Salary] [decimal](18, 0) NULL,
	[DeptId] [bigint] NULL,
 CONSTRAINT [PK_EmpTbl_1] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AreaTbl] ([AreaId], [AreaName], [CityName], [DeptId]) VALUES (1, N'Akurdi', N'Pune', 2)
INSERT [dbo].[AreaTbl] ([AreaId], [AreaName], [CityName], [DeptId]) VALUES (2, N'Nigdi', N'Pune', 4)
INSERT [dbo].[AreaTbl] ([AreaId], [AreaName], [CityName], [DeptId]) VALUES (3, N'Shivajinagar', N'Pune', 3)
INSERT [dbo].[AreaTbl] ([AreaId], [AreaName], [CityName], [DeptId]) VALUES (4, N'Katraj', N'Pune', 1)
INSERT [dbo].[AreaTbl] ([AreaId], [AreaName], [CityName], [DeptId]) VALUES (5, N'Khed', N'Pune', 6)
INSERT [dbo].[AreaTbl] ([AreaId], [AreaName], [CityName], [DeptId]) VALUES (6, N'Wagholi', N'Pune', 5)
INSERT [dbo].[AreaTbl] ([AreaId], [AreaName], [CityName], [DeptId]) VALUES (7, N'KhadeNagar', N'Jamkhed', 7)
GO
INSERT [dbo].[DeptTbl] ([DeptId], [DeptName], [EmpId]) VALUES (1, N'HR', 1)
INSERT [dbo].[DeptTbl] ([DeptId], [DeptName], [EmpId]) VALUES (2, N'Sales', 2)
INSERT [dbo].[DeptTbl] ([DeptId], [DeptName], [EmpId]) VALUES (3, N'Production', 4)
INSERT [dbo].[DeptTbl] ([DeptId], [DeptName], [EmpId]) VALUES (4, N'Process', 6)
INSERT [dbo].[DeptTbl] ([DeptId], [DeptName], [EmpId]) VALUES (5, N'IT', 3)
INSERT [dbo].[DeptTbl] ([DeptId], [DeptName], [EmpId]) VALUES (6, N'Purchase', 5)
INSERT [dbo].[DeptTbl] ([DeptId], [DeptName], [EmpId]) VALUES (7, N'NA', 6)
GO
INSERT [dbo].[EmpTbl] ([EmpId], [EmpName], [EmailId], [Salary], [DeptId]) VALUES (1, N'Ashish', N'ashish@gmail.com', CAST(16000 AS Decimal(18, 0)), 3)
INSERT [dbo].[EmpTbl] ([EmpId], [EmpName], [EmailId], [Salary], [DeptId]) VALUES (2, N'Sham', N'sham@gmail.com', CAST(26000 AS Decimal(18, 0)), 7)
INSERT [dbo].[EmpTbl] ([EmpId], [EmpName], [EmailId], [Salary], [DeptId]) VALUES (3, N'Manisha', N'manisha@hotmail.com', CAST(30000 AS Decimal(18, 0)), 1)
INSERT [dbo].[EmpTbl] ([EmpId], [EmpName], [EmailId], [Salary], [DeptId]) VALUES (4, N'Monisha', N'monisha@gmail.com', CAST(18000 AS Decimal(18, 0)), 2)
INSERT [dbo].[EmpTbl] ([EmpId], [EmpName], [EmailId], [Salary], [DeptId]) VALUES (5, N'Manoj', N'manoj@gmail.com', CAST(37000 AS Decimal(18, 0)), 3)
INSERT [dbo].[EmpTbl] ([EmpId], [EmpName], [EmailId], [Salary], [DeptId]) VALUES (6, N'Sunita', N'sunita@hotmail.com', CAST(48000 AS Decimal(18, 0)), 4)
INSERT [dbo].[EmpTbl] ([EmpId], [EmpName], [EmailId], [Salary], [DeptId]) VALUES (7, N'Revti', N'revti@gmail.com', CAST(15000 AS Decimal(18, 0)), 5)
INSERT [dbo].[EmpTbl] ([EmpId], [EmpName], [EmailId], [Salary], [DeptId]) VALUES (8, N'Onkar', N'onkar@gmail.com', CAST(50000 AS Decimal(18, 0)), 6)
INSERT [dbo].[EmpTbl] ([EmpId], [EmpName], [EmailId], [Salary], [DeptId]) VALUES (9, N'Suresh', N'suresh@hotmail.com', CAST(67000 AS Decimal(18, 0)), 7)
INSERT [dbo].[EmpTbl] ([EmpId], [EmpName], [EmailId], [Salary], [DeptId]) VALUES (10, N'Sneha', N'sneha@hotmail.com', CAST(62000 AS Decimal(18, 0)), 4)
GO
ALTER TABLE [dbo].[AreaTbl]  WITH CHECK ADD  CONSTRAINT [FK_AreaTbl_DeptTbl] FOREIGN KEY([DeptId])
REFERENCES [dbo].[DeptTbl] ([DeptId])
GO
ALTER TABLE [dbo].[AreaTbl] CHECK CONSTRAINT [FK_AreaTbl_DeptTbl]
GO
ALTER TABLE [dbo].[EmpTbl]  WITH CHECK ADD  CONSTRAINT [FK_EmpTbl_DeptTbl] FOREIGN KEY([DeptId])
REFERENCES [dbo].[DeptTbl] ([DeptId])
GO
ALTER TABLE [dbo].[EmpTbl] CHECK CONSTRAINT [FK_EmpTbl_DeptTbl]
GO
