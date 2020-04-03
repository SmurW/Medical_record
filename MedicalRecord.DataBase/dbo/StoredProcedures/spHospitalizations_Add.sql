CREATE PROCEDURE [dbo].[spHospitalizations_Add]
	@patientId int,
	@startd datetime,
	@endd datetime,
	@medorg nvarchar(50),
	@diag nvarchar(50)
AS
BEGIN
	INSERT INTO dbo.Hospitalizations
		(PatientId, StartHospitalizationDate, EndHospitalizationDate, MedicalOrganization, DefinitiveDiagnosis)
	VALUES
		(@patientId, @startd, @endd, @medorg, @diag);

	SELECT SCOPE_IDENTITY(); --возвращает Id только что вставленного
END