
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/04/2023 15:06:59
-- Generated from EDMX file: C:\Users\Alumno\Desktop\recuperacion_DI\App_UT2_09\App_UT2_09\Modelo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Biblio];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Peliculas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Peliculas];
GO
IF OBJECT_ID(N'[dbo].[Libros]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Libros];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Peliculas'
CREATE TABLE [dbo].[Peliculas] (
    [PeliculasId] int IDENTITY(1,1) NOT NULL,
    [Titulo] nvarchar(max)  NOT NULL,
    [Anno] int  NOT NULL,
    [Genero] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Libros'
CREATE TABLE [dbo].[Libros] (
    [LibrosId] int IDENTITY(1,1) NOT NULL,
    [Titulo] nvarchar(max)  NOT NULL,
    [Anno] int  NOT NULL,
    [Autor] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [PeliculasId] in table 'Peliculas'
ALTER TABLE [dbo].[Peliculas]
ADD CONSTRAINT [PK_Peliculas]
    PRIMARY KEY CLUSTERED ([PeliculasId] ASC);
GO

-- Creating primary key on [LibrosId] in table 'Libros'
ALTER TABLE [dbo].[Libros]
ADD CONSTRAINT [PK_Libros]
    PRIMARY KEY CLUSTERED ([LibrosId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------