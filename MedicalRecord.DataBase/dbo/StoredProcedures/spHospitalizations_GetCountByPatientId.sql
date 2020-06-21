CREATE PROCEDURE [dbo].[spHospitalizations_GetCountByPatientId]
	@patientId int = 0
AS
	SELECT COUNT(@patientId)
	from [dbo].[Hospitalizations] AS h
	WHERE h.PatientId = @patientId AND h.IsDeleted = 0;
GO
