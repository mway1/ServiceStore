using Dapper;
using System.Data;

namespace ServiceStore.DataLayer
{
    public class TypeOfServiceRepository : BaseRepository, ITypeOfServiceRepository
    {
        public TypeOfServiceRepository(IDbConnection connection) : base(connection)
        {

        }

        public async Task<int> Add(TypeOfServiceDTO typeOfServiceDto)
        {
            var id = await _connectionString.QuerySingleAsync<int>(
           StoredProcedures.TypeOfService_Add,
           param: new
           {
               typeOfServiceDto.Id,
               typeOfServiceDto.Name,            
               typeOfServiceDto.isDeleted
           },
           commandType: System.Data.CommandType.StoredProcedure);

            return id;
        }

        public async Task Delete(int id, bool isDeleting)
        {
            await _connectionString.QueryFirstOrDefaultAsync<TypeOfServiceDTO>(
                 StoredProcedures.TypeOfService_Delete,
                 param: new { id },
                 commandType: System.Data.CommandType.StoredProcedure);
        }

        public async Task<List<TypeOfServiceDTO>> GetAll()
        {
            var typesOfServices = _connectionString.Query<TypeOfServiceDTO>(
            StoredProcedures.TypeOfService_GetAll,
            commandType: System.Data.CommandType.StoredProcedure)
            .ToList();

            return typesOfServices;
        }

        public async Task<TypeOfServiceDTO> GetById(int id)
        {
            var typeOfService = await _connectionString.QueryFirstOrDefaultAsync<TypeOfServiceDTO>(
           StoredProcedures.TypeOfService_GetById,
           param: new { id },
           commandType: System.Data.CommandType.StoredProcedure);

            return typeOfService;
        }

        public async Task Update(TypeOfServiceDTO typeOfServiceDto)
        {
            await _connectionString.QueryFirstOrDefaultAsync<TypeOfServiceDTO>(
            StoredProcedures.TypeOfService_Update,
            param: new
            {
                typeOfServiceDto.Id,
                typeOfServiceDto.Name,
                typeOfServiceDto.isDeleted
            },
            commandType: System.Data.CommandType.StoredProcedure);
        }
    }
}
