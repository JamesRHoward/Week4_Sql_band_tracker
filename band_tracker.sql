USE [band_tracker]
GO
/****** Object:  Table [dbo].[bands]    Script Date: 12/16/2016 2:34:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bands](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[bands_venues]    Script Date: 12/16/2016 2:34:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bands_venues](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[band_id] [int] NULL,
	[venue_id] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[venues]    Script Date: 12/16/2016 2:34:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venues](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[bands] ON 

INSERT [dbo].[bands] ([id], [name]) VALUES (1, N'The Who')
INSERT [dbo].[bands] ([id], [name]) VALUES (2, N'Kiss')
INSERT [dbo].[bands] ([id], [name]) VALUES (3, N'Dethklok')
INSERT [dbo].[bands] ([id], [name]) VALUES (4, N'Iron Maiden')
SET IDENTITY_INSERT [dbo].[bands] OFF
SET IDENTITY_INSERT [dbo].[bands_venues] ON 

INSERT [dbo].[bands_venues] ([id], [band_id], [venue_id]) VALUES (1, 1, 1)
INSERT [dbo].[bands_venues] ([id], [band_id], [venue_id]) VALUES (2, 2, 1)
INSERT [dbo].[bands_venues] ([id], [band_id], [venue_id]) VALUES (3, 3, 1)
INSERT [dbo].[bands_venues] ([id], [band_id], [venue_id]) VALUES (5, 4, 1)
INSERT [dbo].[bands_venues] ([id], [band_id], [venue_id]) VALUES (6, 5, 1)
SET IDENTITY_INSERT [dbo].[bands_venues] OFF
SET IDENTITY_INSERT [dbo].[venues] ON 

INSERT [dbo].[venues] ([id], [name]) VALUES (1, N'Moda Center')
INSERT [dbo].[venues] ([id], [name]) VALUES (2, N'Keller theater')
SET IDENTITY_INSERT [dbo].[venues] OFF
