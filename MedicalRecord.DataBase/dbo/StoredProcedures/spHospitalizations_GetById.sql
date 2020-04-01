CREATE PROCEDURE [dbo].[spHospitalizations_GetById]
	@id int = 0
AS
BEGIN
	
	SELECT
		[Id],
		[StartHospitalizationDate],
		[EndHospitalizationDate],
		[MedicalOrganization],
		[DefinitiveDiagnosis]
	FROM [dbo].[Hospitalizations]
	WHERE [Id] = @id;

END
