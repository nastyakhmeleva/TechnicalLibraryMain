
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/24/2018 00:31:41
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
IF OBJECT_ID(N'[dbo].[FK_PeopleDocEntityStudent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PeopleDocEntitySet] DROP CONSTRAINT [FK_PeopleDocEntityStudent];
GO
IF OBJECT_ID(N'[dbo].[FK_TypeDocument]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DocumentSet] DROP CONSTRAINT [FK_TypeDocument];
GO
IF OBJECT_ID(N'[dbo].[FK_StudentEducationDirection]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StudentSet] DROP CONSTRAINT [FK_StudentEducationDirection];
GO
IF OBJECT_ID(N'[dbo].[FK_StudyGroupEducationDirection]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EducationDirectionSet] DROP CONSTRAINT [FK_StudyGroupEducationDirection];
GO
IF OBJECT_ID(N'[dbo].[FK_DepartmentEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeSet] DROP CONSTRAINT [FK_DepartmentEmployee];
GO
IF OBJECT_ID(N'[dbo].[FK_NoteStudent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NoteSet] DROP CONSTRAINT [FK_NoteStudent];
GO
IF OBJECT_ID(N'[dbo].[FK_NoteEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NoteSet] DROP CONSTRAINT [FK_NoteEmployee];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EmployeeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeeSet];
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
IF OBJECT_ID(N'[dbo].[StudentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StudentSet];
GO
IF OBJECT_ID(N'[dbo].[TypeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeSet];
GO
IF OBJECT_ID(N'[dbo].[EducationDirectionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EducationDirectionSet];
GO
IF OBJECT_ID(N'[dbo].[StudyGroupSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StudyGroupSet];
GO
IF OBJECT_ID(N'[dbo].[DepartmentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DepartmentSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EmployeeSet'
CREATE TABLE [dbo].[EmployeeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [AcademicTitle] nvarchar(max)  NULL,
    [AcademicDegree] nvarchar(max)  NULL,
    [Department_Id] int  NOT NULL
);
GO

-- Creating table 'DocumentSet'
CREATE TABLE [dbo].[DocumentSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Year] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [PrintCopy] nvarchar(max)  NOT NULL,
    [ElectroCopy] nvarchar(max)  NOT NULL,
    [BookAuthor] nvarchar(max)  NULL,
    [NumberOfCopy] int  NOT NULL,
    [Type_Id] int  NOT NULL
);
GO

-- Creating table 'NoteSet'
CREATE TABLE [dbo].[NoteSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DateOfIssue] nvarchar(max)  NOT NULL,
    [StatusOfIssue] nvarchar(max)  NOT NULL,
    [NumberOfCopy] int  NOT NULL,
    [Document_Id] int  NOT NULL,
    [Student_Id] int  NULL,
    [Employee_Id] int  NULL
);
GO

-- Creating table 'PeopleDocEntitySet'
CREATE TABLE [dbo].[PeopleDocEntitySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Employee_Id] int  NULL,
    [Document_Id] int  NOT NULL,
    [Student_Id] int  NULL
);
GO

-- Creating table 'StudentSet'
CREATE TABLE [dbo].[StudentSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [StudyGroup_Id] int  NOT NULL
);
GO

-- Creating table 'TypeSet'
CREATE TABLE [dbo].[TypeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EducationDirectionSet'
CREATE TABLE [dbo].[EducationDirectionSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'StudyGroupSet'
CREATE TABLE [dbo].[StudyGroupSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [EducationDirection_Id] int  NOT NULL
);
GO

-- Creating table 'DepartmentSet'
CREATE TABLE [dbo].[DepartmentSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EmployeeSet'
ALTER TABLE [dbo].[EmployeeSet]
ADD CONSTRAINT [PK_EmployeeSet]
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

-- Creating primary key on [Id] in table 'StudentSet'
ALTER TABLE [dbo].[StudentSet]
ADD CONSTRAINT [PK_StudentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TypeSet'
ALTER TABLE [dbo].[TypeSet]
ADD CONSTRAINT [PK_TypeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EducationDirectionSet'
ALTER TABLE [dbo].[EducationDirectionSet]
ADD CONSTRAINT [PK_EducationDirectionSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StudyGroupSet'
ALTER TABLE [dbo].[StudyGroupSet]
ADD CONSTRAINT [PK_StudyGroupSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DepartmentSet'
ALTER TABLE [dbo].[DepartmentSet]
ADD CONSTRAINT [PK_DepartmentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Employee_Id] in table 'PeopleDocEntitySet'
ALTER TABLE [dbo].[PeopleDocEntitySet]
ADD CONSTRAINT [FK_StDocEntityStudent]
    FOREIGN KEY ([Employee_Id])
    REFERENCES [dbo].[EmployeeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StDocEntityStudent'
CREATE INDEX [IX_FK_StDocEntityStudent]
ON [dbo].[PeopleDocEntitySet]
    ([Employee_Id]);
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

-- Creating foreign key on [Student_Id] in table 'PeopleDocEntitySet'
ALTER TABLE [dbo].[PeopleDocEntitySet]
ADD CONSTRAINT [FK_PeopleDocEntityStudent]
    FOREIGN KEY ([Student_Id])
    REFERENCES [dbo].[StudentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PeopleDocEntityStudent'
CREATE INDEX [IX_FK_PeopleDocEntityStudent]
ON [dbo].[PeopleDocEntitySet]
    ([Student_Id]);
GO

-- Creating foreign key on [Type_Id] in table 'DocumentSet'
ALTER TABLE [dbo].[DocumentSet]
ADD CONSTRAINT [FK_TypeDocument]
    FOREIGN KEY ([Type_Id])
    REFERENCES [dbo].[TypeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TypeDocument'
CREATE INDEX [IX_FK_TypeDocument]
ON [dbo].[DocumentSet]
    ([Type_Id]);
GO

-- Creating foreign key on [EducationDirection_Id] in table 'StudyGroupSet'
ALTER TABLE [dbo].[StudyGroupSet]
ADD CONSTRAINT [FK_StudyGroupEducationDirection]
    FOREIGN KEY ([EducationDirection_Id])
    REFERENCES [dbo].[EducationDirectionSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudyGroupEducationDirection'
CREATE INDEX [IX_FK_StudyGroupEducationDirection]
ON [dbo].[StudyGroupSet]
    ([EducationDirection_Id]);
GO

-- Creating foreign key on [Department_Id] in table 'EmployeeSet'
ALTER TABLE [dbo].[EmployeeSet]
ADD CONSTRAINT [FK_DepartmentEmployee]
    FOREIGN KEY ([Department_Id])
    REFERENCES [dbo].[DepartmentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmentEmployee'
CREATE INDEX [IX_FK_DepartmentEmployee]
ON [dbo].[EmployeeSet]
    ([Department_Id]);
GO

-- Creating foreign key on [Student_Id] in table 'NoteSet'
ALTER TABLE [dbo].[NoteSet]
ADD CONSTRAINT [FK_NoteStudent]
    FOREIGN KEY ([Student_Id])
    REFERENCES [dbo].[StudentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NoteStudent'
CREATE INDEX [IX_FK_NoteStudent]
ON [dbo].[NoteSet]
    ([Student_Id]);
GO

-- Creating foreign key on [Employee_Id] in table 'NoteSet'
ALTER TABLE [dbo].[NoteSet]
ADD CONSTRAINT [FK_NoteEmployee]
    FOREIGN KEY ([Employee_Id])
    REFERENCES [dbo].[EmployeeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NoteEmployee'
CREATE INDEX [IX_FK_NoteEmployee]
ON [dbo].[NoteSet]
    ([Employee_Id]);
GO

-- Creating foreign key on [StudyGroup_Id] in table 'StudentSet'
ALTER TABLE [dbo].[StudentSet]
ADD CONSTRAINT [FK_StudentStudyGroup]
    FOREIGN KEY ([StudyGroup_Id])
    REFERENCES [dbo].[StudyGroupSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentStudyGroup'
CREATE INDEX [IX_FK_StudentStudyGroup]
ON [dbo].[StudentSet]
    ([StudyGroup_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------