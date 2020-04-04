CREATE PROCEDURE [dbo].[spHospitalizations_Add]
	@patientId int,
	@startd datetime,
	@endd datetime,
	@medorg nvarchar(100),
	@diag nvarchar(150)
AS
BEGIN

	--TODO: в таблицу Госпитализаций надо добавить внешн.ключ для связи с таб. Пациенты

	INSERT INTO dbo.Hospitalizations
		(PatientId, StartHospitalizationDate, EndHospitalizationDate, MedicalOrganization, DefinitiveDiagnosis)
	VALUES
		(@patientId, @startd, @endd, @medorg, @diag);

	SELECT SCOPE_IDENTITY(); --возвращает Id только что вставленного
END