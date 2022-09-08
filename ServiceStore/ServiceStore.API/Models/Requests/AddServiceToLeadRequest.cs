namespace ServiceStore.API.Models.Request
{
    public class AddServiceToLeadRequest
    {
        public int LeadId { get; set; }
        public int ServiceId { get; set; }
        public DateOnly SubStartDate { get; set; }
        public DateOnly SubEndDate { get; set; }
    }
}