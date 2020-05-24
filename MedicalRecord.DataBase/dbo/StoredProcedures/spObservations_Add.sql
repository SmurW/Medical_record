CREATE PROCEDURE [dbo].[spObservations_Add]
	@patientId INT,
	@diagnosisId INT,
	@doctorId INT,
	@startDate DATE,
	@endDate DATE
AS
BEGIN

	INSERT INTO [dbo].[Observations]
		(PatientId, DiagnosisId, DoctorId, StartObservationDate, EndObservationDate)
	VALUES
		(@patientId, @diagnosisId, @doctorId, @startDate, @endDate);

	SELECT SCOPE_IDENTITY(); --возвращает Id только что вставленного
END
