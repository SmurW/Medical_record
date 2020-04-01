CREATE TABLE [dbo].[Hospitalizations]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PatientId] INT NOT NULL , 
    [StartHospitalizationDate] DATETIME NULL, 
    [EndHospitalizationDate] DATETIME NULL, 
    [MedicalOrganization] NVARCHAR(50) NOT NULL, 
    [DefinitiveDiagnosis] NVARCHAR(50) NOT NULL, 
    [IsDeleted] BIT NOT NULL DEFAULT 0
)
