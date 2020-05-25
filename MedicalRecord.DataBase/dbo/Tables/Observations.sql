CREATE TABLE [dbo].[Observations]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PatientId] INT NOT NULL, 
    [DiagnosisId] INT NOT NULL, 
    [DoctorId] INT NOT NULL, 
    [StartObservationDate] DATE NOT NULL, 
    [EndObservationDate] DATE NOT NULL, 
    CONSTRAINT [FK_Observations_Patients] FOREIGN KEY ([PatientId]) REFERENCES [Patients]([Id]), 
    CONSTRAINT [FK_Observations_Diagnoses] FOREIGN KEY ([DiagnosisId]) REFERENCES [Diagnoses]([Id]), 
    CONSTRAINT [FK_Observations_Doctors] FOREIGN KEY ([DoctorId]) REFERENCES [Doctors]([Id])
)
