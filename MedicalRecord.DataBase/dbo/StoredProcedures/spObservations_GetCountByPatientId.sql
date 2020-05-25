CREATE PROCEDURE [dbo].[spObservations_GetCountByPatientId]
	@patientId int
AS
	SELECT COUNT(Id)
    FROM dbo.Observations
    WHERE PatientId = @patientId;
