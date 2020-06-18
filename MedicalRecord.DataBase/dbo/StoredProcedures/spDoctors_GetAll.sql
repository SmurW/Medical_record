CREATE PROCEDURE [dbo].[spDoctors_GetAll]
AS
	SELECT [d].[Id]
		, [d].[LastName]
		, [d].[FirstName]
		, [d].[MiddleName]
		, [d].[SpecializationId]
		, [s].[Name] AS 'Specialization'
	from dbo.Doctors AS d
	INNER JOIN dbo.Specializations AS s
		ON d.SpecializationId = s.Id
	WHERE d.IsDeleted = 0
	ORDER BY d.Id;
GO
