using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceDepartamentosRDSMySql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDepartamentosRDSMySql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentosController : ControllerBase
    {
        Repositories.RepositoryDepartamentos repository;

        public DepartamentosController(Repositories.RepositoryDepartamentos repository) { this.repository = repository; }

        [HttpGet]
        public List<Departamento> GetDepartamentos() { return this.repository.GetDepartamentos(); }

        [HttpGet("{id}")]
        public Departamento GetDepartamento(int id) { return this.repository.FindDepartamento(id); }


    }
}
