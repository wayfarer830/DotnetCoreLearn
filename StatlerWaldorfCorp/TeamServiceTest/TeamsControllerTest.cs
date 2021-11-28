using System.Collections.Generic;
using TeamService.Controllers;
using TeamService.Models;
using Xunit;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TeamService.Persistence;

namespace TeamServiceTest
{
    public class TeamsControllerTest
    {
        [Fact]
        public async void QueryTeamListReturnsCorrectTeams()
        {
            TeamsController controller = new TeamsController(new MemoryTeamRepository());
            var teams = (IEnumerable<Team>)(await controller.GetAllTeams() as ObjectResult).Value;  
            List<Team> origin =new List<Team>(teams);                
            Assert.Equal(origin.Count,2);    
        }

        public async void CreateTeamAddsTeamToList()
        {
            TeamsController controller = new TeamsController(new MemoryTeamRepository());
            var teams = (IEnumerable<Team>)(await controller.GetAllTeams() as ObjectResult).Value;
            List<Team> origin = new List<Team>(teams);

            Team team = new Team("sample");
            var result = controller.CreateTeam(team);
        }
    }
}