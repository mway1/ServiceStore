namespace ServiceStore.DataLayer
{
    public interface ILeadRepository
    {
        Task<int> Add(LeadDTO leadDto);
        Task<List<LeadDTO>> GetAll();
        Task<LeadDTO> GetById(int id);
        Task<LeadDTO> GetByEmail(string email);
        Task Update(LeadDTO leadDto);
        Task DeleteOrRestore(int id, bool isDeleting);
    }
}
