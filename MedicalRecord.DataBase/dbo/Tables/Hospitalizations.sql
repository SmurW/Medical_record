CREATE TABLE [dbo].[Hospitalizations]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PatientId] INT NOT NULL , 
    [StartHospitalizationDate] DATETIME NOT NULL DEFAULT DATEADD(day, -1, GETDATE()), 
    [EndHospitalizationDate] DATETIME NOT NULL DEFAULT GETDATE(), 
    [MedicalOrganization] NVARCHAR(50) NOT NULL, 
    [DefinitiveDiagnosis] NVARCHAR(50) NOT NULL, 
    [IsDeleted] BIT NOT NULL DEFAULT 0
)
