USE [LojistikVeritabanı]
GO
/****** Object:  Table [dbo].[AlıcıFirmaSet]    Script Date: 11.04.2019 15:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlıcıFirmaSet](
	[AlıcıFirmaID] [int] IDENTITY(1,1) NOT NULL,
	[Adı] [nvarchar](max) NOT NULL,
	[Adres] [nvarchar](max) NOT NULL,
	[Telefon] [int] NOT NULL,
	[FirmalarFirmaID] [int] NOT NULL,
 CONSTRAINT [PK_AlıcıFirmaSet] PRIMARY KEY CLUSTERED 
(
	[AlıcıFirmaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DepartmanSet]    Script Date: 11.04.2019 15:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DepartmanSet](
	[DeparmanID] [int] IDENTITY(1,1) NOT NULL,
	[DepartmanAdı] [nvarchar](max) NOT NULL,
	[FirmalarFirmaID] [int] NOT NULL,
 CONSTRAINT [PK_DepartmanSet] PRIMARY KEY CLUSTERED 
(
	[DeparmanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FirmalarSet]    Script Date: 11.04.2019 15:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FirmalarSet](
	[FirmaID] [int] IDENTITY(1,1) NOT NULL,
	[FirmaTipi] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_FirmalarSet] PRIMARY KEY CLUSTERED 
(
	[FirmaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PersonelSet]    Script Date: 11.04.2019 15:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonelSet](
	[PersonelID] [int] IDENTITY(1,1) NOT NULL,
	[PersonlAdı] [nvarchar](max) NOT NULL,
	[PersonelSoyadı] [nvarchar](max) NOT NULL,
	[Telefon] [int] NOT NULL,
	[Adres] [nvarchar](max) NOT NULL,
	[DepartmanDeparmanID] [int] NOT NULL,
 CONSTRAINT [PK_PersonelSet] PRIMARY KEY CLUSTERED 
(
	[PersonelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SevkiyatSet]    Script Date: 11.04.2019 15:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SevkiyatSet](
	[SevkiyatID] [int] IDENTITY(1,1) NOT NULL,
	[SevkAdı] [nvarchar](max) NOT NULL,
	[Ülke] [nvarchar](max) NOT NULL,
	[ÜrünlerÜrünID] [int] NOT NULL,
	[FirmalarFirmaID] [int] NOT NULL,
 CONSTRAINT [PK_SevkiyatSet] PRIMARY KEY CLUSTERED 
(
	[SevkiyatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaşıyıcıFirmaSet]    Script Date: 11.04.2019 15:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaşıyıcıFirmaSet](
	[TaşıyıcıFirmaID] [int] IDENTITY(1,1) NOT NULL,
	[Adı] [nvarchar](max) NOT NULL,
	[Adres] [nvarchar](max) NOT NULL,
	[Telefon] [int] NOT NULL,
	[TaşımaŞekli] [nvarchar](max) NOT NULL,
	[FirmalarFirmaID] [int] NOT NULL,
 CONSTRAINT [PK_TaşıyıcıFirmaSet] PRIMARY KEY CLUSTERED 
(
	[TaşıyıcıFirmaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ÜreticiFirmaSet]    Script Date: 11.04.2019 15:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ÜreticiFirmaSet](
	[ÜreticiFirmaID] [int] IDENTITY(1,1) NOT NULL,
	[Adı] [nvarchar](max) NOT NULL,
	[Adres] [nvarchar](max) NOT NULL,
	[Telefon] [int] NOT NULL,
	[FirmalarFirmaID] [int] NOT NULL,
 CONSTRAINT [PK_ÜreticiFirmaSet] PRIMARY KEY CLUSTERED 
(
	[ÜreticiFirmaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ÜrünlerSet]    Script Date: 11.04.2019 15:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ÜrünlerSet](
	[ÜrünID] [int] IDENTITY(1,1) NOT NULL,
	[ÜrünAdı] [nvarchar](max) NOT NULL,
	[StokMiktar] [int] NOT NULL,
	[ÜrünTipi] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_ÜrünlerSet] PRIMARY KEY CLUSTERED 
(
	[ÜrünID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[AlıcıFirmaSet]  WITH CHECK ADD  CONSTRAINT [FK_FirmalarAlıcıFirma] FOREIGN KEY([FirmalarFirmaID])
REFERENCES [dbo].[FirmalarSet] ([FirmaID])
GO
ALTER TABLE [dbo].[AlıcıFirmaSet] CHECK CONSTRAINT [FK_FirmalarAlıcıFirma]
GO
ALTER TABLE [dbo].[DepartmanSet]  WITH CHECK ADD  CONSTRAINT [FK_FirmalarDepartman] FOREIGN KEY([FirmalarFirmaID])
REFERENCES [dbo].[FirmalarSet] ([FirmaID])
GO
ALTER TABLE [dbo].[DepartmanSet] CHECK CONSTRAINT [FK_FirmalarDepartman]
GO
ALTER TABLE [dbo].[PersonelSet]  WITH CHECK ADD  CONSTRAINT [FK_DepartmanPersonel] FOREIGN KEY([DepartmanDeparmanID])
REFERENCES [dbo].[DepartmanSet] ([DeparmanID])
GO
ALTER TABLE [dbo].[PersonelSet] CHECK CONSTRAINT [FK_DepartmanPersonel]
GO
ALTER TABLE [dbo].[SevkiyatSet]  WITH CHECK ADD  CONSTRAINT [FK_FirmalarSevkiyat] FOREIGN KEY([FirmalarFirmaID])
REFERENCES [dbo].[FirmalarSet] ([FirmaID])
GO
ALTER TABLE [dbo].[SevkiyatSet] CHECK CONSTRAINT [FK_FirmalarSevkiyat]
GO
ALTER TABLE [dbo].[SevkiyatSet]  WITH CHECK ADD  CONSTRAINT [FK_ÜrünlerSevkiyat] FOREIGN KEY([ÜrünlerÜrünID])
REFERENCES [dbo].[ÜrünlerSet] ([ÜrünID])
GO
ALTER TABLE [dbo].[SevkiyatSet] CHECK CONSTRAINT [FK_ÜrünlerSevkiyat]
GO
ALTER TABLE [dbo].[TaşıyıcıFirmaSet]  WITH CHECK ADD  CONSTRAINT [FK_FirmalarTaşıyıcıFirma] FOREIGN KEY([FirmalarFirmaID])
REFERENCES [dbo].[FirmalarSet] ([FirmaID])
GO
ALTER TABLE [dbo].[TaşıyıcıFirmaSet] CHECK CONSTRAINT [FK_FirmalarTaşıyıcıFirma]
GO
ALTER TABLE [dbo].[ÜreticiFirmaSet]  WITH CHECK ADD  CONSTRAINT [FK_FirmalarÜreticiFirma] FOREIGN KEY([FirmalarFirmaID])
REFERENCES [dbo].[FirmalarSet] ([FirmaID])
GO
ALTER TABLE [dbo].[ÜreticiFirmaSet] CHECK CONSTRAINT [FK_FirmalarÜreticiFirma]
GO
