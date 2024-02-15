using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IRepository
    {
        Task<List<Team>> getTeams();
        Task<List<Player>> getPlayersForCountry(string CountryCode);
        Task<List<Match>> getMatchesForTeam(string CountryCode);
    }
}
