CREATE PROCEDURE [dbo].[spDoctors_GetById]
	@id int = 0
AS
	SELECT [d].[Id]
		, [d].[LastName]
		, [d].[FirstName]
		, [d].[MiddleName]
		, [d].[SpecializationId]
		, [s].[Name] AS 'Specialization'
	FROM dbo.Doctors AS d
	INNER JOIN dbo.Specializations AS s
		ON d.SpecializationId = s.Id
	WHERE d.Id = @id
GO
