using TeamService.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using TeamService.Persistence;
using System.Threading.Tasks;

namespace TeamService.Controllers
{
    public class TeamsController:Controller
    {
        protected ITeamRepository repository;
        public TeamsController(ITeamRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async virtual Task<IActionResult> GetAllTeams()
        {
            return this.Ok(repository.GetTeams());
        }

        [HttpPost]
        public virtual IActionResult CreateTeam(Team team)
        {
            repository.AddTeam(team);
            return this.Created($"/teams/{team.ID}", team);           
        }
    }
}