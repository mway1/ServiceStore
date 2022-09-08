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

        public async Task Delete(int id, bool isDeleting)
        {
            await _connectionString.QueryFirstOrDefaultAsync<LeadDTO>(
                StoredProcedures.Lead_Delete,
                param: new { id },
                commandType: System.Data.CommandType.StoredProcedure);
        }

        public async Task<List<LeadDTO>> GetAll()
        {
            var leads = _connectionString.Query<LeadDTO>(
            StoredProcedures.Lead_GetAll,
            commandType: System.Data.CommandType.StoredProcedure)
            .ToList();

            return leads;
        }

        public async Task<LeadDTO> GetById(int id)
        {
            var lead = await _connectionString.QueryFirstOrDefaultAsync<LeadDTO>(
            StoredProcedures.Lead_GetById,
            param: new { id },
            commandType: System.Data.CommandType.StoredProcedure);

            return lead;
        }

        public async Task Update(LeadDTO leadDto)
        {
            await _connectionString.QueryFirstOrDefaultAsync<LeadDTO>(
            StoredProcedures.Lead_Update,
            param: new
            {
                leadDto.Id,
                leadDto.LeadId,
                leadDto.SubStartDate,
                leadDto.SubEndDate,
                leadDto.ServiceId
            },
            commandType: System.Data.CommandType.StoredProcedure);
        }
    }
}

