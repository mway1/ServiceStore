namespace ServiceStore.DataLayer
{
    public interface IServiceRepository
    {
        Task<int> Add(ServiceDTO leadDto);
        Task<List<ServiceDTO>> GetAll();
        Task<ServiceDTO> GetById(int id);
        Task Update(ServiceDTO leadDto);
        Task Delete(int id, bool isDeleting);
    }
}
