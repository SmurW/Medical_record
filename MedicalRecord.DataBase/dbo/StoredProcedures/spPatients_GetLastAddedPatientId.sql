CREATE PROCEDURE [dbo].[spPatients_GetLastAddedPatientId]
AS
BEGIN
	
	SELECT Max(Id)
	FROM [dbo].[Patients]

END

