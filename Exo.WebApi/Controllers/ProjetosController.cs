using Exo.WebApi.Models;
using Exo WebApi Repositories;
using Microsoft. AspNetCore.Authorization;
using Microsoft. AspNetCore.Mvc;
using System;

namespace Exo.WebApi.Controllers
{
  [Route("api/[controller]")]
[ApiController]
public class projetosController : ControllerBase
{
    private readonly ProjetosRepository_projetoRepository;
    public projetosController(ProjetoRepository projetoRepository)
    {
        _projetoRepository = projetoRepository;
}
[HttpGet]
public IActionResult Listar()
{
    return ok(_projetoRepository.Listar();
    }

  }
}
