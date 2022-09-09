using Dapper;
using System.Data;

namespace ServiceStore.DataLayer
{
    public class ServiceRepository : BaseRepository, IServiceRepository
    {
        public ServiceRepository(IDbConnection connection) : base(connection)
        {

        }

        public async Task<int> Add(ServiceDTO serviceDto)
        {
            var id = await _connectionString.QuerySingleAsync<int>(
           StoredProcedures.Service_Add,
           param: new
           {
               serviceDto.Id,
               serviceDto.Name,
               serviceDto.Description,
               serviceDto.TypeId,
               serviceDto.Price,
               serviceDto.isDeleted
           },
           commandType: System.Data.CommandType.StoredProcedure);

            return id;
        }

        public async Task Delete(int id, bool isDeleting)
        {
            await _connectionString.QueryFirstOrDefaultAsync<ServiceDTO>(
                StoredProcedures.Service_Delete,
                param: new { id },
                commandType: System.Data.CommandType.StoredProcedure);
        }

        public async Task<List<ServiceDTO>> GetAll()
        {
            var services = _connectionString.Query<ServiceDTO>(
            StoredProcedures.Service_GetAll,
            commandType: System.Data.CommandType.StoredProcedure)
            .ToList();

            return services;
        }

        public async Task<ServiceDTO> GetById(int id)
        {
            var service = await _connectionString.QueryFirstOrDefaultAsync<ServiceDTO>(
           StoredProcedures.Service_GetById,
           param: new { id },
           commandType: System.Data.CommandType.StoredProcedure);

            return service;
        }

        public async Task Update(ServiceDTO serviceDto)
        {
            await _connectionString.QueryFirstOrDefaultAsync<ServiceDTO>(
            StoredProcedures.Service_Update,
            param: new
            {
                serviceDto.Id,
                serviceDto.Name,
                serviceDto.Description,
                serviceDto.TypeId,
                serviceDto.Price,
                serviceDto.isDeleted
            },
            commandType: System.Data.CommandType.StoredProcedure);
        }
    }
}
