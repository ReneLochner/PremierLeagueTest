using PremierLeague.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PremierLeague.Core.Contracts
{
    public interface ITeamRepository
    {
        Task AddRangeAsync(IEnumerable<Team> team);

        Task<IEnumerable<Team>> GetAllAsync();

        Task<Team> GetByIdAsync(int id);
    }
}