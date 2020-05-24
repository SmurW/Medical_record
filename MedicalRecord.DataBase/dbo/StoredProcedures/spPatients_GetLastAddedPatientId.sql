CREATE PROCEDURE [dbo].[spPatients_GetLastAddedPatientId]
	@id nvarchar(50)
AS
BEGIN
	
	SELECT Max(Id)
		
	FROM [dbo].[Patients] AS h
	WHERE h.[Id] = @id;

END

