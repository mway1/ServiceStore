CREATE PROCEDURE [dbo].[Lead_Update]
	@Id int,
    @LeadId varchar(50),
    @SubStartDate date,
    @SubEndDate date,
    @ServiceId int,
    @isDeleted bit
AS
BEGIN

UPDATE dbo.Lead
SET LeadId=@LeadId,
    SubStartDate=@SubStartDate,
    SubEndDate=@SubEndDate,
    ServiceId=@ServiceId,
	isDeleted=@isDeleted
WHERE Id = @Id

END