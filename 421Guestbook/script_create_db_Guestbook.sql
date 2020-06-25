DROP DATABASE Guestbook
GO

CREATE DATABASE Guestbook
GO

USE Guestbook
GO
/****** Object:  Table [dbo].[Messages]    Script Date: 11/27/2016 3:10:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Messages](
	[MessageID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [varchar](20) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Message] [text] NOT NULL,
 CONSTRAINT [PK__Messages__7C8480AE] PRIMARY KEY CLUSTERED 
(
	[MessageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Messages] ON 

INSERT [dbo].[Messages] ([MessageID], [Date], [Name], [Email], [Message]) VALUES (3, N'10/27/2016', N'Bob Green', N'bgreen@bug2bug.com', N'Great site!')
INSERT [dbo].[Messages] ([MessageID], [Date], [Name], [Email], [Message]) VALUES (4, N'9/28/2016', N'Sue Black', N'sblack@bug2bug.com', N'I love the site! Keep up the good work!')
INSERT [dbo].[Messages] ([MessageID], [Date], [Name], [Email], [Message]) VALUES (10, N'8/29/2016', N'Liz White', N'lwhite@bug2bug.com', N'Very useful information. Will visit again soon.')
SET IDENTITY_INSERT [dbo].[Messages] OFF
USE [master]
GO
ALTER DATABASE Guestbook SET  READ_WRITE 
GO
