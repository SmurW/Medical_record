CREATE PROCEDURE [dbo].[spHospitalizations_Add]
	@sd datetime,
	@ed datetime,
	@mo nvarchar(50),
	@dd nvarchar(50)
AS
BEGIN
	INSERT INTO dbo.Hospitalizations
		(StartHospitalizationDate, EndHospitalizationDate, MedicalOrganization, DefinitiveDiagnosis)
	VALUES
		(@sd, @ed, @mo, @dd);

	SELECT SCOPE_IDENTITY(); --возвращает Id только что вставленного
END