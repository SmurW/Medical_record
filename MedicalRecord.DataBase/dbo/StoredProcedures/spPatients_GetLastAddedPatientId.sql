CREATE PROCEDURE [dbo].[spPatients_GetLastAddedPatientId]
AS
BEGIN
	
	SELECT Max(Id)
	from [dbo].[Patients]

END

