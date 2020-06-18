CREATE PROCEDURE [dbo].[spExaminations_GetByPatientId]
	@patientId int
AS
	SELECT [Id]
	     , [ExaminationDate]
		 , [PatientId]
		 , [DiagnosisId]
		 , [HealthGroupId]
		 , [DoctorId]
    from dbo.Examinations
    WHERE PatientId = @patientId;
