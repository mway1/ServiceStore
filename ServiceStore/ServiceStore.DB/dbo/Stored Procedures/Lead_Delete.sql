CREATE PROCEDURE [dbo].[Lead_Delete]
	@Id int,
    @LeadId varchar(50),
    @SubStartDate date,
    @SubEndDate date,
    @ServiceId int,
    @isDeleted bit
AS
BEGIN

UPDATE dbo.Lead
SET	LeadId=@LeadId,
    SubStartDate=@SubStartDate,
    SubEndDate=@SubEndDate,
    ServiceId=@ServiceId,
	IsDeleted=1
WHERE Id = @Id

END