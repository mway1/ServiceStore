namespace ServiceStore.DataLayer
{
    public interface ILeadRepository
    {
        Task<int> Add(LeadDTO leadDto);
        Task<List<LeadDTO>> GetAll();
        Task<LeadDTO> GetById(int id);
        Task Update(LeadDTO leadDto);
        Task Delete(int id, bool isDeleting);
    }
}
