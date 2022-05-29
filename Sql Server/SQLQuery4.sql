USE [hospital]
GO

/****** Object:  Table [dbo].[PatientMore]    Script Date: 11.05.2022 23:54:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PatientMore](
	[name] [varchar](150) NOT NULL,
	[Symptoms] [varchar](150) NOT NULL,
	[Diagnosis] [varchar](150) NOT NULL,
	[Medicines] [varchar](150) NOT NULL,
	[Ward] [varchar](15) NOT NULL,
	[Ward_Type] [varchar](20) NOT NULL
) ON [PRIMARY]
GO


SELECT * FROM PatientMore