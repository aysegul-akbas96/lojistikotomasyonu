
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/11/2019 11:55:17
-- Generated from EDMX file: C:\Users\smart.ogrenci\Desktop\Lojistik Projesi--11Nisan2019\Lojistik Projesi--11Nisan2019\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [LojistikVeritabanı];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_DepartmanPersonel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonelSet] DROP CONSTRAINT [FK_DepartmanPersonel];
GO
IF OBJECT_ID(N'[dbo].[FK_FirmalarAlıcıFirma]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlıcıFirmaSet] DROP CONSTRAINT [FK_FirmalarAlıcıFirma];
GO
IF OBJECT_ID(N'[dbo].[FK_FirmalarTaşıyıcıFirma]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TaşıyıcıFirmaSet] DROP CONSTRAINT [FK_FirmalarTaşıyıcıFirma];
GO
IF OBJECT_ID(N'[dbo].[FK_FirmalarÜreticiFirma]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ÜreticiFirmaSet] DROP CONSTRAINT [FK_FirmalarÜreticiFirma];
GO
IF OBJECT_ID(N'[dbo].[FK_FirmalarDepartman]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DepartmanSet] DROP CONSTRAINT [FK_FirmalarDepartman];
GO
IF OBJECT_ID(N'[dbo].[FK_ÜrünlerSevkiyat]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SevkiyatSet] DROP CONSTRAINT [FK_ÜrünlerSevkiyat];
GO
IF OBJECT_ID(N'[dbo].[FK_FirmalarSevkiyat]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SevkiyatSet] DROP CONSTRAINT [FK_FirmalarSevkiyat];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ÜrünlerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ÜrünlerSet];
GO
IF OBJECT_ID(N'[dbo].[DepartmanSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DepartmanSet];
GO
IF OBJECT_ID(N'[dbo].[PersonelSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonelSet];
GO
IF OBJECT_ID(N'[dbo].[TaşıyıcıFirmaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TaşıyıcıFirmaSet];
GO
IF OBJECT_ID(N'[dbo].[ÜreticiFirmaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ÜreticiFirmaSet];
GO
IF OBJECT_ID(N'[dbo].[SevkiyatSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SevkiyatSet];
GO
IF OBJECT_ID(N'[dbo].[AlıcıFirmaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AlıcıFirmaSet];
GO
IF OBJECT_ID(N'[dbo].[FirmalarSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FirmalarSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ÜrünlerSet'
CREATE TABLE [dbo].[ÜrünlerSet] (
    [ÜrünID] int IDENTITY(1,1) NOT NULL,
    [ÜrünAdı] nvarchar(max)  NOT NULL,
    [StokMiktar] int  NOT NULL,
    [ÜrünTipi] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DepartmanSet'
CREATE TABLE [dbo].[DepartmanSet] (
    [DeparmanID] int IDENTITY(1,1) NOT NULL,
    [DepartmanAdı] nvarchar(max)  NOT NULL,
    [FirmalarFirmaID] int  NOT NULL
);
GO

-- Creating table 'PersonelSet'
CREATE TABLE [dbo].[PersonelSet] (
    [PersonelID] int IDENTITY(1,1) NOT NULL,
    [PersonlAdı] nvarchar(max)  NOT NULL,
    [PersonelSoyadı] nvarchar(max)  NOT NULL,
    [Telefon] int  NOT NULL,
    [Adres] nvarchar(max)  NOT NULL,
    [DepartmanDeparmanID] int  NOT NULL
);
GO

-- Creating table 'TaşıyıcıFirmaSet'
CREATE TABLE [dbo].[TaşıyıcıFirmaSet] (
    [TaşıyıcıFirmaID] int IDENTITY(1,1) NOT NULL,
    [Adı] nvarchar(max)  NOT NULL,
    [Adres] nvarchar(max)  NOT NULL,
    [Telefon] int  NOT NULL,
    [TaşımaŞekli] nvarchar(max)  NOT NULL,
    [FirmalarFirmaID] int  NOT NULL
);
GO

-- Creating table 'ÜreticiFirmaSet'
CREATE TABLE [dbo].[ÜreticiFirmaSet] (
    [ÜreticiFirmaID] int IDENTITY(1,1) NOT NULL,
    [Adı] nvarchar(max)  NOT NULL,
    [Adres] nvarchar(max)  NOT NULL,
    [Telefon] int  NOT NULL,
    [FirmalarFirmaID] int  NOT NULL
);
GO

-- Creating table 'SevkiyatSet'
CREATE TABLE [dbo].[SevkiyatSet] (
    [SevkiyatID] int IDENTITY(1,1) NOT NULL,
    [SevkAdı] nvarchar(max)  NOT NULL,
    [Ülke] nvarchar(max)  NOT NULL,
    [ÜrünlerÜrünID] int  NOT NULL,
    [FirmalarFirmaID] int  NOT NULL
);
GO

-- Creating table 'AlıcıFirmaSet'
CREATE TABLE [dbo].[AlıcıFirmaSet] (
    [AlıcıFirmaID] int IDENTITY(1,1) NOT NULL,
    [Adı] nvarchar(max)  NOT NULL,
    [Adres] nvarchar(max)  NOT NULL,
    [Telefon] int  NOT NULL,
    [FirmalarFirmaID] int  NOT NULL
);
GO

-- Creating table 'FirmalarSet'
CREATE TABLE [dbo].[FirmalarSet] (
    [FirmaID] int IDENTITY(1,1) NOT NULL,
    [FirmaTipi] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ÜrünID] in table 'ÜrünlerSet'
ALTER TABLE [dbo].[ÜrünlerSet]
ADD CONSTRAINT [PK_ÜrünlerSet]
    PRIMARY KEY CLUSTERED ([ÜrünID] ASC);
GO

-- Creating primary key on [DeparmanID] in table 'DepartmanSet'
ALTER TABLE [dbo].[DepartmanSet]
ADD CONSTRAINT [PK_DepartmanSet]
    PRIMARY KEY CLUSTERED ([DeparmanID] ASC);
GO

-- Creating primary key on [PersonelID] in table 'PersonelSet'
ALTER TABLE [dbo].[PersonelSet]
ADD CONSTRAINT [PK_PersonelSet]
    PRIMARY KEY CLUSTERED ([PersonelID] ASC);
GO

-- Creating primary key on [TaşıyıcıFirmaID] in table 'TaşıyıcıFirmaSet'
ALTER TABLE [dbo].[TaşıyıcıFirmaSet]
ADD CONSTRAINT [PK_TaşıyıcıFirmaSet]
    PRIMARY KEY CLUSTERED ([TaşıyıcıFirmaID] ASC);
GO

-- Creating primary key on [ÜreticiFirmaID] in table 'ÜreticiFirmaSet'
ALTER TABLE [dbo].[ÜreticiFirmaSet]
ADD CONSTRAINT [PK_ÜreticiFirmaSet]
    PRIMARY KEY CLUSTERED ([ÜreticiFirmaID] ASC);
GO

-- Creating primary key on [SevkiyatID] in table 'SevkiyatSet'
ALTER TABLE [dbo].[SevkiyatSet]
ADD CONSTRAINT [PK_SevkiyatSet]
    PRIMARY KEY CLUSTERED ([SevkiyatID] ASC);
GO

-- Creating primary key on [AlıcıFirmaID] in table 'AlıcıFirmaSet'
ALTER TABLE [dbo].[AlıcıFirmaSet]
ADD CONSTRAINT [PK_AlıcıFirmaSet]
    PRIMARY KEY CLUSTERED ([AlıcıFirmaID] ASC);
GO

-- Creating primary key on [FirmaID] in table 'FirmalarSet'
ALTER TABLE [dbo].[FirmalarSet]
ADD CONSTRAINT [PK_FirmalarSet]
    PRIMARY KEY CLUSTERED ([FirmaID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DepartmanDeparmanID] in table 'PersonelSet'
ALTER TABLE [dbo].[PersonelSet]
ADD CONSTRAINT [FK_DepartmanPersonel]
    FOREIGN KEY ([DepartmanDeparmanID])
    REFERENCES [dbo].[DepartmanSet]
        ([DeparmanID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmanPersonel'
CREATE INDEX [IX_FK_DepartmanPersonel]
ON [dbo].[PersonelSet]
    ([DepartmanDeparmanID]);
GO

-- Creating foreign key on [FirmalarFirmaID] in table 'AlıcıFirmaSet'
ALTER TABLE [dbo].[AlıcıFirmaSet]
ADD CONSTRAINT [FK_FirmalarAlıcıFirma]
    FOREIGN KEY ([FirmalarFirmaID])
    REFERENCES [dbo].[FirmalarSet]
        ([FirmaID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FirmalarAlıcıFirma'
CREATE INDEX [IX_FK_FirmalarAlıcıFirma]
ON [dbo].[AlıcıFirmaSet]
    ([FirmalarFirmaID]);
GO

-- Creating foreign key on [FirmalarFirmaID] in table 'TaşıyıcıFirmaSet'
ALTER TABLE [dbo].[TaşıyıcıFirmaSet]
ADD CONSTRAINT [FK_FirmalarTaşıyıcıFirma]
    FOREIGN KEY ([FirmalarFirmaID])
    REFERENCES [dbo].[FirmalarSet]
        ([FirmaID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FirmalarTaşıyıcıFirma'
CREATE INDEX [IX_FK_FirmalarTaşıyıcıFirma]
ON [dbo].[TaşıyıcıFirmaSet]
    ([FirmalarFirmaID]);
GO

-- Creating foreign key on [FirmalarFirmaID] in table 'ÜreticiFirmaSet'
ALTER TABLE [dbo].[ÜreticiFirmaSet]
ADD CONSTRAINT [FK_FirmalarÜreticiFirma]
    FOREIGN KEY ([FirmalarFirmaID])
    REFERENCES [dbo].[FirmalarSet]
        ([FirmaID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FirmalarÜreticiFirma'
CREATE INDEX [IX_FK_FirmalarÜreticiFirma]
ON [dbo].[ÜreticiFirmaSet]
    ([FirmalarFirmaID]);
GO

-- Creating foreign key on [FirmalarFirmaID] in table 'DepartmanSet'
ALTER TABLE [dbo].[DepartmanSet]
ADD CONSTRAINT [FK_FirmalarDepartman]
    FOREIGN KEY ([FirmalarFirmaID])
    REFERENCES [dbo].[FirmalarSet]
        ([FirmaID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FirmalarDepartman'
CREATE INDEX [IX_FK_FirmalarDepartman]
ON [dbo].[DepartmanSet]
    ([FirmalarFirmaID]);
GO

-- Creating foreign key on [ÜrünlerÜrünID] in table 'SevkiyatSet'
ALTER TABLE [dbo].[SevkiyatSet]
ADD CONSTRAINT [FK_ÜrünlerSevkiyat]
    FOREIGN KEY ([ÜrünlerÜrünID])
    REFERENCES [dbo].[ÜrünlerSet]
        ([ÜrünID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ÜrünlerSevkiyat'
CREATE INDEX [IX_FK_ÜrünlerSevkiyat]
ON [dbo].[SevkiyatSet]
    ([ÜrünlerÜrünID]);
GO

-- Creating foreign key on [FirmalarFirmaID] in table 'SevkiyatSet'
ALTER TABLE [dbo].[SevkiyatSet]
ADD CONSTRAINT [FK_FirmalarSevkiyat]
    FOREIGN KEY ([FirmalarFirmaID])
    REFERENCES [dbo].[FirmalarSet]
        ([FirmaID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FirmalarSevkiyat'
CREATE INDEX [IX_FK_FirmalarSevkiyat]
ON [dbo].[SevkiyatSet]
    ([FirmalarFirmaID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------