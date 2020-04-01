CREATE PROCEDURE [dbo].[spHospitalizations_GetCountById]
	@id int
AS
	SELECT COUNT (@id)
	FROM [dbo].[Hospitalizations]
