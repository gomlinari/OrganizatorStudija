
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 07/08/2013 14:46:32
-- Generated from EDMX file: C:\Users\Vrba\Documents\Visual Studio 2012\Projects\OrganizatorStudija\OrganizatorStudija\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [pi2013T420db];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_userusefull_link]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[usefull_links] DROP CONSTRAINT [FK_userusefull_link];
GO
IF OBJECT_ID(N'[dbo].[FK_useruserCourses]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[userCourses] DROP CONSTRAINT [FK_useruserCourses];
GO
IF OBJECT_ID(N'[dbo].[FK_courseuserCourses]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[userCourses] DROP CONSTRAINT [FK_courseuserCourses];
GO
IF OBJECT_ID(N'[dbo].[FK_staffcourseStaff]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[courseStaff] DROP CONSTRAINT [FK_staffcourseStaff];
GO
IF OBJECT_ID(N'[dbo].[FK_coursecourseStaff]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[courseStaff] DROP CONSTRAINT [FK_coursecourseStaff];
GO
IF OBJECT_ID(N'[dbo].[FK_userCoursestask]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tasks] DROP CONSTRAINT [FK_userCoursestask];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[users];
GO
IF OBJECT_ID(N'[dbo].[usefull_links]', 'U') IS NOT NULL
    DROP TABLE [dbo].[usefull_links];
GO
IF OBJECT_ID(N'[dbo].[courses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[courses];
GO
IF OBJECT_ID(N'[dbo].[userCourses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[userCourses];
GO
IF OBJECT_ID(N'[dbo].[staff]', 'U') IS NOT NULL
    DROP TABLE [dbo].[staff];
GO
IF OBJECT_ID(N'[dbo].[courseStaff]', 'U') IS NOT NULL
    DROP TABLE [dbo].[courseStaff];
GO
IF OBJECT_ID(N'[dbo].[tasks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tasks];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'users'
CREATE TABLE [dbo].[users] (
    [user_id] int IDENTITY(1,1) NOT NULL,
    [user_name] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [first_name] nvarchar(max)  NOT NULL,
    [last_name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'usefull_links'
CREATE TABLE [dbo].[usefull_links] (
    [link_id] int IDENTITY(1,1) NOT NULL,
    [link] nvarchar(max)  NOT NULL,
    [table_user_id] int  NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'courses'
CREATE TABLE [dbo].[courses] (
    [course_id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [ects] smallint  NOT NULL,
    [year] smallint  NOT NULL,
    [colour] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'userCourses'
CREATE TABLE [dbo].[userCourses] (
    [table_user_id] int  NOT NULL,
    [table_course_id] int  NOT NULL,
    [status] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'staff'
CREATE TABLE [dbo].[staff] (
    [staff_id] int IDENTITY(1,1) NOT NULL,
    [title] nvarchar(max)  NOT NULL,
    [first_name] nvarchar(max)  NOT NULL,
    [last_name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'courseStaff'
CREATE TABLE [dbo].[courseStaff] (
    [table_staff_id] int  NOT NULL,
    [table_course_id] int  NOT NULL
);
GO

-- Creating table 'tasks'
CREATE TABLE [dbo].[tasks] (
    [task_id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [description] nvarchar(max)  NOT NULL,
    [points] smallint  NOT NULL,
    [points_max] smallint  NOT NULL,
    [start_date] nvarchar(max)  NOT NULL,
    [end_date] nvarchar(max)  NOT NULL,
    [status] nvarchar(max)  NOT NULL,
    [owner] int  NOT NULL,
    [course] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [user_id] in table 'users'
ALTER TABLE [dbo].[users]
ADD CONSTRAINT [PK_users]
    PRIMARY KEY CLUSTERED ([user_id] ASC);
GO

-- Creating primary key on [link_id] in table 'usefull_links'
ALTER TABLE [dbo].[usefull_links]
ADD CONSTRAINT [PK_usefull_links]
    PRIMARY KEY CLUSTERED ([link_id] ASC);
GO

-- Creating primary key on [course_id] in table 'courses'
ALTER TABLE [dbo].[courses]
ADD CONSTRAINT [PK_courses]
    PRIMARY KEY CLUSTERED ([course_id] ASC);
GO

-- Creating primary key on [table_user_id], [table_course_id] in table 'userCourses'
ALTER TABLE [dbo].[userCourses]
ADD CONSTRAINT [PK_userCourses]
    PRIMARY KEY CLUSTERED ([table_user_id], [table_course_id] ASC);
GO

-- Creating primary key on [staff_id] in table 'staff'
ALTER TABLE [dbo].[staff]
ADD CONSTRAINT [PK_staff]
    PRIMARY KEY CLUSTERED ([staff_id] ASC);
GO

-- Creating primary key on [table_staff_id], [table_course_id] in table 'courseStaff'
ALTER TABLE [dbo].[courseStaff]
ADD CONSTRAINT [PK_courseStaff]
    PRIMARY KEY NONCLUSTERED ([table_staff_id], [table_course_id] ASC);
GO

-- Creating primary key on [task_id] in table 'tasks'
ALTER TABLE [dbo].[tasks]
ADD CONSTRAINT [PK_tasks]
    PRIMARY KEY CLUSTERED ([task_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [table_user_id] in table 'usefull_links'
ALTER TABLE [dbo].[usefull_links]
ADD CONSTRAINT [FK_userusefull_link]
    FOREIGN KEY ([table_user_id])
    REFERENCES [dbo].[users]
        ([user_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_userusefull_link'
CREATE INDEX [IX_FK_userusefull_link]
ON [dbo].[usefull_links]
    ([table_user_id]);
GO

-- Creating foreign key on [table_user_id] in table 'userCourses'
ALTER TABLE [dbo].[userCourses]
ADD CONSTRAINT [FK_useruserCourses]
    FOREIGN KEY ([table_user_id])
    REFERENCES [dbo].[users]
        ([user_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [table_course_id] in table 'userCourses'
ALTER TABLE [dbo].[userCourses]
ADD CONSTRAINT [FK_courseuserCourses]
    FOREIGN KEY ([table_course_id])
    REFERENCES [dbo].[courses]
        ([course_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_courseuserCourses'
CREATE INDEX [IX_FK_courseuserCourses]
ON [dbo].[userCourses]
    ([table_course_id]);
GO

-- Creating foreign key on [table_staff_id] in table 'courseStaff'
ALTER TABLE [dbo].[courseStaff]
ADD CONSTRAINT [FK_staffcourseStaff]
    FOREIGN KEY ([table_staff_id])
    REFERENCES [dbo].[staff]
        ([staff_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [table_course_id] in table 'courseStaff'
ALTER TABLE [dbo].[courseStaff]
ADD CONSTRAINT [FK_coursecourseStaff]
    FOREIGN KEY ([table_course_id])
    REFERENCES [dbo].[courses]
        ([course_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_coursecourseStaff'
CREATE INDEX [IX_FK_coursecourseStaff]
ON [dbo].[courseStaff]
    ([table_course_id]);
GO

-- Creating foreign key on [owner], [course] in table 'tasks'
ALTER TABLE [dbo].[tasks]
ADD CONSTRAINT [FK_userCoursestask]
    FOREIGN KEY ([owner], [course])
    REFERENCES [dbo].[userCourses]
        ([table_user_id], [table_course_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_userCoursestask'
CREATE INDEX [IX_FK_userCoursestask]
ON [dbo].[tasks]
    ([owner], [course]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------