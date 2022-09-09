namespace ServiceStore.DataLayer
{
    public interface IServiceRepository
    {
        Task<int> Add(ServiceDTO serviceDto);
        Task<List<ServiceDTO>> GetAll();
        Task<ServiceDTO> GetById(int id);
        Task Update(ServiceDTO serviceDto);
        Task Delete(int id, bool isDeleting);
    }
}
