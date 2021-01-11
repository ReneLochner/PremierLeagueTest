using Microsoft.EntityFrameworkCore;
using PremierLeague.Core.Contracts;
using PremierLeague.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PremierLeague.Persistence
{
    public class TeamRepository : ITeamRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TeamRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddRangeAsync(IEnumerable<Team> team) => await _dbContext.AddRangeAsync(team);

        public async Task<IEnumerable<Team>> GetAllAsync()
        {
            return await _dbContext.Teams.ToArrayAsync();
        }

        public async Task<Team> GetByIdAsync(int id)
        {
            return await _dbContext.Teams.FirstOrDefaultAsync(team => team.Id == id);
        }
    }
}