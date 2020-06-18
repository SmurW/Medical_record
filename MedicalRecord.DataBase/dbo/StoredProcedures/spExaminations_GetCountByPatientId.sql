CREATE PROCEDURE [dbo].[spExaminations_GetCountByPatientId]
	@patientId int
AS
	SELECT COUNT(Id)
    from dbo.Examinations
    WHERE PatientId = @patientId;
