CREATE PROCEDURE [dbo].[spExaminations_GetCountByPatientId]
	@patientId int
AS
	SELECT COUNT(Id)
    FROM dbo.Examinations
    WHERE PatientId = @patientId;
