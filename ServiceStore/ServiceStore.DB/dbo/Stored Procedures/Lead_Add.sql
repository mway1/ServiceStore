CREATE PROCEDURE [dbo].[Lead_Add]
  @Id int,
  @LeadId varchar(50),
  @SubStartDate date,
  @SubEndDate date,
  @ServiceId int,
  @isDeleted bit
AS
BEGIN
INSERT INTO dbo.Lead(
        Id,
        LeadId,
        SubStartDate,
        SubEndDate,
        ServiceId,
		isDeleted)
VALUES(
    @Id,
    @LeadId,
    @SubStartDate,
    @SubEndDate,
    @ServiceId,
	@isDeleted)
SET @Id=SCOPE_IDENTITY()

SELECT
    Id=@Id,
    LeadId=@LeadId,
    SubStartDate=@SubStartDate,
    SubEndDate=@SubEndDate,
    ServiceId=@ServiceId,
	isDeleted=@isDeleted
FROM dbo.Lead
END