CREATE PROCEDURE [dbo].[spObservations_GetCountByPatientId]
	@patientId int
AS
	SELECT COUNT(Id)
    from dbo.Observations
    WHERE PatientId = @patientId;
