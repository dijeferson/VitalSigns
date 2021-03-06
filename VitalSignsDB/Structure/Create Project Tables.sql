/****** Object:  Table [dbo].[Doctors]    Script Date: 02/01/2007 11:08:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Doctors]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Doctors](
	[idDoctor] [int] NOT NULL,
	[Name] [nvarchar](128) NULL,
	[Department] [nvarchar](128) NULL,
	[Email] [nvarchar](128) NULL,
	[Deleted] [bit] NOT NULL,
	[LastModification] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[idDoctor] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Patients]    Script Date: 02/01/2007 11:08:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Patients]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Patients](
	[idPatient] [int] NOT NULL,
	[Name] [nvarchar](128) NULL,
	[Age] [int] NULL,
	[Birthday] [smalldatetime] NULL,
	[Address] [nvarchar](512) NULL,
	[Neighborhood] [nvarchar](128) NULL,
	[City] [nvarchar](128) NULL,
	[State] [nvarchar](128) NULL,
	[PostalCode] [nvarchar](128) NULL,
	[Country] [nvarchar](128) NULL,
	[Gender] [nchar](1) NULL,
	[Ethnicity] [nvarchar](128) NULL,
	[Height] [nvarchar](128) NULL,
	[Weight] [nvarchar](128) NULL,
	[Site] [nvarchar](128) NULL,
	[Room] [nvarchar](128) NULL,
	[Critical] [bit] NULL,
	[Notes] [nvarchar](max) NULL,
	[Deleted] [bit] NOT NULL,
	[LastModification] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[idPatient] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Medications]    Script Date: 02/01/2007 11:08:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Medications]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Medications](
	[idMedication] [int] NOT NULL,
	[Name] [nvarchar](128) NULL,
	[Manufacturer] [nvarchar](128) NULL,
	[DefaultDosage] [nvarchar](128) NULL,
	[Deleted] [bit] NOT NULL,
	[LastModification] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_Medications] PRIMARY KEY CLUSTERED 
(
	[idMedication] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Signs]    Script Date: 02/01/2007 11:08:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Signs]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Signs](
	[idSign] [int] NOT NULL,
	[DataX] [bigint] NULL,
	[DataY] [bigint] NULL,
	[DataZ] [bigint] NULL,
	[Date] [smalldatetime] NULL,
	[Deleted] [bit] NOT NULL,
	[LastModification] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_Signs] PRIMARY KEY CLUSTERED 
(
	[idSign] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[DoctorXPatient]    Script Date: 02/01/2007 11:08:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DoctorXPatient]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DoctorXPatient](
	[idDoctor] [int] NOT NULL,
	[idPatient] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
	[LastModification] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_DoctorXPatient] PRIMARY KEY CLUSTERED 
(
	[idDoctor] ASC,
	[idPatient] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[PatientXSign]    Script Date: 02/01/2007 11:08:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientXSign]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PatientXSign](
	[idPatient] [int] NOT NULL,
	[idSign] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
	[LastModification] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_PatientXSign] PRIMARY KEY CLUSTERED 
(
	[idPatient] ASC,
	[idSign] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[PatientXMedication]    Script Date: 02/01/2007 11:08:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientXMedication]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PatientXMedication](
	[idPatient] [int] NOT NULL,
	[idMedication] [int] NOT NULL,
	[Posology] [nvarchar](128) NULL,
	[Notes] [nvarchar](max) NULL,
	[Deleted] [bit] NOT NULL,
	[LastModification] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_PatientXMedications] PRIMARY KEY CLUSTERED 
(
	[idPatient] ASC,
	[idMedication] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DoctorXPatient_Doctor]') AND parent_object_id = OBJECT_ID(N'[dbo].[DoctorXPatient]'))
ALTER TABLE [dbo].[DoctorXPatient]  WITH CHECK ADD  CONSTRAINT [FK_DoctorXPatient_Doctor] FOREIGN KEY([idDoctor])
REFERENCES [dbo].[Doctors] ([idDoctor])
GO
ALTER TABLE [dbo].[DoctorXPatient] CHECK CONSTRAINT [FK_DoctorXPatient_Doctor]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DoctorXPatient_Patient]') AND parent_object_id = OBJECT_ID(N'[dbo].[DoctorXPatient]'))
ALTER TABLE [dbo].[DoctorXPatient]  WITH CHECK ADD  CONSTRAINT [FK_DoctorXPatient_Patient] FOREIGN KEY([idPatient])
REFERENCES [dbo].[Patients] ([idPatient])
GO
ALTER TABLE [dbo].[DoctorXPatient] CHECK CONSTRAINT [FK_DoctorXPatient_Patient]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PatientXSign_Patient]') AND parent_object_id = OBJECT_ID(N'[dbo].[PatientXSign]'))
ALTER TABLE [dbo].[PatientXSign]  WITH CHECK ADD  CONSTRAINT [FK_PatientXSign_Patient] FOREIGN KEY([idPatient])
REFERENCES [dbo].[Patients] ([idPatient])
GO
ALTER TABLE [dbo].[PatientXSign] CHECK CONSTRAINT [FK_PatientXSign_Patient]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PatientXSign_Signs]') AND parent_object_id = OBJECT_ID(N'[dbo].[PatientXSign]'))
ALTER TABLE [dbo].[PatientXSign]  WITH CHECK ADD  CONSTRAINT [FK_PatientXSign_Signs] FOREIGN KEY([idSign])
REFERENCES [dbo].[Signs] ([idSign])
GO
ALTER TABLE [dbo].[PatientXSign] CHECK CONSTRAINT [FK_PatientXSign_Signs]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PatientXMedications_Medications]') AND parent_object_id = OBJECT_ID(N'[dbo].[PatientXMedication]'))
ALTER TABLE [dbo].[PatientXMedication]  WITH CHECK ADD  CONSTRAINT [FK_PatientXMedications_Medications] FOREIGN KEY([idMedication])
REFERENCES [dbo].[Medications] ([idMedication])
GO
ALTER TABLE [dbo].[PatientXMedication] CHECK CONSTRAINT [FK_PatientXMedications_Medications]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PatientXMedications_Patient]') AND parent_object_id = OBJECT_ID(N'[dbo].[PatientXMedication]'))
ALTER TABLE [dbo].[PatientXMedication]  WITH CHECK ADD  CONSTRAINT [FK_PatientXMedications_Patient] FOREIGN KEY([idPatient])
REFERENCES [dbo].[Patients] ([idPatient])
GO
ALTER TABLE [dbo].[PatientXMedication] CHECK CONSTRAINT [FK_PatientXMedications_Patient]
