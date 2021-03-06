USE [master]
GO
/****** Object:  Database [ABC]    Script Date: 8/25/2017 12:58:50 PM ******/
CREATE DATABASE [ABC] ON  PRIMARY 
( NAME = N'ABC', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\ABC.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ABC_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\ABC_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ABC] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ABC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ABC] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ABC] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ABC] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ABC] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ABC] SET ARITHABORT OFF 
GO
ALTER DATABASE [ABC] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ABC] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ABC] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ABC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ABC] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ABC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ABC] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ABC] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ABC] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ABC] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ABC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ABC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ABC] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ABC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ABC] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ABC] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ABC] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ABC] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ABC] SET  MULTI_USER 
GO
ALTER DATABASE [ABC] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ABC] SET DB_CHAINING OFF 
GO
USE [ABC]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 8/25/2017 12:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[Account_No] [int] NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[DOB] [date] NOT NULL,
	[Phone_No] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](20) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[District] [nvarchar](20) NOT NULL,
	[Gender] [nvarchar](20) NOT NULL,
	[Marital_Status] [nvarchar](20) NOT NULL,
	[Father_Name] [nvarchar](20) NOT NULL,
	[Mother_Name] [nvarchar](20) NOT NULL,
	[Balance] [int] NOT NULL,
	[Photo] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[deposit]    Script Date: 8/25/2017 12:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[deposit](
	[Account_No] [int] NOT NULL,
	[Deposit_Amount] [int] NOT NULL,
	[Date] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fd]    Script Date: 8/25/2017 12:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fd](
	[Account_No] [int] NOT NULL,
	[Type] [nvarchar](20) NOT NULL,
	[Amount] [int] NOT NULL,
	[Period] [int] NOT NULL,
	[Interest] [int] NOT NULL,
	[Date] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loan]    Script Date: 8/25/2017 12:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loan](
	[Account_No] [int] NOT NULL,
	[Loan_Amount] [int] NOT NULL,
	[Monthly_Pay] [int] NOT NULL,
	[Period] [int] NOT NULL,
	[Interest] [int] NOT NULL,
	[Loan_Status] [nvarchar](20) NOT NULL,
	[Date] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loan_payment]    Script Date: 8/25/2017 12:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loan_payment](
	[Account_No] [int] NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[Payment_Month] [nvarchar](20) NOT NULL,
	[Payment_Amount] [int] NOT NULL,
	[Date] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 8/25/2017 12:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[user_id] [int] NOT NULL,
	[Username] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transaction]    Script Date: 8/25/2017 12:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transaction](
	[Account_No] [nvarchar](50) NOT NULL,
	[Debit] [int] NULL,
	[Credit] [int] NULL,
	[TransferFrom] [int] NULL,
	[TransferTo] [int] NULL,
	[Amount] [int] NULL,
	[Date] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transfer]    Script Date: 8/25/2017 12:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transfer](
	[Payee_Account] [int] NOT NULL,
	[Recv_Account] [int] NOT NULL,
	[Transfer_Amount] [int] NOT NULL,
	[Date] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 8/25/2017 12:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[Name] [nvarchar](20) NOT NULL,
	[Username] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](20) NOT NULL,
	[Gender] [nvarchar](20) NOT NULL,
	[DOB] [date] NOT NULL,
	[User_Type] [nvarchar](20) NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
	[Address] [nvarchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Withdraw]    Script Date: 8/25/2017 12:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Withdraw](
	[Account_no] [int] NOT NULL,
	[Withdraw_Amount] [nvarchar](20) NOT NULL,
	[Date] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[loan_pay]    Script Date: 8/25/2017 12:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[loan_pay]
  @ano int OUT,
  @n nvarchar(20) OUT,
  @pm nvarchar(20) OUT,
  @pa int OUT,
  @dt date OUT,
  @ul int OUT

  AS
BEGIN
 Insert into Loan_Payment (Account_No,Name,Payment_Month,Payment_Amount,Date) values(@ano,@n,@pm,@pa,@dt);

 update loan set Loan_Amount=@ul where Account_No=@ano;

 if @ul=0
  delete from loan where Account_No=@ano;
   

END;
GO
USE [master]
GO
ALTER DATABASE [ABC] SET  READ_WRITE 
GO
