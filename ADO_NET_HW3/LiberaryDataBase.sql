USE [master]
GO
/****** Object:  Database [Liberary]    Script Date: 08.12.2020 10:33:27 ******/
CREATE DATABASE [Liberary]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Liberary', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Liberary.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Liberary_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Liberary_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Liberary] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Liberary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Liberary] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Liberary] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Liberary] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Liberary] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Liberary] SET ARITHABORT OFF 
GO
ALTER DATABASE [Liberary] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Liberary] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Liberary] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Liberary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Liberary] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Liberary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Liberary] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Liberary] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Liberary] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Liberary] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Liberary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Liberary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Liberary] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Liberary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Liberary] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Liberary] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Liberary] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Liberary] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Liberary] SET  MULTI_USER 
GO
ALTER DATABASE [Liberary] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Liberary] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Liberary] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Liberary] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Liberary] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Liberary] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Liberary] SET QUERY_STORE = OFF
GO
USE [Liberary]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 08.12.2020 10:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Firstname] [nvarchar](30) NOT NULL,
	[Lastname] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 08.12.2020 10:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Price] [int] NOT NULL,
	[Pages] [int] NOT NULL,
	[AuthorId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pictures]    Script Date: 08.12.2020 10:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pictures](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BookId] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Picture] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Authors] ON 
GO
INSERT [dbo].[Authors] ([Id], [Firstname], [Lastname]) VALUES (1, N'John ', N'Tolkien')
GO
INSERT [dbo].[Authors] ([Id], [Firstname], [Lastname]) VALUES (2, N'George ', N'Martin')
GO
INSERT [dbo].[Authors] ([Id], [Firstname], [Lastname]) VALUES (3, N'Roger  ', N'Zelazny')
GO
SET IDENTITY_INSERT [dbo].[Authors] OFF
GO
SET IDENTITY_INSERT [dbo].[Books] ON 
GO
INSERT [dbo].[Books] ([Id], [Title], [Price], [Pages], [AuthorId]) VALUES (1, N'The Lord of the Rings. Book one', 1234, 620, 1)
GO
INSERT [dbo].[Books] ([Id], [Title], [Price], [Pages], [AuthorId]) VALUES (2, N'The Lord of the Rings. Book two', 111, 555, 1)
GO
INSERT [dbo].[Books] ([Id], [Title], [Price], [Pages], [AuthorId]) VALUES (3, N'The Lord of the Rings. Book three', 1568, 496, 1)
GO
INSERT [dbo].[Books] ([Id], [Title], [Price], [Pages], [AuthorId]) VALUES (4, N'A Song of Ice and Fire. A Game of Thrones', 1520, 694, 2)
GO
INSERT [dbo].[Books] ([Id], [Title], [Price], [Pages], [AuthorId]) VALUES (5, N'A Song of Ice and Fire. A Clash of Kings', 1400, 768, 2)
GO
INSERT [dbo].[Books] ([Id], [Title], [Price], [Pages], [AuthorId]) VALUES (6, N'A Song of Ice and Fire. A Storm of Swords', 1920, 973, 2)
GO
INSERT [dbo].[Books] ([Id], [Title], [Price], [Pages], [AuthorId]) VALUES (7, N'A Song of Ice and Fire. A Feast for Crows', 1850, 753, 2)
GO
INSERT [dbo].[Books] ([Id], [Title], [Price], [Pages], [AuthorId]) VALUES (8, N'A Song of Ice and Fire. A Dance with Dragons', 2100, 1056, 2)
GO
INSERT [dbo].[Books] ([Id], [Title], [Price], [Pages], [AuthorId]) VALUES (9, N'Nine Princes in Amber', 960, 652, 3)
GO
INSERT [dbo].[Books] ([Id], [Title], [Price], [Pages], [AuthorId]) VALUES (10, N'The Guns of Avalon', 780, 652, 3)
GO
INSERT [dbo].[Books] ([Id], [Title], [Price], [Pages], [AuthorId]) VALUES (11, N'Sign of the Unicorn', 562, 490, 3)
GO
INSERT [dbo].[Books] ([Id], [Title], [Price], [Pages], [AuthorId]) VALUES (12, N'The Hand of Oberon', 690, 650, 3)
GO
INSERT [dbo].[Books] ([Id], [Title], [Price], [Pages], [AuthorId]) VALUES (13, N'The Courts of Chaos', 540, 420, 3)
GO
SET IDENTITY_INSERT [dbo].[Books] OFF
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Authors] ([Id])
GO
ALTER TABLE [dbo].[Pictures]  WITH CHECK ADD FOREIGN KEY([BookId])
REFERENCES [dbo].[Books] ([Id])
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD CHECK  (([Pages]>=(0)))
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD CHECK  (([PRICE]>=(0)))
GO
/****** Object:  StoredProcedure [dbo].[UpdateBooks]    Script Date: 08.12.2020 10:33:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateBooks]
	@Id int = 0,
	@Title nvarchar(30),
	@Price int,
	@Pages int,
	@AuthorId int
AS
    UPDATE dbo.Books
    SET
	Title = @Title,
	Price = @Price,
	Pages = @Pages,
	AuthorId = @AuthorId
	WHERE @Id = Id
GO
USE [master]
GO
ALTER DATABASE [Liberary] SET  READ_WRITE 
GO
