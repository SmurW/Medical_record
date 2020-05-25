CREATE TABLE [dbo].[Examinations]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ExaminationDate] DATE NOT NULL, 
    [PatientId] INT NOT NULL, 
    [DiagnosisId] INT NOT NULL, 
    [HealthGroupId] INT NOT NULL, 
    [DoctorId] INT NOT NULL, 
    CONSTRAINT [FK_Examinations_Patients] FOREIGN KEY ([PatientId]) REFERENCES [Patients]([Id]), 
    CONSTRAINT [FK_Examinations_DiagnosisId] FOREIGN KEY ([DiagnosisId]) REFERENCES [Diagnoses]([Id]), 
    CONSTRAINT [FK_Examinations_HealthGroups] FOREIGN KEY ([HealthGroupId]) REFERENCES [HealthGroups]([Id]), 
    CONSTRAINT [FK_Examinations_Doctors] FOREIGN KEY ([DoctorId]) REFERENCES [Doctors]([Id])
)
