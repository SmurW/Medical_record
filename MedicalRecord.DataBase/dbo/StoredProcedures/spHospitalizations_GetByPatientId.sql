CREATE PROCEDURE [dbo].[spHospitalizations_GetByPatientId]
	@patientId int = 0
AS
BEGIN
	
	SELECT [Id]
		, [PatientId]
		, [StartHospitalizationDate]
		, [EndHospitalizationDate]
		, [MedicalOrganization]
		, [DefinitiveDiagnosis]
		, [IsDeleted]
	from [dbo].[Hospitalizations] AS h
	WHERE h.PatientId = @patientId AND h.IsDeleted = 0
	ORDER BY h.StartHospitalizationDate DESC;

END
