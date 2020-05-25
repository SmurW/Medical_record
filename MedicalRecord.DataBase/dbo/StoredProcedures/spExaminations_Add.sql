CREATE PROCEDURE [dbo].[spExaminations_Add]
	@date DATE,
	@patientId INT,
	@diagnosisId INT,
	@hgroupId INT,
	@doctorId INT
AS
BEGIN

	INSERT INTO [dbo].[Examinations]
		(ExaminationDate, PatientId, DiagnosisId, HealthGroupId, DoctorId)
	VALUES
		(@date, @patientId, @diagnosisId, @hgroupId, @doctorId);

	SELECT SCOPE_IDENTITY(); --возвращает Id только что вставленного
END