CREATE PROCEDURE [dbo].[spObservations_GetByPatientId]
	@patientId int
AS
	SELECT [Id]
     , [PatientId]
     , [DiagnosisId]
     , [DoctorId]
     , [StartObservationDate]
     , [EndObservationDate]
    from dbo.Observations
    WHERE PatientId = @patientId;
