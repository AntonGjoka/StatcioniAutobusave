USE [master]
GO
/****** Object:  Database [Statcioni i autobusave]    Script Date: 19/04/2020 21:03:24 ******/
CREATE DATABASE [Statcioni i autobusave]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Statcioni i autobusave', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL\MSSQL\DATA\Statcioni i autobusave.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Statcioni i autobusave_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL\MSSQL\DATA\Statcioni i autobusave_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Statcioni i autobusave] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Statcioni i autobusave].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Statcioni i autobusave] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Statcioni i autobusave] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Statcioni i autobusave] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Statcioni i autobusave] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Statcioni i autobusave] SET ARITHABORT OFF 
GO
ALTER DATABASE [Statcioni i autobusave] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Statcioni i autobusave] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Statcioni i autobusave] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Statcioni i autobusave] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Statcioni i autobusave] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Statcioni i autobusave] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Statcioni i autobusave] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Statcioni i autobusave] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Statcioni i autobusave] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Statcioni i autobusave] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Statcioni i autobusave] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Statcioni i autobusave] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Statcioni i autobusave] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Statcioni i autobusave] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Statcioni i autobusave] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Statcioni i autobusave] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Statcioni i autobusave] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Statcioni i autobusave] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Statcioni i autobusave] SET  MULTI_USER 
GO
ALTER DATABASE [Statcioni i autobusave] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Statcioni i autobusave] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Statcioni i autobusave] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Statcioni i autobusave] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Statcioni i autobusave] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Statcioni i autobusave]
GO
/****** Object:  Table [dbo].[Bileta]    Script Date: 19/04/2020 21:03:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bileta](
	[BiletaID] [int] IDENTITY(1,1) NOT NULL,
	[BusId] [int] NULL,
	[PuntoriID] [int] NULL,
	[Cmimi] [money] NULL,
	[KohaMberritjes] [varchar](50) NULL,
	[KohaNisjes] [varchar](50) NULL,
	[NumriKontaktues] [varchar](50) NULL,
	[InsertBy] [varchar](50) NOT NULL,
	[InsertDate] [date] NOT NULL,
	[UpdateBy] [varchar](50) NOT NULL,
	[UpdateDate] [date] NOT NULL,
	[UpdateNo] [int] NOT NULL,
 CONSTRAINT [PK_Bileta] PRIMARY KEY CLUSTERED 
(
	[BiletaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bus]    Script Date: 19/04/2020 21:03:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bus](
	[BusID] [int] NOT NULL,
	[Kapaciteti] [int] NOT NULL,
	[EmriIKompanise] [varchar](50) NOT NULL,
	[InsertedBy] [varchar](50) NOT NULL,
	[InsertedDate] [date] NOT NULL,
	[LUB] [varchar](50) NOT NULL,
	[LUD] [date] NOT NULL,
	[LUN] [int] NOT NULL,
 CONSTRAINT [PK_Autobusi] PRIMARY KEY CLUSTERED 
(
	[BusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Puntori]    Script Date: 19/04/2020 21:03:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Puntori](
	[PuntoriID] [int] IDENTITY(1,1) NOT NULL,
	[Emri] [varchar](50) NOT NULL,
	[Mbiemri] [varchar](50) NOT NULL,
	[Datlindja] [date] NOT NULL,
	[Shtetsia] [varchar](50) NOT NULL,
	[RezervimetID] [int] NOT NULL,
	[InsertBy] [varchar](50) NOT NULL,
	[InsertDate] [date] NOT NULL,
	[LUB] [varchar](50) NOT NULL,
	[LUD] [date] NOT NULL,
	[LUN] [int] NOT NULL,
 CONSTRAINT [PK_Puntori] PRIMARY KEY CLUSTERED 
(
	[PuntoriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rezervimet]    Script Date: 19/04/2020 21:03:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezervimet](
	[RezervimetID] [int] NOT NULL,
	[BiletaID] [int] NOT NULL,
 CONSTRAINT [PK_Rezervimet] PRIMARY KEY CLUSTERED 
(
	[RezervimetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Role]    Script Date: 19/04/2020 21:03:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](50) NOT NULL,
	[Description] [varchar](4000) NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [datetime] NULL,
	[LUB] [int] NULL,
	[LUD] [datetime] NULL,
	[LUN] [int] NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 19/04/2020 21:03:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UsersID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[IsActive] [int] NULL,
	[UserPass] [varchar](50) NOT NULL,
	[ExpiresDate] [datetime] NULL,
	[RoleID] [int] NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [datetime] NULL,
	[LUB] [int] NULL,
	[LUD] [datetime] NULL,
	[LUN] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UsersID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UsersID], [UserName], [IsActive], [UserPass], [ExpiresDate], [RoleID], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (1, N'admin', 1, N'admin', NULL, NULL, 1, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Bileta]  WITH CHECK ADD  CONSTRAINT [FK_Bileta_Bileta] FOREIGN KEY([BusId])
REFERENCES [dbo].[Bus] ([BusID])
GO
ALTER TABLE [dbo].[Bileta] CHECK CONSTRAINT [FK_Bileta_Bileta]
GO
ALTER TABLE [dbo].[Bileta]  WITH CHECK ADD  CONSTRAINT [FK_Bileta_Puntori] FOREIGN KEY([PuntoriID])
REFERENCES [dbo].[Puntori] ([PuntoriID])
GO
ALTER TABLE [dbo].[Bileta] CHECK CONSTRAINT [FK_Bileta_Puntori]
GO
ALTER TABLE [dbo].[Puntori]  WITH CHECK ADD  CONSTRAINT [FK_Puntori_Rezervimet] FOREIGN KEY([RezervimetID])
REFERENCES [dbo].[Rezervimet] ([RezervimetID])
GO
ALTER TABLE [dbo].[Puntori] CHECK CONSTRAINT [FK_Puntori_Rezervimet]
GO
ALTER TABLE [dbo].[Rezervimet]  WITH CHECK ADD  CONSTRAINT [FK_Rezervimet_Bileta] FOREIGN KEY([BiletaID])
REFERENCES [dbo].[Bileta] ([BiletaID])
GO
ALTER TABLE [dbo].[Rezervimet] CHECK CONSTRAINT [FK_Rezervimet_Bileta]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Users1] FOREIGN KEY([UsersID])
REFERENCES [dbo].[Users] ([UsersID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Users1]
GO
/****** Object:  StoredProcedure [dbo].[ups_Authenticate]    Script Date: 19/04/2020 21:03:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ups_Authenticate]
(
	@username varchar(50),
	@password varchar (50)
)
as 
select * from Users where UserName=@username
and UserPass=@password;
GO
/****** Object:  StoredProcedure [dbo].[usp_Role_Insert]    Script Date: 19/04/2020 21:03:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Role_Insert]
@name varchar(50),
@Description varchar(4000)
as
insert into Role
(
RoleName,
Description
)
values 
(
	@name,
	@Description
);
GO
/****** Object:  StoredProcedure [dbo].[usp_Roles_GetAll]    Script Date: 19/04/2020 21:03:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Roles_GetAll]
as
select * from Role
GO
USE [master]
GO
ALTER DATABASE [Statcioni i autobusave] SET  READ_WRITE 
GO
