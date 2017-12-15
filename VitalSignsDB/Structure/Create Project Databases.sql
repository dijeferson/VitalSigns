USE [master]
GO
/****** Object:  Database [VitalSigns]    Script Date: 02/01/2007 11:10:29 ******/
CREATE DATABASE [VitalSigns] ON  PRIMARY 
( NAME = N'VitalSigns', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\VitalSigns.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'VitalSigns_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\VitalSigns_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 COLLATE SQL_Latin1_General_CP1_CI_AS
GO
EXEC dbo.sp_dbcmptlevel @dbname=N'VitalSigns', @new_cmptlevel=90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VitalSigns].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VitalSigns] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VitalSigns] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VitalSigns] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VitalSigns] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VitalSigns] SET ARITHABORT OFF 
GO
ALTER DATABASE [VitalSigns] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VitalSigns] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [VitalSigns] SET AUTO_SHRINK ON 
GO
ALTER DATABASE [VitalSigns] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VitalSigns] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VitalSigns] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VitalSigns] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VitalSigns] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VitalSigns] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VitalSigns] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VitalSigns] SET  ENABLE_BROKER 
GO
ALTER DATABASE [VitalSigns] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VitalSigns] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VitalSigns] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VitalSigns] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VitalSigns] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VitalSigns] SET  READ_WRITE 
GO
ALTER DATABASE [VitalSigns] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VitalSigns] SET  MULTI_USER 
GO
ALTER DATABASE [VitalSigns] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VitalSigns] SET DB_CHAINING OFF 