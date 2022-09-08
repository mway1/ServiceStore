using Dapper;
using System.Data;

namespace ServiceStore.DataLayer
{
    public class LeadRepository : BaseRepository, ILeadRepository
    {
        public LeadRepository(IDbConnection connection) : base(connection)
        {

        }

        public async Task<int> Add(LeadDTO leadDto)
        {
            var id = await _connectionString.QuerySingleAsync<int>(
            StoredProcedures.Lead_Add,
            param: new
            {
                leadDto.Id,
                leadDto.LeadId,
                leadDto.SubStartDate,
                leadDto.SubEndDate,
                leadDto.ServiceId
            },
            commandType: System.Data.CommandType.StoredProcedure);

            return id;
        }

        public Task Delete(int id, bool isDeleting)
        {
            throw new NotImplementedException();
        }

        public async Task<List<LeadDTO>> GetAll()
        {
            var leads = _connectionString.Query<LeadDTO>(
            StoredProcedures.Lead_GetAll,
            commandType: System.Data.CommandType.StoredProcedure)
            .ToList();

            return leads;
        }

        public Task<LeadDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(LeadDTO leadDto)
        {
            throw new NotImplementedException();
        }
    }
}

