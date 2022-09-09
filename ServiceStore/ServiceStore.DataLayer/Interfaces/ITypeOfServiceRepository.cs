namespace ServiceStore.DataLayer
{
    public interface ITypeOfServiceRepository
    {
        Task<int> Add(TypeOfServiceDTO typeOfServiceDto);
        Task<List<TypeOfServiceDTO>> GetAll();
        Task<TypeOfServiceDTO> GetById(int id);
        Task Update(TypeOfServiceDTO typeOfServiceDto);
        Task Delete(int id, bool isDeleting);
    }
}
