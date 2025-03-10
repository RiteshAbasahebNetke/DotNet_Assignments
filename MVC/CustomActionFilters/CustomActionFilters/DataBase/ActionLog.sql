USE [ActionLog]
GO
/****** Object:  Table [dbo].[ActionLog]    Script Date: 6/20/2024 2:57:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActionLog](
	[ActionlogID] [bigint] IDENTITY(1,1) NOT NULL,
	[ActionName] [varchar](50) NOT NULL,
	[ControllerName] [varchar](50) NOT NULL,
	[LogDateTime] [date] NOT NULL,
 CONSTRAINT [PK_ActionLog] PRIMARY KEY CLUSTERED 
(
	[ActionlogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ActionLog] ON 

INSERT [dbo].[ActionLog] ([ActionlogID], [ActionName], [ControllerName], [LogDateTime]) VALUES (0, N'index', N'Test', CAST(N'2024-06-03' AS Date))
INSERT [dbo].[ActionLog] ([ActionlogID], [ActionName], [ControllerName], [LogDateTime]) VALUES (1, N'index', N'Test', CAST(N'2024-06-03' AS Date))
INSERT [dbo].[ActionLog] ([ActionlogID], [ActionName], [ControllerName], [LogDateTime]) VALUES (2, N'index', N'Test', CAST(N'2024-06-03' AS Date))
INSERT [dbo].[ActionLog] ([ActionlogID], [ActionName], [ControllerName], [LogDateTime]) VALUES (3, N'Index', N'Test', CAST(N'2024-06-03' AS Date))
INSERT [dbo].[ActionLog] ([ActionlogID], [ActionName], [ControllerName], [LogDateTime]) VALUES (4, N'about', N'Test', CAST(N'2024-06-03' AS Date))
SET IDENTITY_INSERT [dbo].[ActionLog] OFF
GO
