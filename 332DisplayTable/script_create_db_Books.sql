DROP DATABASE Books
GO

CREATE DATABASE Books
GO

USE Books
GO
/****** Object:  Table [dbo].[AuthorISBN]    Script Date: 11/27/2016 9:08:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AuthorISBN](
	[AuthorID] [int] NOT NULL,
	[ISBN] [varchar](20) NOT NULL,
 CONSTRAINT [PK_AuthorISBN] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC,
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 11/27/2016 9:08:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](30) NOT NULL,
	[LastName] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Titles]    Script Date: 11/27/2019 9:08:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Titles](
	[ISBN] [varchar](20) NOT NULL,
	[Title] [varchar](100) NOT NULL,
	[EditionNumber] [int] NOT NULL,
	[Copyright] [varchar](4) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (1, N'0131752421')
INSERT [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (1, N'0132222205')
INSERT [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (1, N'0132404168')
INSERT [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (1, N'0136053033')
INSERT [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (1, N'013605305X')
INSERT [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (1, N'013605322X')
INSERT [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (1, N'0136151574')
INSERT [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (1, N'0136152503')
INSERT [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (2, N'0131752421')
INSERT [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (2, N'0132222205')
INSERT [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (2, N'0132404168')
INSERT [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (2, N'0136053033')
INSERT [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (2, N'013605305X')
INSERT [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (2, N'013605322X')
INSERT [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (2, N'0136151574')
INSERT [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (2, N'0136152503')
INSERT [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (3, N'0136053033')
INSERT [dbo].[AuthorISBN] ([AuthorID], [ISBN]) VALUES (4, N'0136151574')
SET IDENTITY_INSERT [dbo].[Authors] ON 

INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (1, N'Choo Jun', N'Tan')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (2, N'Paul', N'Sierra')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (3, N'Herbert', N'Ayer')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (4, N'Dan', N'Joel')
SET IDENTITY_INSERT [dbo].[Authors] OFF
INSERT [dbo].[Titles] ([ISBN], [Title], [EditionNumber], [Copyright]) VALUES (N'0131752421', N'Effective Java', 4, N'2018')
INSERT [dbo].[Titles] ([ISBN], [Title], [EditionNumber], [Copyright]) VALUES (N'0132222205', N'Java How to Program', 7, N'2017')
INSERT [dbo].[Titles] ([ISBN], [Title], [EditionNumber], [Copyright]) VALUES (N'0132404168', N'C How to Program', 5, N'2017')
INSERT [dbo].[Titles] ([ISBN], [Title], [EditionNumber], [Copyright]) VALUES (N'0136053033', N'Simply Visual Basic', 3, N'2019')
INSERT [dbo].[Titles] ([ISBN], [Title], [EditionNumber], [Copyright]) VALUES (N'013605305X', N'Visual Basic How to Program', 4, N'2019')
INSERT [dbo].[Titles] ([ISBN], [Title], [EditionNumber], [Copyright]) VALUES (N'013605322X', N'Visual C# How to Program', 3, N'2019')
INSERT [dbo].[Titles] ([ISBN], [Title], [EditionNumber], [Copyright]) VALUES (N'0136151574', N'Visual C++ How to Program', 2, N'2018')
INSERT [dbo].[Titles] ([ISBN], [Title], [EditionNumber], [Copyright]) VALUES (N'0136152503', N'C++ How to Program', 6, N'2018')
ALTER TABLE [dbo].[AuthorISBN]  WITH CHECK ADD FOREIGN KEY([AuthorID])
REFERENCES [dbo].[Authors] ([AuthorID])
GO
ALTER TABLE [dbo].[AuthorISBN]  WITH CHECK ADD FOREIGN KEY([ISBN])
REFERENCES [dbo].[Titles] ([ISBN])
GO


ALTER DATABASE Books SET  READ_WRITE 
GO