CREATE PROCEDURE [dbo].[spObservations_GetByPatientId]
	@patientId int
AS
	SELECT [Id]
     , [PatientId]
     , [DiagnosisId]
     , [DoctorId]
     , [StartObservationDate]
     , [EndObservationDate]
    FROM dbo.Observations
    WHERE PatientId = @patientId;
