
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/23/2018 13:06:18
-- Generated from EDMX file: C:\Users\User\Source\Repos\TechnicalLibrary\TechnicalLibrary\Library.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Library];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_StDocEntityStudent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PeopleDocEntitySet] DROP CONSTRAINT [FK_StDocEntityStudent];
GO
IF OBJECT_ID(N'[dbo].[FK_NoteDocument]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NoteSet] DROP CONSTRAINT [FK_NoteDocument];
GO
IF OBJECT_ID(N'[dbo].[FK_DocumentStDocEntity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PeopleDocEntitySet] DROP CONSTRAINT [FK_DocumentStDocEntity];
GO
IF OBJECT_ID(N'[dbo].[FK_ReaderAuthor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReaderSet] DROP CONSTRAINT [FK_ReaderAuthor];
GO
IF OBJECT_ID(N'[dbo].[FK_NoteReader]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NoteSet] DROP CONSTRAINT [FK_NoteReader];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AuthorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AuthorSet];
GO
IF OBJECT_ID(N'[dbo].[DocumentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DocumentSet];
GO
IF OBJECT_ID(N'[dbo].[NoteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NoteSet];
GO
IF OBJECT_ID(N'[dbo].[PeopleDocEntitySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PeopleDocEntitySet];
GO
IF OBJECT_ID(N'[dbo].[ReaderSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReaderSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AuthorSet'
CREATE TABLE [dbo].[AuthorSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [StudyGroup] nvarchar(max)  NULL,
    [AcademicTitle] nvarchar(max)  NULL,
    [AcademicDegree] nvarchar(max)  NULL,
    [Department] nvarchar(max)  NULL
);
GO

-- Creating table 'DocumentSet'
CREATE TABLE [dbo].[DocumentSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Year] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [PrintCopy] nvarchar(max)  NOT NULL,
    [ElectroCopy] nvarchar(max)  NOT NULL,
    [BookAuthor] nvarchar(max)  NULL,
    [NumberOfCopy] int  NOT NULL
);
GO

-- Creating table 'NoteSet'
CREATE TABLE [dbo].[NoteSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DateOfIssue] nvarchar(max)  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [NumberOfCopy] int  NOT NULL,
    [Document_Id] int  NOT NULL,
    [Reader_Id] int  NOT NULL
);
GO

-- Creating table 'PeopleDocEntitySet'
CREATE TABLE [dbo].[PeopleDocEntitySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Author_Id] int  NOT NULL,
    [Document_Id] int  NOT NULL
);
GO

-- Creating table 'ReaderSet'
CREATE TABLE [dbo].[ReaderSet] (
    [Id] int  NOT NULL,
    [Author_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'AuthorSet'
ALTER TABLE [dbo].[AuthorSet]
ADD CONSTRAINT [PK_AuthorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DocumentSet'
ALTER TABLE [dbo].[DocumentSet]
ADD CONSTRAINT [PK_DocumentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NoteSet'
ALTER TABLE [dbo].[NoteSet]
ADD CONSTRAINT [PK_NoteSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PeopleDocEntitySet'
ALTER TABLE [dbo].[PeopleDocEntitySet]
ADD CONSTRAINT [PK_PeopleDocEntitySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ReaderSet'
ALTER TABLE [dbo].[ReaderSet]
ADD CONSTRAINT [PK_ReaderSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Author_Id] in table 'PeopleDocEntitySet'
ALTER TABLE [dbo].[PeopleDocEntitySet]
ADD CONSTRAINT [FK_StDocEntityStudent]
    FOREIGN KEY ([Author_Id])
    REFERENCES [dbo].[AuthorSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StDocEntityStudent'
CREATE INDEX [IX_FK_StDocEntityStudent]
ON [dbo].[PeopleDocEntitySet]
    ([Author_Id]);
GO

-- Creating foreign key on [Document_Id] in table 'NoteSet'
ALTER TABLE [dbo].[NoteSet]
ADD CONSTRAINT [FK_NoteDocument]
    FOREIGN KEY ([Document_Id])
    REFERENCES [dbo].[DocumentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NoteDocument'
CREATE INDEX [IX_FK_NoteDocument]
ON [dbo].[NoteSet]
    ([Document_Id]);
GO

-- Creating foreign key on [Document_Id] in table 'PeopleDocEntitySet'
ALTER TABLE [dbo].[PeopleDocEntitySet]
ADD CONSTRAINT [FK_DocumentStDocEntity]
    FOREIGN KEY ([Document_Id])
    REFERENCES [dbo].[DocumentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DocumentStDocEntity'
CREATE INDEX [IX_FK_DocumentStDocEntity]
ON [dbo].[PeopleDocEntitySet]
    ([Document_Id]);
GO

-- Creating foreign key on [Author_Id] in table 'ReaderSet'
ALTER TABLE [dbo].[ReaderSet]
ADD CONSTRAINT [FK_ReaderAuthor]
    FOREIGN KEY ([Author_Id])
    REFERENCES [dbo].[AuthorSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReaderAuthor'
CREATE INDEX [IX_FK_ReaderAuthor]
ON [dbo].[ReaderSet]
    ([Author_Id]);
GO

-- Creating foreign key on [Reader_Id] in table 'NoteSet'
ALTER TABLE [dbo].[NoteSet]
ADD CONSTRAINT [FK_NoteReader]
    FOREIGN KEY ([Reader_Id])
    REFERENCES [dbo].[ReaderSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NoteReader'
CREATE INDEX [IX_FK_NoteReader]
ON [dbo].[NoteSet]
    ([Reader_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------