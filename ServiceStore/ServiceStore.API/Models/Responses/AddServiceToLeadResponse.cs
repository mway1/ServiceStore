namespace ServiceStore.API.Models.Responses
{
    public class AddServiceToLeadResponse
    {
        public int LeadId { get; set; }
        public int ServiceId { get; set; }
        public DateOnly SubEndDate { get; set; }
    }
}