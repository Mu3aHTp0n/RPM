
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/24/2023 00:05:10
-- Generated from EDMX file: C:\Users\koval\OneDrive\Рабочий стол\PROEKT2\WpfApp1\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [РПМ];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Student_Group]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Student] DROP CONSTRAINT [FK_Student_Group];
GO
IF OBJECT_ID(N'[dbo].[FK_Student_People]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Student] DROP CONSTRAINT [FK_Student_People];
GO
IF OBJECT_ID(N'[dbo].[FK_Teacher_People]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Teacher] DROP CONSTRAINT [FK_Teacher_People];
GO
IF OBJECT_ID(N'[dbo].[FK_User_Role_Role]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User_Role] DROP CONSTRAINT [FK_User_Role_Role];
GO
IF OBJECT_ID(N'[dbo].[FK_User_Role_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User_Role] DROP CONSTRAINT [FK_User_Role_User];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AcademicYear]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AcademicYear];
GO
IF OBJECT_ID(N'[dbo].[Discipline]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Discipline];
GO
IF OBJECT_ID(N'[dbo].[Group]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Group];
GO
IF OBJECT_ID(N'[dbo].[Journal]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Journal];
GO
IF OBJECT_ID(N'[dbo].[People]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People];
GO
IF OBJECT_ID(N'[dbo].[Role]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Role];
GO
IF OBJECT_ID(N'[dbo].[Student]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Student];
GO
IF OBJECT_ID(N'[dbo].[Teacher]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Teacher];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO
IF OBJECT_ID(N'[dbo].[User_Role]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User_Role];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AcademicYear'
CREATE TABLE [dbo].[AcademicYear] (
    [ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [StartYear] decimal(4,0)  NOT NULL,
    [EndYear] decimal(4,0)  NOT NULL
);
GO

-- Creating table 'Discipline'
CREATE TABLE [dbo].[Discipline] (
    [ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Group'
CREATE TABLE [dbo].[Group] (
    [ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [Year] decimal(4,0)  NOT NULL,
    [Litera] nvarchar(2)  NOT NULL,
    [SubGroup] decimal(1,0)  NOT NULL,
    [CountClasses] decimal(2,0)  NOT NULL,
    [Name] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Journal'
CREATE TABLE [dbo].[Journal] (
    [ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [TeacherID] decimal(18,0)  NOT NULL,
    [DisciplineID] decimal(18,0)  NOT NULL,
    [StudentID] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [ID] decimal(18,0)  NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [SurName] nvarchar(50)  NOT NULL,
    [SecondName] nvarchar(50)  NOT NULL,
    [UserLogin] nvarchar(50)  NULL
);
GO

-- Creating table 'Role'
CREATE TABLE [dbo].[Role] (
    [ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Student'
CREATE TABLE [dbo].[Student] (
    [ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [PeopleID] decimal(18,0)  NOT NULL,
    [GroupID] decimal(18,0)  NOT NULL,
    [Date] datetime  NOT NULL
);
GO

-- Creating table 'Teacher'
CREATE TABLE [dbo].[Teacher] (
    [ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [PeopleID] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [login] nvarchar(50)  NOT NULL,
    [password] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'User_Role'
CREATE TABLE [dbo].[User_Role] (
    [Role_ID] decimal(18,0)  NOT NULL,
    [User_login] nvarchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'AcademicYear'
ALTER TABLE [dbo].[AcademicYear]
ADD CONSTRAINT [PK_AcademicYear]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Discipline'
ALTER TABLE [dbo].[Discipline]
ADD CONSTRAINT [PK_Discipline]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Group'
ALTER TABLE [dbo].[Group]
ADD CONSTRAINT [PK_Group]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Journal'
ALTER TABLE [dbo].[Journal]
ADD CONSTRAINT [PK_Journal]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Role'
ALTER TABLE [dbo].[Role]
ADD CONSTRAINT [PK_Role]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Student'
ALTER TABLE [dbo].[Student]
ADD CONSTRAINT [PK_Student]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Teacher'
ALTER TABLE [dbo].[Teacher]
ADD CONSTRAINT [PK_Teacher]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [login] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([login] ASC);
GO

-- Creating primary key on [Role_ID], [User_login] in table 'User_Role'
ALTER TABLE [dbo].[User_Role]
ADD CONSTRAINT [PK_User_Role]
    PRIMARY KEY CLUSTERED ([Role_ID], [User_login] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [GroupID] in table 'Student'
ALTER TABLE [dbo].[Student]
ADD CONSTRAINT [FK_Student_Group]
    FOREIGN KEY ([GroupID])
    REFERENCES [dbo].[Group]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Student_Group'
CREATE INDEX [IX_FK_Student_Group]
ON [dbo].[Student]
    ([GroupID]);
GO

-- Creating foreign key on [PeopleID] in table 'Student'
ALTER TABLE [dbo].[Student]
ADD CONSTRAINT [FK_Student_People]
    FOREIGN KEY ([PeopleID])
    REFERENCES [dbo].[People]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Student_People'
CREATE INDEX [IX_FK_Student_People]
ON [dbo].[Student]
    ([PeopleID]);
GO

-- Creating foreign key on [PeopleID] in table 'Teacher'
ALTER TABLE [dbo].[Teacher]
ADD CONSTRAINT [FK_Teacher_People]
    FOREIGN KEY ([PeopleID])
    REFERENCES [dbo].[People]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Teacher_People'
CREATE INDEX [IX_FK_Teacher_People]
ON [dbo].[Teacher]
    ([PeopleID]);
GO

-- Creating foreign key on [Role_ID] in table 'User_Role'
ALTER TABLE [dbo].[User_Role]
ADD CONSTRAINT [FK_User_Role_Role]
    FOREIGN KEY ([Role_ID])
    REFERENCES [dbo].[Role]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [User_login] in table 'User_Role'
ALTER TABLE [dbo].[User_Role]
ADD CONSTRAINT [FK_User_Role_User]
    FOREIGN KEY ([User_login])
    REFERENCES [dbo].[User]
        ([login])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_User_Role_User'
CREATE INDEX [IX_FK_User_Role_User]
ON [dbo].[User_Role]
    ([User_login]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------