using Dapper;
using System.Data;

namespace ServiceStore.DataLayer
{
    public class ServiceRepository : BaseRepository, IServiceRepository
    {
        public ServiceRepository(IDbConnection connection) : base(connection)
        {

        }

        public Task<int> Add(ServiceDTO leadDto)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id, bool isDeleting)
        {
            throw new NotImplementedException();
        }

        public Task<List<ServiceDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(ServiceDTO leadDto)
        {
            throw new NotImplementedException();
        }
    }
}
